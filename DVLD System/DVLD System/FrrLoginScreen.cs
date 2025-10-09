using ClsGlobalUserLayer;
using ClsUserBusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class FrrLoginScreen : Form
    {
        public FrrLoginScreen()
        {
            InitializeComponent();
        }

        private void FrrLoginScreen_Load(object sender, EventArgs e)
        {
            checkRememberMe.Checked = false;
            tbUsername.MaxLength = 20;
            tbPassword.MaxLength = 20;

            string Path = @"C:\DVLD System\RememberMe\UsernameAndPassword.txt";

            if (File.Exists(Path))
            {
                string Content = File.ReadAllText(Path);
                if (string.IsNullOrEmpty(Content))
                    return;
                else
                {
                    string[] Contents = Content.Split('/');

                    tbUsername.Text = Contents[0];
                    tbPassword.Text = Contents[1];
                    checkRememberMe.Checked = true;
                }
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                MessageBox.Show("Enter Login Information", "Login Info Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ClsUser.IsUserExistByUserName(tbUsername.Text))
            {
                if (ClsUser.IsUserActive(tbUsername.Text))
                {

                    if (ClsUser.IsUsernameAndPasswordCorrect(tbUsername.Text, tbPassword.Text))
                    {
                        bool IsUserFound = false;
                        ClsGlobalUser.LoadUserInfo(tbUsername.Text, ref IsUserFound);

                        if(!IsUserFound)
                        {
                            MessageBox.Show("Error : To Load User Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FrrMainScreen frr = new FrrMainScreen();
                        frr.ShowDialog();
                    }
                    else
                        MessageBox.Show("Username/Password : Not Correct", "Not Correct", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("User Not Active : Contact Admin", "Not Active" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Username Not Exist", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void checkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            string Path = @"C:\DVLD System\RememberMe\UsernameAndPassword.txt";

            if (checkRememberMe.Checked)
            {

                if(File.Exists(Path))
                {
                    string Content = tbUsername.Text + '/' + tbPassword.Text;
                    File.WriteAllText(Path, Content);
                }
            }
            else
            {
                if (File.Exists(Path))
                    File.WriteAllText(Path, string.Empty);
            }

        }
    }
}
