using DVLD_BusinussLayer;
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

namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication
{
    public partial class frmShowLicenseHistory : Form
    {
        int _PersonID;

        public frmShowLicenseHistory(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        void _LoadLocalLicenseInfo(int DriverID)
        {
            dgvLocalLicense.DataSource = clsLicense.GetAllLicenseForDriver(DriverID);
        }
        void _LoadInternationalLicenseInfo(int DriverID)
        {
            dgvInternationalLicenses.DataSource = clsInternationalLicense.GetAllInterLicensesForDriver(DriverID);
        }

      

        private void frmShowLicenseHistory_Load(object sender, EventArgs e)
        {
            usctrlInfoCard1.LoadPersonInfo(_PersonID);

            clsDrivers driver = clsDrivers.FindByPerson(_PersonID);

            if (driver != null) 
            {
                _LoadLocalLicenseInfo(driver.DriverID);
                _LoadInternationalLicenseInfo(driver.DriverID);
            }
            else
            {
                MessageBox.Show("Driver Not found");
                this.Close();
                return;
            }
        }

        private void showLiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo((int)dgvLocalLicense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
