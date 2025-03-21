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

namespace midProject.UI.userForm.Adm
{
    public partial class ViewFacultyCourses : UserControl
    {
        public ViewFacultyCourses()
        {
            InitializeComponent();
        }

        private DataTable LoadFacultyCoursesFromDB()
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
                            c.course_name, 
                            c.course_type, 
                            c.credit_hours, 
                            s.term, 
                            s.year
                        FROM faculty_courses fc
                        JOIN faculty f ON fc.faculty_id = f.faculty_id
                        JOIN courses c ON fc.course_id = c.course_id
                        JOIN semesters s ON fc.semester_id = s.semester_id;";

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
            DataTable dt = LoadFacultyCoursesFromDB();
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
    }
}
