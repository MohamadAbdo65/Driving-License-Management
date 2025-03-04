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

namespace DVLD_Manage.ClassApplications.Driving_License_Servises.RenewLicense
{
    public partial class frmRenewDrivingLicense : Form
    {
        int _NewLicenseID = -1;

        public frmRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;

            clsLicense License = clsLicense.Find(LicenseID);

            if (License == null) 
            {
                MessageBox.Show("Error in Load License Info", "DVLD");
                return;
            }

            lblOldLicenseID.Text = License.LicenseID.ToString();

            lblExpirationDate.Text = Convert.ToDateTime(lblIssueDate.Text).AddYears(License.LicenseClassInfo.DefaultValidLenght).ToShortDateString();

            lblLicenseFees.Text = ((int)License.PaidFees).ToString();

            lblTotalFees.Text = (Convert.ToInt32(lblAppFees.Text) + Convert.ToInt32(lblLicenseFees.Text)).ToString();


            // اول شرط ان تكون الرخصة منتهية 1
            if (!License.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expiared, it will expire on: " + License.ExpirationDate
                , "Not allowed", MessageBoxButtons.OK);
                btnRenew.Enabled = false;
                btnShowLicenseHistory.Enabled = true;
                btnShowLicenseInfo.Enabled = false;
                return;
            }

            // منع تجديد اي رخصة في حال وجود رخصة اخرى منتهية - نفس الفئة طبعا - 2
            // يعني اذا عندي رخصة 25 غير نشطة و 26 نشطة فيمنع تجديد ال 25
            int ActiveID = clsLicense.GetActiveLicenseID(License.DriverInfo.PersonID , License.LicenseClassID);
            if (ActiveID != -1)
            {
                MessageBox.Show($"Person already have a active License with id : {ActiveID}" , "Not allowed", MessageBoxButtons.OK);
                btnRenew.Enabled = false;
                btnShowLicenseHistory.Enabled = true;
                btnShowLicenseInfo.Enabled = false;
                return;
            }

            btnRenew.Enabled = true;
        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory
                (usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID);

            frm.Show();
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo
                (_NewLicenseID  );

            frm.Show();
        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblAppFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees.ToString();
            lblCreatedBy.Text = GlobalClass.CurrentUser.Username;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if(!(MessageBox.Show("Are you sure you want to Renew this License ?" , "DVLD - Renew License" , MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }

            clsLicense NewLicense = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.RenewLicense(txtbNotes.Text, GlobalClass.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Error in Renew License", "DVLD");
                return;
            }

            lblRLAppID.Text = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            lblRenewedLicenseID.Text = _NewLicenseID.ToString() ;


            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK);

            btnRenew.Enabled = false;
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
            btnShowLicenseHistory.Enabled = true;
            btnShowLicenseInfo.Enabled = true;
        }
    }
}
