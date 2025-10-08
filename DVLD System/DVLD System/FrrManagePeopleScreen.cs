using ClsCountryBusinessLayer;
using ClsPeopleBusinessLayer;
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
    public partial class FrrManagePeopleScreen : Form
    {
        DataTable _dtPeople;

        public FrrManagePeopleScreen()
        {
            InitializeComponent();
        }

        private void _FillDGVPeople()
        {
            _dtPeople = ClsPerson.GetPeople();

            if(_dtPeople.Rows.Count > 0)
            {
                DGVPeople.DataSource = _dtPeople;

                DGVPeople.Columns[0].HeaderText = "Person ID";
                DGVPeople.Columns[0].Width = 100;

                DGVPeople.Columns[1].HeaderText = "National No";
                DGVPeople.Columns[1].Width = 100;

                DGVPeople.Columns[2].HeaderText = "FirstName";
                DGVPeople.Columns[2].Width = 100;

                DGVPeople.Columns[3].HeaderText = "SecondName";
                DGVPeople.Columns[3].Width = 100;

                DGVPeople.Columns[4].HeaderText = "ThirdName";
                DGVPeople.Columns[4].Width = 100;

                DGVPeople.Columns[5].HeaderText = "LastName";
                DGVPeople.Columns[5].Width = 100;

                DGVPeople.Columns[6].HeaderText = "DateOfBirth";
                DGVPeople.Columns[6].Width = 130;

                DGVPeople.Columns[7].HeaderText = "Gendor";
                DGVPeople.Columns[7].Width = 100;

                DGVPeople.Columns[8].HeaderText = "CountryName";
                DGVPeople.Columns[8].Width = 100;

                DGVPeople.Columns[9].HeaderText = "Phone";
                DGVPeople.Columns[9].Width = 100;

                DGVPeople.Columns[10].HeaderText = "Email";
                DGVPeople.Columns[10].Width = 100;

                DGVPeople.Columns[11].HeaderText = "Address";
                DGVPeople.Columns[11].Width = 100;

            }

            lblRecords.Text = _dtPeople.Rows.Count.ToString();
        }

        private void _FillCbCountries()
        {
            DataTable _dtCountires = ClsCountry.GetCountries();

            if (_dtCountires.Rows.Count > 0)
            {
                foreach (DataRow Country in _dtCountires.Rows)
                {
                    CbCountries.Items.Add(Country["CountryName"]);
                }
            }
            else
            {
                MessageBox.Show("Countries Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CbCountries.SelectedIndex = 0;
        }

        private void _FillCbFilter()
        {
            cbFilterBy.Items.Add("None");
            cbFilterBy.Items.Add("PersonID");
            cbFilterBy.Items.Add("NationalNo");
            cbFilterBy.Items.Add("FirstName");
            cbFilterBy.Items.Add("SecondName");
            cbFilterBy.Items.Add("ThirdName");
            cbFilterBy.Items.Add("LastName");
            cbFilterBy.Items.Add("Nationality");
            cbFilterBy.Items.Add("Gendor");
            cbFilterBy.Items.Add("Phone");
            cbFilterBy.Items.Add("Email");

            cbFilterBy.SelectedIndex = 0;
        }

        private void FrrManagePeopleScreen_Load(object sender, EventArgs e)
        {
            tbFilter.Visible = false;
            rbMale.Visible = false;
            rbFemale.Visible = false;
            CbCountries.Visible = false;
            _FillCbFilter();
            _FillDGVPeople();
            _FillCbCountries();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddNewPerson_Click(object sender, EventArgs e)
        {
            FrrAddOrEditPersonInfo frr = new FrrAddOrEditPersonInfo();
            frr.ShowDialog();
            _FillDGVPeople();
            cbFilterBy_SelectedIndexChanged(null, null);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            _FillDGVPeople();

            if (cbFilterBy.SelectedItem.ToString() == "None")
            {
                tbFilter.Visible = false;
                rbMale.Visible = false;
                rbFemale.Visible = false;
                CbCountries.Visible = false;
                return;
            }
            else if(cbFilterBy.SelectedItem.ToString() == "Nationality")
            {
                tbFilter.Visible = false;
                rbMale.Visible = false;
                rbFemale.Visible = false;
                CbCountries.Visible = true;
                CbCountries_SelectedIndexChanged(null, null);
                return;
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Gendor")
            {
                tbFilter.Visible = false;
                rbMale.Visible = true;
                rbFemale.Visible = true;
                CbCountries.Visible = false;
                if (rbMale.Checked)
                    rbMale_CheckedChanged(null, null);
                else
                    rbFemale_CheckedChanged(null, null);
                return;
            }
            else
            {
                tbFilter.Visible = true;
                rbMale.Visible = false;
                rbFemale.Visible = false;
                CbCountries.Visible = false;
                return;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            if (cbFilterBy.SelectedItem.ToString() == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", cbFilterBy.SelectedItem.ToString() , tbFilter.Text.Trim());
                return;
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Nationality")
            {
               
                return;
            }
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", cbFilterBy.SelectedItem.ToString() , tbFilter.Text.Trim());

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (_dtPeople.Rows.Count > 0 && rbMale.Visible && rbFemale.Visible)
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIke '{1}%'", cbFilterBy.SelectedItem.ToString(), "Male");

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (_dtPeople.Rows.Count > 0 && rbMale.Visible && rbFemale.Visible)
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", cbFilterBy.SelectedItem.ToString(), "Female");
        }

        private void CbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtPeople.Rows.Count > 0 && CbCountries.Visible)
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", "CountryName", CbCountries.SelectedItem.ToString());
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "PersonID" || cbFilterBy.SelectedItem.ToString() == "Phone")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrAddOrEditPersonInfo frr = new FrrAddOrEditPersonInfo();
            frr.ShowDialog();
            _FillDGVPeople();
            cbFilterBy_SelectedIndexChanged(null, null);
        }

        private void updatePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVPeople.Rows.Count > 0)
            {
                FrrAddOrEditPersonInfo frr = new FrrAddOrEditPersonInfo((int)DGVPeople.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVPeople();
                cbFilterBy_SelectedIndexChanged(null, null);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVPeople.Rows.Count > 0)
            {
                if (MessageBox.Show($"Are You Sure Do You Want To Delete Person With ID = {(int)DGVPeople.CurrentRow.Cells[0].Value}"
                    , "Conferm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ClsPerson.DeletePerson((int)DGVPeople.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show($"Person With ID = {(int)DGVPeople.CurrentRow.Cells[0].Value} Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FillDGVPeople();
                        cbFilterBy_SelectedIndexChanged(null, null);
                    }
                    else
                        MessageBox.Show($"Person With ID = {(int)DGVPeople.CurrentRow.Cells[0].Value} Not Deleted", "Failed To Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGVPeople.Rows.Count > 0)
            {
                FrrShowPersonInfo frr = new FrrShowPersonInfo((int)DGVPeople.CurrentRow.Cells[0].Value);
                frr.ShowDialog();
                _FillDGVPeople();
                cbFilterBy_SelectedIndexChanged(null, null);
            }
        }
    }
}
