using ClsGlobalUserLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class FrrMainScreen : Form
    {
        public FrrMainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrManagePeopleScreen frr = new FrrManagePeopleScreen();
            frr.ShowDialog();
        }

        private void singToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsGlobalUser.CurrentUser = null;
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrManageUsers frr = new FrrManageUsers();
            frr.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrShowUserInfo frr = new FrrShowUserInfo(ClsGlobalUser.CurrentUser.UserID);
            frr.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrChangeUserPassword frr = new FrrChangeUserPassword(ClsGlobalUser.CurrentUser.UserID);
            frr.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrManageApplicationTypes frr = new FrrManageApplicationTypes();
            frr.ShowDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrManageTestTypes frr = new FrrManageTestTypes();
            frr.ShowDialog();
        }

      
    }
}
