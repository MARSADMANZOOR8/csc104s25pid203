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

namespace midProject.UI.userForm.Faculty
{
    public partial class ViewCources : UserControl
    {
        public ViewCources()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userId = SignIn.GlobalUserID;
            DataTable dt = new DataTable();

            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string facultyQuery = "SELECT faculty_id FROM faculty WHERE user_id = @userId";
                    int faculty_id;

                    using (SqlCommand facultyCmd = new SqlCommand(facultyQuery, connection))
                    {
                        facultyCmd.Parameters.AddWithValue("@userId", userId);  // ✅ Corrected parameter name
                        object facultyResult = facultyCmd.ExecuteScalar();

                        if (facultyResult == null)
                        {
                            MessageBox.Show("No faculty record found for the logged-in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        faculty_id = Convert.ToInt32(facultyResult);
                    }

                    string query = @"SELECT 
                        courses.course_name, 
                        courses.credit_hours, 
                        semesters.term, 
                        semesters.year 
                     FROM faculty_courses 
                     INNER JOIN courses ON faculty_courses.course_id = courses.course_id
                     INNER JOIN semesters ON semesters.semester_id = faculty_courses.semester_id
                     WHERE faculty_courses.faculty_id = @faculty_id"; // ✅ Correct SQL parameter name

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@faculty_id", faculty_id);  // ✅ Fixed mismatch

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Bind the fetched data to courseGrid
            courseGrid.DataSource = dt;
        }


    }
}
