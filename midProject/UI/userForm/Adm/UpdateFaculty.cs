using midProject.bl;
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

namespace midProject.UI.userForm.Admin
{
    public partial class UpdateFaculty : UserControl
    {
        public UpdateFaculty()
        {
            InitializeComponent();
        }

        private void UptBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string password = PassTxt.Text;
            string email = EmTxt.Text;
            string contact = ConTxt.Text;
            string research_area = ResTxt.Text;
            int TotalHours = Convert.ToInt32(HrsTxt.Text);
            string designation = DesignationTxt.Text;
            FacultyBL faculty = new FacultyBL(name, email, password, contact, designation, research_area, TotalHours);
            int id = FacultyDL.UpdateFacultyData(faculty);
            if (id > 0)
            {
                var connection = DataBaseHelper.GetConnection();
                connection.Open();
                string query = "Update users set username = @name, email=@email where user_id=@id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record updated successfully");
                }
            }
            else
            {
                MessageBox.Show("Error updating user");
            }
        }
    }
}
