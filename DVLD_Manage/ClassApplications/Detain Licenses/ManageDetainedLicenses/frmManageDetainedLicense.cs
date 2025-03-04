using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Detain_Licenses.DetainLicense;
using DVLD_Manage.ClassApplications.Detain_Licenses.ReleaseDetainLicense;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication;
using DVLD_Manage.ClassManageDrivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.ClassApplications.Detain_Licenses.ManageDetainedLicenses
{
    public partial class frmManageDetainedLicense : Form
    {
        public frmManageDetainedLicense()
        {
            InitializeComponent();
        }
        void _RefreshData()
        {
            dgvDetainLicenses.DataSource = clsDetainLicense.GetAllDetainLicenses_View();

            lblTotalLicense.Text = dgvDetainLicenses.RowCount.ToString();

            if (dgvDetainLicenses.RowCount > 0 )
            {
                dgvDetainLicenses.Columns[0].HeaderText = "Detain ID";
                dgvDetainLicenses.Columns[0].Width = 100;

                dgvDetainLicenses.Columns[1].HeaderText = "License ID";
                dgvDetainLicenses.Columns[1].Width = 100;

                dgvDetainLicenses.Columns[2].HeaderText = "Detain Date";
                dgvDetainLicenses.Columns[2].Width = 180;

                dgvDetainLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainLicenses.Columns[3].Width = 140;

                dgvDetainLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainLicenses.Columns[4].Width = 130;

                dgvDetainLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainLicenses.Columns[5].Width = 160;

                dgvDetainLicenses.Columns[6].HeaderText = "N.No";
                dgvDetainLicenses.Columns[6].Width = 100;

                dgvDetainLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainLicenses.Columns[7].Width = 400;

                dgvDetainLicenses.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainLicenses.Columns[8].Width = 150;


            }

        }
        private void frmManageDetainedLicense_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void txtbSearsh_TextChanged(object sender, EventArgs e)
        {
            int CountRow = 0;
            clsDGV_Filter.Filter(txtbSearsh.Text, cmbbFilterBy.Text, dgvDetainLicenses, clsDetainLicense.GetAllDetainLicenses_View(), ref CountRow);
            lblTotalLicense.Text = CountRow.ToString();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _RefreshData();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool IsDetain = (bool)dgvDetainLicenses.CurrentRow.Cells[3].Value;

            if (!IsDetain)
                releaseLicenseToolStripMenuItem.Enabled = true;
            else
                releaseLicenseToolStripMenuItem.Enabled = false;
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.Find((string)dgvDetainLicenses.CurrentRow.Cells[6].Value);
            frmPersonDetails frm = new frmPersonDetails(person.PersonID);
            frm.ShowDialog();
            _RefreshData();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo((int)dgvDetainLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshData();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson person = clsPerson.Find((string)dgvDetainLicenses.CurrentRow.Cells[6].Value);
            frmShowLicenseHistory frm = new frmShowLicenseHistory(person.PersonID);
            frm.ShowDialog();
            _RefreshData();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense((int)dgvDetainLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
            _RefreshData();
        }
    }
}
