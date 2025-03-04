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
    public partial class frmShowApplicationInfo : Form
    {
        private int _LDLApplicationID = -1;

        public frmShowApplicationInfo(int LDLApplicatoinID)
        {
            InitializeComponent();

            _LDLApplicationID = LDLApplicatoinID;
        }

        private void frmShowApplicationInfo_Load(object sender, EventArgs e)
        {
            usctrlLDLApp_BaseApp_Info1.ShowApplicationInfo(_LDLApplicationID);
        }
    }
}
