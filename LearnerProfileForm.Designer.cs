namespace INF2011_ProjectP2_Team7
{
    partial class LearnerProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnerProfileForm));
            this.headerBanner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderBanner = new System.Windows.Forms.Label();
            this.requiredFieldLegend = new System.Windows.Forms.Label();
            this.grpboxGradeLevel = new System.Windows.Forms.GroupBox();
            this.rbGrade12 = new System.Windows.Forms.RadioButton();
            this.rbGrade11 = new System.Windows.Forms.RadioButton();
            this.grpboxPersonalDetails = new System.Windows.Forms.GroupBox();
            this.txtContactDetails = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblContactDetails = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.statusBarStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.headerBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpboxGradeLevel.SuspendLayout();
            this.grpboxPersonalDetails.SuspendLayout();
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
            this.headerBanner.TabIndex = 0;
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
            this.lblHeaderBanner.Size = new System.Drawing.Size(552, 45);
            this.lblHeaderBanner.TabIndex = 0;
            this.lblHeaderBanner.Text = "Step 1 of 4: Create Learner Profile ";
            // 
            // requiredFieldLegend
            // 
            this.requiredFieldLegend.AutoSize = true;
            this.requiredFieldLegend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredFieldLegend.Location = new System.Drawing.Point(43, 157);
            this.requiredFieldLegend.Name = "requiredFieldLegend";
            this.requiredFieldLegend.Size = new System.Drawing.Size(240, 28);
            this.requiredFieldLegend.TabIndex = 1;
            this.requiredFieldLegend.Text = "* Denotes a required field ";
            // 
            // grpboxGradeLevel
            // 
            this.grpboxGradeLevel.Controls.Add(this.rbGrade12);
            this.grpboxGradeLevel.Controls.Add(this.rbGrade11);
            this.grpboxGradeLevel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxGradeLevel.Location = new System.Drawing.Point(47, 205);
            this.grpboxGradeLevel.Name = "grpboxGradeLevel";
            this.grpboxGradeLevel.Size = new System.Drawing.Size(871, 125);
            this.grpboxGradeLevel.TabIndex = 2;
            this.grpboxGradeLevel.TabStop = false;
            this.grpboxGradeLevel.Text = "Grade Level *";
            // 
            // rbGrade12
            // 
            this.rbGrade12.AutoSize = true;
            this.rbGrade12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrade12.Location = new System.Drawing.Point(47, 77);
            this.rbGrade12.Name = "rbGrade12";
            this.rbGrade12.Size = new System.Drawing.Size(113, 32);
            this.rbGrade12.TabIndex = 1;
            this.rbGrade12.TabStop = true;
            this.rbGrade12.Text = "Grade 12";
            this.rbGrade12.UseVisualStyleBackColor = true;
            this.rbGrade12.CheckedChanged += new System.EventHandler(this.rbGrade_CheckedChange);
            // 
            // rbGrade11
            // 
            this.rbGrade11.AutoSize = true;
            this.rbGrade11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGrade11.Location = new System.Drawing.Point(47, 37);
            this.rbGrade11.Name = "rbGrade11";
            this.rbGrade11.Size = new System.Drawing.Size(113, 32);
            this.rbGrade11.TabIndex = 0;
            this.rbGrade11.TabStop = true;
            this.rbGrade11.Text = "Grade 11";
            this.rbGrade11.UseVisualStyleBackColor = true;
            this.rbGrade11.CheckedChanged += new System.EventHandler(this.rbGrade_CheckedChange);
            // 
            // grpboxPersonalDetails
            // 
            this.grpboxPersonalDetails.Controls.Add(this.txtContactDetails);
            this.grpboxPersonalDetails.Controls.Add(this.txtProvince);
            this.grpboxPersonalDetails.Controls.Add(this.txtSchool);
            this.grpboxPersonalDetails.Controls.Add(this.txtName);
            this.grpboxPersonalDetails.Controls.Add(this.lblContactDetails);
            this.grpboxPersonalDetails.Controls.Add(this.lblProvince);
            this.grpboxPersonalDetails.Controls.Add(this.lblSchool);
            this.grpboxPersonalDetails.Controls.Add(this.lblName);
            this.grpboxPersonalDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxPersonalDetails.Location = new System.Drawing.Point(47, 351);
            this.grpboxPersonalDetails.Name = "grpboxPersonalDetails";
            this.grpboxPersonalDetails.Size = new System.Drawing.Size(871, 209);
            this.grpboxPersonalDetails.TabIndex = 3;
            this.grpboxPersonalDetails.TabStop = false;
            this.grpboxPersonalDetails.Text = "Personal Details (Optional)";
            this.grpboxPersonalDetails.Enter += new System.EventHandler(this.grpboxPersonalDetails_Enter);
            // 
            // txtContactDetails
            // 
            this.txtContactDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactDetails.Location = new System.Drawing.Point(220, 156);
            this.txtContactDetails.Name = "txtContactDetails";
            this.txtContactDetails.Size = new System.Drawing.Size(305, 34);
            this.txtContactDetails.TabIndex = 7;
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(220, 120);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(305, 34);
            this.txtProvince.TabIndex = 6;
            // 
            // txtSchool
            // 
            this.txtSchool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchool.Location = new System.Drawing.Point(220, 80);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(305, 34);
            this.txtSchool.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(220, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 34);
            this.txtName.TabIndex = 4;
            // 
            // lblContactDetails
            // 
            this.lblContactDetails.AutoSize = true;
            this.lblContactDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactDetails.Location = new System.Drawing.Point(27, 159);
            this.lblContactDetails.Name = "lblContactDetails";
            this.lblContactDetails.Size = new System.Drawing.Size(144, 28);
            this.lblContactDetails.TabIndex = 3;
            this.lblContactDetails.Text = "Contact Details";
            this.lblContactDetails.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(27, 120);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(87, 28);
            this.lblProvince.TabIndex = 2;
            this.lblProvince.Text = "Province";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(27, 80);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(72, 28);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "School";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(45, 593);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 39);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(813, 593);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(116, 39);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // statusBarStrip
            // 
            this.statusBarStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBarStrip.Location = new System.Drawing.Point(0, 687);
            this.statusBarStrip.Name = "statusBarStrip";
            this.statusBarStrip.Size = new System.Drawing.Size(1006, 34);
            this.statusBarStrip.TabIndex = 6;
            this.statusBarStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(352, 28);
            this.lblStatus.Text = "Status: Grade level required to proceed";
            // 
            // LearnerProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.statusBarStrip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpboxPersonalDetails);
            this.Controls.Add(this.grpboxGradeLevel);
            this.Controls.Add(this.requiredFieldLegend);
            this.Controls.Add(this.headerBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "LearnerProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Path - Learner Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LearnerProfileForm_FormClosed);
            this.Load += new System.EventHandler(this.LearnerProfileForm_Load);
            this.headerBanner.ResumeLayout(false);
            this.headerBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpboxGradeLevel.ResumeLayout(false);
            this.grpboxGradeLevel.PerformLayout();
            this.grpboxPersonalDetails.ResumeLayout(false);
            this.grpboxPersonalDetails.PerformLayout();
            this.statusBarStrip.ResumeLayout(false);
            this.statusBarStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerBanner;
        private System.Windows.Forms.Label lblHeaderBanner;
        private System.Windows.Forms.Label requiredFieldLegend;
        private System.Windows.Forms.GroupBox grpboxGradeLevel;
        private System.Windows.Forms.GroupBox grpboxPersonalDetails;
        private System.Windows.Forms.RadioButton rbGrade12;
        private System.Windows.Forms.RadioButton rbGrade11;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblContactDetails;
        private System.Windows.Forms.TextBox txtContactDetails;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.StatusStrip statusBarStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}