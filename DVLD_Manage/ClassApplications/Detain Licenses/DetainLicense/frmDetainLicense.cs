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

namespace DVLD_Manage.ClassApplications.Detain_Licenses.DetainLicense
{
    public partial class frmDetainLicense : Form
    {
        int _LicenseID = -1;
        int _DetainID = -1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }



        private void usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _LicenseID = obj;

            if(!clsLicense.LicenseIsExist(_LicenseID))
            {
                MessageBox.Show("License not found", "DVLD");
                return;
            }

            lblLicenseID.Text = _LicenseID.ToString();

            btnShowLicenseHistory.Enabled = true;
            btnShowLicenseInfo.Enabled = true;  


            // ان تكون الرخصة غير محجوزة اصلا
            if (usctrlDriverlicenseInfoWithFilter1.SelectedLicense.IsDetain)
            {
                MessageBox.Show("This License already Detaine", "DVLD");
                btnDetain.Enabled = false;
                return;
            }

            // ان تكون الرخصة نشطة
            if (!usctrlDriverlicenseInfoWithFilter1.SelectedLicense.IsActive)
            {
                MessageBox.Show("This License is not active", "DVLD");
                btnDetain.Enabled = false;
                return;
            }


            btnDetain.Enabled = true;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = GlobalClass.CurrentUser.Username;
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

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Are you sure you want to Detain this license ?" , "Detain License" , MessageBoxButtons.YesNo))
            {
                return;
            }

            if (string.IsNullOrEmpty(txtbFees.Text))
            {
                MessageBox.Show("Please enter fees amount", "DVLD");
                return;
            }

            _DetainID = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DetainLicense(Convert.ToInt32(txtbFees.Text), GlobalClass.CurrentUser.UserID);

            if(_DetainID == -1)
            {
                MessageBox.Show("Error in save Detain license", "DVLD");
                return;    
            }

            // here Detain completed 

            lblDetainID.Text = _DetainID.ToString();

            MessageBox.Show("Done Detain license", "DVLD");

            btnDetain.Enabled = false;
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
            btnShowLicenseHistory.Enabled = true;
            btnShowLicenseInfo.Enabled = true;
            txtbFees.Enabled = false;

        }
    }
}
