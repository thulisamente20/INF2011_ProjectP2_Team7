namespace INF2011_ProjectP2_Team7
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.panelHeaderBanner = new System.Windows.Forms.Panel();
            this.lblTagLine = new System.Windows.Forms.Label();
            this.lblFuturePath = new System.Windows.Forms.Label();
            this.picLearner = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLearner = new System.Windows.Forms.Label();
            this.lblCareerAdvisor = new System.Windows.Forms.Label();
            this.lblSystemAdministrator = new System.Windows.Forms.Label();
            this.lblLearnerDescription = new System.Windows.Forms.Label();
            this.lblAdvisorDescription = new System.Windows.Forms.Label();
            this.lblAdministratorDescription = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.panelHeaderBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLearner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderBanner
            // 
            this.panelHeaderBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.panelHeaderBanner.Controls.Add(this.lblTagLine);
            this.panelHeaderBanner.Controls.Add(this.lblFuturePath);
            this.panelHeaderBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderBanner.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderBanner.Name = "panelHeaderBanner";
            this.panelHeaderBanner.Size = new System.Drawing.Size(1006, 150);
            this.panelHeaderBanner.TabIndex = 1;
            // 
            // lblTagLine
            // 
            this.lblTagLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTagLine.ForeColor = System.Drawing.Color.White;
            this.lblTagLine.Location = new System.Drawing.Point(0, 84);
            this.lblTagLine.Name = "lblTagLine";
            this.lblTagLine.Size = new System.Drawing.Size(1006, 66);
            this.lblTagLine.TabIndex = 1;
            this.lblTagLine.Text = "Your Future Path Starts Today";
            this.lblTagLine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFuturePath
            // 
            this.lblFuturePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFuturePath.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuturePath.ForeColor = System.Drawing.Color.White;
            this.lblFuturePath.Location = new System.Drawing.Point(0, 0);
            this.lblFuturePath.Name = "lblFuturePath";
            this.lblFuturePath.Size = new System.Drawing.Size(1006, 84);
            this.lblFuturePath.TabIndex = 0;
            this.lblFuturePath.Text = "Future Path";
            this.lblFuturePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFuturePath.Click += new System.EventHandler(this.lblHeaderBanner_Click);
            // 
            // picLearner
            // 
            this.picLearner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLearner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLearner.Image = ((System.Drawing.Image)(resources.GetObject("picLearner.Image")));
            this.picLearner.Location = new System.Drawing.Point(139, 249);
            this.picLearner.Name = "picLearner";
            this.picLearner.Size = new System.Drawing.Size(180, 180);
            this.picLearner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLearner.TabIndex = 2;
            this.picLearner.TabStop = false;
            this.picLearner.Click += new System.EventHandler(this.picLearner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(699, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblLearner
            // 
            this.lblLearner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearner.Location = new System.Drawing.Point(146, 444);
            this.lblLearner.Name = "lblLearner";
            this.lblLearner.Size = new System.Drawing.Size(154, 75);
            this.lblLearner.TabIndex = 5;
            this.lblLearner.Text = "I\'m a learner ";
            this.lblLearner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCareerAdvisor
            // 
            this.lblCareerAdvisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCareerAdvisor.Location = new System.Drawing.Point(383, 444);
            this.lblCareerAdvisor.Name = "lblCareerAdvisor";
            this.lblCareerAdvisor.Size = new System.Drawing.Size(256, 75);
            this.lblCareerAdvisor.TabIndex = 6;
            this.lblCareerAdvisor.Text = "I\'m a career advisor";
            this.lblCareerAdvisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemAdministrator
            // 
            this.lblSystemAdministrator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemAdministrator.Location = new System.Drawing.Point(645, 444);
            this.lblSystemAdministrator.Name = "lblSystemAdministrator";
            this.lblSystemAdministrator.Size = new System.Drawing.Size(322, 75);
            this.lblSystemAdministrator.TabIndex = 7;
            this.lblSystemAdministrator.Text = "I\'m a system administrator ";
            this.lblSystemAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLearnerDescription
            // 
            this.lblLearnerDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnerDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblLearnerDescription.Location = new System.Drawing.Point(91, 506);
            this.lblLearnerDescription.Name = "lblLearnerDescription";
            this.lblLearnerDescription.Size = new System.Drawing.Size(273, 69);
            this.lblLearnerDescription.TabIndex = 8;
            this.lblLearnerDescription.Text = "Explore career paths and study choices ";
            this.lblLearnerDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdvisorDescription
            // 
            this.lblAdvisorDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblAdvisorDescription.Location = new System.Drawing.Point(370, 506);
            this.lblAdvisorDescription.Name = "lblAdvisorDescription";
            this.lblAdvisorDescription.Size = new System.Drawing.Size(281, 69);
            this.lblAdvisorDescription.TabIndex = 9;
            this.lblAdvisorDescription.Text = "Support learners and review reports";
            this.lblAdvisorDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAdministratorDescription
            // 
            this.lblAdministratorDescription.AutoSize = true;
            this.lblAdministratorDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministratorDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblAdministratorDescription.Location = new System.Drawing.Point(694, 506);
            this.lblAdministratorDescription.Name = "lblAdministratorDescription";
            this.lblAdministratorDescription.Size = new System.Drawing.Size(197, 25);
            this.lblAdministratorDescription.TabIndex = 10;
            this.lblAdministratorDescription.Text = "Maintain reference data";
            this.lblAdministratorDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDisclaimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(0, 661);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(1006, 60);
            this.lblDisclaimer.TabIndex = 11;
            this.lblDisclaimer.Text = "Note: Designed to provide preliminary guidance not make official admission decisi" +
    "ons.";
            this.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblAdministratorDescription);
            this.Controls.Add(this.lblAdvisorDescription);
            this.Controls.Add(this.lblLearnerDescription);
            this.Controls.Add(this.lblSystemAdministrator);
            this.Controls.Add(this.lblCareerAdvisor);
            this.Controls.Add(this.lblLearner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLearner);
            this.Controls.Add(this.panelHeaderBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Future Path ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPageForm_FormClosed);
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            this.panelHeaderBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLearner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderBanner;
        private System.Windows.Forms.Label lblFuturePath;
        private System.Windows.Forms.Label lblTagLine;
        private System.Windows.Forms.PictureBox picLearner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLearner;
        private System.Windows.Forms.Label lblCareerAdvisor;
        private System.Windows.Forms.Label lblSystemAdministrator;
        private System.Windows.Forms.Label lblLearnerDescription;
        private System.Windows.Forms.Label lblAdvisorDescription;
        private System.Windows.Forms.Label lblAdministratorDescription;
        private System.Windows.Forms.Label lblDisclaimer;
    }
}