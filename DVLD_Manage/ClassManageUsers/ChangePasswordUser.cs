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
    public partial class ChangePasswordUser : Form
    {
        private int _UserID;

        private clsUsers _User;

        public ChangePasswordUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
        }   

        private void _ResetDefaultValue()
        {
            txtbConfirm.Text = string.Empty;
            txtbCurrent.Text = string.Empty;
            txtbNew.Text = string.Empty;
            txtbCurrent.Focus();
        }

        private void ChangePasswordUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            _User = clsUsers.GetUser(_UserID);

            if (_User != null)
            {
                ctrlUserInfoCard1.ShowUserInfo(_User);
            }
            else
            {
                MessageBox.Show("User Not Found.", "DVLD", MessageBoxButtons.OK);
                this.Close();
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbCurrent_Validating(object sender, CancelEventArgs e)
        {
            if(txtbCurrent.Text != _User.Password.ToString())
            {
                e.Cancel = true;
                txtbCurrent.Focus();
                errorProvider1.SetError(txtbCurrent, "the Current password is not correct");
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtbNew.Text != string.Empty || txtbConfirm.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to save new password", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(txtbNew.Text == txtbConfirm.Text)
                    {
                        _User.Password = txtbNew.Text;

                        if(_User.Save())
                        {
                            MessageBox.Show("Done save succesfully");
                        }
                        else
                        {
                            MessageBox.Show("Error in save new password");
                        }

                    }
                    else
                    {
                        MessageBox.Show("the password is not match");
                    }
                }
            }
            else
            {
                MessageBox.Show("Some value are missing !");
            }
        }
    }
}
