using INF2011_ProjectP2_Team7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011_ProjectP2_Team7
{
    public partial class SubjectMarkEntryForm : Form
    {
        private Learner learner; // the profile passed in from the previous screen

        public SubjectMarkEntryForm(Learner learner)
        {
            InitializeComponent();
            this.learner = learner; // keep it so this screen can add subjects to it later
        }

        private void SubjectMarkEntryForm_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
            lblStatus.Text = "Status: No subjects added yet";

            // Placeholder subjects: the UI is built first with hard-coded data,
            // and these will later be loaded from the database
            cmbSubject.Items.AddRange(new string[] {
                "English", "Mathematics", "Mathematical Literacy", "Accounting",
                "Business Studies", "Economics", "Physical Sciences",
                "Life Sciences", "Geography", "History" });

            // If the learner came back from a later screen, show what was already captured
            foreach (LearnerSubject s in learner.Subjects)
            {
                ListViewItem row = new ListViewItem(s.SubjectName);
                row.SubItems.Add(s.Mark + "%");
                lvSubjects.Items.Add(row);
                cmbSubject.Items.Remove(s.SubjectName);
            }

            lblErrorMessage.Text = "";
            if (learner.Subjects.Count > 0)
            {
                btnNext.Enabled = true;
                lblStatus.Text = "Status: Subjects and marks captured successfully";
            }
            else
            {
                btnNext.Enabled = false; // at least one subject is required
                lblStatus.Text = "Status: Add at least one subject to proceed";
            }
            this.ActiveControl = cmbSubject;
        }

        

        private void lblHeaderBanner_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedItem == null)
            {
                lblErrorMessage.Text = "Please select a subject.";
                lblStatus.Text = "Status: Validation error: Subject required";
                return;
            }

            LearnerSubject entry = new LearnerSubject
            {
                SubjectName = cmbSubject.SelectedItem.ToString(),
                Mark = (int)nudMark.Value
            };
            learner.Subjects.Add(entry);

            ListViewItem row = new ListViewItem(entry.SubjectName);
            row.SubItems.Add(entry.Mark + "%");
            lvSubjects.Items.Add(row);

            // Remove the chosen subject so it can't be added twice
            cmbSubject.Items.Remove(cmbSubject.SelectedItem);
            cmbSubject.SelectedIndex = -1;
            nudMark.Value = 0;

            lblErrorMessage.Text = "";
            btnNext.Enabled = true;
            lblStatus.Text = "Status: Subjects and marks captured successfully";
        }
    

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnerProfileForm profileForm = new LearnerProfileForm(learner);
            profileForm.Show();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterestQuestionnaireForm nextForm = new InterestQuestionnaireForm(learner);
            nextForm.Show();
        }

        private void SubjectMarkEntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
