namespace PointOfSale
{
    partial class EmployeeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Employeeroundpanel = new PointOfSale.roundpanel();
            this.EmplyeeIDtextbox = new PointOfSale.RoundTxtbox();
            this.EmployeeUsernameTextbox = new PointOfSale.RoundTxtbox();
            this.EmployeeNameTextbox = new PointOfSale.RoundTxtbox();
            this.EmployeePasswordTextbox = new PointOfSale.RoundTxtbox();
            this.EmployeeSubmitButton = new PointOfSale.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.Employeeroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.employeename,
            this.Username,
            this.Password,
            this.AdminID,
            this.Delete});
            this.EmployeedataGridView.Location = new System.Drawing.Point(260, 74);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowHeadersWidth = 51;
            this.EmployeedataGridView.Size = new System.Drawing.Size(482, 441);
            this.EmployeedataGridView.TabIndex = 0;
            this.EmployeedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeedataGridView_CellContentClick);
            this.EmployeedataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeedataGridView_RowHeaderMouseClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Width = 125;
            // 
            // employeename
            // 
            this.employeename.DataPropertyName = "EmployeeName";
            this.employeename.HeaderText = "Employee Name";
            this.employeename.MinimumWidth = 6;
            this.employeename.Name = "employeename";
            this.employeename.Width = 125;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 125;
            // 
            // AdminID
            // 
            this.AdminID.DataPropertyName = "AdminID";
            this.AdminID.HeaderText = "AdminID";
            this.AdminID.MinimumWidth = 6;
            this.AdminID.Name = "AdminID";
            this.AdminID.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(367, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(291, 30);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Employeeroundpanel
            // 
            this.Employeeroundpanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Employeeroundpanel.BottomLeftRadius = 40;
            this.Employeeroundpanel.BottomRightRadius = 40;
            this.Employeeroundpanel.Controls.Add(this.EmplyeeIDtextbox);
            this.Employeeroundpanel.Controls.Add(this.EmployeeUsernameTextbox);
            this.Employeeroundpanel.Controls.Add(this.EmployeeNameTextbox);
            this.Employeeroundpanel.Controls.Add(this.EmployeePasswordTextbox);
            this.Employeeroundpanel.Controls.Add(this.EmployeeSubmitButton);
            this.Employeeroundpanel.Location = new System.Drawing.Point(3, 32);
            this.Employeeroundpanel.Name = "Employeeroundpanel";
            this.Employeeroundpanel.Size = new System.Drawing.Size(237, 522);
            this.Employeeroundpanel.TabIndex = 0;
            this.Employeeroundpanel.Tag = "ooo";
            this.Employeeroundpanel.TopLeftRadius = 40;
            this.Employeeroundpanel.TopRightRadius = 40;
            this.Employeeroundpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Employeeroundpanel_Paint);
            // 
            // EmplyeeIDtextbox
            // 
            this.EmplyeeIDtextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmplyeeIDtextbox.BorderRadius = 15;
            this.EmplyeeIDtextbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmplyeeIDtextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmplyeeIDtextbox.Location = new System.Drawing.Point(13, 138);
            this.EmplyeeIDtextbox.Name = "EmplyeeIDtextbox";
            this.EmplyeeIDtextbox.Padding = new System.Windows.Forms.Padding(10);
            this.EmplyeeIDtextbox.PlaceholderText = "ID";
            this.EmplyeeIDtextbox.Size = new System.Drawing.Size(209, 40);
            this.EmplyeeIDtextbox.TabIndex = 2;
            // 
            // EmployeeUsernameTextbox
            // 
            this.EmployeeUsernameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeUsernameTextbox.BorderRadius = 15;
            this.EmployeeUsernameTextbox.Location = new System.Drawing.Point(13, 196);
            this.EmployeeUsernameTextbox.Name = "EmployeeUsernameTextbox";
            this.EmployeeUsernameTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeeUsernameTextbox.PlaceholderText = "User Name";
            this.EmployeeUsernameTextbox.Size = new System.Drawing.Size(209, 40);
            this.EmployeeUsernameTextbox.TabIndex = 3;
            // 
            // EmployeeNameTextbox
            // 
            this.EmployeeNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeNameTextbox.BorderRadius = 15;
            this.EmployeeNameTextbox.Location = new System.Drawing.Point(13, 311);
            this.EmployeeNameTextbox.Name = "EmployeeNameTextbox";
            this.EmployeeNameTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeeNameTextbox.PlaceholderText = "Employee Name";
            this.EmployeeNameTextbox.Size = new System.Drawing.Size(209, 40);
            this.EmployeeNameTextbox.TabIndex = 5;
            // 
            // EmployeePasswordTextbox
            // 
            this.EmployeePasswordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmployeePasswordTextbox.BorderRadius = 15;
            this.EmployeePasswordTextbox.Location = new System.Drawing.Point(13, 253);
            this.EmployeePasswordTextbox.Name = "EmployeePasswordTextbox";
            this.EmployeePasswordTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.EmployeePasswordTextbox.PlaceholderText = "Password";
            this.EmployeePasswordTextbox.Size = new System.Drawing.Size(209, 40);
            this.EmployeePasswordTextbox.TabIndex = 4;
            // 
            // EmployeeSubmitButton
            // 
            this.EmployeeSubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.EmployeeSubmitButton.BottomLeftRadius = 15;
            this.EmployeeSubmitButton.BottomRightRadius = 15;
            this.EmployeeSubmitButton.FlatAppearance.BorderSize = 0;
            this.EmployeeSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.EmployeeSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.EmployeeSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeSubmitButton.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSubmitButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeSubmitButton.Location = new System.Drawing.Point(32, 428);
            this.EmployeeSubmitButton.Name = "EmployeeSubmitButton";
            this.EmployeeSubmitButton.Size = new System.Drawing.Size(171, 55);
            this.EmployeeSubmitButton.TabIndex = 6;
            this.EmployeeSubmitButton.Text = "Submit";
            this.EmployeeSubmitButton.TopLeftRadius = 15;
            this.EmployeeSubmitButton.TopRightRadius = 15;
            this.EmployeeSubmitButton.UseVisualStyleBackColor = false;
            this.EmployeeSubmitButton.Click += new System.EventHandler(this.EmployeeSubmitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.Employeeroundpanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EmployeeForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.Employeeroundpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private roundpanel Employeeroundpanel;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private RoundTxtbox EmployeePasswordTextbox;
        private RoundButton EmployeeSubmitButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RoundTxtbox EmployeeNameTextbox;
        private RoundTxtbox EmplyeeIDtextbox;
        private RoundTxtbox EmployeeUsernameTextbox;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminID;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}