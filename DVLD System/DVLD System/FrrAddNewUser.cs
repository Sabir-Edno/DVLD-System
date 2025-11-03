using ClsPeopleBusinessLayer;
using ClsUserBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class FrrAddNewUser : Form
    {
        int _PersonID = -1;
        int _UserID = -1; 
        ClsUser User;

        enum enMode {AddNew = 1 , Update = 2 }
        enMode _Mode = enMode.Update;

        public FrrAddNewUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddNewUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.Update;
        }

        private void LoadUserInfo()
        {
            if(_Mode == enMode.AddNew)
            {
                lblTitleMode.Text = "Add New User";
                User = new ClsUser();
                btnSave.Enabled = false;
                ctrlPersonCard1.DisableFindPersonCard = true;
                return;
            }

            User = ClsUser.FindByUserID(_UserID);

            if(User != null)
            {
                lblTitleMode.Text = "Update User Info";

                _PersonID = User.PersonID;
                ctrlPersonCard1.LoadPersonInfo(_PersonID);
                lblUserID.Text = User.UserID.ToString();
                tbUsername.Text = User.UserName;
                tbPassword.Text = User.Password;
                tbConfirmPassword.Text = User.Password;

                if (User.IsActive)
                    checkActive.Checked = true;
                else
                    checkActive.Checked = false;

                btnSave.Enabled = true;

                ctrlPersonCard1.DisableFindPersonCard = true;
                btnSave.Enabled = true;
            }
        }

        private void FrrAddNewUser_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            LoadUserInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonCard1_OnPersonSelected(int obj)
        {
            if(ClsPerson.IsPersonExistByPersonID(obj))
                _PersonID = obj;
            else
            {
                MessageBox.Show($"Person With ID = {obj} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                _PersonID = -1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
            {
                if (ClsUser.FindByPersonID(_PersonID) == null)
                {
                    tabControl1.SelectedIndex = 1;
                    tbUsername.Focus();
                    btnSave.Enabled = true;
                }
                else
                    MessageBox.Show($"Person With ID = {_PersonID} Aleardy User On System , Choose Another One that Not User On System", "Aleardy User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("You Should Select Person", "Select Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Filds Not Valid ", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User.PersonID = _PersonID;
            User.UserID = _UserID;
            User.UserName = tbUsername.Text.Trim();
            User.Password = tbPassword.Text.Trim();

            if (checkActive.Checked)
                User.IsActive = true;
            else
                User.IsActive = false;

            if(_Mode == enMode.AddNew)
            {
                if(User.Save())
                {
                    lblUserID.Text = "Update User Info";
                    lblUserID.Text = User.UserID.ToString();

                    MessageBox.Show($"New User Added Successfully With ID = {User.UserID}", "Added New User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ctrlPersonCard1.DisableFindPersonCard = false;
                }
                else
                    MessageBox.Show("Failed To Add User", "User Not Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(_Mode == enMode.Update)
            {
                if (User.Save())
                    MessageBox.Show($"User Info Updated Successfully", "User Info Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed To Update User Info", "User Info Failed To Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Username Not Be Empty");
            }
            else
            {
                if(ClsUser.IsUserExistByUserName(tbUsername.Text.Trim()) && User.UserName.Trim() != tbUsername.Text.Trim())
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbUsername, "Username Aleardy Exist");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbUsername, null);
                }
            }
            
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Confirm Password Not Be Empty");
            }
            else
            {
                if (tbConfirmPassword.Text != tbPassword.Text)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbConfirmPassword, "Confirm Password Does Not Math Password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbConfirmPassword, null);
                }

            }
        }
    }
}
