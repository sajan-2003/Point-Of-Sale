namespace PointOfSale
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.roundpanel1 = new PointOfSale.roundpanel();
            this.roundTxtboxPassword = new PointOfSale.RoundTxtbox();
            this.roundTxtboxUsername = new PointOfSale.RoundTxtbox();
            this.roundButtonLogin = new PointOfSale.RoundButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.roundpanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundpanel1
            // 
            this.roundpanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundpanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundpanel1.BackgroundImage")));
            this.roundpanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundpanel1.BottomLeftRadius = 20;
            this.roundpanel1.BottomRightRadius = 20;
            this.roundpanel1.Controls.Add(this.roundTxtboxPassword);
            this.roundpanel1.Controls.Add(this.roundTxtboxUsername);
            this.roundpanel1.Controls.Add(this.roundButtonLogin);
            this.roundpanel1.Controls.Add(this.lblLogin);
            this.roundpanel1.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundpanel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.roundpanel1.Location = new System.Drawing.Point(82, 85);
            this.roundpanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundpanel1.Name = "roundpanel1";
            this.roundpanel1.Size = new System.Drawing.Size(382, 425);
            this.roundpanel1.TabIndex = 1;
            this.roundpanel1.TopLeftRadius = 20;
            this.roundpanel1.TopRightRadius = 20;
            // 
            // roundTxtboxPassword
            // 
            this.roundTxtboxPassword.BackColor = System.Drawing.Color.Transparent;
            this.roundTxtboxPassword.BorderRadius = 15;
            this.roundTxtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTxtboxPassword.Location = new System.Drawing.Point(46, 277);
            this.roundTxtboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.roundTxtboxPassword.Name = "roundTxtboxPassword";
            this.roundTxtboxPassword.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.roundTxtboxPassword.PasswordChar = '•';
            this.roundTxtboxPassword.PlaceholderText = "Password";
            this.roundTxtboxPassword.Size = new System.Drawing.Size(299, 49);
            this.roundTxtboxPassword.TabIndex = 5;
            // 
            // roundTxtboxUsername
            // 
            this.roundTxtboxUsername.BackColor = System.Drawing.Color.Transparent;
            this.roundTxtboxUsername.BorderRadius = 15;
            this.roundTxtboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundTxtboxUsername.Location = new System.Drawing.Point(46, 220);
            this.roundTxtboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.roundTxtboxUsername.Name = "roundTxtboxUsername";
            this.roundTxtboxUsername.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.roundTxtboxUsername.PasswordChar = '\0';
            this.roundTxtboxUsername.PlaceholderText = "Username";
            this.roundTxtboxUsername.Size = new System.Drawing.Size(299, 49);
            this.roundTxtboxUsername.TabIndex = 4;
            // 
            // roundButtonLogin
            // 
            this.roundButtonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundButtonLogin.BottomLeftRadius = 15;
            this.roundButtonLogin.BottomRightRadius = 15;
            this.roundButtonLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.roundButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.roundButtonLogin.FlatAppearance.BorderSize = 0;
            this.roundButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.roundButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.roundButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonLogin.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F);
            this.roundButtonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.roundButtonLogin.Location = new System.Drawing.Point(109, 345);
            this.roundButtonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundButtonLogin.Name = "roundButtonLogin";
            this.roundButtonLogin.Size = new System.Drawing.Size(171, 55);
            this.roundButtonLogin.TabIndex = 3;
            this.roundButtonLogin.Text = "Submit";
            this.roundButtonLogin.TopLeftRadius = 15;
            this.roundButtonLogin.TopRightRadius = 15;
            this.roundButtonLogin.UseVisualStyleBackColor = false;
            this.roundButtonLogin.Click += new System.EventHandler(this.roundButtonLogin_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Location = new System.Drawing.Point(140, 179);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(106, 37);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 702);
            this.Controls.Add(this.roundpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.roundpanel1.ResumeLayout(false);
            this.roundpanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private roundpanel roundpanel1;
        private System.Windows.Forms.Label lblLogin;
        private RoundButton roundButtonLogin;
        private RoundTxtbox roundTxtboxPassword;
        private RoundTxtbox roundTxtboxUsername;
    }
}

