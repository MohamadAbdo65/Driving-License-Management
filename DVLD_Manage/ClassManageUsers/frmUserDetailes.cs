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
    public partial class frmUserDetailes : Form
    {
        private int _UserID;

       
        public frmUserDetailes(int UserID)
        {
            InitializeComponent();
        
            _UserID = UserID;
        }

        private void frmUserDetailes_Load(object sender, EventArgs e)
        {           
            ctrlUserInfoCard1.ShowUserInfo(clsUsers.GetUser(_UserID)) ;
        }
    }
}
