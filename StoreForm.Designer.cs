namespace PointOfSale
{
    partial class StoreForm
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
            this.Storeroundpanel = new PointOfSale.roundpanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStoreID = new System.Windows.Forms.Label();
            this.StoreNameTextbox = new PointOfSale.RoundTxtbox();
            this.StoreAddressTextbox = new PointOfSale.RoundTxtbox();
            this.StoreContactNumberTextbox = new PointOfSale.RoundTxtbox();
            this.StoreSubmitButton = new PointOfSale.RoundButton();
            this.StoredataGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminIDstorepanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Storeroundpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoredataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Storeroundpanel
            // 
            this.Storeroundpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Storeroundpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Storeroundpanel.BottomLeftRadius = 40;
            this.Storeroundpanel.BottomRightRadius = 40;
            this.Storeroundpanel.Controls.Add(this.label1);
            this.Storeroundpanel.Controls.Add(this.labelStoreID);
            this.Storeroundpanel.Controls.Add(this.StoreNameTextbox);
            this.Storeroundpanel.Controls.Add(this.StoreAddressTextbox);
            this.Storeroundpanel.Controls.Add(this.StoreContactNumberTextbox);
            this.Storeroundpanel.Controls.Add(this.StoreSubmitButton);
            this.Storeroundpanel.Location = new System.Drawing.Point(0, 29);
            this.Storeroundpanel.Name = "Storeroundpanel";
            this.Storeroundpanel.Size = new System.Drawing.Size(758, 260);
            this.Storeroundpanel.TabIndex = 1;
            this.Storeroundpanel.Tag = "ooo";
            this.Storeroundpanel.TopLeftRadius = 40;
            this.Storeroundpanel.TopRightRadius = 40;
            this.Storeroundpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Storeroundpanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Store  ID :";
            // 
            // labelStoreID
            // 
            this.labelStoreID.AutoSize = true;
            this.labelStoreID.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelStoreID.Location = new System.Drawing.Point(166, 43);
            this.labelStoreID.Name = "labelStoreID";
            this.labelStoreID.Size = new System.Drawing.Size(37, 29);
            this.labelStoreID.TabIndex = 11;
            this.labelStoreID.Text = "ID";
            // 
            // StoreNameTextbox
            // 
            this.StoreNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.StoreNameTextbox.BorderRadius = 15;
            this.StoreNameTextbox.Location = new System.Drawing.Point(401, 32);
            this.StoreNameTextbox.Name = "StoreNameTextbox";
            this.StoreNameTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.StoreNameTextbox.PasswordChar = '\0';
            this.StoreNameTextbox.PlaceholderText = "Name";
            this.StoreNameTextbox.Size = new System.Drawing.Size(306, 40);
            this.StoreNameTextbox.TabIndex = 8;
            this.StoreNameTextbox.Load += new System.EventHandler(this.StoreNameTextbox_Load);
            // 
            // StoreAddressTextbox
            // 
            this.StoreAddressTextbox.BackColor = System.Drawing.Color.Transparent;
            this.StoreAddressTextbox.BorderRadius = 15;
            this.StoreAddressTextbox.Location = new System.Drawing.Point(401, 92);
            this.StoreAddressTextbox.Name = "StoreAddressTextbox";
            this.StoreAddressTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.StoreAddressTextbox.PasswordChar = '\0';
            this.StoreAddressTextbox.PlaceholderText = "Address";
            this.StoreAddressTextbox.Size = new System.Drawing.Size(302, 40);
            this.StoreAddressTextbox.TabIndex = 4;
            // 
            // StoreContactNumberTextbox
            // 
            this.StoreContactNumberTextbox.BackColor = System.Drawing.Color.Transparent;
            this.StoreContactNumberTextbox.BorderRadius = 15;
            this.StoreContactNumberTextbox.Location = new System.Drawing.Point(44, 90);
            this.StoreContactNumberTextbox.Name = "StoreContactNumberTextbox";
            this.StoreContactNumberTextbox.Padding = new System.Windows.Forms.Padding(10);
            this.StoreContactNumberTextbox.PasswordChar = '\0';
            this.StoreContactNumberTextbox.PlaceholderText = "Contact Number";
            this.StoreContactNumberTextbox.Size = new System.Drawing.Size(276, 40);
            this.StoreContactNumberTextbox.TabIndex = 1;
            // 
            // StoreSubmitButton
            // 
            this.StoreSubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.StoreSubmitButton.BottomLeftRadius = 15;
            this.StoreSubmitButton.BottomRightRadius = 15;
            this.StoreSubmitButton.FlatAppearance.BorderSize = 0;
            this.StoreSubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.StoreSubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.StoreSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreSubmitButton.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreSubmitButton.ForeColor = System.Drawing.Color.White;
            this.StoreSubmitButton.Location = new System.Drawing.Point(260, 183);
            this.StoreSubmitButton.Name = "StoreSubmitButton";
            this.StoreSubmitButton.Size = new System.Drawing.Size(171, 55);
            this.StoreSubmitButton.TabIndex = 0;
            this.StoreSubmitButton.Text = "Submit";
            this.StoreSubmitButton.TopLeftRadius = 15;
            this.StoreSubmitButton.TopRightRadius = 15;
            this.StoreSubmitButton.UseVisualStyleBackColor = false;
            this.StoreSubmitButton.Click += new System.EventHandler(this.StoreSubmitButton_Click);
            // 
            // StoredataGridView
            // 
            this.StoredataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoredataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Number,
            this.StoreAddress,
            this.AdminIDstorepanel});
            this.StoredataGridView.Location = new System.Drawing.Point(47, 365);
            this.StoredataGridView.Name = "StoredataGridView";
            this.StoredataGridView.RowHeadersWidth = 51;
            this.StoredataGridView.Size = new System.Drawing.Size(656, 137);
            this.StoredataGridView.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "StoreID";
            this.ID.HeaderText = "Store ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Store NAme";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Number
            // 
            this.Number.HeaderText = "Contact Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 125;
            // 
            // StoreAddress
            // 
            this.StoreAddress.DataPropertyName = "StoreAddress";
            this.StoreAddress.HeaderText = "Store Address";
            this.StoreAddress.MinimumWidth = 6;
            this.StoreAddress.Name = "StoreAddress";
            this.StoreAddress.Width = 125;
            // 
            // AdminIDstorepanel
            // 
            this.AdminIDstorepanel.DataPropertyName = "AdminID";
            this.AdminIDstorepanel.HeaderText = "AdminID";
            this.AdminIDstorepanel.MinimumWidth = 6;
            this.AdminIDstorepanel.Name = "AdminIDstorepanel";
            this.AdminIDstorepanel.Width = 125;
            // 
            // StoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(754, 581);
            this.Controls.Add(this.StoredataGridView);
            this.Controls.Add(this.Storeroundpanel);
           
            this.Text = "Store";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.Storeroundpanel.ResumeLayout(false);
            this.Storeroundpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoredataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private roundpanel Storeroundpanel;
        private RoundTxtbox StoreNameTextbox;
        private RoundTxtbox StoreAddressTextbox;
        private RoundTxtbox StoreContactNumberTextbox;
        private RoundButton StoreSubmitButton;
        private System.Windows.Forms.Label labelStoreID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StoredataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminIDstorepanel;
    }
}