namespace INF2011_ProjectP2_Team7
{
    partial class ManageDegreesForm
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
            this.dgvDegrees = new System.Windows.Forms.DataGridView();
            this.lblDegreeName = new System.Windows.Forms.Label();
            this.txtDegreeName = new System.Windows.Forms.TextBox();
            this.cmbFaculties = new System.Windows.Forms.ComboBox();
            this.btnAddDegree = new System.Windows.Forms.Button();
            this.btnUpdateDegree = new System.Windows.Forms.Button();
            this.btnDeleteDegree = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegrees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDegrees
            // 
            this.dgvDegrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDegrees.Location = new System.Drawing.Point(12, 12);
            this.dgvDegrees.Name = "dgvDegrees";
            this.dgvDegrees.Size = new System.Drawing.Size(440, 387);
            this.dgvDegrees.TabIndex = 0;
            this.dgvDegrees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegrees_CellClick);
            // 
            // lblDegreeName
            // 
            this.lblDegreeName.AutoSize = true;
            this.lblDegreeName.Location = new System.Drawing.Point(473, 44);
            this.lblDegreeName.Name = "lblDegreeName";
            this.lblDegreeName.Size = new System.Drawing.Size(73, 13);
            this.lblDegreeName.TabIndex = 1;
            this.lblDegreeName.Text = "Degree Name";
            // 
            // txtDegreeName
            // 
            this.txtDegreeName.Location = new System.Drawing.Point(597, 36);
            this.txtDegreeName.Name = "txtDegreeName";
            this.txtDegreeName.Size = new System.Drawing.Size(100, 20);
            this.txtDegreeName.TabIndex = 2;
            // 
            // cmbFaculties
            // 
            this.cmbFaculties.FormattingEnabled = true;
            this.cmbFaculties.Items.AddRange(new object[] {
            "Commerce",
            "Humanities",
            "Science"});
            this.cmbFaculties.Location = new System.Drawing.Point(476, 92);
            this.cmbFaculties.Name = "cmbFaculties";
            this.cmbFaculties.Size = new System.Drawing.Size(121, 21);
            this.cmbFaculties.TabIndex = 3;
            this.cmbFaculties.SelectedIndexChanged += new System.EventHandler(this.cmbFaculties_SelectedIndexChanged);
            // 
            // btnAddDegree
            // 
            this.btnAddDegree.Location = new System.Drawing.Point(487, 219);
            this.btnAddDegree.Name = "btnAddDegree";
            this.btnAddDegree.Size = new System.Drawing.Size(75, 23);
            this.btnAddDegree.TabIndex = 4;
            this.btnAddDegree.Text = "Add Degree";
            this.btnAddDegree.UseVisualStyleBackColor = true;
            this.btnAddDegree.Click += new System.EventHandler(this.btnAddDegree_Click);
            // 
            // btnUpdateDegree
            // 
            this.btnUpdateDegree.Location = new System.Drawing.Point(487, 267);
            this.btnUpdateDegree.Name = "btnUpdateDegree";
            this.btnUpdateDegree.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateDegree.TabIndex = 5;
            this.btnUpdateDegree.Text = "Update Degree";
            this.btnUpdateDegree.UseVisualStyleBackColor = true;
            this.btnUpdateDegree.Click += new System.EventHandler(this.btnUpdateDegree_Click);
            // 
            // btnDeleteDegree
            // 
            this.btnDeleteDegree.Location = new System.Drawing.Point(487, 317);
            this.btnDeleteDegree.Name = "btnDeleteDegree";
            this.btnDeleteDegree.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteDegree.TabIndex = 6;
            this.btnDeleteDegree.Text = "Delete Degree";
            this.btnDeleteDegree.UseVisualStyleBackColor = true;
            this.btnDeleteDegree.Click += new System.EventHandler(this.btnDeleteDegree_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(487, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageDegreesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteDegree);
            this.Controls.Add(this.btnUpdateDegree);
            this.Controls.Add(this.btnAddDegree);
            this.Controls.Add(this.cmbFaculties);
            this.Controls.Add(this.txtDegreeName);
            this.Controls.Add(this.lblDegreeName);
            this.Controls.Add(this.dgvDegrees);
            this.Name = "ManageDegreesForm";
            this.Text = "ManageDegreesForm";
            this.Load += new System.EventHandler(this.ManageDegreesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegrees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDegrees;
        private System.Windows.Forms.Label lblDegreeName;
        private System.Windows.Forms.TextBox txtDegreeName;
        private System.Windows.Forms.ComboBox cmbFaculties;
        private System.Windows.Forms.Button btnAddDegree;
        private System.Windows.Forms.Button btnUpdateDegree;
        private System.Windows.Forms.Button btnDeleteDegree;
        private System.Windows.Forms.Button btnClose;
    }
}