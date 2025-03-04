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
    public partial class usctrlLDLApp_BaseApp_Info : UserControl
    {
        private clsLocalDrivingLicenseApplication _LDLApp;

        private int _LDLAppID = -1;



        public int LDLAppID 
            {
            get {  return _LDLAppID; }
            }

        public usctrlLDLApp_BaseApp_Info()
        {
            InitializeComponent();
        }
             
        public void ShowApplicationInfo (int LDLAppID)
        {
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (_LDLApp == null) { return; }
        
            _LDLAppID = LDLAppID;

            usctrlLDLAppInfo1.ShowApplicationInfo(_LDLAppID);
            usctrlShowBaseApp1.LoadLDLAppInfo(_LDLAppID);

        }

        private void usctrlLDLApp_BaseApp_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
