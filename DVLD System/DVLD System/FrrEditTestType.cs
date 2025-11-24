using ClsApplicationTypeBusinessLayer;
using ClsTestTypeBusinessLayer;
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
    public partial class FrrEditTestType : Form
    {
        ClsTestType TestType;
        int _TestTypeID = -1;

        public FrrEditTestType(int testtypeid)
        {
            InitializeComponent();

            _TestTypeID = testtypeid;

            btnSave.Enabled = false;    
        }

        private void _LoadTestTypeInfo()
        {
            TestType = ClsTestType.FindByTestTypeID(_TestTypeID);

            if (TestType != null)
            {
                lblID.Text = TestType.TestTypeID.ToString();
                tbTitle.Text = TestType.TestTypeTitle;
                tbDescription.Text = TestType.TestTypeDescription;
                tbFees.Text = TestType.TestTypeFees.ToString();

                btnSave.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TestType.TestTypeTitle = tbTitle.Text.Trim();
            TestType.TestTypeDescription = tbDescription.Text.Trim();
            TestType.TestTypeFees = Convert.ToDecimal(tbFees.Text.Trim());

            if (TestType.Save())
                MessageBox.Show("TestType Updated Succesfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("TestType Failed To Updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrrEditTestType_Load(object sender, EventArgs e)
        {
            _LoadTestTypeInfo();
        }
    }
}
