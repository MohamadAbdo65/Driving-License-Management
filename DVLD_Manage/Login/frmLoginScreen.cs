using DVLD_BusinussLayer;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using DVLDLogger;

namespace DVLD_Manage
{
    public partial class frmLoginScreen : Form
    {
        //user8
        //010

        /// <summary>
        /// This class for get Registry Information for Get/Set User Info
        /// </summary>
        private static class clsRegistryInfo
        {
            /// <summary>
            /// This property to get Sub Key path
            /// </summary>
            public static string KeyPathLoginInfo 
            {
                get { return @"HKEY_CURRENT_USER\SOFTWARE\DVLDManager"; } 
            }

            /// <summary>
            /// This property gets the name of the column in which the Username is stored
            /// </summary>
            public static string ColumnName_UserName
            {
                get { return @"Username"; }
            }

            /// <summary>
            /// This property gets the name of the column in which the Password is stored
            /// </summary>
            public static string ColumnName_Password
            {
                get { return @"Password"; }
            }

        }

        private clsUsers _User;        
        public clsUsers User
        {
            get { return _User; }
        }


        public frmLoginScreen()
        {
            InitializeComponent();
        }


        private bool Hide_Show = false;
        private void btnHideShowPass_Click(object sender, EventArgs e)
        {
            Hide_Show = (Hide_Show == false) ? true : false;

            if(Hide_Show)
            {
                txtbPassword.PasswordChar = '\0';
            }
            else
            {
                txtbPassword.PasswordChar = '*';
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact the Administrator", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void _StoreLoginInfo(string Username , string Password)
        {
            try
            {
                // for store username                 
                Registry.SetValue(clsRegistryInfo.KeyPathLoginInfo,
                clsRegistryInfo.ColumnName_UserName, Username);

                // for store password
                Registry.SetValue(clsRegistryInfo.KeyPathLoginInfo,
                    clsRegistryInfo.ColumnName_Password, Password);
            }
            catch (Exception ex)
            {
                clsLogger.AddLog(clsLogger.enErrorLocation.ErrorInPresentation, ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }            }

            private void _CleanFile()
        {
         


            Registry.SetValue(clsRegistryInfo.KeyPathLoginInfo, clsRegistryInfo.ColumnName_UserName, "");
            Registry.SetValue(clsRegistryInfo.KeyPathLoginInfo, clsRegistryInfo.ColumnName_Password, "");


        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbUsername.Text.ToString()))
            {  
                txtbUsername.Focus();
                errorProvider1.SetError(txtbUsername, "This value is incomplete");
                return;
            }
            if (string.IsNullOrEmpty(txtbPassword.Text.ToString()))
            {
                txtbPassword.Focus();
                errorProvider1.SetError(txtbPassword, "This value is incomplete");
                return;
            }

            _User = clsUsers.GetUser(txtbUsername.Text.ToString());

            if (_User != null)
            {
                if (_User.Password != txtbPassword.Text.ToString())
                {
                    MessageBox.Show("The password is incorrect, try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   
                

                if(chkbRememberMe.Checked)
                {
                    _StoreLoginInfo(_User.Username , _User.Password);
                }
                else
                {
                    _CleanFile();
                    txtbPassword.Text = string.Empty;
                    txtbUsername.Text = string.Empty;  
                }


                if (!_User.IsActive)
                {
                    txtbUsername.Focus();
                    MessageBox.Show("This account not active , please contact your admin.", "DVLD");
                    return;
                }

                GlobalClass.CurrentUser = _User;
                this.Hide();

                Form MainForm = new MainForm(this);
                MainForm.ShowDialog();

                

                return;
            }
            else
            {
                MessageBox.Show("Username or password is incorrect, try again" , "", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string Username = "";
            string Password = "";

            try
            { 
                 Username = Registry.GetValue(clsRegistryInfo.KeyPathLoginInfo,
                clsRegistryInfo.ColumnName_UserName, null) as string;

                 Password = Registry.GetValue(clsRegistryInfo.KeyPathLoginInfo,
                    clsRegistryInfo.ColumnName_Password, null) as string;
            }
            catch (Exception ex) { clsLogger.AddLog(clsLogger.enErrorLocation.ErrorInPresentation, ex.Message, System.Diagnostics.EventLogEntryType.Error); }

            if (Username == null || Password == null)
            {
                txtbUsername.Text = "";
                txtbPassword.Text = "";
            }

            txtbUsername.Text = Username;
            txtbPassword.Text = Password;

        }
    }
}
