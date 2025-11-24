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
    public partial class FrrChangeUserPassword : Form
    {
        int _UserID = -1;
        ClsUser _User;

        public FrrChangeUserPassword(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            btnSave.Enabled = false;
            tbConfirmPassword.Enabled = false;
            tbNewPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;

            _User = ClsUser.FindByUserID(UserID);

            if (_User != null)
            {
                ctrlChangePassword1.LoadUserInfo(_UserID);
                btnSave.Enabled = true;
                tbConfirmPassword.Enabled = true;
                tbNewPassword.Enabled = true;
                tbConfirmPassword.Enabled = true;
            }
            else
                MessageBox.Show($"User With ID = {_UserID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrrChangeUserPassword_Load(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds Not Valid Put The Mouse On The Red Icon To Read The Problem", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ClsUser._UpdateUserPassword(_UserID, tbNewPassword.Text.Trim()))
                MessageBox.Show("Password Changed Succeefully", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed To Change Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(_User.Password != tbCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Current Password Wrong");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, null);
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbNewPassword.Text.Trim() == _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "New Password Doesn't Be Like Last Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text.Trim() != tbNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Confirm Password Doesn't Match New Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }
    }
}
