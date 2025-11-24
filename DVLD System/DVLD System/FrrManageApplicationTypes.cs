using ClsApplicationTypeBusinessLayer;
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
    public partial class FrrManageApplicationTypes : Form
    {
        DataTable _dtApplicationTypes;

        public FrrManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _FillDGVApplicationType()
        {
            _dtApplicationTypes = ClsApplicationType.GetApplicationTypes();

            if (_dtApplicationTypes.Rows.Count > 0)
            {
                DGVApplicationTypes.DataSource = _dtApplicationTypes;

                DGVApplicationTypes.Columns[0].HeaderText = "ID";
                DGVApplicationTypes.Columns[0].Width = 150;

                DGVApplicationTypes.Columns[1].HeaderText = "Title";
                DGVApplicationTypes.Columns[1].Width = 300;

                DGVApplicationTypes.Columns[2].HeaderText = "Fees";
                DGVApplicationTypes.Columns[2].Width = 200;

            }

            lblRecords.Text = _dtApplicationTypes.Rows.Count.ToString();
        }

        private void FrrManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _FillDGVApplicationType();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrrEditApplicationType frr = new FrrEditApplicationType((int)DGVApplicationTypes.CurrentRow.Cells[0].Value);
            frr.ShowDialog();

            _FillDGVApplicationType();
        }
    }
}
