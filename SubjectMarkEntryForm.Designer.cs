namespace INF2011_ProjectP2_Team7
{
    partial class SubjectMarkEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectMarkEntryForm));
            this.headerBanner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderBanner = new System.Windows.Forms.Label();
            this.requiredFieldLegend = new System.Windows.Forms.Label();
            this.grpboxAcademicPerformance = new System.Windows.Forms.GroupBox();
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.Subjects = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.statusBarStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.headerBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpboxAcademicPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).BeginInit();
            this.statusBarStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBanner
            // 
            this.headerBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(217)))));
            this.headerBanner.Controls.Add(this.pictureBox1);
            this.headerBanner.Controls.Add(this.lblHeaderBanner);
            this.headerBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBanner.Location = new System.Drawing.Point(0, 0);
            this.headerBanner.Name = "headerBanner";
            this.headerBanner.Size = new System.Drawing.Size(1006, 150);
            this.headerBanner.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeaderBanner
            // 
            this.lblHeaderBanner.AutoSize = true;
            this.lblHeaderBanner.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderBanner.ForeColor = System.Drawing.Color.White;
            this.lblHeaderBanner.Location = new System.Drawing.Point(183, 52);
            this.lblHeaderBanner.Name = "lblHeaderBanner";
            this.lblHeaderBanner.Size = new System.Drawing.Size(653, 45);
            this.lblHeaderBanner.TabIndex = 0;
            this.lblHeaderBanner.Text = "Step 2 of 4: Capture Subjects And Marks ";
            this.lblHeaderBanner.Click += new System.EventHandler(this.lblHeaderBanner_Click);
            // 
            // requiredFieldLegend
            // 
            this.requiredFieldLegend.AutoSize = true;
            this.requiredFieldLegend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredFieldLegend.Location = new System.Drawing.Point(42, 153);
            this.requiredFieldLegend.Name = "requiredFieldLegend";
            this.requiredFieldLegend.Size = new System.Drawing.Size(240, 28);
            this.requiredFieldLegend.TabIndex = 2;
            this.requiredFieldLegend.Text = "* Denotes a required field ";
            // 
            // grpboxAcademicPerformance
            // 
            this.grpboxAcademicPerformance.Controls.Add(this.lvSubjects);
            this.grpboxAcademicPerformance.Controls.Add(this.lblErrorMessage);
            this.grpboxAcademicPerformance.Controls.Add(this.nudMark);
            this.grpboxAcademicPerformance.Controls.Add(this.btnAddSubject);
            this.grpboxAcademicPerformance.Controls.Add(this.cmbSubject);
            this.grpboxAcademicPerformance.Controls.Add(this.lblMark);
            this.grpboxAcademicPerformance.Controls.Add(this.lblSubject);
            this.grpboxAcademicPerformance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAcademicPerformance.Location = new System.Drawing.Point(93, 197);
            this.grpboxAcademicPerformance.Name = "grpboxAcademicPerformance";
            this.grpboxAcademicPerformance.Size = new System.Drawing.Size(839, 435);
            this.grpboxAcademicPerformance.TabIndex = 3;
            this.grpboxAcademicPerformance.TabStop = false;
            this.grpboxAcademicPerformance.Text = "Academic Performance *";
            // 
            // lvSubjects
            // 
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subjects,
            this.Marks});
            this.lvSubjects.HideSelection = false;
            this.lvSubjects.Location = new System.Drawing.Point(61, 175);
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.Size = new System.Drawing.Size(724, 231);
            this.lvSubjects.TabIndex = 6;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            // 
            // Subjects
            // 
            this.Subjects.Text = "Subjects";
            this.Subjects.Width = 250;
            // 
            // Marks
            // 
            this.Marks.Text = "Marks";
            this.Marks.Width = 120;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(431, 150);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 28);
            this.lblErrorMessage.TabIndex = 5;
            // 
            // nudMark
            // 
            this.nudMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMark.Location = new System.Drawing.Point(436, 96);
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(120, 34);
            this.nudMark.TabIndex = 4;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.Location = new System.Drawing.Point(643, 88);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(142, 49);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(65, 96);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(335, 39);
            this.cmbSubject.TabIndex = 2;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.Location = new System.Drawing.Point(431, 55);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(90, 28);
            this.lblMark.TabIndex = 1;
            this.lblMark.Text = "Mark (%)";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(60, 55);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(77, 28);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject";
            // 
            // statusBarStrip
            // 
            this.statusBarStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBarStrip.Location = new System.Drawing.Point(0, 687);
            this.statusBarStrip.Name = "statusBarStrip";
            this.statusBarStrip.Size = new System.Drawing.Size(1006, 34);
            this.statusBarStrip.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(430, 28);
            this.lblStatus.Text = "Status: Subjects and marks captured successfully";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(99, 635);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(803, 638);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 37);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SubjectMarkEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.statusBarStrip);
            this.Controls.Add(this.grpboxAcademicPerformance);
            this.Controls.Add(this.requiredFieldLegend);
            this.Controls.Add(this.headerBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SubjectMarkEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Path - Subjects and Marks Capture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubjectMarkEntryForm_FormClosed);
            this.Load += new System.EventHandler(this.SubjectMarkEntryForm_Load);
            this.headerBanner.ResumeLayout(false);
            this.headerBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpboxAcademicPerformance.ResumeLayout(false);
            this.grpboxAcademicPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).EndInit();
            this.statusBarStrip.ResumeLayout(false);
            this.statusBarStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerBanner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeaderBanner;
        private System.Windows.Forms.Label requiredFieldLegend;
        private System.Windows.Forms.GroupBox grpboxAcademicPerformance;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.NumericUpDown nudMark;
        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.StatusStrip statusBarStrip;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ColumnHeader Subjects;
        private System.Windows.Forms.ColumnHeader Marks;
    }
}