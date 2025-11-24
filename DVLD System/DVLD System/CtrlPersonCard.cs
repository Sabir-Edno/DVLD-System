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
    public partial class CtrlPersonCard : UserControl
    {
        ClsPerson Person;

        public CtrlPersonCard()
        {
            InitializeComponent();
        }

        public bool DisableFindPersonCard
        {
            set { GbPersonCard.Enabled = value; }
            get { return GbPersonCard.Enabled; }
        }

        public event Action<int> OnPersonSelected;

        public event Action<bool> OnPersonNotSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> Handler = OnPersonSelected;

            if (Handler != null)
                Handler(PersonID);
        }
        protected virtual void PersonNotSelected(bool Empty)
        {
            Action<bool> Handler = OnPersonNotSelected;

            if (Handler != null)
                Handler(Empty);
        }

        public void LoadPersonInfo(int PersonID)
        {
            Person = ClsPerson.FindByPersonID(PersonID);

            if(Person != null)
            {
                tbFilter.Text = PersonID.ToString();
                ctrlShowPersonInfo1.LoadPersonInfo(PersonID);
                if(OnPersonSelected != null)
                    OnPersonSelected(PersonID);

                
            }
            else
            {
                MessageBox.Show($"Person With ID = {PersonID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlShowPersonInfo1.ResetValues();
            }
        }

        public void LoadPersonInfo(string NationalNo)
        {
            Person = ClsPerson.FindByNationalNo(NationalNo);

            if (Person != null)
            {
                tbFilter.Text = NationalNo;
                ctrlShowPersonInfo1.LoadPersonInfo(Person.PersonID);
                if (OnPersonSelected != null)
                    OnPersonSelected(Person.PersonID);
            }
            else
            {
                MessageBox.Show($"Person With NationalNo = {NationalNo} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlShowPersonInfo1.ResetValues();
            }
        }

        private void CtrlPersonCard_Load(object sender, EventArgs e)
        {
            cbFilterBy.Items.Add("PersonID");
            cbFilterBy.Items.Add("National No.");

            cbFilterBy.SelectedIndex = 0; 
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Text = string.Empty;
            Person = null;
            ctrlShowPersonInfo1.ResetValues();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
                return;

            switch(cbFilterBy.SelectedItem.ToString())
            {
                case "PersonID":
                    LoadPersonInfo(Convert.ToInt32(tbFilter.Text));
                    break;

                case "National No.":
                    LoadPersonInfo(tbFilter.Text);
                    break;
            }
        }

        private void PersonID_DataBack(object Sender , int PersonID)
        {
            cbFilterBy.SelectedItem = "PersonID";
            tbFilter.Text = PersonID.ToString();
            ctrlShowPersonInfo1.ResetValues();
            LoadPersonInfo(PersonID);
        }

        private void pbAddNewPerson_Click(object sender, EventArgs e)
        {
            FrrAddOrEditPersonInfo frr = new FrrAddOrEditPersonInfo();
            frr.DataBack += PersonID_DataBack;
            frr.ShowDialog();
        }
    }
}
