using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF2011_ProjectP2_Team7.Models;

namespace INF2011_ProjectP2_Team7
{
    public partial class LearnerProfileForm : Form
    {
        private Learner learner; // the one learner object shared across all screens

        public LearnerProfileForm()                  // first launch (from the main page)
        {
            InitializeComponent();
            this.learner = new Learner();
        }

        public LearnerProfileForm(Learner learner)   // returning via Back from the marks screen
        {
            InitializeComponent();
            this.learner = learner;
        }

        private void LearnerProfileForm_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false; // grade level is required before proceeding

            // If the learner came back from a later screen, refill what was already entered
            txtName.Text = learner.Name;
            txtSchool.Text = learner.School;
            txtProvince.Text = learner.Province;
            txtContactDetails.Text = learner.ContactDetails;
            if (learner.Grade == 11) rbGrade11.Checked = true;
            else if (learner.Grade == 12) rbGrade12.Checked = true;

            UpdateStatus();
            this.ActiveControl = txtName;
        }

        private void rbGrade_CheckedChange(object sender, EventArgs e)
        {
            btnNext.Enabled = rbGrade11.Checked || rbGrade12.Checked;
            UpdateStatus();
        }


        private void UpdateStatus()
        {
            if (!rbGrade11.Checked && !rbGrade12.Checked)
            {
                lblStatus.Text = "Status: Grade level required to proceed";
            }
            else
            {
                lblStatus.Text = "Status: Ready to proceed";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpboxPersonalDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            // Only Grade is mandatory; everything else is optional per the design.
            // Update the existing learner (don't create a new one) so subjects aren't lost.
            learner.Name = txtName.Text;
            learner.Grade = rbGrade11.Checked ? 11 : 12;
            learner.School = txtSchool.Text;
            learner.Province = txtProvince.Text;
            learner.ContactDetails = txtContactDetails.Text;

            this.Hide();
            SubjectMarkEntryForm nextForm = new SubjectMarkEntryForm(learner);
            nextForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        { 
           this.Hide();
           MainPageForm mainPage = new MainPageForm();
           mainPage.Show();
        }

        private void LearnerProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
