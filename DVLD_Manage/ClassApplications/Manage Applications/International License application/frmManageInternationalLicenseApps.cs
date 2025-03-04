using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Driving_License_Servises.New_Driving_License.International_License;
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

namespace DVLD_Manage.ClassApplications.Manage_Applications.International_License_application
{
    public partial class frmManageInternationalLicenseApps : Form
    {
        public frmManageInternationalLicenseApps()
        {
            InitializeComponent();
        }

        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();

            RefreashData();
        }

        void RefreashData()
        {
            dgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllInternationalLicenses();

            lblCountLicenses.Text = dgvInternationalLicenses.RowCount.ToString();

            if (dgvInternationalLicenses.RowCount > 0 )
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "I.L ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 100;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 100;

                dgvInternationalLicenses.Columns[3].HeaderText = "Local L.ID";
                dgvInternationalLicenses.Columns[3].Width = 100;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 160;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 160;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 100;


            }

        }

        private void frmManageInternationalLicenseApps_Load(object sender, EventArgs e)
        {
            RefreashData();
        }

        private void toolStripMenuItem_ShowPersonInfo_Click(object sender, EventArgs e)
        {
            clsDrivers D = clsDrivers.FindByDriver((int)dgvInternationalLicenses.CurrentRow.Cells[2].Value);

            if (D == null) return;

            frmPersonDetails frm = new frmPersonDetails(D.PersonID);
            frm.ShowDialog();

            RefreashData();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InterLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;

            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(InterLicenseID);
            frm.ShowDialog();

            RefreashData();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDrivers D = clsDrivers.FindByDriver((int)dgvInternationalLicenses.CurrentRow.Cells[2].Value);

            if (D == null) return;

            frmShowLicenseHistory frm = new frmShowLicenseHistory(D.PersonID);
            frm.ShowDialog();

            RefreashData();
        }
    }
}
