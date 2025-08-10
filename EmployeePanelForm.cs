using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class EmployeePanelForm : Form

    {

        private Form activeForm = null;
        public EmployeePanelForm()
        {
            InitializeComponent();
        }

        private void EmployeePanelForm_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new BillingForm());

            // Set the greeting when form loads
            labelGreeting.Text = GetGreeting();

            roundButtonDashboard.BackColor = Color.LightSteelBlue;
        }

        private string GetGreeting()
        {
            int currentHour = DateTime.Now.Hour;
            string greeting;

            // Assuming you have four PictureBoxes for each time of day.
            GM.Visible = false;
            GA.Visible = false;
            GE.Visible = false;
            GN.Visible = false;

            // Determine which greeting to display
            if (currentHour < 12)
            {
                greeting = "Good Morning...!";
                GM.Visible = true;  // Show morning picture
            }
            else if (currentHour < 15)
            {
                greeting = "Good Afternoon...!";
                GA.Visible = true;  // Show afternoon picture
            }
            else if (currentHour < 18)
            {
                greeting = "Good Evening...!";
                GE.Visible = true;  // Show evening picture
            }
            else
            {
                greeting = "Good Night...!";
                GN.Visible = true;  // Show night picture
            }

            // Return the greeting message
            return greeting;
        }
        private void OpenChildForm(Form childForm)

        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            roundPanelContainer.Controls.Add(childForm);
            roundPanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void roundButtonDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillingForm());

            roundButtonDashboard.BackColor = Color.LightSteelBlue;
            roundButtonCustomers.BackColor = Color.SteelBlue;
        }

        private void roundButtonCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoyaltyCustomerForm());

            roundButtonDashboard.BackColor = Color.SteelBlue;
            roundButtonCustomers.BackColor = Color.LightSteelBlue;
        }

        private void roundButtonLogout_Click(object sender, EventArgs e)
        {
            // Reopen Login Form
            LoginForm loginForm = new LoginForm();

            this.Hide();
            loginForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelGreeting_Click(object sender, EventArgs e)
        {

        }

        private void roundPanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
