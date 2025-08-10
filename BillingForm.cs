using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class BillingForm : Form
    {
        private string itemName;
        private Item item;
        private BindingList<TableItems> tableItemsList;
        private int intQuantitiy;
        private string unit;
        private float totalPrice;

        private const float LOYALTY_CUSTOMER_GET_PERCENTAGE = 10f;
        private const float LOYALTY_CUSTOMER_SET_PERCENTAGE = 3f;

        private float subTotal = 0;
        private int customerPoints;
        private int customerCardNumber;

        private Store store;
        private float amountPaid;
        private float balance;
        private float discount = 0;
        private float total;
        private string employeeName;
        private string billTemplate;

        private float customerPointsDiscount = 0;
        float totalDiscount = 0f;
        private DateTime date;
        private TimeSpan time;


        public BillingForm()
        {
            InitializeComponent();

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // Fill units 
            SetComboBoxUnits();
            SetComboBoxItems();
            // Hide the empty row in the DataGridView
            EmployeedataGridView.AllowUserToAddRows = false;


            DiscountTextbox.EnterKeyPressed += Discount_EnterKeyPressed;
            PaidTexBox.EnterKeyPressed += AmountPaid_EnterKeyPressed;

            tableItemsList = new BindingList<TableItems>();

            // Get store 
            store = GetStore();

            employeeName = GetEmployeeName();
        }

        private void AmountPaid_EnterKeyPressed(object sender, EventArgs e)
        {


            amountPaid = float.TryParse(PaidTexBox.Text.ToString(), out amountPaid) ? amountPaid : 0.0f;

            balance = amountPaid - total;

            BalanceLabel.Text = balance.ToString("F2");


            // Get the current date and time
            DateTime now = DateTime.Now;

            // Get the current DateTime
            date = DateTime.Now; // This holds both date and time

            // Extract the time as TimeSpan
            time = date.TimeOfDay; // This gives you the time portion as TimeSpan

            billTemplate = GenerateBill(date, time);

            // Now, set this template as the content for your RichTextBox
            richTextBox1.Text = billTemplate;

        }


        private string GenerateBill(DateTime date, TimeSpan time)
        {
            // Get the maximum width of the bill for centering and separators
            int lineWidth = 45;

            // Center the store name, address, and contact details
            string storeName = store.StoreName.PadLeft((lineWidth + store.StoreName.Length) / 2).PadRight(lineWidth).ToUpper();
            string storeAddress = store.Address.PadLeft((lineWidth + store.Address.Length) / 2).PadRight(lineWidth).ToUpper();
            string storeContact = ("CONTACT: " + store.ContactNumber).PadLeft((lineWidth + ("CONTACT: " + store.ContactNumber).Length) / 2).PadRight(lineWidth);

            // Create the bill as a string with proper alignment and full-width separators
            string billTemplate = $@"
*********************************************
{storeName}
{storeAddress}
{storeContact}
*********************************************

Cashier: {employeeName}
Date: {date}
Time: {time}

=============================================
ITEM NAME       UNIT      UNITPRICE  QTY    AMOUNT
=============================================
";

            // Loop through items and format them properly
            foreach (var item in tableItemsList)
            {
                billTemplate += string.Format("{0,-14} {1,-8} {2,10:F2} {3,6} {4,12:F2}\n",
                    item.ItemName, item.Unit, item.UnitPrice, item.Quantity, item.ItemAmount);
            }

            billTemplate += $@"
=============================================
Sub Total:            {subTotal,14:F2}

Discount:             {discount,14:F2}

Total:                {total,14:F2}

Amount Paid:          {amountPaid,14:F2}

Balance:              {balance,14:F2}
=============================================

Customer Points:      {customerPoints}
Customer Card #:      {customerCardNumber}

Thank you for shopping with us!

Please come again!

";

            return billTemplate;
        }





        private void Discount_EnterKeyPressed(object sender, EventArgs e)
        {


            customerCardNumber = int.TryParse(LoyaltyCustomer.Text.ToString().Trim(), out customerCardNumber) ? customerCardNumber : 0;
            float discountPercentage = float.TryParse(DiscountTextbox.Text.ToString().Trim(), out discountPercentage) ? discountPercentage : 0f;

            // 4200 = subtotal
            total = subTotal;
            int customerGainsPoints = 0;

            if (customerCardNumber > 0)
            {
                // Calculate Customer Points
                CustomerPointsCalculate();

                 customerGainsPoints = (int)(subTotal / 100 * LOYALTY_CUSTOMER_SET_PERCENTAGE);
                 customerPoints += customerGainsPoints;

            }
            else
            {
                // මෙතනදි වෙන්නෙ කස්ටමර් කාර්ඩ් නම්බර් එකක් දීල නැත්තම් කස්ටරමර් පොයින්ට් වලින් ලැබෙන ඩිස්කෞන්ට් එක බින්දුවක් වෙන එක
                customerPointsDiscount = 0;
            }
            if (discountPercentage > 0)
            {
                discount = total / 100 * discountPercentage;
                total -=  discount;
            }
            else if (discountPercentage <= 0)
            {
                discount = 0;
            }


            // discount means percent
            totalDiscount = customerPointsDiscount + discount;

            // Set discount 
            Discount.Text = totalDiscount.ToString("F2");

            // Set Total after discount
            TotalLabel.Text = total.ToString("F2");


        }


        private void CustomerPointsCalculate()
        {
            customerPoints = GetCustomerPoints(customerCardNumber);

            // සබ් පොයින්ට්ස් කියන්නෙ සබ් ටෝටල් එකෙන් සීයට 10යි
            float subPoints = subTotal / 100 * LOYALTY_CUSTOMER_GET_PERCENTAGE;

            if (customerPoints >= subPoints)
            {
                total -= subPoints; // subTotal = subTotal - subPoints
                customerPoints -= (int)subPoints;

                customerPointsDiscount = subPoints;
            }
            else
            {
                total -= customerPoints;

                customerPointsDiscount = customerPoints;
                // Customer points will be 0
                customerPoints = 0;


            }



        }
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemComboBox.SelectedItem != null)
            {
                // Get item name from ComboBox
                itemName = ItemComboBox.SelectedItem.ToString();

                // Retrieve item details based on itemName
                item = GetValues(itemName);

                // Check if item is valid and not null before setting values
                if (item != null)
                {
                    BarCode.Text = item.Barcode.ToString();
                }
                else
                {
                    // Handle case when item is null
                    BarCode.Text = string.Empty;
                }
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
                float itemTotal = float.TryParse(clickedRow.Cells["ItemTotal"].Value.ToString(), out itemTotal) ? itemTotal : 0f;

                // Ask for confirmation before removing the row
                DialogResult result = MessageBox.Show("Are you sure you want to remove this item?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                // If the user clicked 'Yes', proceed with removal
                if (result == DialogResult.Yes)
                {
                    subTotal -= itemTotal;

                    // Remove the item from the list and update the GridView
                    tableItemsList.RemoveAt(e.RowIndex);
                    SetValuesToGridView(); // Assuming this updates your DataGridView
                }

            }

        }

        private void SetComboBoxItems()
        {
            List<string> listItems = new List<string>();

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT  ItemName FROM Item", connection);
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        // add items to the list
                        listItems.Add(reader["ItemName"].ToString());
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

            foreach (string item in listItems)
            {
                ItemComboBox.Items.Add(item);
            }
        }

        private void SetComboBoxUnits()
        {
            foreach (var unit in UserData.UnitsArray)
            {
                UnitComboBox.Items.Add(unit);
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

            // Trim() --> Removes whitespace in start and end
            string quantity = roundTxtboxQuantity.Text.ToString().Trim();

            intQuantitiy = 0;
            if (quantity != null && quantity != "")
            {
                intQuantitiy = int.Parse(quantity);
            }
            else
            {
                return;
            }

            unit = UnitComboBox.SelectedItem?.ToString() ?? "One";


            // Ensure units are compatible before proceeding
            if (!UnitConverter.AreUnitsCompatible(unit, UserData.UnitsArray[item.Unit].ToString()))
            {
                MessageBox.Show("Selected unit is not compatible with the item's unit.", item.Unit.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // customer given details
            float baseQuantity = UnitConverter.ConvertToBaseUnit(intQuantitiy, unit); 
            
            // database details to relevent item (200)
            float baseItemQuantity = UnitConverter.ConvertToBaseUnit(item.Quantity, UserData.UnitsArray[(int)item.Unit]); 
           
            //Calculate total price
            float unitPrice = item.UnitPrice; 
            
            totalPrice = 0;
            if (baseItemQuantity > 0)
            {
                totalPrice = baseQuantity * unitPrice / baseItemQuantity;
            }

            // Display total price

            Amount.Text = $"Rs. {totalPrice:F2}";
        }

        // method to get values from database
        private Item GetValues(string itemName)
        {
            item = new Item();

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Barcode, Quantity, Unit, UnitPrice, Stock FROM Item WHERE ItemName = @ItemName", connection);

                    command.Parameters.AddWithValue("@ItemName", itemName);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        item.Barcode = int.Parse(reader["Barcode"].ToString());
                        item.Quantity = int.Parse(reader["Quantity"].ToString());
                        item.Unit = int.Parse(reader["Unit"].ToString());
                        item.UnitPrice = float.Parse(reader["UnitPrice"].ToString());
                        item.Stock = int.Parse(reader["Stock"].ToString());
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
            return item;
        }



        private void AddButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(itemName) &&
                intQuantitiy > 0 &&
                !string.IsNullOrEmpty(unit) &&
                item.UnitPrice > 0 &&
                totalPrice > 0)
            {
                var tableItems = new TableItems
                {
                    ItemName = itemName,
                    Quantity = intQuantitiy,
                    Unit = unit,
                    UnitPrice = item.UnitPrice,
                    ItemAmount = totalPrice
                };

                tableItemsList.Add(tableItems);

                // Calculate sub total when add button clicked
                subTotal += tableItems.ItemAmount;

                SetValuesToGridView();
            }
            else
            {
                MessageBox.Show("Fields cannot be empty or have invalid values", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetValuesToGridView()
        {

            // Clear the datagridview before populating
            EmployeedataGridView.Rows.Clear();

            int index = 1;

            foreach (var tableItem in tableItemsList)
            {
                EmployeedataGridView.Rows.Add(
                    index,
                    tableItem.ItemName,
                    tableItem.Unit,
                    tableItem.UnitPrice,
                    tableItem.Quantity,
                    tableItem.ItemAmount

                    );
                index++;
            }

            SubTotal1.Text = $"{subTotal:F2}";  // Output: "12.35"
        }



        private int GetCustomerPoints(int customerCardNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Points From LoyaltyCustomer WHERE CustomerCardNumber = @CustomerCardNumber", connection);

                    command.Parameters.AddWithValue("@CustomerCardNumber", customerCardNumber);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return int.Parse(reader["Points"].ToString());
                    }

                    reader.Close();
                    return 0;

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

        private void SetCustomerPoints(int customerCardNumber, int points)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Correct SQL UPDATE statement
                    SqlCommand command = new SqlCommand("UPDATE LoyaltyCustomer SET Points = @Points WHERE CustomerCardNumber = @CustomerCardNumber", connection);

                    // Set parameters
                    command.Parameters.AddWithValue("@Points", points);
                    command.Parameters.AddWithValue("@CustomerCardNumber", customerCardNumber);

                    // Execute the command
                    command.ExecuteNonQuery(); // Use ExecuteNonQuery for UPDATE


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

        private void PrintButton_Click(object sender, EventArgs e)
        {

            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to set customer points and save the bill as an image?",
                                                  "Confirm Action",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If the user clicks 'Yes', proceed with the actions
            if (result == DialogResult.Yes)
            {
                if (total == 0.0)
                {

                    MessageBox.Show("Something went wrong! Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }


                int billID = InsertBill(Convert.ToDecimal(total), customerPoints, Convert.ToDecimal(totalDiscount), date, time, customerCardNumber.ToString());

                // Set Customer Points
                SetCustomerPoints(customerCardNumber, customerPoints);

                string filePath = $@"D:\C# Tests\POS Prints\Bill_{billID}.png";
                Font font = new Font("Arial", 12, FontStyle.Regular);
                Color textColor = Color.Black;
                Color backColor = Color.White;

                // Save RichTextBox as Image
                SaveBillAsImage(billTemplate, filePath, font, textColor, backColor);

            }

        }



        private Store GetStore()
        {

            Store store = new Store();

            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT StoreID, StoreName, ContactNumber, Address FROM Store", connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        store.StoreID = reader["StoreID"].ToString();
                        store.StoreName = reader["StoreName"].ToString();
                        store.ContactNumber = reader["ContactNumber"].ToString();
                        store.Address = reader["Address"].ToString();
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
            return store;
        }

        public void SaveBillAsImage(string billText, string filePath, Font font, Color textColor, Color backColor)
        {
            try
            {
                // Measure the string to see how big the image needs to be
                using (Bitmap dummyBitmap = new Bitmap(1, 1))
                using (Graphics drawing = Graphics.FromImage(dummyBitmap))
                {
                    SizeF textSize = drawing.MeasureString(billText, font);

                    // Add some padding around the text 
                    int padding = 10;
                    int imgWidth = (int)textSize.Width + padding * 2;
                    int imgHeight = (int)textSize.Height + padding * 2;

                    // Create a new image of the right size
                    using (Bitmap img = new Bitmap(imgWidth, imgHeight))
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        // Paint the background
                        g.Clear(backColor);

                        // Create a brush for the text
                        using (Brush textBrush = new SolidBrush(textColor))
                        {
                            // Draw the text in the image, with padding
                            g.DrawString(billText, font, textBrush, padding, padding);

                            // Save the image in the specified format
                            img.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                        }
                    }
                }

                MessageBox.Show("Bill saved as image successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bill as image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Discount_Click(object sender, EventArgs e)
        {

        }

        private void ClearRoundButton1_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?",
                                                  "Confirm Clear",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            // If the user clicks 'Yes', proceed with clearing the fields
            if (result == DialogResult.Yes)
            {
                // Clear TextBox and RoundTextBox controls

                string Zero = "0.00";
                string NewZero = "000000";

                PaidTexBox.Text = string.Empty;
                DiscountTextbox.Text = string.Empty;
                LoyaltyCustomer.Text = string.Empty;
                roundTxtboxQuantity.Text = string.Empty;
                BarCode.Text = NewZero;
                Amount.Text = $"Rs. {Zero}";

                // Clear RichTextBox
                richTextBox1.Clear();

                // Clear DataGridView
                EmployeedataGridView.Rows.Clear();

                // Reset ComboBox controls
                ItemComboBox.SelectedIndex = -1; // Clears the selected item
                UnitComboBox.SelectedIndex = -1;

                // Optionally, clear Labels if needed
                BalanceLabel.Text =Zero;
                TotalLabel.Text = Zero;
                SubTotal1.Text = Zero;
                Discount.Text = Zero;

                tableItemsList.Clear();
                discount = 0;
                subTotal = 0;
                totalDiscount = 0;
                customerPointsDiscount = 0;

                itemName = string.Empty;
                intQuantitiy = 0;
                unit = string.Empty;

                totalPrice = 0;

                if (item != null)
                {
                    item.UnitPrice = 0;
                }

            }

        }


        private string GetEmployeeName()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Name From Employee WHERE EmployeeID = @EmployeeID", connection);


                    command.Parameters.AddWithValue("@EmployeeID", UserData.EmployeeID);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return reader["Name"].ToString();
                    }

                    reader.Close();

                    return string.Empty;

                }
            }

            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                MessageBox.Show($"Database error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty; // Return a default value indicating failure
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return string.Empty; // Return a default value indicating failure
            }



        
        }


        private int InsertBill(decimal total, decimal customerPoints, decimal totalDiscount, DateTime date, TimeSpan time, string customerCardNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(@"
                INSERT INTO Bill (Total, CustomerPoints, ToatalDiscount, Date, Time, EmployeeID, CustomerCardNumber, StoreID)
                VALUES (@Total, @CustomerPoints, @TotalDiscount, @Date, @Time, @EmployeeID, @CustomerCardNumber, @StoreID);
                SELECT CAST(SCOPE_IDENTITY() AS INT);", connection); // Cast to INT

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Total", total);
                    command.Parameters.AddWithValue("@CustomerPoints", customerPoints);
                    command.Parameters.AddWithValue("@TotalDiscount", totalDiscount);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@EmployeeID", UserData.EmployeeID);
                    command.Parameters.AddWithValue("@StoreID", store.StoreID);

                    // Handle nullable CustomerCardNumber
                    if (customerCardNumber == "0")
                    {
                        command.Parameters.AddWithValue("@CustomerCardNumber", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@CustomerCardNumber", customerCardNumber);
                    }

                    // Execute the command and retrieve the BillID
                    var billID = command.ExecuteScalar();
                    return Convert.ToInt32(billID);
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



    }
}






