using ClsPeopleBusinessLayer;
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
    public partial class CtrlShowUserInfo : UserControl
    {
        ClsPerson _Person;
        ClsUser _User;

        public CtrlShowUserInfo()
        {
            InitializeComponent();
        }

        private void CtrlChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadPersonInfo(int PersonID)
        {
            _Person = ClsPerson.FindByPersonID(PersonID);

            if (_Person != null)
                ctrlShowPersonInfo1.LoadPersonInfo(PersonID);
            else
                MessageBox.Show($"Person With ID = {PersonID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadUserInfo(int UserID)
        {
            _User = ClsUser.FindByUserID(UserID);

            if (_User != null)
            {
                lblUserID.Text = _User.UserID.ToString();
                lblUsername.Text = _User.UserName.ToString();
                if (_User.IsActive)
                    lblIsActive.Text = "Active";
                else
                    lblIsActive.Text = "InActive";

                LoadPersonInfo(_User.PersonID);
            }
            else
                MessageBox.Show($"User With ID = {UserID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
