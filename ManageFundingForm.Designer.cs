namespace INF2011_ProjectP2_Team7
{
    partial class ManageFundingForm
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
            this.txtFundingName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFundingName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvFunding = new System.Windows.Forms.DataGridView();
            this.btnAddFunding = new System.Windows.Forms.Button();
            this.btnUpdateFunding = new System.Windows.Forms.Button();
            this.btnDeleteFunding = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunding)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFundingName
            // 
            this.txtFundingName.Location = new System.Drawing.Point(205, 33);
            this.txtFundingName.Name = "txtFundingName";
            this.txtFundingName.Size = new System.Drawing.Size(100, 20);
            this.txtFundingName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 82);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // lblFundingName
            // 
            this.lblFundingName.AutoSize = true;
            this.lblFundingName.Location = new System.Drawing.Point(70, 36);
            this.lblFundingName.Name = "lblFundingName";
            this.lblFundingName.Size = new System.Drawing.Size(76, 13);
            this.lblFundingName.TabIndex = 2;
            this.lblFundingName.Text = "Funding Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(70, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // dgvFunding
            // 
            this.dgvFunding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunding.Location = new System.Drawing.Point(45, 158);
            this.dgvFunding.Name = "dgvFunding";
            this.dgvFunding.Size = new System.Drawing.Size(668, 222);
            this.dgvFunding.TabIndex = 4;
            // 
            // btnAddFunding
            // 
            this.btnAddFunding.Location = new System.Drawing.Point(577, 26);
            this.btnAddFunding.Name = "btnAddFunding";
            this.btnAddFunding.Size = new System.Drawing.Size(75, 23);
            this.btnAddFunding.TabIndex = 5;
            this.btnAddFunding.Text = "Add Funding";
            this.btnAddFunding.UseVisualStyleBackColor = true;
            this.btnAddFunding.Click += new System.EventHandler(this.btnAddFunding_Click);
            // 
            // btnUpdateFunding
            // 
            this.btnUpdateFunding.Location = new System.Drawing.Point(577, 55);
            this.btnUpdateFunding.Name = "btnUpdateFunding";
            this.btnUpdateFunding.Size = new System.Drawing.Size(136, 23);
            this.btnUpdateFunding.TabIndex = 6;
            this.btnUpdateFunding.Text = "Update Funding";
            this.btnUpdateFunding.UseVisualStyleBackColor = true;
            this.btnUpdateFunding.Click += new System.EventHandler(this.btnUpdateFunding_Click);
            // 
            // btnDeleteFunding
            // 
            this.btnDeleteFunding.Location = new System.Drawing.Point(577, 96);
            this.btnDeleteFunding.Name = "btnDeleteFunding";
            this.btnDeleteFunding.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteFunding.TabIndex = 7;
            this.btnDeleteFunding.Text = "Delete Funding";
            this.btnDeleteFunding.UseVisualStyleBackColor = true;
            this.btnDeleteFunding.Click += new System.EventHandler(this.btnDeleteFunding_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(577, 125);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageFundingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteFunding);
            this.Controls.Add(this.btnUpdateFunding);
            this.Controls.Add(this.btnAddFunding);
            this.Controls.Add(this.dgvFunding);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFundingName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtFundingName);
            this.Name = "ManageFundingForm";
            this.Text = "ManageFundingForm";
            this.Load += new System.EventHandler(this.ManageFundingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFundingName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFundingName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgvFunding;
        private System.Windows.Forms.Button btnAddFunding;
        private System.Windows.Forms.Button btnUpdateFunding;
        private System.Windows.Forms.Button btnDeleteFunding;
        private System.Windows.Forms.Button btnClose;
    }
}