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
    public partial class frmPersonDetails : Form
    {
        private string _NationalNO;

        private int _PersonID;

        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
        }

        public frmPersonDetails(string NationalNO)
        {
            InitializeComponent();

            _NationalNO = NationalNO;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            usctrlInfoCard1.LoadPersonInfo(_PersonID);
        }
    }
}
