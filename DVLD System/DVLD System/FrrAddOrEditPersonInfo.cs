using ClsCountryBusinessLayer;
using ClsPeopleBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClsUtilLayer;

namespace DVLD_System
{
    public partial class FrrAddOrEditPersonInfo : Form
    {
        int _PersonID = -1;
        ClsPerson _Person;

        enum enMode { AddNew = 1 , Update = 2};
        private enMode _Mode = enMode.Update;

        public FrrAddOrEditPersonInfo()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public FrrAddOrEditPersonInfo(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;

            _Mode = enMode.Update;
        }

        private void _FillCbCountries()
        {
            DataTable _dtCountires = ClsCountry.GetCountries();

            if (_dtCountires.Rows.Count > 0)
            {
                foreach (DataRow Country in _dtCountires.Rows)
                {
                    cbCountries.Items.Add(Country["CountryName"]);
                }
            }
            else
            {
                MessageBox.Show("Countries Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cbCountries.SelectedIndex = 0;
        }

        private void _LoadPersonInfo()
        {
            if(_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";
                _Person = new ClsPerson();
                linkRemove.Visible = false;
                return;
            }

            _Person = ClsPerson.FindByPersonID(_PersonID);

            if(_Person != null)
            {
                lblMode.Text = "Update Person Info";
                lblPersonID.Text = _Person.PersonID.ToString();
                tbFirstName.Text = _Person.FirstName;
                tbSecondName.Text = _Person.SecondName;
                tbThirdName.Text = _Person.ThirdName;
                tbLastName.Text = _Person.LastName;
                tbNationalNo.Text = _Person.NationalNo;
                DTPDateOfBirth.Value = _Person.DateOfBirth;
                if (_Person.Gendor == 0)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                tbPhone.Text = _Person.Phone;
                tbEmail.Text = _Person.Email;
                cbCountries.SelectedItem = ClsCountry.FindByCountryID(_Person.NationalityCountryID).CountryName;
                tbAddress.Text = _Person.Address;

                if (_Person.ImagePath != "")
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                    linkRemove.Visible = true;
                }
                else
                {
                    pbPersonImage.ImageLocation = null;
                    linkRemove.Visible = false;
                }

            }
        }

        private void FrrAddOrEditPersonInfo_Load(object sender, EventArgs e)
        {
            _FillCbCountries();
            _LoadPersonInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            linkRemove.Visible = false;
        }

        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pbPersonImage.ImageLocation = openFileDialog.FileName;
                    linkRemove.Visible = true;
                }
            }


        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbFirstName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFirstName, "FirstName Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFirstName, null);
            }
        }

        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSecondName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSecondName, "SecondName Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbSecondName, null);
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbLastName, "LastName Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbLastName, null);
            }
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNo, "NationalNo Not Be Empty");
            }
            else
            {
                if (ClsPerson.IsPersonExistByNationalNo(tbNationalNo.Text.Trim()) && _Person.NationalNo != tbNationalNo.Text.Trim())
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbNationalNo, "NationalNo Already Exits");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbNationalNo, null);
                }
            }
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhone.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPhone, "Phone Not Be Empty");
            }
            else
            {
                if (ClsPerson.IsPersonExistByPhone(tbPhone.Text.Trim()) && _Person.Phone != tbPhone.Text.Trim())
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPhone, "Phone Already Exits");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbPhone, null);
                }
            }
        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Regular expression for validating email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbEmail.Text.Trim()))
            {
                if (IsValidEmail(tbEmail.Text.Trim()))
                {
                    if (ClsPerson.IsPersonExistByEmail(tbEmail.Text.Trim()) && _Person.Email != tbEmail.Text.Trim())
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(tbEmail, "Email Already Exits");
                    }
                    
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Email Not Valid");
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (_Mode == enMode.Update)
                {
                    if (_Person.ImagePath != null)
                    {

                        try
                        {
                            File.Delete(_Person.ImagePath);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Error : Image Not Deleted From File Error Message : " + e.Message);
                        }
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();
                    if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image , Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds Not Valid Put The Mouse Over The Icon(s) And See Wath's the Problem(s)", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = tbFirstName.Text;
            _Person.SecondName = tbSecondName.Text;
            if (!string.IsNullOrEmpty(tbThirdName.Text.Trim()))
                _Person.ThirdName = tbThirdName.Text;
            else
                _Person.ThirdName = "";
            _Person.LastName = tbLastName.Text;
            _Person.NationalNo = tbNationalNo.Text;
            _Person.DateOfBirth = DTPDateOfBirth.Value;
            if (rbMale.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;
            _Person.Phone = tbPhone.Text;
            if (!string.IsNullOrEmpty(tbEmail.Text.Trim()))
                _Person.Email = tbEmail.Text;
            else
                _Person.Email = "";
            _Person.NationalityCountryID = ClsCountry.FindByCountryName(cbCountries.SelectedItem.ToString()).CountryID;
            _Person.Address = tbAddress.Text;

            if (_Person.ImagePath != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Mode == enMode.AddNew)
            {

                if (_Person.Save())
                {
                    lblPersonID.Text = _Person.PersonID.ToString();
                    lblMode.Text = "Update Person Info";
                    MessageBox.Show("Person Added Successfully", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblMode.Text = "Add New Person";
                    MessageBox.Show("Person Not Added", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_Person.Save())
                {
                    MessageBox.Show("Person Updated Successfully", "Succed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Person Not Updated", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAddress.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAddress, "Address Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbAddress, null);
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = true;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = true;
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
