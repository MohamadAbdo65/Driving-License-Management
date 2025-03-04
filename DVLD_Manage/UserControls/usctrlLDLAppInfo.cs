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

namespace DVLD_Manage
{
    public partial class usctrlLDLAppInfo : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApp;

        public clsLocalDrivingLicenseApplication LDLApp
        {
            get { return _LDLApp; }
        }

        public usctrlLDLAppInfo()
        {
            InitializeComponent();
        }

        private void btnViewLicenseInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon !");
        }

        public void SetDefault()
        {
            lblDLAppID.Text = "?";
            lblLicenseClass.Text = "?";
            lblPassedTest.Text = "?";
        }

        public void ShowApplicationInfo(int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (_LDLApp == null) { return; }

            lblDLAppID.Text = _LDLApp.LDLAppID.ToString();
            lblLicenseClass.Text = _LDLApp.licenseClassInfo.ClassName;
            lblPassedTest.Text = clsTest.GetCountOfPassedTest(LDLAppID).ToString();
        }

    }
}
