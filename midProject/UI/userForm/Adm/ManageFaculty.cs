using midProject.UI.userForm.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.userForm.Adm
{
    public partial class ManageFaculty : UserControl
    {
        public ManageFaculty()
        {
            InitializeComponent();
        }

        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddFaculty add = new AddFaculty();
            AddPanel(add);

        }

        private void UptBtn_Click(object sender, EventArgs e)
        {
            UpdateFaculty updateFaculty = new UpdateFaculty();
            AddPanel(updateFaculty);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DeleteFaculty deleteFaculty = new DeleteFaculty();
            AddPanel(deleteFaculty);
        }
    }
}
