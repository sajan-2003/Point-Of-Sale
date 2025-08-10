using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class LoyaltyCustomerForm : Form
    {

        private BindingList<Customer> customerList;
        private BindingSource bindingSource;

        public LoyaltyCustomerForm()
        {
            InitializeComponent();
        }

        private void LoyaltyCustomerForm_Load(object sender, System.EventArgs e)
        {
            customerList = new BindingList<Customer>();

            // Hide the empty row in the DataGridView
            CustomerdataGridView.AllowUserToAddRows = false;

            GetCustomer();
            ShowCustomersInDataGridView();
        }

        private void CustomerSubmitButton_Click(object sender, System.EventArgs e)
        {

            var customers = ValidateFields();

            if (customers != null)
            {

                MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add new item to the item list
                InsertCustomer(customers);
                GetCustomer();

                ShowCustomersInDataGridView();
            }
            else
            {
                MessageBox.Show("Fields Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Customer ValidateFields()
        {
            // Validate customerID
            string customerID = CustomerIDtextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(customerID))
            {
                return null;
            }

            // Validate customerName
            string customerName = CustomerNameTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                return null;
            }

            // Validate points
            string points = CustomerPointsTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(points))
            {
                return null;
            }

            // Set default points to 100
            int pointsValue = int.TryParse(points, out pointsValue) ? pointsValue : 100;

            // Validate cardNumber
            string cardNumber = CustomerCardNumberTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(cardNumber))
            {
                return null;
            }

            int cardNumberNew = int.Parse(cardNumber.ToString());

            var customer = new Customer
            {
                CustomerID = customerID,
                CustomerName = customerName,
                Points = pointsValue,
                CustomerCardNumber = cardNumberNew,
                RoleID = UserData.EmployeeID

            };

            return customer;
        }

        private int InsertCustomer(Customer customer)
        {

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
        IF EXISTS (SELECT 1 FROM LoyaltyCustomer WHERE CustomerID = @CustomerID)
        BEGIN
            UPDATE LoyaltyCustomer
            SET Name = @CustomerName,
                Points = @Points,
                CustomerCardNumber = @CustomerCardNumber,
                EmployeeID = @RoleID
            WHERE CustomerID = @CustomerID; 
        END
        ELSE
        BEGIN
            INSERT INTO LoyaltyCustomer (CustomerID, Name, Points, CustomerCardNumber, EmployeeID)
            VALUES (@CustomerID, @CustomerName, @Points, @CustomerCardNumber, @RoleID);
        END";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = customer.CustomerID;
                    command.Parameters.Add("@CustomerName", SqlDbType.VarChar).Value = customer.CustomerName;
                    command.Parameters.AddWithValue("@Points", customer.Points);
                    command.Parameters.AddWithValue("@CustomerCardNumber", customer.CustomerCardNumber);
                    command.Parameters.Add("@RoleID", SqlDbType.VarChar).Value = customer.RoleID;

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


        private void GetCustomer()
        {

            customerList.Clear();

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM LoyaltyCustomer;";

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        // add customers to the list

                        Customer customer = new Customer();
                        customer.CustomerID = reader["CustomerID"].ToString();
                        customer.CustomerName = reader["Name"].ToString();
                        customer.Points = int.Parse(reader["Points"].ToString());
                        customer.CustomerCardNumber = int.Parse(reader["CustomerCardNumber"].ToString());
                        customer.RoleID = reader["EmployeeID"].ToString();

                        customerList.Add(customer);

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

        private void DeleteCustomer(string customerID)
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
                    SqlCommand command = new SqlCommand(@"DELETE FROM LoyaltyCustomer WHERE CustomerID = @CustomerID", connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@CustomerID", customerID);

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

        private void UpdateBill(int customerCardNumber)
        {

            try
            {

                // Get the connection string from the configuration
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
            UPDATE Bill
            SET CustomerCardNumber = @CustomerDeleted
            WHERE CustomerCardNumber = @CustomerCardNumber;";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CustomerCardNumber", customerCardNumber);
                    command.Parameters.AddWithValue("@CustomerDeleted", DBNull.Value);

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

        private void CustomerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is from the Image Column 
            if (e.ColumnIndex == CustomerdataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = CustomerdataGridView.Rows[e.RowIndex];

                // Retrieve the value of another cell in the same row 
                string customerID = clickedRow.Cells["CustomerID"].Value.ToString() ?? string.Empty;

                int customerCardNumber = int.Parse(clickedRow.Cells["CustomerCardNumber"].Value.ToString());

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(customerID))
                {
                    // Update Bill
                    UpdateBill(customerCardNumber);
                    // Delete Item from database
                    DeleteCustomer(customerID);

                    // Remove Row in DataGridView
                    customerList.RemoveAt(e.RowIndex);

                    // Refresh the DataGridView
                    ShowCustomersInDataGridView();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSearch.Text.ToLower();

            BindingList<Customer> newCustomerList = new BindingList<Customer>();

            foreach (var items in customerList)
            {
                if (items.CustomerName.ToLower().Contains(filterText))
                {

                    newCustomerList.Add(items);
                }

            }

            bindingSource.DataSource = newCustomerList;
        }

        private void CustomerdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = CustomerdataGridView.Rows[e.RowIndex];

            // Extract values as strings
            string customerID = clickedRow.Cells["CustomerID"].Value?.ToString() ?? string.Empty;
            string customerName = clickedRow.Cells["CustomerName"].Value?.ToString() ?? string.Empty;
            string points = clickedRow.Cells["Points"].Value?.ToString() ?? string.Empty;
            string cardNumber = clickedRow.Cells["CustomerCardNumber"].Value?.ToString() ?? string.Empty;


            // Set values to fields for updating
            CustomerIDtextbox.Text = customerID;
            CustomerNameTextbox.Text = customerName;
            CustomerPointsTextbox.Text = points;
            CustomerCardNumberTextbox.Text = cardNumber;

        }

        private void ShowCustomersInDataGridView()
        {



            // Set AutoGenerateColumns to false to use predefined columns
            CustomerdataGridView.AutoGenerateColumns = false;

            // Create a BindingSource to wrap the items list
            bindingSource = new BindingSource();


            bindingSource.DataSource = customerList.ToList();
            // Bind the BindingSource to the DataGridView
            CustomerdataGridView.DataSource = bindingSource;

        }


    }
}
