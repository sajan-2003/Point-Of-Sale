using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class EmployeeForm : Form
    {

        private BindingList<Employee> employeeList;
        private BindingSource bindingSource;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            employeeList = new BindingList<Employee>();

            // Hide the empty row in the DataGridView
            EmployeedataGridView.AllowUserToAddRows = false;

            GetEmployee();
            ShowEmployeesInDataGridView();
        }

        public Employee ValidateFields()
        {
            // Validate employeeID
            string employeeID = EmplyeeIDtextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(employeeID))
            {
                return null;
            }

            // Validate employeeName
            string employeeName = EmployeeNameTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(employeeName))
            {
                return null;
            }

            // Validate username
            string username = EmployeeUsernameTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }


            // Validate cardNumber
            string password = EmployeePasswordTextbox.Text.ToString().Trim();
            if (string.IsNullOrEmpty(password))
            {
                return null;
            }



            var employee = new Employee
            {
                EmployeeID = employeeID,
                EmployeeName = employeeName,
                Username = username,
                Password = password,
                AdminID = UserData.AdminID

            };

            return employee;
        }


        private void ShowEmployeesInDataGridView()
        {



            // Set AutoGenerateColumns to false to use predefined columns
            EmployeedataGridView.AutoGenerateColumns = false;

            // Create a BindingSource to wrap the items list
            bindingSource = new BindingSource();


            bindingSource.DataSource = employeeList.ToList();
            // Bind the BindingSource to the DataGridView
            EmployeedataGridView.DataSource = bindingSource;

        }

        private void EmployeeSubmitButton_Click(object sender, EventArgs e)
        {
            var employees = ValidateFields();


            if (employees != null)
            {

                MessageBox.Show("Successfully Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // add new item to the item list

                InsertEmployee(employees);
                GetEmployee();

                ShowEmployeesInDataGridView();
            }
            else
            {
                MessageBox.Show("Fields Cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int InsertEmployee(Employee employee)
        {
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
        IF EXISTS (SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID)
        BEGIN
            UPDATE Employee
            SET Name = @EmployeeName,
                Username = @Username,
                Password = @Password,
                AdminID = @AdminID
            WHERE EmployeeID = @EmployeeID; 
        END
        ELSE
        BEGIN
            INSERT INTO Employee (EmployeeID, Name, Username, Password, AdminID)
            VALUES (@EmployeeID, @EmployeeName, @Username, @Password, @AdminID);
        END";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.Add("@EmployeeID", SqlDbType.VarChar).Value = employee.EmployeeID;
                    command.Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = employee.EmployeeName;
                    command.Parameters.Add("@Username", SqlDbType.VarChar).Value = employee.Username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar).Value = employee.Password; // Hashing recommended
                    command.Parameters.Add("@AdminID", SqlDbType.Int).Value = employee.AdminID;

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


        private void GetEmployee()
        {

            employeeList.Clear();

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {

                // Use a using statement to ensure the connection is closed properly
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee;";

                    // Prepare the SQL command to insert a new item
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        // add employees to the list

                        Employee employee = new Employee();
                        employee.EmployeeID = reader["EmployeeID"].ToString();
                        employee.EmployeeName = reader["Name"].ToString();
                        employee.Username = reader["Username"].ToString();
                        employee.Password = reader["Password"].ToString();
                        employee.AdminID = int.Parse(reader["AdminID"].ToString());

                        employeeList.Add(employee);

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

        private void DeleteEmployee(string employeeID)
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
                    SqlCommand command = new SqlCommand(@"DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

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

        private void UpdateLoyaltyCustomer(string employeeID)
        {

            try
            {

                // Get the connection string from the configuration
                string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
            UPDATE LoyaltyCustomer
            SET EmployeeID = @AdminID
            WHERE EmployeeID = @EmployeeID;";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@AdminID", UserData.EmployeeID);

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

        private void UpdateBill(string employeeID)
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
            SET EmployeeID = @AdminID
            WHERE EmployeeID = @EmployeeID;";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@AdminID", UserData.EmployeeID);

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

        private void EmployeedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is from the Image Column 
            if (e.ColumnIndex == EmployeedataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = EmployeedataGridView.Rows[e.RowIndex];

                // Retrieve the value of another cell in the same row 
                string employeeID = clickedRow.Cells["EmployeeID"].Value.ToString() ?? string.Empty;

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes && !string.IsNullOrEmpty(employeeID))
                {
                    // Update employeeId to adminID
                    UpdateLoyaltyCustomer(employeeID);


                    // Update employeeId to adminID
                    UpdateBill(employeeID);


                    // Then Delete employee from database
                    DeleteEmployee(employeeID);

                    // Remove Row in DataGridView
                    employeeList.RemoveAt(e.RowIndex);

                    // Refresh the DataGridView
                    ShowEmployeesInDataGridView();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxSearch.Text.ToLower();

            BindingList<Employee> newEmployeeList = new BindingList<Employee>();

            foreach (var items in employeeList)
            {
                if (items.EmployeeName.ToLower().Contains(filterText))
                {

                    newEmployeeList.Add(items);
                }

            }

            bindingSource.DataSource = newEmployeeList;
        }

        private void EmployeedataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = EmployeedataGridView.Rows[e.RowIndex];

            // Extract values as strings
            string employeeID = clickedRow.Cells["EmployeeID"].Value?.ToString() ?? string.Empty;
            string employeeName = clickedRow.Cells["EmployeeName"].Value?.ToString() ?? string.Empty;
            string username = clickedRow.Cells["Username"].Value?.ToString() ?? string.Empty;
            string password = clickedRow.Cells["Password"].Value?.ToString() ?? string.Empty;


            // Set values to fields for updating
            EmplyeeIDtextbox.Text = employeeID;
            EmployeeNameTextbox.Text = employeeName;
            EmployeeUsernameTextbox.Text = username;
            EmployeePasswordTextbox.Text = password;

        }

        private void Employeeroundpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
