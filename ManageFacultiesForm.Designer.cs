namespace INF2011_ProjectP2_Team7
{
    partial class ManageFacultiesForm
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
            this.dgvFaculties = new System.Windows.Forms.DataGridView();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaculties
            // 
            this.dgvFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaculties.Location = new System.Drawing.Point(12, 12);
            this.dgvFaculties.Name = "dgvFaculties";
            this.dgvFaculties.Size = new System.Drawing.Size(358, 363);
            this.dgvFaculties.TabIndex = 0;
            this.dgvFaculties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaculties_CellClick);
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(526, 41);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(100, 20);
            this.txtFacultyName.TabIndex = 1;
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Location = new System.Drawing.Point(449, 44);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(72, 13);
            this.lblFacultyName.TabIndex = 2;
            this.lblFacultyName.Text = "Faculty Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(445, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Faculty";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(446, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Selected";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(445, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete/Deactivate";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ManageFacultiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFacultyName);
            this.Controls.Add(this.txtFacultyName);
            this.Controls.Add(this.dgvFaculties);
            this.Name = "ManageFacultiesForm";
            this.Text = "ManageFacultiesForm";
            this.Load += new System.EventHandler(this.ManageFacultiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaculties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaculties;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}