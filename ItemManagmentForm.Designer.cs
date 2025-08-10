namespace PointOfSale
{
    partial class ItemManagmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemManagmentForm));
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.roundpanel1 = new PointOfSale.roundpanel();
            this.roundTxtboxSupplier = new PointOfSale.RoundTxtbox();
            this.ComboBoxUnits = new PointOfSale.RoundComboBox();
            this.roundTextboxItemStock = new PointOfSale.RoundTxtbox();
            this.roundTextboxDescription = new PointOfSale.RoundTxtbox();
            this.roundTextboxUnitPrice = new PointOfSale.RoundTxtbox();
            this.roundTextboxQuantitiy = new PointOfSale.RoundTxtbox();
            this.roundTextboxBarcode = new PointOfSale.RoundTxtbox();
            this.roundTextboxItemName = new PointOfSale.RoundTxtbox();
            this.roundTextboxItemID = new PointOfSale.RoundTxtbox();
            this.Submit = new PointOfSale.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.roundpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Barcode,
            this.Quantity,
            this.Unit,
            this.UnitPrice,
            this.Description,
            this.Stock,
            this.Supplier,
            this.AdminID,
            this.Delete});
            this.dataGridViewItems.Location = new System.Drawing.Point(260, 64);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.Size = new System.Drawing.Size(482, 516);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_RowHeaderMouseClick);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemId";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 6;
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            this.Supplier.Width = 125;
            // 
            // AdminID
            // 
            this.AdminID.DataPropertyName = "AdminID";
            this.AdminID.HeaderText = "Admin ID";
            this.AdminID.MinimumWidth = 6;
            this.AdminID.Name = "AdminID";
            this.AdminID.ReadOnly = true;
            this.AdminID.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 125;
            // 
            // roundpanel1
            // 
            this.roundpanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.roundpanel1.BottomLeftRadius = 40;
            this.roundpanel1.BottomRightRadius = 40;
            this.roundpanel1.Controls.Add(this.roundTxtboxSupplier);
            this.roundpanel1.Controls.Add(this.ComboBoxUnits);
            this.roundpanel1.Controls.Add(this.roundTextboxItemStock);
            this.roundpanel1.Controls.Add(this.roundTextboxDescription);
            this.roundpanel1.Controls.Add(this.roundTextboxUnitPrice);
            this.roundpanel1.Controls.Add(this.roundTextboxQuantitiy);
            this.roundpanel1.Controls.Add(this.roundTextboxBarcode);
            this.roundpanel1.Controls.Add(this.roundTextboxItemName);
            this.roundpanel1.Controls.Add(this.roundTextboxItemID);
            this.roundpanel1.Controls.Add(this.Submit);
            this.roundpanel1.Location = new System.Drawing.Point(3, 47);
            this.roundpanel1.Name = "roundpanel1";
            this.roundpanel1.Size = new System.Drawing.Size(237, 522);
            this.roundpanel1.TabIndex = 0;
            this.roundpanel1.Tag = "ooo";
            this.roundpanel1.TopLeftRadius = 40;
            this.roundpanel1.TopRightRadius = 40;
            // 
            // roundTxtboxSupplier
            // 
            this.roundTxtboxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.roundTxtboxSupplier.BorderRadius = 15;
            this.roundTxtboxSupplier.Location = new System.Drawing.Point(13, 358);
            this.roundTxtboxSupplier.Name = "roundTxtboxSupplier";
            this.roundTxtboxSupplier.Padding = new System.Windows.Forms.Padding(10);
            this.roundTxtboxSupplier.PasswordChar = '\0';
            this.roundTxtboxSupplier.PlaceholderText = "Supplier";
            this.roundTxtboxSupplier.Size = new System.Drawing.Size(209, 40);
            this.roundTxtboxSupplier.TabIndex = 10;
            // 
            // ComboBoxUnits
            // 
            this.ComboBoxUnits.ArrowColor = System.Drawing.Color.Gray;
            this.ComboBoxUnits.BackColor = System.Drawing.Color.White;
            this.ComboBoxUnits.BackgroundColor = System.Drawing.Color.White;
            this.ComboBoxUnits.BorderColor = System.Drawing.Color.Gray;
            this.ComboBoxUnits.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxUnits.DropDownHeight = 100;
            this.ComboBoxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxUnits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxUnits.Font = new System.Drawing.Font("Arial", 12F);
            this.ComboBoxUnits.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxUnits.FormattingEnabled = true;
            this.ComboBoxUnits.IntegralHeight = false;
            this.ComboBoxUnits.ItemHeight = 25;
            this.ComboBoxUnits.Location = new System.Drawing.Point(124, 170);
            this.ComboBoxUnits.Name = "ComboBoxUnits";
            this.ComboBoxUnits.Size = new System.Drawing.Size(98, 31);
            this.ComboBoxUnits.TabIndex = 6;
            this.ComboBoxUnits.TextColor = System.Drawing.Color.Black;
            // 
            // roundTextboxItemStock
            // 
            this.roundTextboxItemStock.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxItemStock.BorderRadius = 15;
            this.roundTextboxItemStock.Location = new System.Drawing.Point(13, 312);
            this.roundTextboxItemStock.Name = "roundTextboxItemStock";
            this.roundTextboxItemStock.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxItemStock.PasswordChar = '\0';
            this.roundTextboxItemStock.PlaceholderText = "Stock";
            this.roundTextboxItemStock.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxItemStock.TabIndex = 9;
            // 
            // roundTextboxDescription
            // 
            this.roundTextboxDescription.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxDescription.BorderRadius = 15;
            this.roundTextboxDescription.Location = new System.Drawing.Point(13, 262);
            this.roundTextboxDescription.Name = "roundTextboxDescription";
            this.roundTextboxDescription.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxDescription.PasswordChar = '\0';
            this.roundTextboxDescription.PlaceholderText = "Description";
            this.roundTextboxDescription.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxDescription.TabIndex = 8;
            // 
            // roundTextboxUnitPrice
            // 
            this.roundTextboxUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxUnitPrice.BorderRadius = 15;
            this.roundTextboxUnitPrice.Location = new System.Drawing.Point(13, 216);
            this.roundTextboxUnitPrice.Name = "roundTextboxUnitPrice";
            this.roundTextboxUnitPrice.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxUnitPrice.PasswordChar = '\0';
            this.roundTextboxUnitPrice.PlaceholderText = "Unit Price";
            this.roundTextboxUnitPrice.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxUnitPrice.TabIndex = 7;
            // 
            // roundTextboxQuantitiy
            // 
            this.roundTextboxQuantitiy.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxQuantitiy.BorderRadius = 15;
            this.roundTextboxQuantitiy.Location = new System.Drawing.Point(13, 170);
            this.roundTextboxQuantitiy.Name = "roundTextboxQuantitiy";
            this.roundTextboxQuantitiy.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxQuantitiy.PasswordChar = '\0';
            this.roundTextboxQuantitiy.PlaceholderText = "Quantity";
            this.roundTextboxQuantitiy.Size = new System.Drawing.Size(105, 40);
            this.roundTextboxQuantitiy.TabIndex = 5;
            // 
            // roundTextboxBarcode
            // 
            this.roundTextboxBarcode.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxBarcode.BorderRadius = 15;
            this.roundTextboxBarcode.Location = new System.Drawing.Point(13, 119);
            this.roundTextboxBarcode.Name = "roundTextboxBarcode";
            this.roundTextboxBarcode.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxBarcode.PasswordChar = '\0';
            this.roundTextboxBarcode.PlaceholderText = "Barcode";
            this.roundTextboxBarcode.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxBarcode.TabIndex = 4;
            // 
            // roundTextboxItemName
            // 
            this.roundTextboxItemName.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxItemName.BorderRadius = 15;
            this.roundTextboxItemName.Location = new System.Drawing.Point(13, 73);
            this.roundTextboxItemName.Name = "roundTextboxItemName";
            this.roundTextboxItemName.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxItemName.PasswordChar = '\0';
            this.roundTextboxItemName.PlaceholderText = "Item Name";
            this.roundTextboxItemName.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxItemName.TabIndex = 3;
            // 
            // roundTextboxItemID
            // 
            this.roundTextboxItemID.BackColor = System.Drawing.Color.Transparent;
            this.roundTextboxItemID.BorderRadius = 15;
            this.roundTextboxItemID.Location = new System.Drawing.Point(13, 27);
            this.roundTextboxItemID.Name = "roundTextboxItemID";
            this.roundTextboxItemID.Padding = new System.Windows.Forms.Padding(10);
            this.roundTextboxItemID.PasswordChar = '\0';
            this.roundTextboxItemID.PlaceholderText = "ID";
            this.roundTextboxItemID.Size = new System.Drawing.Size(209, 40);
            this.roundTextboxItemID.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DodgerBlue;
            this.Submit.BottomLeftRadius = 15;
            this.Submit.BottomRightRadius = 15;
            this.Submit.FlatAppearance.BorderSize = 0;
            this.Submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(29, 428);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(171, 55);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.TopLeftRadius = 15;
            this.Submit.TopRightRadius = 15;
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(367, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(291, 30);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // ItemManagmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.roundpanel1);
            this.Name = "ItemManagmentForm";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemManagmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.roundpanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private roundpanel roundpanel1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private RoundButton Submit;
        private RoundTxtbox roundTextboxItemName;
        private RoundTxtbox roundTextboxItemID;
        private RoundTxtbox roundTextboxQuantitiy;
        private RoundTxtbox roundTextboxBarcode;
        private RoundTxtbox roundTextboxDescription;
        private RoundTxtbox roundTextboxUnitPrice;
        private RoundTxtbox roundTextboxItemStock;
        private RoundComboBox ComboBoxUnits;
        private RoundTxtbox roundTxtboxSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminID;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}