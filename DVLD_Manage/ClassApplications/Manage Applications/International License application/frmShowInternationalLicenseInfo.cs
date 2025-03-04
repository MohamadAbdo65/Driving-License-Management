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

namespace DVLD_Manage.ClassApplications.Manage_Applications.International_License_application
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        int _InternationalLicenseID;
        public frmShowInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            if (!clsInternationalLicense.IsInterLicenseExist(_InternationalLicenseID))
            {
                MessageBox.Show($"International license with ID = {_InternationalLicenseID} not found", "DVLD");
                return;
            }

            usctrlDriverIntrernationalLicenseInfo1.LoadInterLicenseInfo(_InternationalLicenseID);

        }
    }
}
