using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.userForm.DeptHead
{
    public partial class ViewProjects : UserControl
    {
        public ViewProjects()
        {
            InitializeComponent();
        }


        private DataTable LoadFacultyProjectsFromDB()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT 
                    f.name AS Faculty_Name, 
                    f.contact, 
                    f.total_teaching_hours, 
                    p.title AS Project_Title, 
                    p.description AS Project_Description, 
                    s.term, 
                    s.year
                FROM faculty_projects fp
                JOIN faculty f ON fp.faculty_id = f.faculty_id
                JOIN projects p ON fp.project_id = p.project_id
                JOIN semesters s ON fp.semester_id = s.semester_id;";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }

        private void LoadDataIntoGrid()
        {
            DataTable dt = LoadFacultyProjectsFromDB();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
        }

        private void RefBtn_Click(object sender, EventArgs e)
        {
            LoadDataIntoGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
