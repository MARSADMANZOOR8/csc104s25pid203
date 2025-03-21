using midProject.dl;
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
    public partial class DeleteFaculty : UserControl
    {
        public DeleteFaculty()
        {
            InitializeComponent();
            LoadFacultyData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadFacultyData()
        {
            DataTable dt = LoadFacultyFromDB();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            dataGridView1.DataSource = dt;
        }


        private DataTable LoadFacultyFromDB()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DataBaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT faculty_id, name, email, contact, research_area, total_teaching_hours FROM faculty";

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


        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                string name = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                string researchArea = dataGridView1.SelectedRows[0].Cells["research_area"].Value.ToString();
                List<int> ids = new List<int>();
                ids = FacultyDL.GetFaultyID(name, email, researchArea);
                int faculty_id = ids[0];
                int user_id = ids[1];
                if (UsersDL.DeleteUserData(user_id) && FacultyDL.DeleteFaculty(faculty_id))
                {
                    MessageBox.Show("Record Deleted Successfully");
                    LoadFacultyData();
                }
                else
                {
                    MessageBox.Show("Unable to delete this record");
                }
            }
        }
    }
}
