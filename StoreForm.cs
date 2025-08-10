using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class StoreForm : Form
    {

        private string storeID;
        private string storeName;
        private string address;
        private string contactNumber;
        private string adminID;


        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, System.EventArgs e)
        {

            // Hide the empty row in the DataGridView
            StoredataGridView.AllowUserToAddRows = false;

            // Get store details in database
            GetStore();
            // Next, show them in datagridview
            ShowStoreInDataGridView();

            labelStoreID.Text = storeID;
        }

        private void StoreSubmitButton_Click(object sender, System.EventArgs e)
        {
            ValidateFields();

            // Get store details in database
            GetStore();
            // Next, show them in datagridview
            ShowStoreInDataGridView();

        }

        public void ValidateFields()
        {

            // Validate StoreName
            storeName = StoreNameTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(storeName))
            {
                return;
            }

            // Validate points
            address = StoreAddressTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(address))
            {
                return;
            }

            // Validate contactNumber
            contactNumber = StoreContactNumberTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(contactNumber))
            {
                return;
            }

            // Update Only
            UpdateStore();

            MessageBox.Show("Successfully Updated", "Update", MessageBoxButtons.OK);

        }

        private void UpdateStore()
        {
           
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"UPDATE Store
            SET StoreName = @StoreName,
                Address = @Address,
                ContactNumber = @ContactNumber
            WHERE StoreID = @StoreID;";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StoreID", storeID);
                    command.Parameters.AddWithValue("@StoreName", storeName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);

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


        private void GetStore()
        {
            
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Store;";

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {

                        storeID = reader["StoreID"].ToString();
                        storeName = reader["StoreName"].ToString();
                        address = reader["Address"].ToString();
                        contactNumber = reader["ContactNumber"].ToString();
                        adminID = reader["AdminID"].ToString();

                    }

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


        private void StoredataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow clickedRow = StoredataGridView.Rows[e.RowIndex];

            // Extract values as strings
            storeID = clickedRow.Cells["StoreID"].Value?.ToString() ?? string.Empty;
            storeName = clickedRow.Cells["Storename"].Value?.ToString() ?? string.Empty;
            address = clickedRow.Cells["StoreAddress"].Value?.ToString() ?? string.Empty;
            contactNumber = clickedRow.Cells["ContactNumber"].Value?.ToString() ?? string.Empty;


            // Set values to fields for updating
            labelStoreID.Text = storeID;
            StoreNameTextbox.Text = storeName;
            StoreAddressTextbox.Text = address;
            StoreContactNumberTextbox.Text = contactNumber;
        }

        private void ShowStoreInDataGridView()
        {
            StoredataGridView.Rows.Clear();

            // Set AutoGenerateColumns to false to use predefined columns
            StoredataGridView.AutoGenerateColumns = false;

            // show store detail in datagridview
            StoredataGridView.Rows.Add(
                storeID,
                storeName,
                address,
                contactNumber,
                adminID
                );
        }

        private void Storeroundpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StoreNameTextbox_Load(object sender, EventArgs e)
        {

        }
    }
}
