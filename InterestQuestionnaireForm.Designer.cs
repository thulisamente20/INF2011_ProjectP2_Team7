namespace INF2011_ProjectP2_Team7
{
    partial class InterestQuestionnaireForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterestQuestionnaireForm));
            this.headerBanner = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderBanner = new System.Windows.Forms.Label();
            this.requiredFieldLegend = new System.Windows.Forms.Label();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.statusBarStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.headerBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.headerBanner.TabIndex = 2;
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
            this.lblHeaderBanner.Location = new System.Drawing.Point(181, 51);
            this.lblHeaderBanner.Name = "lblHeaderBanner";
            this.lblHeaderBanner.Size = new System.Drawing.Size(719, 45);
            this.lblHeaderBanner.TabIndex = 0;
            this.lblHeaderBanner.Text = "Step 3 of 4: Complete Interest Questionnaire ";
            this.lblHeaderBanner.Click += new System.EventHandler(this.lblHeaderBanner_Click);
            // 
            // requiredFieldLegend
            // 
            this.requiredFieldLegend.AutoSize = true;
            this.requiredFieldLegend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredFieldLegend.Location = new System.Drawing.Point(53, 153);
            this.requiredFieldLegend.Name = "requiredFieldLegend";
            this.requiredFieldLegend.Size = new System.Drawing.Size(240, 28);
            this.requiredFieldLegend.TabIndex = 3;
            this.requiredFieldLegend.Text = "* Denotes a required field ";
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Location = new System.Drawing.Point(55, 190);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(920, 410);
            this.pnlQuestions.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(55, 630);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(843, 633);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 37);
            this.btnNext.TabIndex = 10;
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
            this.statusBarStrip.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(361, 28);
            this.lblStatus.Text = "Status: Interest questionnare incomplete";
            // 
            // InterestQuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.statusBarStrip);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.requiredFieldLegend);
            this.Controls.Add(this.headerBanner);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "InterestQuestionnaireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Path - Interest Questionnare ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterestQuestionnaireForm_FormClosed);
            this.Load += new System.EventHandler(this.InterestQuestionnaireForm_Load);
            this.headerBanner.ResumeLayout(false);
            this.headerBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.StatusStrip statusBarStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}