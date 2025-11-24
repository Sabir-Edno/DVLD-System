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
    public partial class FrrManageTestTypes : Form
    {
        DataTable _dtTestTypes;

        public FrrManageTestTypes()
        {
            InitializeComponent();
        }

        private void _FillDGVTestTypes()
        {
            _dtTestTypes = ClsTestType.GetTestTypes();

            if (_dtTestTypes.Rows.Count > 0)
            {
                DGVTestTypes.DataSource = _dtTestTypes;

                DGVTestTypes.Columns[0].HeaderText = "ID";
                DGVTestTypes.Columns[0].Width = 150;

                DGVTestTypes.Columns[1].HeaderText = "Title";
                DGVTestTypes.Columns[1].Width = 250;

                DGVTestTypes.Columns[2].HeaderText = "Description";
                DGVTestTypes.Columns[2].Width = 350;

                DGVTestTypes.Columns[3].HeaderText = "Fees";
                DGVTestTypes.Columns[3].Width = 200;

            }

            lblRecords.Text = _dtTestTypes.Rows.Count.ToString();
        }

        private void FrrManageTestTypes_Load(object sender, EventArgs e)
        {
            _FillDGVTestTypes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrEditTestType frr = new FrrEditTestType((int)DGVTestTypes.CurrentRow.Cells[0].Value);
            frr.ShowDialog();
            _FillDGVTestTypes();
        }
    }
}
