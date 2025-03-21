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
    public partial class TrackReq : UserControl
    {
        public TrackReq()
        {
            InitializeComponent();
        }

        private void reqGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            int userId = SignIn.GlobalUserID;
            

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string facultyQuery = "SELECT faculty_id FROM faculty WHERE user_id = @UserID";
                    int faculty_id;

                    using (SqlCommand facultyCmd = new SqlCommand(facultyQuery, conn))
                    {
                        facultyCmd.Parameters.AddWithValue("@UserID", userId);
                        object facultyResult = facultyCmd.ExecuteScalar();

                        if (facultyResult == null)
                        {
                            MessageBox.Show("No faculty record found for the logged-in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        faculty_id = Convert.ToInt32(facultyResult);
                    }
                    string query = @"
                        SELECT 
                            consumables.item_name, 
                            faculty_requests.quantity, 
                            lookup.value AS status
                        FROM consumables
                        INNER JOIN faculty_requests ON faculty_requests.item_id = consumables.consumable_id
                        INNER JOIN lookup ON faculty_requests.status_id = lookup.lookup_id
                        WHERE faculty_requests.faculty_id = @faculty_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@faculty_id", faculty_id);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            reqGrid.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
