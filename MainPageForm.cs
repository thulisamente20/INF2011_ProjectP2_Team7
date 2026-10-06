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
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();
           
        }

        private void lblHeaderBanner_Click(object sender, EventArgs e)
        {

        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {
           
        }

        private void picLearner_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnerProfileForm profileForm = new LearnerProfileForm();
            profileForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // TEMPORARY: advisor login screen is built later
            MessageBox.Show("Career Advisor login is not built yet.", "Coming soon");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // TEMPORARY: administrator login screen is built later
            MessageBox.Show("System Administrator login is not built yet.", "Coming soon");
        }


        // When the user closes this window with the X button, the whole application is exited.
        // Screens are moved between using Hide(), so without this the hidden screens would keep the program running in the background.
        private void MainPageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
