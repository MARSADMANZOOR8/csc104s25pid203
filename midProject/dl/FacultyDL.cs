using midProject.bl;
using midProject.UI.userForm.Admin;
using midProject.UI.windowForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.dl
{
    internal class FacultyDL
    {
        public static List<FacultyBL> faculties = new List<FacultyBL>();

        public static void AddFaculty(FacultyBL faculty)
        {
            faculties.Add(faculty);
        }

        public static List<int> GetFaultyID(string name, string email, string area)
        {
            List<int> ids = new List<int>();
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Select faculty_id,user_id from faculty where name=@name and email=@email and research_area=@area";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("area", area);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int faculty_id = reader.GetInt32(0);
                        int user_id = reader.GetInt32(1);
                        ids.Add(faculty_id);
                        ids.Add(user_id);
                    }
                }
            }
            return ids;
        }

        public static void LoadFaculty()
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Select name,email,lookup.value,contact,research_area,total_teaching_hours from faculty\r\nleft join lookup on faculty.designation_id = lookup.lookup_id;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                string designation = reader["value"].ToString();
                string contact = reader["contact"].ToString();
                string research_area = reader["research_area"].ToString();
                int hours = Convert.ToInt32(reader["total_teaching_hours"]);
                FacultyBL faculty = new FacultyBL(name, email, contact, designation, research_area, hours);
                AddFaculty(faculty);
            }

            reader.Close();
        }

        public static int GetInsertedID(FacultyBL faculty)
        {
            int insertedUserId = -1;
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                connection.Open();
                int roleId = 2;
                string insertQuery = @"
            INSERT INTO [users] (username, email, password_hash, role_id) 
            OUTPUT INSERTED.user_id 
            VALUES (@name, @email, @password, @roleId)";

                string hash_password = UsersDL.HashPassword(faculty.password);
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", faculty.name);
                    cmd.Parameters.AddWithValue("@email", faculty.email);
                    cmd.Parameters.AddWithValue("@password", hash_password);
                    cmd.Parameters.AddWithValue("@roleId", roleId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        insertedUserId = Convert.ToInt32(result);
                    }
                }
            }

            return insertedUserId;
        }


        public static int GetDesignationID(string designation)
        {
            int designation_id = -1;
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Select lookup_id\r\nfrom lookup\r\nwhere value = @value";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@value", designation);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    designation_id = Convert.ToInt32(result);
                }

            }
            return designation_id;
        }

        public static int InsertIntoFaculty(FacultyBL faculty)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string insertQuery = @"
            INSERT INTO [faculty] (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) 
            VALUES (@name, @email, @contact, @designation_id, @research_area, @total_teaching_hours, @user_id)";
            int user_id = GetInsertedID(faculty);
            int designation_id = GetDesignationID(faculty.designation);
            if(user_id > 0 && designation_id>0)
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", faculty.name);
                    cmd.Parameters.AddWithValue("@email", faculty.email);
                    cmd.Parameters.AddWithValue("@contact", faculty.contact);
                    cmd.Parameters.AddWithValue("@designation_id", designation_id);
                    cmd.Parameters.AddWithValue("@research_area", faculty.research_area);
                    cmd.Parameters.AddWithValue("@total_teaching_hours", faculty.teaching_hours);
                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return 0;

                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            else
            {
                return 2;
            }
        }
        
        public static bool DeleteFaculty(int faculty_id)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "Delete from faculty where faculty_id = @fac_id";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@fac_id", faculty_id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0) {
                return true;
                }
                return false;

            }
        }


        public static List<int> GetFacultyIDfromPassword(string email, string password)
        {
            List<int> ids = new List<int>();
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string hashed_password = UsersDL.HashPassword(password);
            string query = @"
        SELECT faculty.faculty_id, faculty.user_id 
        FROM faculty 
        LEFT JOIN users ON faculty.user_id = users.user_id 
        WHERE faculty.email = @email AND users.password_hash = @password";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("password", hashed_password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int faculty_id = reader.GetInt32(0);
                        int user_id = reader.GetInt32(1);
                        ids.Add(faculty_id);
                        ids.Add(user_id);
                    }
                }
            }
            return ids;
        }
        public static int UpdateFacultyData(FacultyBL faculty)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = @"
        UPDATE faculty 
        SET name = @name, 
            contact = @contact, 
            research_area = @res, 
            designation_id = @designation_id,
            total_teaching_hours = @hours 
        WHERE faculty_id = @id";
            List<int> ids = new List<int>();
            ids = GetFacultyIDfromPassword(faculty.email, faculty.password);
            int fac_id = ids[0];
            int user_id = ids[1];
            int designation_id = GetDesignationID(faculty.designation);
            if (user_id > 0 && fac_id>0 && designation_id>0)
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", faculty.name);
                    cmd.Parameters.AddWithValue("@email", faculty.email);
                    cmd.Parameters.AddWithValue("@contact", faculty.contact);
                    cmd.Parameters.AddWithValue("@res", faculty.research_area);
                    cmd.Parameters.AddWithValue("@hours", faculty.teaching_hours);
                    cmd.Parameters.AddWithValue("@designation_id", designation_id);
                    cmd.Parameters.AddWithValue("@id", fac_id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return user_id;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
            return -2;
        }


    }
}
