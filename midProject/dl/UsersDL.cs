using midProject.bl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace midProject.dl
{
    internal class UsersDL
    {
        public static List<UsersBL> users = new List<UsersBL>();

        public static void AddUser(UsersBL user)
        {
            users.Add(user);
        }

        public static void LoadUsers()
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "SELECT username, email, lookup.value as RoleValue\r\nFROM users \r\nLEFT JOIN lookup ON lookup.lookup_id = users.role_id;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string username = reader["username"].ToString();
                string email = reader["email"].ToString();
                string role = reader["RoleValuee"].ToString();
                UsersBL user = new UsersBL(username, email, role);
                AddUser(user);
            }

            reader.Close();
        }


        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2")); // Convert byte to hex string
                }
                return sb.ToString();
            }
        }


        public static int InsertUserData(UsersBL user)
        {
            var connection = DataBaseHelper.GetConnection();
            connection.Open();
            string query = "SELECT lookup_id FROM lookup WHERE category = 'User Roles' AND value = @role";
            int roleId = -1;
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@role", user.role);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    roleId = Convert.ToInt32(result);
                }
                else
                {
                    return 1;
                }

            }

            string hashedPassword = HashPassword(user.password);

            string insertQuery = "INSERT INTO [users] (username, email, password_hash, role_id) VALUES (@name, @email, @password, @roleId)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@name", user.username);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@roleId", roleId);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return 0;

                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
