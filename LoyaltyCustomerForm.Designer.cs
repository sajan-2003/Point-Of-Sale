namespace PointOfSale
{
    partial class LoyaltyCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoyaltyCustomerForm));
            this.CustomerdataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Customerroundpanel = new PointOfSale.roundpanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.CustomerIDtextbox = new PointOfSale.RoundTxtbox();
            this.CustomerNameTextbox = new PointOfSale.RoundTxtbox();
            this.CustomerCardNumberTextbox = new PointOfSale.RoundTxtbox();
            this.CustomerPointsTextbox = new PointOfSale.RoundTxtbox();
            this.CustomerSubmitButton = new PointOfSale.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Customerroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerdataGridView
            // 
            this.CustomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Points,
            this.CustomerCardNumber,
            this.RoleID,
            this.Delete});
            this.CustomerdataGridView.Location = new System.Drawing.Point(263, 74);
            this.CustomerdataGridView.Name = "CustomerdataGridView";
            this.CustomerdataGridView.RowHeadersWidth = 51;
            this.CustomerdataGridView.Size = new System.Drawing.Size(479, 479);
            this.CustomerdataGridView.TabIndex = 0;
            this.CustomerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerdataGridView_CellContentClick);
            this.CustomerdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerdataGridView_RowHeaderMouseClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Points
            // 
            this.Points.DataPropertyName = "Points";
            this.Points.HeaderText = "Points";
            this.Points.MinimumWidth = 6;
            this.Points.Name = "Points";
            this.Points.Width = 125;
            // 
            // CustomerCardNumber
            // 
            this.CustomerCardNumber.DataPropertyName = "CustomerCardNumber";
            this.CustomerCardNumber.HeaderText = "CustomerCardNumber";
            this.CustomerCardNumber.MinimumWidth = 6;
            this.CustomerCardNumber.Name = "CustomerCardNumber";
            this.CustomerCardNumber.Width = 125;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "RoleID";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.Width = 125;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(294, 23);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(219, 26);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Customerroundpanel
            // 
            this.Customerroundpanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Customerroundpanel.BottomLeftRadius = 40;
            this.Customerroundpanel.BottomRightRadius = 40;
            this.Customerroundpanel.Controls.Add(this.dataGridView1);
            this.Customerroundpanel.Controls.Add(this.CustomerIDtextbox);
            this.Customerroundpanel.Controls.Add(this.CustomerNameTextbox);
            this.Customerroundpanel.Controls.Add(this.CustomerCardNumberTextbox);
            this.Customerroundpanel.Controls.Add(this.CustomerPointsTextbox);
            this.Customerroundpanel.Controls.Add(this.CustomerSubmitButton);
            this.Customerroundpanel.Location = new System.Drawing.Point(3, 32);
            this.Customerroundpanel.Name = "Customerroundpanel";
            this.Customerroundpanel.Size = new System.Drawing.Size(237, 522);
            this.Customerroundpanel.TabIndex = 2;
            this.Customerroundpanel.Tag = "ooo";
            this.Customerroundpanel.TopLeftRadius = 40;
            this.Customerroundpanel.TopRightRadius = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.employeename,
            this.Username,
            this.Password,
            this.AdminID,
            this.Itemimage});
            this.dataGridView1.Location = new System.Drawing.Point(260, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(482, 516);
            this.dataGridView1.TabIndex = 10;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 125;
            // 
            // employeename
            // 
            this.employeename.HeaderText = "employeename";
            this.employeename.MinimumWidth = 6;
            this.employeename.Name = "employeename";
            this.employeename.Width = 125;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // AdminID
            // 
            this.AdminID.HeaderText = "AdminID";
            this.AdminID.MinimumWidth = 6;
            this.AdminID.Name = "AdminID";
            this.AdminID.Width = 125;
            // 
            // Itemimage
            // 
            this.Itemimage.HeaderText = "Itemimage";
            this.Itemimage.MinimumWidth = 6;
            this.Itemimage.Name = "Itemimage";
            this.Itemimage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Itemimage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Itemimage.Width = 125;
            // 
            // CustomerIDtextbox
            // 
            this.CustomerIDtextbox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerIDtextbox.BorderRadius = 15;
            this.CustomerIDtextbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDtextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerIDtextbox.Location = new System.Drawing.Point(13, 138);
            this.CustomerIDtextbox.Name = "CustomerIDtextbox";
            this.CustomerIDtextbox.Padding = new System.Windows.Forms.Padding(10);
            this.CustomerIDtextbox.PasswordChar = '\0';
            this.CustomerIDtextbox.PlaceholderText = "ID";
            this.CustomerIDtextbox.Size = new System.Drawing.Size(209, 40);
            this.CustomerIDtextbox.TabIndex = 2;
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameTextbox.BorderRadius = 15;
            this.CustomerNameTextbox.Location = new System.Drawing.Point(13, 196);
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.CustomerNameTextbox.PasswordChar = '\0';
            this.CustomerNameTextbox.PlaceholderText = "Name";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(209, 40);
            this.CustomerNameTextbox.TabIndex = 3;
            // 
            // CustomerCardNumberTextbox
            // 
            this.CustomerCardNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerCardNumberTextbox.BorderRadius = 15;
            this.CustomerCardNumberTextbox.Location = new System.Drawing.Point(13, 311);
            this.CustomerCardNumberTextbox.Name = "CustomerCardNumberTextbox";
            this.CustomerCardNumberTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.CustomerCardNumberTextbox.PasswordChar = '\0';
            this.CustomerCardNumberTextbox.PlaceholderText = "Card Number";
            this.CustomerCardNumberTextbox.Size = new System.Drawing.Size(209, 40);
            this.CustomerCardNumberTextbox.TabIndex = 5;
            // 
            // CustomerPointsTextbox
            // 
            this.CustomerPointsTextbox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPointsTextbox.BorderRadius = 15;
            this.CustomerPointsTextbox.Location = new System.Drawing.Point(13, 253);
            this.CustomerPointsTextbox.Name = "CustomerPointsTextbox";
            this.CustomerPointsTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.CustomerPointsTextbox.PasswordChar = '\0';
            this.CustomerPointsTextbox.PlaceholderText = "Points";
            this.CustomerPointsTextbox.Size = new System.Drawing.Size(209, 40);
            this.CustomerPointsTextbox.TabIndex = 4;
            // 
            // CustomerSubmitButton
            // 
            this.CustomerSubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CustomerSubmitButton.BottomLeftRadius = 15;
            this.CustomerSubmitButton.BottomRightRadius = 15;
            this.CustomerSubmitButton.FlatAppearance.BorderSize = 0;
            this.CustomerSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.CustomerSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerSubmitButton.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSubmitButton.ForeColor = System.Drawing.Color.White;
            this.CustomerSubmitButton.Location = new System.Drawing.Point(32, 428);
            this.CustomerSubmitButton.Name = "CustomerSubmitButton";
            this.CustomerSubmitButton.Size = new System.Drawing.Size(171, 55);
            this.CustomerSubmitButton.TabIndex = 6;
            this.CustomerSubmitButton.Text = "Submit";
            this.CustomerSubmitButton.TopLeftRadius = 15;
            this.CustomerSubmitButton.TopRightRadius = 15;
            this.CustomerSubmitButton.UseVisualStyleBackColor = false;
            this.CustomerSubmitButton.Click += new System.EventHandler(this.CustomerSubmitButton_Click);
            // 
            // LoyaltyCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.CustomerdataGridView);
            this.Controls.Add(this.Customerroundpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoyaltyCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoyaltyCustomers";
            this.Load += new System.EventHandler(this.LoyaltyCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Customerroundpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private roundpanel Customerroundpanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminID;
        private System.Windows.Forms.DataGridViewImageColumn Itemimage;
        private RoundTxtbox CustomerIDtextbox;
        private RoundTxtbox CustomerNameTextbox;
        private RoundTxtbox CustomerCardNumberTextbox;
        private RoundTxtbox CustomerPointsTextbox;
        private RoundButton CustomerSubmitButton;
        private System.Windows.Forms.DataGridView CustomerdataGridView;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}