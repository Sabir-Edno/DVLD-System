using ClsApplicationTypeBusinessLayer;
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
    public partial class FrrEditApplicationType : Form
    {
        ClsApplicationType ApplicationType;
        int _ApplicationTypeID = -1;

        public FrrEditApplicationType(int applicationTypeID)
        {
            InitializeComponent();

            _ApplicationTypeID = applicationTypeID;

            btnSave.Enabled = false;
        }

        private void _LoadApplicationTypeInfo()
        {
            ApplicationType = ClsApplicationType.FindByApplicationTypeID(_ApplicationTypeID);

            if(ApplicationType != null)
            {
                lblID.Text = ApplicationType.ApplicationTypeID.ToString();
                tbTitle.Text = ApplicationType.ApplicationTypeTitle;
                tbFees.Text = ApplicationType.ApplicationFees.ToString();

                btnSave.Enabled = true;
            }
        }

        private void FrrEditApplicationType_Load(object sender, EventArgs e)
        {
            _LoadApplicationTypeInfo();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplicationType.ApplicationTypeTitle = tbTitle.Text.Trim();
            ApplicationType.ApplicationFees = Convert.ToDecimal(tbFees.Text.Trim());

            if (ApplicationType.Save())
                MessageBox.Show("Application Type Updated Succesfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Application Type Failed To Updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
