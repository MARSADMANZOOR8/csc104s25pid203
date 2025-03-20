using midProject.bl;
using midProject.UI.windowForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midProject.dl
{
    internal class FacultyDL
    {
        public static List<FacultyBL> faculties = new List<FacultyBL>();

        public static void AddFaculty(FacultyBL faculty)
        {
            faculties.Add(faculty);
        }

        //public static void LoadFaculty()
        //{
        //    var connection = DataBaseHelper.GetConnection();
        //    connection.Open();
        //    string query = "SELECT username, email, lookup.value as RoleValue\r\nFROM users \r\nLEFT JOIN lookup ON lookup.lookup_id = users.role_id;";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    SqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        string username = reader["username"].ToString();
        //        string email = reader["email"].ToString();
        //        string role = reader["RoleValuee"].ToString();
        //        UsersBL user = new UsersBL(username, email, role);
        //        AddFaculty(user);
        //    }

        //    reader.Close();
        //}

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


    }
}
