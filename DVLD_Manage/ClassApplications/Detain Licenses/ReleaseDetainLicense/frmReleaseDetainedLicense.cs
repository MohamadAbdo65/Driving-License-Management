using DVLD_BusinussLayer;
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

namespace DVLD_Manage.ClassApplications.Detain_Licenses.ReleaseDetainLicense
{
    public partial class frmReleaseDetainedLicense : Form
    {
        int _LicenseID;
        //int _DetainID;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
            usctrlDriverlicenseInfoWithFilter1.LoadLicenseInfo(LicenseID);
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            lblCreatedBy.Text = GlobalClass.CurrentUser.Username;
            lblAppFess.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.ReleaseDetainDrivingLicense).Fees.ToString();
        }

        private void usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            if (!clsLicense.LicenseIsExist(_LicenseID))
            {

                return;
            }

            lblLicenseID.Text = _LicenseID.ToString();

            btnShowLicenseHistory.Enabled = true;
            btnShowLicenseInfo.Enabled = true;

            // ان تكون محجوزة
            if (!usctrlDriverlicenseInfoWithFilter1.SelectedLicense.IsDetain)
            {
                MessageBox.Show("This license is not Detained", "DVLD");
                return;
            }

            clsDetainLicense DL = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DetainLicenseInfo;

            lblAppFess.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.ReleaseDetainDrivingLicense).Fees.ToString();

            lblDetainID.Text = DL.DetainID.ToString();
            lblDetainDate.Text = DL.DetainDate.ToShortDateString();
            lblFineFees.Text = DL.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToInt32(lblAppFess.Text) + Convert.ToInt32(lblFineFees.Text)).ToString();

            btnRelease.Enabled = true;            
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to release this detained  license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int AppID = -1;

            bool IsReleased = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.ReleaseDetainLicense(GlobalClass.CurrentUser.UserID, ref AppID);

            if (!IsReleased)
            {
                MessageBox.Show("Error in Release detain", "DVLD");
                return;
            }

            // here done Release

            lblAppID.Text = AppID.ToString();

            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            btnShowLicenseHistory.Enabled = true;
            btnShowLicenseInfo.Enabled = true;
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
        }
    }
}
