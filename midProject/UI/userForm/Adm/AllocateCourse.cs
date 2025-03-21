using midProject.dl;
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
    public partial class AllocateCourse : UserControl
    {
        public AllocateCourse()
        {
            InitializeComponent();
            dataGridView1.DataSource = LoadCourseData();
            dataGridView2.DataSource = LoadFacultyData();
            LoadSemesterData();

        }


        private void LoadSemesterData()
        {
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT term, year FROM semesters"; // Fetch term and year

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string semesterValue = $"{reader["term"]} {reader["year"]}"; // Combine term and year
                            comboBox1.Items.Add(semesterValue); // Add to comboBox
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private DataTable LoadCourseData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT course_id, course_name, course_type, credit_hours, contact_hours FROM courses";

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

        private DataTable LoadFacultyData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT faculty_id, name, email, contact, research_area, total_teaching_hours FROM faculty";

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

        private int GetSemesterID(string semester)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string[] parts = semester.Split(' ');
            string term = parts[0];
            int year = Convert.ToInt32(parts[1]);
            string query = "SELECT semester_id FROM semesters WHERE term = @term AND year = @year";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@term", term);
                cmd.Parameters.AddWithValue("@year", year);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView2.SelectedRows.Count > 0)
            {
                int courseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["course_id"].Value);
                int facultyID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["faculty_id"].Value);
                string semester = comboBox1.Text;
                if(semester!=string.Empty)
                {
                    int semester_id = GetSemesterID(semester);
                    int result = CourseDL.InsertFacultyCourse(facultyID, courseID, semester_id);
                    if (result != 0)
                    {
                        MessageBox.Show("Course Allocated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Unable to allocate course");

                    }
                }


            }
            else
            {
                MessageBox.Show("Please select a row from both tables before allocating.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AllocateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
