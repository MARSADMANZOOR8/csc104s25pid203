using midProject.bl;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.dl
{
    internal class ProjectsDL
    {
        public static List<ProjectsBL> projectss = new List<ProjectsBL>();

        public static void AddProject(ProjectsBL project)
        {
            projectss.Add(project);
        }

        public static int InsertProject(ProjectsBL project)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Insert into [projects] (title, description)" +
                "VALUES (@title, @desc)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", project.title);
                cmd.Parameters.AddWithValue("@desc", project.description);
                int rowsaffected = cmd.ExecuteNonQuery();
                if (rowsaffected > 0)
                {
                    return 1;
                }
                return 0;
            }
        }

        public static int InsertFacultyProject(int faculty_id, int course_id, int semester_id, int hours)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Insert into [faculty_projects] (faculty_id, course_id, semester_id, supervision_hours)" +
                "VALUES (@faculty_id, @course_id, @semester_id, @hours)";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@faculty_id", faculty_id);
                cmd.Parameters.AddWithValue("@course_id", course_id);
                cmd.Parameters.AddWithValue("@semester_id", semester_id);
                cmd.Parameters.AddWithValue("@hours", hours);
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
