namespace INF2011_ProjectP2_Team7
{
    partial class ManageSubjectsForm
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
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.chkIsMandatory = new System.Windows.Forms.CheckBox();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(150, 36);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectName.TabIndex = 0;
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(44, 36);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(74, 13);
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "Subject Name";
            // 
            // chkIsMandatory
            // 
            this.chkIsMandatory.AutoSize = true;
            this.chkIsMandatory.Location = new System.Drawing.Point(47, 90);
            this.chkIsMandatory.Name = "chkIsMandatory";
            this.chkIsMandatory.Size = new System.Drawing.Size(124, 17);
            this.chkIsMandatory.TabIndex = 2;
            this.chkIsMandatory.Text = "Subject is mandatory";
            this.chkIsMandatory.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(33, 127);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(366, 251);
            this.dgvSubjects.TabIndex = 3;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(435, 50);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 4;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(435, 109);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(115, 23);
            this.btnUpdateSubject.TabIndex = 5;
            this.btnUpdateSubject.Text = "Update Subject";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(435, 159);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(115, 23);
            this.btnDeleteSubject.TabIndex = 6;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(435, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ManageSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.chkIsMandatory);
            this.Controls.Add(this.lblSubjectName);
            this.Controls.Add(this.txtSubjectName);
            this.Name = "ManageSubjectsForm";
            this.Text = "ManageSubjectsForm";
            this.Load += new System.EventHandler(this.ManageSubjectsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.CheckBox chkIsMandatory;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnClose;
    }
}