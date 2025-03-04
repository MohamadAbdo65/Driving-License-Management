using DVLD_BusinussLayer;
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
    public partial class frmIssueDrivingLicense : Form
    {
        int _LDLAppID;
        clsLocalDrivingLicenseApplication _LDLApp;

        public frmIssueDrivingLicense(int LDLAppID)
        {
            InitializeComponent();
            _LDLAppID = LDLAppID;
        }

        private void frmIssueDrivingLicense_Load(object sender, EventArgs e)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);

            if (_LDLApp == null) 
            {
                MessageBox.Show("No Applicaiton with ID=" + _LDLAppID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return; 
            }

            if(!_LDLApp.IsPassAllTest())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LDLApp.GetActiveLicenseID();
            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            usctrlLDLApp_BaseApp_Info1.ShowApplicationInfo(_LDLAppID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = _LDLApp.IssueLicenseForTheFistTime(txtbNote.Text, GlobalClass.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("Done Save Seccessfully", "DVLD Issue license");
                this.Close();              
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
