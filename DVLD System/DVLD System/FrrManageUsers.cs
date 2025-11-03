using ClsCountryBusinessLayer;
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
    public partial class FrrManageUsers : Form
    {
        DataTable _dtUsers;

        public FrrManageUsers()
        {
            InitializeComponent();
        }

        private void _FillDGVUsers()
        {
            _dtUsers = ClsUser.GetUsers();

            if (_dtUsers.Rows.Count > 0)
            {
                DGVUsers.DataSource = _dtUsers;

                DGVUsers.Columns[0].HeaderText = "UserID";
                DGVUsers.Columns[0].Width = 150;

                DGVUsers.Columns[1].HeaderText = "Person ID";
                DGVUsers.Columns[1].Width = 150;

                DGVUsers.Columns[2].HeaderText = "FullName";
                DGVUsers.Columns[2].Width = 180;

                DGVUsers.Columns[3].HeaderText = "Username";
                DGVUsers.Columns[3].Width = 150;

                DGVUsers.Columns[4].HeaderText = "IsActive";
                DGVUsers.Columns[4].Width = 150;

            }

            lblRecords.Text = DGVUsers.Rows.Count.ToString();
        }

        private void _FillCbFilter()
        {
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("UserID");
            cbFilterBy.Items.Add("PersonID");
            cbFilterBy.Items.Add("UserName");
            cbFilterBy.Items.Add("IsActive");

            cbFilterBy.SelectedIndex = 0;
        }

        private void FrrManageUsers_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = false;
            rbActive.Visible = false;
            rbInActive.Visible = false;
            _FillDGVUsers();
            _FillCbFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtUsers.Rows.Count > 0)
                _dtUsers.DefaultView.RowFilter = "";

            tbFilter.Text = string.Empty;

            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                rbActive.Visible = false;
                rbInActive.Visible = false;
                return;
            }
            else if (cbFilterBy.SelectedItem.ToString() == "IsActive")
            {
                tbFilter.Visible = false;
                rbActive.Visible = true;
                rbInActive.Visible = true;
                rbActive.Checked = true;
                rbActive_CheckedChanged(null , null);
            }
            else
            {
                tbFilter.Visible = true;
                rbActive.Visible = false;
                rbInActive.Visible = false;
            }

        }

        private void pbAddNewUser_Click(object sender, EventArgs e)
        {
            FrrAddNewUser frr = new FrrAddNewUser();
            frr.ShowDialog();
            _FillDGVUsers();
        }

        private void FilterActiveUsers()
        {
            if (rbActive.Checked)
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilterBy.SelectedItem.ToString(), true);

            lblRecords.Text = DGVUsers.Rows.Count.ToString();
        }

        private void FilterInActiveUsers()
        {
            if (rbInActive.Checked)
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilterBy.SelectedItem.ToString(), false);

            lblRecords.Text = DGVUsers.Rows.Count.ToString();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked)
                FilterActiveUsers();
            else if (rbInActive.Checked)
                FilterInActiveUsers();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "UserID" || cbFilterBy.SelectedItem.ToString() == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbFilter_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                if (_dtUsers.Rows.Count > 0)
                    _dtUsers.DefaultView.RowFilter = "";

                lblRecords.Text = DGVUsers.Rows.Count.ToString();
                return;
            }

            if (_dtUsers.Rows.Count > 0)
            {
                if (cbFilterBy.SelectedItem.ToString() == "UserID" || cbFilterBy.SelectedItem.ToString() == "PersonID")
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilterBy.SelectedItem.ToString(), tbFilter.Text.Trim());
                else
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilterBy.SelectedItem.ToString(), tbFilter.Text.Trim());

                lblRecords.Text = DGVUsers.Rows.Count.ToString();
            }
        }
    }
}
