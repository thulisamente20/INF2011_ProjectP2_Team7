using FuturePath.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF2011_ProjectP2_Team7
{
    public partial class LoadDegreesButton : Form
    {
        private FacultyController facultyController = new FacultyController();
        private DegreeProgrammeController degreeController = new DegreeProgrammeController();
        public LoadDegreesButton()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This satisfies the designer event hookup
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the business layer to get data and bind it to your DataGridView
            dataGridView1.DataSource = facultyController.GetFaculties();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentController studentController = new StudentController();
            dataGridView1.DataSource = studentController.GetStudents();
        }
    }
}