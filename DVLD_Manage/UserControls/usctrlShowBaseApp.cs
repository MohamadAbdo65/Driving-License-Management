using DVLD_BusinussLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage
{
    public partial class usctrlShowBaseApp : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApp;

        public clsLocalDrivingLicenseApplication LDLApp
        {
            get { return _LDLApp; }
        }
        public usctrlShowBaseApp()
        {
            InitializeComponent();
        }

        public void SetDefault()
        {
            lblApplicationID.Text = "";
            lblStatus.Text = "";
            lblFees.Text = "";
            lblType.Text = "";
            lblApplicant.Text = "";
            lblDate.Text = "";
            lblStatusDate.Text = "";
            lblCreatedBy.Text = "";
        }

        public void LoadLDLAppInfo(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (_LDLApp == null) { return; }

            lblApplicationID.Text = _LDLApp.ApplicationID.ToString();
            lblStatus.Text = _LDLApp.StatusText;
            lblFees.Text = _LDLApp.PaidFees.ToString();
            lblType.Text = clsApplicationsType.GetApplicationType(_LDLApp.ApplicationTypeID).Title.ToString();
            lblApplicant.Text = _LDLApp.ApplicantFullName;
            lblDate.Text = _LDLApp.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _LDLApp.LastUpdateStatus.ToShortDateString();
            lblCreatedBy.Text = clsUsers.GetUser(_LDLApp.CreateByUserID).Username;

        }

        private void btnEditUserInfo_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(_LDLApp.ApplicantPersonID);
            frm.ShowDialog();

            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLApp.LDLAppID);

            LoadLDLAppInfo(_LDLApp.LDLAppID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void usctrlShowLDLApp_Load(object sender, EventArgs e)
        {

        }
    }
}
