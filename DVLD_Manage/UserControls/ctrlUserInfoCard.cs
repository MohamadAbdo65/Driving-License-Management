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
    public partial class ctrlUserInfoCard : UserControl
    {
        private int _UserID = -1;

        private clsUsers _User;

        public int UserID
        {
            get { return _UserID; }
        }

        public ctrlUserInfoCard()
        {
            InitializeComponent();
        }

        public void ShowUserInfo(clsUsers User)
        {
            _User = User;

            if (_User == null)
            {
                MessageBox.Show("User Not Found", "DVLD");
                return;
            }

            btnEditUserInfo.Enabled = true; 
            usctrlInfoCard1.LoadPersonInfo(_User.PersonID);

            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.Username;
            lblIsActive.Text = (_User.IsActive) ? "Yes" : "No";

        }

        private void btnEditUserInfo_Click(object sender, EventArgs e)
        {
            Add_Update_User add_Update = new Add_Update_User(_User.UserID);

            add_Update.ShowDialog();

            _User = clsUsers.GetUser(_User.UserID);

            ShowUserInfo(_User);
        }

        private void usctrlInfoCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
