using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuturePath.DataAccess;

namespace INF2011_ProjectP2_Team7
{
    public partial class ManageSubjectsForm : Form
    {
        private int selectedSubjectID = -1;

        public ManageSubjectsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ManageSubjectsForm_Load);
            this.dgvSubjects.CellClick += new DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
        }

        private void ManageSubjectsForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Check if Subject table exists, if not create it and add seed data
                    string checkTableQuery = @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Subject' and xtype='U')
                    BEGIN
                        CREATE TABLE Subject (
                            SubjectID INT IDENTITY(1,1) PRIMARY KEY,
                            SubjectName VARCHAR(100) NOT NULL,
                            IsMandatory BIT NOT NULL DEFAULT 0
                        );
                        INSERT INTO Subject (SubjectName, IsMandatory) VALUES ('Mathematics', 1);
                        INSERT INTO Subject (SubjectName, IsMandatory) VALUES ('English Home Language', 1);
                        INSERT INTO Subject (SubjectName, IsMandatory) VALUES ('Physical Sciences', 0);
                        INSERT INTO Subject (SubjectName, IsMandatory) VALUES ('Accounting', 0);
                    END";

                    using (SqlCommand createCmd = new SqlCommand(checkTableQuery, conn))
                    {
                        createCmd.ExecuteNonQuery();
                    }

                    // Load subjects into grid
                    string query = "SELECT SubjectID, SubjectName, IsMandatory FROM Subject";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSubjects.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load subjects: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubjectName.Text.Trim();
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter a subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Subject (SubjectName, IsMandatory) VALUES (@SubjectName, @IsMandatory)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                        cmd.Parameters.AddWithValue("@IsMandatory", chkIsMandatory.Checked);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting subject: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateSubject_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == -1)
            {
                MessageBox.Show("Please select a subject from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string subjectName = txtSubjectName.Text.Trim();
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please enter a subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Subject SET SubjectName = @SubjectName, IsMandatory = @IsMandatory WHERE SubjectID = @SubjectID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubjectName", subjectName);
                        cmd.Parameters.AddWithValue("@IsMandatory", chkIsMandatory.Checked);
                        cmd.Parameters.AddWithValue("@SubjectID", selectedSubjectID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating subject: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == -1)
            {
                MessageBox.Show("Please select a subject from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Subject WHERE SubjectID = @SubjectID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SubjectID", selectedSubjectID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Subject deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadSubjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting subject: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSubjects.Rows.Count - 1)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                if (row.Cells["SubjectID"].Value != null && row.Cells["SubjectID"].Value != DBNull.Value)
                {
                    selectedSubjectID = Convert.ToInt32(row.Cells["SubjectID"].Value);
                }
                if (row.Cells["SubjectName"].Value != null)
                {
                    txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                }
                if (row.Cells["IsMandatory"].Value != null && row.Cells["IsMandatory"].Value != DBNull.Value)
                {
                    chkIsMandatory.Checked = Convert.ToBoolean(row.Cells["IsMandatory"].Value);
                }
            }
        }

        private void ClearForm()
        {
            txtSubjectName.Clear();
            chkIsMandatory.Checked = false;
            selectedSubjectID = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}