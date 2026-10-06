using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011_ProjectP2_Team7
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Initialization logic when the dashboard loads
        }

        private void btnManageFaculties_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Faculty Management...", "Admin Hub");
        }

        private void btnManageDegrees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opening Degree Management...", "Admin Hub");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageFaculties_Click_1(object sender, EventArgs e)
        {
            ManageFacultiesForm facultyForm = new ManageFacultiesForm();
            facultyForm.ShowDialog();
        }

        private void btnManageDegrees_Click_1(object sender, EventArgs e)
        {
            ManageDegreesForm degreesForm = new ManageDegreesForm();
            degreesForm.ShowDialog();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            ManageSubjectsForm subjectsForm = new ManageSubjectsForm();
            subjectsForm.ShowDialog();
        }

        private void btnManageFunding_Click(object sender, EventArgs e)
        {
            ManageFundingForm fundingForm = new ManageFundingForm();
            fundingForm.ShowDialog();
        }
    }
}