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
    public partial class CtrlShowPersonInfo : UserControl
    {
        ClsPerson Person;

        public CtrlShowPersonInfo()
        {
            InitializeComponent();

            linkEditPerson.Enabled = false;
        }

        public bool ShowPersonInfo
        {
            set { gbPersonInfo.Enabled = value; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            Person = ClsPerson.FindByPersonID(PersonID);

            if(Person != null)
            {
                lblPersonID.Text = PersonID.ToString();
                lblName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                lblNationalNo.Text = Person.NationalNo;
                if (Person.Gendor == 0)
                    lblGendor.Text = "Male";
                else
                    lblGendor.Text = "Female";

                if(Person.Email != "")
                    lblEmail.Text = Person.Email;

                lblAddress.Text = Person.Address;
                lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
                lblPhone.Text = Person.Phone;
                lblCountry.Text = ClsCountry.FindByCountryID(Person.NationalityCountryID).CountryName;

                if(Person.ImagePath != "")
                    pbPersonImage.ImageLocation = Person.ImagePath;

                linkEditPerson.Enabled = true;
            }
        }

        private void CtrlShowPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void linkEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Person.PersonID != -1 && Person != null)
            {
                FrrAddOrEditPersonInfo frr = new FrrAddOrEditPersonInfo(Person.PersonID);
                frr.ShowDialog();
                LoadPersonInfo(Person.PersonID);
            }
        }

        public void ResetValues()
        {
            Person = null;
            lblPersonID.Text = "???";
            lblName.Text = "???";
            lblNationalNo.Text = "???";
            lblPersonID.Text = "???";
            lblGendor.Text = "???";
            lblEmail.Text = "???";
            lblAddress.Text = "???";
            lblDateOfBirth.Text = "???";
            lblPhone.Text = "???";
            lblCountry.Text = "???";
            pbPersonImage.ImageLocation = null;
            linkEditPerson.Enabled = false;
        }
    }
}
