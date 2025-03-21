using System;
using System.Data.SqlClient;

namespace midProject
{
    internal static class DataBaseHelper
    {
        private static readonly string connectionString = "Data Source=DESKTOP-SBVR2CA;Initial Catalog=ProjectB;Integrated Security=True;TrustServerCertificate=True";

        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true; 
                }
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
