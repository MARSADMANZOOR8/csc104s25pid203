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
    public partial class ResourceReq : UserControl
    {
        public ResourceReq()
        {
            InitializeComponent();
            LoadConsumablesIntoComboBox();
        }

        private void LoadConsumablesIntoComboBox()
        {
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT item_name FROM consumables";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            pname.Items.Clear(); // Clear previous items if any

                            while (reader.Read())
                            {
                                pname.Items.Add(reader["item_name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading consumables: " + ex.Message);
                }
            }
        }

        private void reqBtn_Click(object sender, EventArgs e)
        {

            string Pname = pname.Text;
            int quantity = Convert.ToInt32(Qtxt.Text);
            DateTime date = DateTime.Now;
            int status_id = 8;
            int loggedInUserID = SignIn.GlobalUserID;

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();

                    string facultyQuery = "SELECT faculty_id FROM faculty WHERE user_id = @UserID";
                    int faculty_id;

                    using (SqlCommand facultyCmd = new SqlCommand(facultyQuery, conn))
                    {
                        facultyCmd.Parameters.AddWithValue("@UserID", loggedInUserID);
                        object facultyResult = facultyCmd.ExecuteScalar();

                        if (facultyResult == null)
                        {
                            MessageBox.Show("No faculty record found for the logged-in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        faculty_id = Convert.ToInt32(facultyResult);
                    }

                    string consumableQuery = "SELECT consumable_id FROM consumables WHERE item_name = @Pname";
                    int consumable_id;

                    using (SqlCommand consumableCmd = new SqlCommand(consumableQuery, conn))
                    {
                        consumableCmd.Parameters.AddWithValue("@Pname", Pname);
                        object consumableResult = consumableCmd.ExecuteScalar();

                        if (consumableResult == null)
                        {
                            MessageBox.Show("Item not found in consumables.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        consumable_id = Convert.ToInt32(consumableResult);
                    }

                    string insertQuery = "INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date) " +
                                         "VALUES (@FacultyID, @ItemID, @Quantity, @StatusID, @RequestDate)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@FacultyID", faculty_id);
                        insertCmd.Parameters.AddWithValue("@ItemID", consumable_id);
                        insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertCmd.Parameters.AddWithValue("@StatusID", status_id);
                        insertCmd.Parameters.AddWithValue("@RequestDate", date);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
