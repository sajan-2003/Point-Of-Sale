using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class AdminPanelForm : Form

    {
        private Form activeForm = null;
        public AdminPanelForm()
        {
            InitializeComponent();
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());

            // Set the greeting when form loads
            labelGreeting.Text = GetGreeting();

            roundButtonDashboard.BackColor = Color.LightSteelBlue;
        }


        private void roundButtonDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DashboardForm());

            roundButtonDashboard.BackColor = Color.LightSteelBlue;
            roundButtonItem.BackColor = Color.SteelBlue;
            roundButtonEmployee.BackColor = Color.SteelBlue;
            roundButtonStore.BackColor = Color.SteelBlue;
        }

        private void roundButtonItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ItemManagmentForm());

            roundButtonDashboard.BackColor = Color.SteelBlue;
            roundButtonItem.BackColor = Color.LightSteelBlue;
            roundButtonEmployee.BackColor = Color.SteelBlue;
            roundButtonStore.BackColor = Color.SteelBlue;
        }

        private void roundButtonEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());

            roundButtonDashboard.BackColor = Color.SteelBlue;
            roundButtonItem.BackColor = Color.SteelBlue;
            roundButtonEmployee.BackColor = Color.LightSteelBlue;
            roundButtonStore.BackColor = Color.SteelBlue;
        }

        private void roundButtonStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StoreForm());

            roundButtonDashboard.BackColor = Color.SteelBlue;
            roundButtonItem.BackColor = Color.SteelBlue;
            roundButtonEmployee.BackColor = Color.SteelBlue;
            roundButtonStore.BackColor = Color.LightSteelBlue;
        }

        private void roundButtonSignout_Click(object sender, EventArgs e)
        {
            // Reopen Login Form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundButtonEmployeeDashboard_Click(object sender, EventArgs e)
        {


            BillingForm billingForm = new BillingForm();

            // Show the BillingForm as a new window
            billingForm.Show();

            // Alternatively, you can use ShowDialog() if you want it to be a modal form
            // billingForm.ShowDialog();

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

            // Check if ExampleForm is open
            bool isLoyaltyCustomerFormOpen = Application.OpenForms.OfType<LoyaltyCustomerForm>().Any();
            // Create an instance of BillingForm

            if (!isLoyaltyCustomerFormOpen)
            {
                // Create an instance of BillingForm
                LoyaltyCustomerForm LoyaltyCustomerForm = new LoyaltyCustomerForm();
                

                // Show the BillingForm as a new window
                LoyaltyCustomerForm.Show();

            }

            // Alternatively, you can use ShowDialog() if you want it to be a modal form
            // billingForm.ShowDialog();

        }

        private void roundButtonLogout_Click(object sender, EventArgs e)
        {
            // Reopen Login Form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void labelGreeting_Click(object sender, EventArgs e)
        {

        }
    }
}
