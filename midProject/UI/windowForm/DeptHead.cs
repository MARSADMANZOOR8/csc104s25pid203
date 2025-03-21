using midProject.UI.userForm.DeptHead;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midProject.UI.windowForm
{
    public partial class DeptHead : Form
    {
        public DeptHead()
        {
            InitializeComponent();
        }
        private void AddPanel(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel6.Controls.Clear();
            panel6.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApprBtn_Click(object sender, EventArgs e)
        {
            HandleReq r = new HandleReq();
            AddPanel(r);
        }

        private void AsWork_Click(object sender, EventArgs e)
        {
            ManageProject manageProject = new ManageProject();
            AddPanel(manageProject);
        }

        private void ResBtn_Click(object sender, EventArgs e)
        {
            AddResources r = new AddResources();
            AddPanel(r);
        }
    }
}
