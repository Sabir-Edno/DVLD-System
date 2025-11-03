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
            ClsGlobalUser.User = null;
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrManageUsers frr = new FrrManageUsers();
            frr.ShowDialog();
        }
    }
}
