using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuturePath.DataAccess;

namespace INF2011_ProjectP2_Team7
{
    public partial class ManageFacultiesForm : Form
    {
        private int selectedFacultyId = -1;

        public ManageFacultiesForm()
        {
            InitializeComponent();
        }

        private void ManageFacultiesForm_Load(object sender, EventArgs e)
        {
            LoadFaculties();
        }

        private void LoadFaculties()
        {
            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    // Updated FacultyID to FacultyId
                    string query = "SELECT FacultyId, FacultyName FROM Faculty";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvFaculties.DataSource = dt;

                        if (dgvFaculties.Columns["FacultyId"] != null)
                        {
                            dgvFaculties.Columns["FacultyId"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading faculties: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string facultyName = txtFacultyName.Text.Trim();
            if (string.IsNullOrEmpty(facultyName))
            {
                MessageBox.Show("Please enter a faculty name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Faculty (FacultyName) VALUES (@FacultyName)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FacultyName", facultyName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Faculty added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFacultyName.Clear();
                selectedFacultyId = -1;
                LoadFaculties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding faculty: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedFacultyId == -1)
            {
                MessageBox.Show("Please select a faculty from the grid to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string facultyName = txtFacultyName.Text.Trim();
            if (string.IsNullOrEmpty(facultyName))
            {
                MessageBox.Show("Please enter a faculty name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    // Updated FacultyID to FacultyId
                    string query = "UPDATE Faculty SET FacultyName = @FacultyName WHERE FacultyId = @FacultyId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FacultyName", facultyName);
                        cmd.Parameters.AddWithValue("@FacultyId", selectedFacultyId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Faculty updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFacultyName.Clear();
                selectedFacultyId = -1;
                LoadFaculties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating faculty: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFacultyId == -1)
            {
                MessageBox.Show("Please select a faculty from the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this faculty?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        // Updated FacultyID to FacultyId
                        string query = "DELETE FROM Faculty WHERE FacultyId = @FacultyId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FacultyId", selectedFacultyId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Faculty deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFacultyName.Clear();
                    selectedFacultyId = -1;
                    LoadFaculties();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting faculty: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFaculties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvFaculties.Rows.Count)
            {
                DataGridViewRow row = dgvFaculties.Rows[e.RowIndex];

                if (row.Cells["FacultyId"].Value != null && row.Cells["FacultyId"].Value != DBNull.Value)
                {
                    selectedFacultyId = Convert.ToInt32(row.Cells["FacultyId"].Value);
                }

                if (row.Cells["FacultyName"].Value != null)
                {
                    txtFacultyName.Text = row.Cells["FacultyName"].Value.ToString();
                }
            }
        }
    }
}