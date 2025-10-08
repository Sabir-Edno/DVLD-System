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
    public partial class FrrShowPersonInfo : Form
    {
        int _PersonID = -1;

        public FrrShowPersonInfo(int personID)
        {
            InitializeComponent();

            _PersonID = personID;
        }

        private void FrrShowPersonInfo_Load(object sender, EventArgs e)
        {
            if (ClsPerson.IsPersonExistByPersonID(_PersonID))
                ctrlShowPersonInfo1.LoadPersonInfo(_PersonID);
            else
                MessageBox.Show($"Person With ID = {_PersonID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
