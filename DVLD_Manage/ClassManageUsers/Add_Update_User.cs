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
    public partial class Add_Update_User : Form
    {
        enum enMode { add , update}

        private enMode _Mode;


        private clsUsers _User ;

        private int _UserID ;   


        public Add_Update_User()
        {
            InitializeComponent();

            _Mode = enMode.add;
        }

        public Add_Update_User(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            _Mode = enMode.update;
            this.Text = "Edit User Info";
        }

        //*-*-*-*

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbctAddNewUser.SelectedIndex = 1;
            btnNext.Enabled = false;
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tbctAddNewUser.SelectedIndex = 0;
            btnNext.Enabled = true;
            btnBack.Enabled = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbUsername.Text == string.Empty || txtbPassword.Text == string.Empty || txtbUsername.Text == string.Empty)
            {
                MessageBox.Show("Some value Missing !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_User.Username != txtbUsername.Text)
                {
                    if (clsUsers.UserIsExist(txtbUsername.Text))
                    {
                        MessageBox.Show("This Username is Used");
                        return;
                    }
                }

                if (MessageBox.Show("Are you sure you want save this informetion ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtbPassword.Text == txtbConfirm.Text)
                    {
                        _User.Password = txtbPassword.Text.ToString();
                    }
                    else { MessageBox.Show("Password not Match !"); return; }

                    _User.PersonID = usctrlInfoCardWithFind1.PersonID;
                    _User.Username = txtbUsername.Text;
                    _User.IsActive = (chbIsActive.Checked) ? true : false;

                    if (_User.Save())
                    {
                        _Mode = enMode.update;
                        lblTitle.Text = "Update User Info";
                        lblUserID.Text = _User.UserID.ToString();

                        usctrlInfoCardWithFind1.ShowGrpbxFind = false;

                        MessageBox.Show("Data Saved succesfully.");

                        // DataBack?.Invoke(this,);

                    }
                    else
                    {
                        MessageBox.Show("Error 705.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        //*-*-*-*

        private void _LoadData()
        {
            if (_Mode == enMode.add)
            {
                _User = new clsUsers();
                lblTitle.Text = "Add New User";
                return;
            }

            _User = clsUsers.GetUser(_UserID);
            lblTitle.Text = "Update User Info";

            txtbPassword.Enabled = false;
            txtbConfirm.Enabled = false;

            if (_User == null)
            {
                MessageBox.Show("Error 501 !", "");
                this.Close();
                return;
            }

            usctrlInfoCardWithFind1.CardInfo.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtbUsername.Text = _User.Username;
            txtbPassword.Text = _User.Password;
            txtbConfirm.Text = _User.Password;
            chbIsActive.Checked = _User.IsActive;
            usctrlInfoCardWithFind1.ShowGrpbxFind = false;
            btnSave.Enabled = true;
        }

        private void Add_Update_User_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void usctrlInfoCardWithFind1_OnPersonSelected(int obj)
        {
            _User.PersonID = obj;
            btnSave.Enabled = true;
        }

        private void tbctAddNewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbctAddNewUser.SelectedIndex == 0)
                return;

            if (_Mode == enMode.update)
                return;

            if (usctrlInfoCardWithFind1.PersonID != -1)
            {
                if (clsUsers.UserExistByPersonID(usctrlInfoCardWithFind1.PersonID))
                {
                    if (MessageBox.Show("This Person Is Used , Choose anothor Person.", "DVLD", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        tbctAddNewUser.SelectedIndex = 0;
                        usctrlInfoCardWithFind1.TextFindBox = string.Empty;
                        usctrlInfoCardWithFind1.SetDefaultCard();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }

        }

        private void txtbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (clsUsers.UserIsExist( txtbUsername.Text))
            {
                e.Cancel = true;
                txtbUsername.Focus();
                errorProvider1.SetError(txtbUsername, "this Username is Used");

            }
        }
    }
}
