using INF2011_ProjectP2_Team7.Models;
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
    public partial class InterestQuestionnaireForm : Form
    {
        private Learner learner;

        // Placeholder questions (from the Part 1 mock-up); later loaded from the database
        private string[] questions = {
            "I enjoy solving problems using numbers or data.",
            "I enjoy helping people and communities.",
            "I enjoy working with technology.",
            "I enjoy science experiments and research.",
            "I enjoy reading, writing and analysing ideas.",
            "I enjoy business, entrepreneurship and finance.",
            "I enjoy designing or building practical solutions.",
            "I enjoy understanding society, law or politics." };

        // answers[i] holds the answer to question i: 0 = unanswered, 1 = Disagree, 2 = Neutral, 3 = Agree
        private int[] answers = new int[8];

        public InterestQuestionnaireForm(Learner learner)
        {
            InitializeComponent();
            this.learner = learner;
        }

        private void InterestQuestionnaireForm_Load(object sender, EventArgs e)
        {
            BuildQuestions();
            btnNext.Enabled = false;
            UpdateStatus();
            // Start focus on Back so Windows doesn't auto-select a radio button
            this.ActiveControl = btnBack;
        }

        // Creates one row per question: a label plus three radio buttons
        private void BuildQuestions()
        {
            string[] choices = { "Disagree", "Neutral", "Agree" };

            pnlQuestions.AutoScroll = true; // safety net if the panel is too short
            int radioW = 110;
            int rowH = 38;
            int rowGap = 40; // row height + 2px spacing
            int rowW = pnlQuestions.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;
            int labelW = rowW - 3 * radioW - 10;

            for (int i = 0; i < questions.Length; i++)
            {
                // Each row is its own Panel so its 3 radio buttons form a separate group
                Panel row = new Panel();
                row.Size = new Size(rowW, rowH);
                row.Location = new Point(0, i * rowGap);

                Label lbl = new Label();
                lbl.Text = (i + 1) + ". " + questions[i] + " *";
                lbl.AutoSize = false;
                lbl.Size = new Size(labelW, rowH);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                row.Controls.Add(lbl);

                for (int v = 0; v < 3; v++)
                {
                    RadioButton rb = new RadioButton();
                    rb.Text = choices[v];
                    rb.AutoSize = true;
                    rb.Location = new Point(labelW + 10 + v * radioW, 6);
                    rb.Tag = new int[] { i, v + 1 }; // question index and answer value
                    rb.CheckedChanged += rbAnswer_CheckedChanged;
                    row.Controls.Add(rb);
                }

                pnlQuestions.Controls.Add(row);
            }
        }

        // One handler shared by all 24 radio buttons
        private void rbAnswer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (!rb.Checked) return; // ignore the "unchecked" half of the change

            int[] info = (int[])rb.Tag;
            answers[info[0]] = info[1];

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int answered = 0;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] != 0) answered++;
            }

            if (answered == answers.Length)
            {
                btnNext.Enabled = true;
                lblStatus.Text = "Status: Interest questionnaire complete";
            }
            else
            {
                btnNext.Enabled = false;
                lblStatus.Text = "Status: Interest questionnaire incomplete (" + answered + " of 8 answered)";
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            // Store the answers on the learner object
            learner.Responses.Clear();
            for (int i = 0; i < answers.Length; i++)
            {
                learner.Responses.Add(new LearnerInterestResponse
                {
                    QuestionID = i + 1,
                    ResponseValue = answers[i]
                });
            }

            // TEMPORARY until the faculty/degree selection form exists
            MessageBox.Show("Answers saved: " + learner.Responses.Count, "Temporary");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SubjectMarkEntryForm previous = new SubjectMarkEntryForm(learner);
            previous.Show();
        }

        private void InterestQuestionnaireForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHeaderBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
