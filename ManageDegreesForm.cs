using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuturePath.DataAccess;

namespace INF2011_ProjectP2_Team7
{
    public partial class ManageDegreesForm : Form
    {
        private int selectedDegreeId = -1;

        public ManageDegreesForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(ManageDegreesForm_Load);
            this.dgvDegrees.CellClick += new DataGridViewCellEventHandler(this.dgvDegrees_CellClick);
        }

        private void ManageDegreesForm_Load(object sender, EventArgs e)
        {
            LoadFacultiesComboBox();
            LoadDegrees();
        }

        private void LoadFacultiesComboBox()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Faculty";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertDefaults = @"INSERT INTO Faculty (FacultyName) VALUES ('Commerce');
                                                     INSERT INTO Faculty (FacultyName) VALUES ('Science');
                                                     INSERT INTO Faculty (FacultyName) VALUES ('Humanities');";
                            using (SqlCommand insertCmd = new SqlCommand(insertDefaults, conn))
                            {
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Updated FacultyID to FacultyId
                    string query = "SELECT FacultyId, FacultyName FROM Faculty";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cmbFaculties.DataSource = dt;
                        cmbFaculties.DisplayMember = "FacultyName";
                        cmbFaculties.ValueMember = "FacultyId";
                        cmbFaculties.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculties: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDegrees()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // Updated to use table 'Degree' and lowercase column names 'DegreeId', 'FacultyId'
                    string query = @"SELECT d.DegreeId, d.DegreeName, 
                             ISNULL(f.FacultyName, 'Unassigned') AS FacultyName, 
                             d.FacultyId 
                             FROM Degree d 
                             LEFT JOIN Faculty f ON d.FacultyId = f.FacultyId";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvDegrees.DataSource = dt;

                        if (dgvDegrees.Columns["FacultyId"] != null)
                        {
                            dgvDegrees.Columns["FacultyId"].Visible = false;
                        }
                        if (dgvDegrees.Columns["DegreeId"] != null)
                        {
                            dgvDegrees.Columns["DegreeId"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load degrees table: " + ex.Message, "Database Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbFaculties_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Leave empty or use if needed
        }

        private void btnAddDegree_Click(object sender, EventArgs e)
        {
            string degreeName = txtDegreeName.Text.Trim();

            if (string.IsNullOrEmpty(degreeName))
            {
                MessageBox.Show("Please enter a degree name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbFaculties.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a faculty from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Updated to use table 'Degree' and column 'FacultyId'
                    string query = @"INSERT INTO Degree (DegreeName, FacultyId, IsActive) 
                                     SELECT @DegreeName, FacultyId, 1 
                                     FROM Faculty WHERE FacultyName = @FacultyName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DegreeName", degreeName);
                        cmd.Parameters.AddWithValue("@FacultyName", cmbFaculties.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Degree added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Could not find matching faculty in the database table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                ClearForm();
                LoadDegrees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting degree: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateDegree_Click(object sender, EventArgs e)
        {
            if (selectedDegreeId == -1)
            {
                MessageBox.Show("Please select a degree from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string degreeName = txtDegreeName.Text.Trim();
            if (string.IsNullOrEmpty(degreeName) || cmbFaculties.SelectedValue == null)
            {
                MessageBox.Show("Please enter a degree name and select a faculty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Updated to use table 'Degree' and lowercase keys
                    string query = "UPDATE Degree SET DegreeName = @DegreeName, FacultyId = @FacultyId WHERE DegreeId = @DegreeId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DegreeName", degreeName);
                        cmd.Parameters.AddWithValue("@FacultyId", cmbFaculties.SelectedValue);
                        cmd.Parameters.AddWithValue("@DegreeId", selectedDegreeId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Degree updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadDegrees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating degree: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteDegree_Click(object sender, EventArgs e)
        {
            if (selectedDegreeId == -1)
            {
                MessageBox.Show("Please select a degree from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this degree?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        // Updated to use table 'Degree' and lowercase primary key
                        string query = "DELETE FROM Degree WHERE DegreeId = @DegreeId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DegreeId", selectedDegreeId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Degree deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDegrees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting degree: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDegrees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDegrees.Rows.Count)
            {
                DataGridViewRow row = dgvDegrees.Rows[e.RowIndex];

                if (row.Cells["DegreeId"].Value != null && row.Cells["DegreeId"].Value != DBNull.Value)
                {
                    selectedDegreeId = Convert.ToInt32(row.Cells["DegreeId"].Value);
                }

                if (row.Cells["DegreeName"].Value != null)
                {
                    txtDegreeName.Text = row.Cells["DegreeName"].Value.ToString();
                }

                if (row.Cells["FacultyId"] != null && row.Cells["FacultyId"].Value != DBNull.Value)
                {
                    cmbFaculties.SelectedValue = row.Cells["FacultyId"].Value;
                }
            }
        }

        private void ClearForm()
        {
            txtDegreeName.Clear();
            cmbFaculties.SelectedIndex = -1;
            selectedDegreeId = -1;
        }
    }
}