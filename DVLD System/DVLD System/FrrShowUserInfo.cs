using ClsUserBusinessLayer;
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
    public partial class FrrShowUserInfo : Form
    {
        int _UserID = -1;

        public FrrShowUserInfo(int userID)
        {
            InitializeComponent();

            _UserID = userID;
        }

        private void FrrShowUserInfo_Load(object sender, EventArgs e)
        {
            if (ClsUser.IsUserExistByUserID(_UserID))
                ctrlShowUserInfo1.LoadUserInfo(_UserID);
            else
                MessageBox.Show($"User With ID = {_UserID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
