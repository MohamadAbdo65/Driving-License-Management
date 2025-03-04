using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.ClassManageDrivers
{
    public partial class frmShowDriverLicenseInfo : Form
    {
        int _LicenseID;

        public frmShowDriverLicenseInfo(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void frmShowDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            usctrlDriverLicenseInfo1.LoadLicenseInfo(_LicenseID);
        }
    }
}
