using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuturePath.DataAccess;

namespace INF2011_ProjectP2_Team7
{
    public partial class ManageFundingForm : Form
    {
        private int selectedFundingId = -1;

        public ManageFundingForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ManageFundingForm_Load);
            this.dgvFunding.CellClick += new DataGridViewCellEventHandler(this.dgvFunding_CellClick);
        }

        private void ManageFundingForm_Load(object sender, EventArgs e)
        {
            LoadFunding();
        }

        private void LoadFunding()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if Funding table exists, if not create it and add seed data (8 funding options from project spec)
                    // Updated FundingID to FundingId
                    string checkTableQuery = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Funding' and xtype='U')
                    BEGIN
                        CREATE TABLE Funding (
                            FundingId INT IDENTITY(1,1) PRIMARY KEY,
                            FundingName VARCHAR(100) NOT NULL,
                            Description VARCHAR(255) NULL
                        );
                        INSERT INTO Funding (FundingName, Description) VALUES ('NSFAS', 'National Student Financial Aid Scheme for qualifying undergraduate students');
                        INSERT INTO Funding (FundingName, Description) VALUES ('Allan Gray Orbis Foundation Fellowship', 'Fellowship for entrepreneurial students');
                        INSERT INTO Funding (FundingName, Description) VALUES ('ISFDB Bursary', 'Information Systems Faculty Development Bursary');
                        INSERT INTO Funding (FundingName, Description) VALUES ('BankSETA Bursary', 'Banking sector education and training authority bursary');
                        INSERT INTO Funding (FundingName, Description) VALUES ('Merit Scholarship', 'Awarded for top academic performance');
                        INSERT INTO Funding (FundingName, Description) VALUES ('Sars Bursary', 'South African Revenue Service bursary scheme');
                        INSERT INTO Funding (FundingName, Description) VALUES ('Funza Lushaka Bursary', 'Teaching bursary programme');
                        INSERT INTO Funding (FundingName, Description) VALUES ('Scrum Master Grant', 'Specialized tech certification grant');
                    END";

                    using (SqlCommand createCmd = new SqlCommand(checkTableQuery, conn))
                    {
                        createCmd.ExecuteNonQuery();
                    }

                    // Load funding records into grid using FundingId
                    string query = "SELECT FundingId, FundingName, Description FROM Funding";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFunding.DataSource = dt;

                        if (dgvFunding.Columns["FundingId"] != null)
                        {
                            dgvFunding.Columns["FundingId"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load funding options: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddFunding_Click(object sender, EventArgs e)
        {
            string fundingName = txtFundingName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(fundingName))
            {
                MessageBox.Show("Please enter a funding name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Funding (FundingName, Description) VALUES (@FundingName, @Description)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FundingName", fundingName);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funding option added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadFunding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting funding option: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateFunding_Click(object sender, EventArgs e)
        {
            if (selectedFundingId == -1)
            {
                MessageBox.Show("Please select a funding option from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fundingName = txtFundingName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(fundingName))
            {
                MessageBox.Show("Please enter a funding name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Updated FundingID to FundingId
                    string query = "UPDATE Funding SET FundingName = @FundingName, Description = @Description WHERE FundingId = @FundingId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FundingName", fundingName);
                        cmd.Parameters.AddWithValue("@Description", string.IsNullOrEmpty(description) ? (object)DBNull.Value : description);
                        cmd.Parameters.AddWithValue("@FundingId", selectedFundingId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Funding option updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadFunding();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating funding option: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFunding_Click(object sender, EventArgs e)
        {
            if (selectedFundingId == -1)
            {
                MessageBox.Show("Please select a funding option from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this funding option?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        // Updated FundingID to FundingId
                        string query = "DELETE FROM Funding WHERE FundingId = @FundingId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FundingId", selectedFundingId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Funding option deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadFunding();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting funding option: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFunding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFunding.Rows.Count - 1)
            {
                DataGridViewRow row = dgvFunding.Rows[e.RowIndex];

                // Updated FundingID to FundingId
                if (row.Cells["FundingId"].Value != null && row.Cells["FundingId"].Value != DBNull.Value)
                {
                    selectedFundingId = Convert.ToInt32(row.Cells["FundingId"].Value);
                }

                if (row.Cells["FundingName"].Value != null)
                {
                    txtFundingName.Text = row.Cells["FundingName"].Value.ToString();
                }

                if (row.Cells["Description"].Value != null && row.Cells["Description"].Value != DBNull.Value)
                {
                    txtDescription.Text = row.Cells["Description"].Value.ToString();
                }
                else
                {
                    txtDescription.Clear();
                }
            }
        }

        private void ClearForm()
        {
            txtFundingName.Clear();
            txtDescription.Clear();
            selectedFundingId = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}