using System;
using System.Windows.Forms;
using FuturePath.Business;

namespace INF2011_ProjectP2_Team7
{
    public partial class LoginForm : Form
    {
        private AccountController accountController = new AccountController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string role = accountController.AuthenticateUser(username, password);

            if (role != null)
            {
                MessageBox.Show($"Login successful! Welcome, {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // RBAC Routing based on role
                this.Hide();

                if (role == "Admin")
                {
                    // Open Admin Dashboard
                    AdminDashboardForm adminForm = new AdminDashboardForm();
                    adminForm.ShowDialog();
                }
                else if (role == "Advisor")
                {
                    // Open Advisor Dashboard (Replace placeholder with actual form when ready)
                    MessageBox.Show("Routing to Advisor Dashboard...", "Navigation");
                    // AdvisorDashboardForm advisorForm = new AdvisorDashboardForm();
                    // advisorForm.ShowDialog();
                }
                else if (role == "Learner")
                {
                    // Open Learner Wizard (Replace placeholder with actual form when ready)
                    MessageBox.Show("Routing to Learner Wizard...", "Navigation");
                    // LearnerWizardForm learnerForm = new LearnerWizardForm();
                    // learnerForm.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}