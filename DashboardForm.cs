using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private int GetItemCount()
        {

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Prepare the SQL command to insert a new item
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Item;", connection);


                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return int.Parse(result.ToString());
                }
                else
                {
                    return 0;

                }

            }

        }

        private int GetCustomerCount()
        {

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Prepare the SQL command to insert a new LoyaltyCustomer
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM LoyaltyCustomer;", connection);



                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return int.Parse(result.ToString());
                }
                else
                {
                    return 0;

                }

            }

        }

        private int GetEmployeesCount()
        {

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Employee;", connection);

                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return int.Parse(result.ToString());
                }
                else
                {
                    return 0;

                }

            }

        }

        private float GetMonthlyIncome(DateTime firstDay, DateTime lastDay)
        {

            float monthlyIncome = 0.0f;
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT SUM(Total) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);

                var result = command.ExecuteScalar();


                return float.TryParse(result.ToString(), out monthlyIncome) ? monthlyIncome : 0.0f;


            }
        }

        private float GetMonthlyDiscounts(DateTime firstDay, DateTime lastDay)
        {

            float monthlyDiscount = 0.0f;
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT SUM(ToatalDiscount) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);

                var result = command.ExecuteScalar();
                return float.TryParse(result.ToString(), out monthlyDiscount) ? monthlyDiscount : 0.0f;

            }
        }


        private int GetMonthlyOrders(DateTime firstDay, DateTime lastDay)
        {
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT COUNT(*) FROM Bill WHERE Date >= @FirstDay AND Date <= @LastDay";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstDay", firstDay);
                command.Parameters.AddWithValue("@LastDay", lastDay);

                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return int.Parse(result.ToString());
                }
                else
                {
                    return 0;

                }
            }
        }

        private float GetTodayTotal(DateTime today)
        {

            float todayTotal = 0.0f;

            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(Total) FROM Bill WHERE Date = @Today";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Today", today);

                var result = command.ExecuteScalar();

                return float.TryParse(result.ToString(), out todayTotal) ? todayTotal : 0.00f;


            }
        }

        private float GetTodayDiscount(DateTime today)
        {

            float todayDiscount = 0.0f;
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT SUM(ToatalDiscount) FROM Bill WHERE Date = @Today";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Today", today);

                var result = command.ExecuteScalar();

                return float.TryParse(result.ToString(), out todayDiscount) ? todayDiscount : 0.0f;


            }
        }

        private int GetTodayOrders(DateTime today)
        {
            // Get the connection string from the configuration
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            // Use a using statement to ensure the connection is closed properly
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                string query = "SELECT COUNT(*) FROM Bill WHERE Date = @Today";
                // Prepare the SQL command to insert a new Employee
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Today", today);

                var result = command.ExecuteScalar();

                if (result != null)
                {
                    return int.Parse(result.ToString());
                }
                else
                {
                    return 0;

                }
            }
        }


        private void DashboardForm_Load(object sender, System.EventArgs e)
        {
            // Set values

            labelItemCount.Text = GetItemCount().ToString();
            labelEmployeesCount.Text = GetEmployeesCount().ToString();
            labelLoyaltyCustomers.Text = GetCustomerCount().ToString();

            // Get the first day and last day of the current month
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            // Total = income
            string todayIncome = GetTodayTotal(today).ToString("F2");
            string todayDiscount = GetTodayDiscount(today).ToString("F2");
            string todayOrders = GetTodayOrders(today).ToString();


            string monthlyIncome = GetMonthlyIncome(firstDayOfMonth, lastDayOfMonth).ToString("F2");
            string monthlyDiscount = GetMonthlyDiscounts(firstDayOfMonth, lastDayOfMonth).ToString("F2");
            string monthlyOrders = GetMonthlyOrders(firstDayOfMonth, lastDayOfMonth).ToString();

            labelMonthIncome.Text = monthlyIncome;
            labelMonthDiscounts.Text = monthlyDiscount;
            labelMonthOrders.Text = monthlyOrders;

            labelTodayIncome.Text = todayIncome;
            labelTodayDiscount.Text = todayDiscount;
            labelTodayOrders.Text = todayOrders;

        }

        private void labelTodayIncome_Click(object sender, EventArgs e)
        {

        }

        private void roundpanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
