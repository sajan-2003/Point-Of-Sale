namespace PointOfSale
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundpanel3 = new PointOfSale.roundpanel();
            this.ClearRoundButton1 = new PointOfSale.RoundButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PrintButton = new PointOfSale.RoundButton();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.SubTotal1 = new System.Windows.Forms.Label();
            this.PaidTexBox = new PointOfSale.RoundTxtbox();
            this.DiscountTextbox = new PointOfSale.RoundTxtbox();
            this.LoyaltyCustomer = new PointOfSale.RoundTxtbox();
            this.Balance = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Discunt = new System.Windows.Forms.Label();
            this.SubTotal2 = new System.Windows.Forms.Label();
            this.roundpanel1 = new PointOfSale.roundpanel();
            this.BarCode = new System.Windows.Forms.Label();
            this.BarCodeText = new System.Windows.Forms.Label();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.roundTxtboxQuantity = new PointOfSale.RoundTxtbox();
            this.Amount = new System.Windows.Forms.Label();
            this.AddButton = new PointOfSale.RoundButton();
            this.CalculateButton = new PointOfSale.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            this.roundpanel3.SuspendLayout();
            this.roundpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.EmployeedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeedataGridView.ColumnHeadersHeight = 33;
            this.EmployeedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.OrderName,
            this.unit_,
            this.UnitPrice,
            this.Quantity,
            this.ItemTotal,
            this.Delete});
            this.EmployeedataGridView.Location = new System.Drawing.Point(13, 255);
            this.EmployeedataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowHeadersWidth = 50;
            this.EmployeedataGridView.Size = new System.Drawing.Size(429, 313);
            this.EmployeedataGridView.TabIndex = 2;
            this.EmployeedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeedataGridView_CellContentClick);
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 125;
            // 
            // OrderName
            // 
            this.OrderName.HeaderText = "Item Name";
            this.OrderName.MinimumWidth = 6;
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            this.OrderName.Width = 125;
            // 
            // unit_
            // 
            this.unit_.HeaderText = "Unit";
            this.unit_.MinimumWidth = 6;
            this.unit_.Name = "unit_";
            this.unit_.ReadOnly = true;
            this.unit_.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // ItemTotal
            // 
            this.ItemTotal.HeaderText = "Total";
            this.ItemTotal.MinimumWidth = 6;
            this.ItemTotal.Name = "ItemTotal";
            this.ItemTotal.ReadOnly = true;
            this.ItemTotal.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 125;
            // 
            // roundpanel3
            // 
            this.roundpanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundpanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundpanel3.BottomLeftRadius = 40;
            this.roundpanel3.BottomRightRadius = 40;
            this.roundpanel3.Controls.Add(this.ClearRoundButton1);
            this.roundpanel3.Controls.Add(this.richTextBox1);
            this.roundpanel3.Controls.Add(this.PrintButton);
            this.roundpanel3.Controls.Add(this.BalanceLabel);
            this.roundpanel3.Controls.Add(this.TotalLabel);
            this.roundpanel3.Controls.Add(this.Discount);
            this.roundpanel3.Controls.Add(this.SubTotal1);
            this.roundpanel3.Controls.Add(this.PaidTexBox);
            this.roundpanel3.Controls.Add(this.DiscountTextbox);
            this.roundpanel3.Controls.Add(this.LoyaltyCustomer);
            this.roundpanel3.Controls.Add(this.Balance);
            this.roundpanel3.Controls.Add(this.Total);
            this.roundpanel3.Controls.Add(this.Discunt);
            this.roundpanel3.Controls.Add(this.SubTotal2);
            this.roundpanel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundpanel3.Location = new System.Drawing.Point(455, 12);
            this.roundpanel3.Name = "roundpanel3";
            this.roundpanel3.Size = new System.Drawing.Size(287, 556);
            this.roundpanel3.TabIndex = 2;
            this.roundpanel3.TopLeftRadius = 40;
            this.roundpanel3.TopRightRadius = 40;
            // 
            // ClearRoundButton1
            // 
            this.ClearRoundButton1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearRoundButton1.BottomLeftRadius = 40;
            this.ClearRoundButton1.BottomRightRadius = 40;
            this.ClearRoundButton1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.ClearRoundButton1.FlatAppearance.BorderSize = 0;
            this.ClearRoundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClearRoundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.ClearRoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearRoundButton1.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRoundButton1.ForeColor = System.Drawing.Color.Black;
            this.ClearRoundButton1.Location = new System.Drawing.Point(19, 487);
            this.ClearRoundButton1.Name = "ClearRoundButton1";
            this.ClearRoundButton1.Size = new System.Drawing.Size(115, 47);
            this.ClearRoundButton1.TabIndex = 13;
            this.ClearRoundButton1.Text = "Clear";
            this.ClearRoundButton1.TopLeftRadius = 40;
            this.ClearRoundButton1.TopRightRadius = 40;
            this.ClearRoundButton1.UseVisualStyleBackColor = false;
            this.ClearRoundButton1.Click += new System.EventHandler(this.ClearRoundButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 171);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PrintButton.BottomLeftRadius = 40;
            this.PrintButton.BottomRightRadius = 40;
            this.PrintButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.Black;
            this.PrintButton.Location = new System.Drawing.Point(140, 487);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(115, 47);
            this.PrintButton.TabIndex = 11;
            this.PrintButton.Text = "Print";
            this.PrintButton.TopLeftRadius = 40;
            this.PrintButton.TopRightRadius = 40;
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(145, 262);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(55, 30);
            this.BalanceLabel.TabIndex = 10;
            this.BalanceLabel.Text = "0.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(119, 177);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(55, 30);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "0.00";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(159, 146);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(55, 30);
            this.Discount.TabIndex = 8;
            this.Discount.Text = "0.00";
            this.Discount.Click += new System.EventHandler(this.Discount_Click);
            // 
            // SubTotal1
            // 
            this.SubTotal1.AutoSize = true;
            this.SubTotal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubTotal1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal1.Location = new System.Drawing.Point(159, 21);
            this.SubTotal1.Name = "SubTotal1";
            this.SubTotal1.Size = new System.Drawing.Size(55, 30);
            this.SubTotal1.TabIndex = 7;
            this.SubTotal1.Text = "0.00";
            // 
            // PaidTexBox
            // 
            this.PaidTexBox.BackColor = System.Drawing.Color.Transparent;
            this.PaidTexBox.BorderRadius = 15;
            this.PaidTexBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidTexBox.Location = new System.Drawing.Point(23, 219);
            this.PaidTexBox.Name = "PaidTexBox";
            this.PaidTexBox.Padding = new System.Windows.Forms.Padding(10);
            this.PaidTexBox.PasswordChar = '\0';
            this.PaidTexBox.PlaceholderText = "Amount Paid ...";
            this.PaidTexBox.Size = new System.Drawing.Size(200, 40);
            this.PaidTexBox.TabIndex = 6;
            // 
            // DiscountTextbox
            // 
            this.DiscountTextbox.BackColor = System.Drawing.Color.Transparent;
            this.DiscountTextbox.BorderRadius = 15;
            this.DiscountTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTextbox.Location = new System.Drawing.Point(21, 103);
            this.DiscountTextbox.Name = "DiscountTextbox";
            this.DiscountTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.DiscountTextbox.PasswordChar = '\0';
            this.DiscountTextbox.PlaceholderText = "Discount  (%) ...";
            this.DiscountTextbox.Size = new System.Drawing.Size(138, 40);
            this.DiscountTextbox.TabIndex = 5;
            // 
            // LoyaltyCustomer
            // 
            this.LoyaltyCustomer.BackColor = System.Drawing.Color.Transparent;
            this.LoyaltyCustomer.BorderRadius = 15;
            this.LoyaltyCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoyaltyCustomer.Location = new System.Drawing.Point(19, 57);
            this.LoyaltyCustomer.Name = "LoyaltyCustomer";
            this.LoyaltyCustomer.Padding = new System.Windows.Forms.Padding(10);
            this.LoyaltyCustomer.PasswordChar = '\0';
            this.LoyaltyCustomer.PlaceholderText = "Loyalty Customer ...";
            this.LoyaltyCustomer.Size = new System.Drawing.Size(232, 40);
            this.LoyaltyCustomer.TabIndex = 4;
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(19, 262);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(132, 28);
            this.Balance.TabIndex = 3;
            this.Balance.Text = "Balance : RS.";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(19, 177);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(105, 28);
            this.Total.TabIndex = 2;
            this.Total.Text = "Total : RS.";
            // 
            // Discunt
            // 
            this.Discunt.AutoSize = true;
            this.Discunt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discunt.Location = new System.Drawing.Point(19, 146);
            this.Discunt.Name = "Discunt";
            this.Discunt.Size = new System.Drawing.Size(142, 28);
            this.Discunt.TabIndex = 1;
            this.Discunt.Text = "Discount : RS.";
            // 
            // SubTotal2
            // 
            this.SubTotal2.AutoSize = true;
            this.SubTotal2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal2.Location = new System.Drawing.Point(15, 23);
            this.SubTotal2.Name = "SubTotal2";
            this.SubTotal2.Size = new System.Drawing.Size(146, 28);
            this.SubTotal2.TabIndex = 0;
            this.SubTotal2.Text = "Sub Total : RS.";
            // 
            // roundpanel1
            // 
            this.roundpanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roundpanel1.BottomLeftRadius = 40;
            this.roundpanel1.BottomRightRadius = 40;
            this.roundpanel1.Controls.Add(this.BarCode);
            this.roundpanel1.Controls.Add(this.BarCodeText);
            this.roundpanel1.Controls.Add(this.ItemComboBox);
            this.roundpanel1.Controls.Add(this.UnitComboBox);
            this.roundpanel1.Controls.Add(this.roundTxtboxQuantity);
            this.roundpanel1.Controls.Add(this.Amount);
            this.roundpanel1.Controls.Add(this.AddButton);
            this.roundpanel1.Controls.Add(this.CalculateButton);
            this.roundpanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundpanel1.Location = new System.Drawing.Point(13, 12);
            this.roundpanel1.Name = "roundpanel1";
            this.roundpanel1.Size = new System.Drawing.Size(429, 216);
            this.roundpanel1.TabIndex = 0;
            this.roundpanel1.TopLeftRadius = 40;
            this.roundpanel1.TopRightRadius = 40;
            // 
            // BarCode
            // 
            this.BarCode.AutoSize = true;
            this.BarCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.Location = new System.Drawing.Point(310, 39);
            this.BarCode.Name = "BarCode";
            this.BarCode.Size = new System.Drawing.Size(84, 28);
            this.BarCode.TabIndex = 10;
            this.BarCode.Text = "000000";
            // 
            // BarCodeText
            // 
            this.BarCodeText.AutoSize = true;
            this.BarCodeText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeText.Location = new System.Drawing.Point(207, 36);
            this.BarCodeText.Name = "BarCodeText";
            this.BarCodeText.Size = new System.Drawing.Size(107, 31);
            this.BarCodeText.TabIndex = 9;
            this.BarCodeText.Text = "Barcode:";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(14, 39);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(169, 39);
            this.ItemComboBox.TabIndex = 8;
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(131, 94);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(88, 39);
            this.UnitComboBox.TabIndex = 7;
            // 
            // roundTxtboxQuantity
            // 
            this.roundTxtboxQuantity.BackColor = System.Drawing.Color.Transparent;
            this.roundTxtboxQuantity.BorderRadius = 15;
            this.roundTxtboxQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.roundTxtboxQuantity.Location = new System.Drawing.Point(14, 88);
            this.roundTxtboxQuantity.Name = "roundTxtboxQuantity";
            this.roundTxtboxQuantity.Padding = new System.Windows.Forms.Padding(10);
            this.roundTxtboxQuantity.PasswordChar = '\0';
            this.roundTxtboxQuantity.PlaceholderText = "Qunatity";
            this.roundTxtboxQuantity.Size = new System.Drawing.Size(102, 40);
            this.roundTxtboxQuantity.TabIndex = 6;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Amount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(245, 94);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(88, 30);
            this.Amount.TabIndex = 5;
            this.Amount.Text = "Rs. 0.00";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddButton.BottomLeftRadius = 40;
            this.AddButton.BottomRightRadius = 40;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Black;
            this.AddButton.Location = new System.Drawing.Point(226, 157);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(169, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "ADD";
            this.AddButton.TopLeftRadius = 40;
            this.AddButton.TopRightRadius = 40;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CalculateButton.BottomLeftRadius = 40;
            this.CalculateButton.BottomRightRadius = 40;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.Black;
            this.CalculateButton.Location = new System.Drawing.Point(14, 159);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(169, 40);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "CALCULATE";
            this.CalculateButton.TopLeftRadius = 40;
            this.CalculateButton.TopRightRadius = 40;
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.roundpanel3);
            this.Controls.Add(this.roundpanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            this.roundpanel3.ResumeLayout(false);
            this.roundpanel3.PerformLayout();
            this.roundpanel1.ResumeLayout(false);
            this.roundpanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private roundpanel roundpanel1;
        private roundpanel roundpanel3;
        private RoundButton AddButton;
        private RoundButton CalculateButton;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label SubTotal2;
        private RoundTxtbox LoyaltyCustomer;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Discunt;
        private RoundTxtbox DiscountTextbox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label SubTotal1;
        private RoundTxtbox PaidTexBox;
        private RoundButton PrintButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private RoundTxtbox roundTxtboxQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTotal;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private RoundButton ClearRoundButton1;
        private System.Windows.Forms.Label BarCode;
        private System.Windows.Forms.Label BarCodeText;
    }
}