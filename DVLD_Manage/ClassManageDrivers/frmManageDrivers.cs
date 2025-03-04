using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.ClassManageDrivers
{
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        void _RefreshData()
        {
            dgvDriversData.DataSource = clsDrivers.GetAllDrivers();
            lblTotalDrivers.Text = dgvDriversData.RowCount.ToString();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void txtbSearsh_TextChanged(object sender, EventArgs e)
        {
            int CountRow = 0;
            clsDGV_Filter.Filter(txtbSearsh.Text, cmbbFilterBy.Text, dgvDriversData, clsDrivers.GetAllDrivers(), ref CountRow);
            lblTotalDrivers.Text = CountRow.ToString();
        }

        private void ShowPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails((int)dgvDriversData.CurrentRow.Cells[1].Value);
            frm.ShowDialog();

            _RefreshData();
        }

        private void ShowPersonLicenseHisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory((int)dgvDriversData.CurrentRow.Cells[1].Value);

            frm.ShowDialog();

        }
    }
}
