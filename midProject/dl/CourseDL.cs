using midProject.bl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.dl
{
    internal class CourseDL
    {
        public static List<CourseBL> courses = new List<CourseBL> ();

        public static int InsertCourse(CourseBL course)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Insert into [courses] (course_name, course_type, credit_hours, contact_hours)" +
                "VALUES (@name, @type, @credit_hours, @contact_hours)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", course.course_name);
                cmd.Parameters.AddWithValue("@type", course.course_type);
                cmd.Parameters.AddWithValue("@credit_hours", course.credit_hours);
                cmd.Parameters.AddWithValue("@contact_hours", course.contact_hours);
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    return 1;
                }
                return 0;
            }
        }


        public static int InsertFacultyCourse(int faculty_id, int course_id, int semester_id)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Insert into [faculty_courses] (faculty_id, course_id, semester_id)" +
                "VALUES (@faculty_id, @course_id, @semester_id)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@faculty_id", faculty_id);
                cmd.Parameters.AddWithValue("@course_id", course_id);
                cmd.Parameters.AddWithValue("@semester_id", semester_id);
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    return 1;
                }
                return 0;
            }
        }
    }
}
