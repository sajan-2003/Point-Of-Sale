using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class ItemManagmentForm : Form
    {



        private BindingList<Items> itemsList;
        private BindingSource bindingSource;

        public ItemManagmentForm()
        {
            InitializeComponent();
        }

        private void ItemManagmentForm_Load(object sender, System.EventArgs e)
        {
            SetComboBoxUnits();

            itemsList = new BindingList<Items>();

            // Hide the empty row in the DataGridView
            dataGridViewItems.AllowUserToAddRows = false;

            GetItems();
            ShowItemsInDataGridView();


            //roundTxtboxSearch.TextChanged += roundTxtboxSearch_TextChanged;
        }



        private void Submit_Click(object sender, System.EventArgs e)
        {
            var items = ValidateFields();


            if (items != null)
            {

                MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add new item to the item list

                InsertItem(items);
                GetItems();

                ShowItemsInDataGridView();
            }
            else
            {
                MessageBox.Show("Fileds Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void ShowItemsInDataGridView()
        {



            // Set AutoGenerateColumns to false to use predefined columns
            dataGridViewItems.AutoGenerateColumns = false;

            // Create a BindingSource to wrap the items list
            bindingSource = new BindingSource();


            bindingSource.DataSource = itemsList.ToList();
            // Bind the BindingSource to the DataGridView
            dataGridViewItems.DataSource = bindingSource;

        }

        public Items ValidateFields()
        {
            // Validate itemId
            string itemId = roundTextboxItemID.Text.ToString().Trim();
            if (string.IsNullOrEmpty(itemId))
            {
                return null;
            }

            // Validate itemName
            string itemName = roundTextboxItemName.Text.ToString().Trim();
            if (string.IsNullOrEmpty(itemName))
            {
                return null;
            }

            // Validate barcode
            int barcode;
            if (!int.TryParse(roundTextboxBarcode.Text, out barcode) || barcode <= 0)
            {
                return null;
            }

            // Validate unit
            int unitIndex = ComboBoxUnits.SelectedIndex;

            if (unitIndex < 0)
            {

                return null;

            }

            // get unit as string 
            string unit = UserData.UnitsArray[unitIndex];

            // Validate unitPrice

            float unitPrice;
            if (!float.TryParse(roundTextboxUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                return null;
            }

            // Validate description
            string description = roundTextboxDescription.Text.ToString().Trim();
            if (string.IsNullOrEmpty(description))
            {
                return null;
            }

            // Validate quantity
            int quantity;
            if (!int.TryParse(roundTextboxQuantitiy.Text, out quantity) || quantity < 0)
            {
                return null;
            }


            // Validate stock
            int stock;
            if (!int.TryParse(roundTextboxItemStock.Text, out stock) || stock < 0)
            {
                return null;
            }

            // Validate supplier
            string supplier = roundTxtboxSupplier.Text.ToString().Trim();
            if (string.IsNullOrEmpty(supplier))
            {
                return null;
            }

            var items = new Items
            {
                ItemId = itemId,
                ItemName = itemName,
                Barcode = barcode,
                Unit = unitIndex,
                UnitPrice = unitPrice,
                Description = description,
                Quantity = quantity,
                Stock = stock,
                Supplier = supplier,
                AdminID = UserData.AdminID

            };

            return items;
        }

        private void SetComboBoxUnits()
        {
            foreach (var unit in UserData.UnitsArray)
            {
                ComboBoxUnits.Items.Add(unit);
            }
        }



        private int InsertItem(Items items)
        {
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
            IF EXISTS (SELECT 1 FROM Item WHERE ItemID = @ItemID)
            BEGIN
                UPDATE Item
                SET ItemName = @ItemName,
                    Barcode = @Barcode,
                    Quantity = @Quantity,
                    Unit = @Unit,
                    UnitPrice = @UnitPrice,
                    Stock = @Stock,
                    Description = @Description,
                    AdminID = @AdminID,
                    Supplier = @Supplier
                WHERE ItemID = @ItemID;
            END
            ELSE
            BEGIN
                INSERT INTO Item (ItemID, ItemName, Barcode, Quantity, Unit, UnitPrice, Stock, Description, AdminID, Supplier)
                VALUES (@ItemID, @ItemName, @Barcode, @Quantity, @Unit, @UnitPrice, @Stock, @Description, @AdminID, @Supplier);
            END";

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ItemID", items.ItemId);
                    command.Parameters.AddWithValue("@ItemName", items.ItemName);
                    command.Parameters.AddWithValue("@Barcode", items.Barcode);
                    command.Parameters.AddWithValue("@Quantity", items.Quantity);
                    command.Parameters.AddWithValue("@Unit", items.Unit);
                    command.Parameters.AddWithValue("@UnitPrice", items.UnitPrice);
                    command.Parameters.AddWithValue("@Stock", items.Stock);
                    command.Parameters.AddWithValue("@Description", items.Description);
                    command.Parameters.AddWithValue("@Supplier", items.Supplier);
                    command.Parameters.AddWithValue("@AdminID", UserData.AdminID);

                    // Execute the command and return the number of affected rows
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return -1; // Return a default value indicating failure
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return -1; // Return a default value indicating failure
            }
        }


        private void GetItems()
        {

            itemsList.Clear();

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {

                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Item;";

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        // add items to the list

                        Items items = new Items();
                        items.ItemId = reader["ItemID"].ToString();
                        items.ItemName = reader["ItemName"].ToString();
                        items.Barcode = int.Parse(reader["Barcode"].ToString());
                        items.Quantity = int.Parse(reader["Quantity"].ToString());
                        items.Unit = int.Parse(reader["Unit"].ToString());
                        items.UnitPrice = float.Parse(reader["UnitPrice"].ToString());
                        items.Stock = int.Parse(reader["Stock"].ToString());
                        items.Description = reader["Description"].ToString();
                        items.Supplier = reader["Supplier"].ToString();
                        items.AdminID = int.Parse(reader["AdminID"].ToString());

                        itemsList.Add(items);

                    }



                    reader.Close();

                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DeleteItem(string itemId)
        {
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(@"DELETE FROM Item WHERE ItemID = @ItemID", connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@ItemID", itemId);

                    // Execute the command and return the number of affected rows
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is from the Image Column 
            if (e.ColumnIndex == dataGridViewItems.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = dataGridViewItems.Rows[e.RowIndex];

                // Retrieve the value of another cell in the same row 
                string itemID = clickedRow.Cells["ItemID"].Value.ToString() ?? string.Empty;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(itemID))
                {
                    // Delete Item from database
                    DeleteItem(itemID);

                    // Remove Row in DataGridView
                    itemsList.RemoveAt(e.RowIndex);

                    // Refresh the DataGridView
                    ShowItemsInDataGridView();
                }
            }
        }

        private void dataGridViewItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridViewItems.Rows[e.RowIndex];

            // Extract values as strings
            string itemID = clickedRow.Cells["ItemID"].Value?.ToString() ?? string.Empty;
            string itemName = clickedRow.Cells["ItemName"].Value?.ToString() ?? string.Empty;
            string barcode = clickedRow.Cells["Barcode"].Value?.ToString() ?? string.Empty;
            string quantity = clickedRow.Cells["Quantity"].Value?.ToString() ?? string.Empty;
            string unit = clickedRow.Cells["Unit"].Value?.ToString() ?? string.Empty;
            string unitPrice = clickedRow.Cells["UnitPrice"].Value?.ToString() ?? string.Empty;
            string description = clickedRow.Cells["Description"].Value?.ToString() ?? string.Empty;
            string stock = clickedRow.Cells["Stock"].Value?.ToString() ?? string.Empty;
            string supplier = clickedRow.Cells["Supplier"].Value?.ToString() ?? string.Empty;

            // Set values to fields for updating
            roundTextboxItemID.Text = itemID;
            roundTextboxItemName.Text = itemName;
            roundTextboxBarcode.Text = barcode;
            roundTextboxQuantitiy.Text = quantity;
            roundTextboxUnitPrice.Text = unitPrice;
            roundTextboxDescription.Text = description;
            roundTextboxItemStock.Text = stock;
            roundTxtboxSupplier.Text = supplier;

            ComboBoxUnits.SelectedItem = UserData.UnitsArray[int.Parse(unit)];
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSearch.Text.ToLower();

            BindingList<Items> newItemList = new BindingList<Items>();

            foreach (var items in itemsList)
            {
                if (items.ItemName.ToLower().Contains(filterText))
                {

                    newItemList.Add(items);
                }

            }

            bindingSource.DataSource = newItemList;
        }
    }
}
