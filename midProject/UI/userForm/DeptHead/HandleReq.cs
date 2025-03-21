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

namespace midProject.UI.userForm.DeptHead
{
    public partial class HandleReq : UserControl
    {
        public HandleReq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT 
                                faculty.name, 
                                faculty_requests.quantity, 
                                consumables.item_name, 
                                lookup.value AS Status 
                            FROM faculty_requests 
                            JOIN consumables ON faculty_requests.item_id = consumables.consumable_id
                            JOIN faculty ON faculty_requests.faculty_id = faculty.faculty_id
                            JOIN lookup ON faculty_requests.status_id = lookup.lookup_id";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
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

            // Bind the fetched data to FReqGrid
            FReqGrid.DataSource = dt;
        }

    }
}
