namespace INF2011_ProjectP2_Team7
{
    partial class AdminDashboardForm
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
            this.btnManageFaculties = new System.Windows.Forms.Button();
            this.btnManageDegrees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageSubjects = new System.Windows.Forms.Button();
            this.btnManageFunding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageFaculties
            // 
            this.btnManageFaculties.Location = new System.Drawing.Point(37, 95);
            this.btnManageFaculties.Name = "btnManageFaculties";
            this.btnManageFaculties.Size = new System.Drawing.Size(112, 23);
            this.btnManageFaculties.TabIndex = 0;
            this.btnManageFaculties.Text = "Manage Faculties";
            this.btnManageFaculties.UseVisualStyleBackColor = true;
            this.btnManageFaculties.Click += new System.EventHandler(this.btnManageFaculties_Click_1);
            // 
            // btnManageDegrees
            // 
            this.btnManageDegrees.Location = new System.Drawing.Point(37, 137);
            this.btnManageDegrees.Name = "btnManageDegrees";
            this.btnManageDegrees.Size = new System.Drawing.Size(112, 23);
            this.btnManageDegrees.TabIndex = 1;
            this.btnManageDegrees.Text = "Manage Degrees";
            this.btnManageDegrees.UseVisualStyleBackColor = true;
            this.btnManageDegrees.Click += new System.EventHandler(this.btnManageDegrees_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(53, 280);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.Location = new System.Drawing.Point(37, 181);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(102, 23);
            this.btnManageSubjects.TabIndex = 3;
            this.btnManageSubjects.Text = "Manage Subjects";
            this.btnManageSubjects.UseVisualStyleBackColor = true;
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click);
            // 
            // btnManageFunding
            // 
            this.btnManageFunding.Location = new System.Drawing.Point(37, 227);
            this.btnManageFunding.Name = "btnManageFunding";
            this.btnManageFunding.Size = new System.Drawing.Size(102, 23);
            this.btnManageFunding.TabIndex = 4;
            this.btnManageFunding.Text = "Manage Funding";
            this.btnManageFunding.UseVisualStyleBackColor = true;
            this.btnManageFunding.Click += new System.EventHandler(this.btnManageFunding_Click);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManageFunding);
            this.Controls.Add(this.btnManageSubjects);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageDegrees);
            this.Controls.Add(this.btnManageFaculties);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageFaculties;
        private System.Windows.Forms.Button btnManageDegrees;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageSubjects;
        private System.Windows.Forms.Button btnManageFunding;
    }
}