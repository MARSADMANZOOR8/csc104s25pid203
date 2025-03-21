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

namespace midProject.UI.userForm.Adm
{
    public partial class FacultyRequests : UserControl
    {
        public FacultyRequests()
        {
            InitializeComponent();
            LoadDataIntoGrid();
        }


        private void LoadDataIntoGrid()
        {
            DataTable dt = LoadFacultyRequestsFromDB();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
        }
        private DataTable LoadFacultyRequestsFromDB()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            fr.request_id AS ID,
                            f.name AS Faculty_Name, 
                            f.email, 
                            f.contact, 
                            f.research_area, 
                            c.item_name, 
                            fr.quantity, 
                            l.value AS Status
                        FROM faculty_requests fr
                        JOIN faculty f ON fr.faculty_id = f.faculty_id
                        JOIN consumables c ON fr.item_id = c.consumable_id
                        JOIN lookup l ON fr.status_id = l.lookup_id;";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return dt;
        }

        private int GetStatusId(string statusValue)
        {
            int statusId = -1;
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT lookup_id FROM lookup WHERE value = @statusValue";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@statusValue", statusValue);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            statusId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching status ID: " + ex.Message);
                }
            }

            return statusId;
        }


        private void UpdateStatus(int id, string status)
        {
            int statusId = GetStatusId(status);

            if (statusId == -1)
            {
                MessageBox.Show("Invalid status value.");
                return;
            }

            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE faculty_requests SET status_id = @statusId WHERE request_id = @requestId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@statusId", statusId);
                        command.Parameters.AddWithValue("@requestId", id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully!");
                            LoadDataIntoGrid();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message);
                }
            }
        }
        private void UptBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int requestID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                string status = comboBox2.Text;
                UpdateStatus(requestID, status);
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }
    }
}
