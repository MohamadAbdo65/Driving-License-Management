using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Detain_Licenses.DetainLicense;
using DVLD_Manage.ClassApplications.Detain_Licenses.ManageDetainedLicenses;
using DVLD_Manage.ClassApplications.Detain_Licenses.ReleaseDetainLicense;
using DVLD_Manage.ClassApplications.Driving_License_Servises.New_Driving_License.International_License;
using DVLD_Manage.ClassApplications.Driving_License_Servises.RenewLicense;
using DVLD_Manage.ClassApplications.Driving_License_Servises.ReplacementLostOrDamageLicense;
using DVLD_Manage.ClassApplications.Manage_Applications.International_License_application;
using DVLD_Manage.ClassManageDrivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage
{
    public partial class MainForm : Form
    {
       // private clsUsers _CurrentUser;

        frmLoginScreen _frmLoginScreen;

        public MainForm(frmLoginScreen LS)
        {
            InitializeComponent();

            _frmLoginScreen = LS;
        }

        void _LoadDashbordData()
        {
            
            //*- Panel - International
            lblNumberOfInternationalLicense.Text = clsInternationalLicense.GetAllInternationalLicenses().Rows.Count.ToString();


            //*- Panel - Drivers
            lblNumberOfDrivers.Text = clsDrivers.GetAllDrivers().Rows.Count.ToString();


            //*- Panel - Detain License
            DataTable DetainLicense = clsDetainLicense.GetAllDetainLicenses();
            lblNumberOfDetainLicense.Text = DetainLicense.Rows.Count.ToString();

            if (DetainLicense.Rows.Count > 0)
            { 
            DataView view = new DataView(DetainLicense);
            view.RowFilter = " IsReleased = 1";
            lblNumberOfRealesedLicense.Text = view.Count.ToString() + " Released"; }


            //*- Panel - Application
            DataTable Applications = clsApplication.GetAllApplications();
            lblNumberOfApplication.Text = Applications.Rows.Count.ToString();

            if(Applications.Rows.Count > 0)
            {
                DataView view1 = new DataView(Applications);
                view1.RowFilter = " ApplicationStatus = 1";
                lblNumberOfNewApplication.Text = view1.Count.ToString() + " New";
            }


            //*- Panel - Licenses
            DataTable Licenses = clsLicense.GetAllLicense();
            lblNumberOfLicense.Text = Licenses.Rows.Count.ToString();

            if (Licenses.Rows.Count > 0)
            {
                DataView view2 = new DataView(Licenses);
                view2.RowFilter = " IsActive = 1";
                lblNumberOfActiveLicense.Text = view2.Count.ToString() + " Active";
            }


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _LoadDashbordData();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();  
            _frmLoginScreen.Close();
        }

        // class manage people
         
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form ManagePeopleForm = new ManagePeople();

            ManagePeopleForm.ShowDialog();
            _LoadDashbordData();
        }

        // class manage users
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
              Form ManageUsersForm = new ManageUsers();
            ManageUsersForm.ShowDialog();
            _LoadDashbordData();
        }

        // class Account Settings
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalClass.CurrentUser = null;
            this.Hide();

            _frmLoginScreen.Show();

        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetailes userDetailes = new frmUserDetailes(GlobalClass.CurrentUser.UserID);

            userDetailes.ShowDialog();
            _LoadDashbordData();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordUser changePassword = new ChangePasswordUser(GlobalClass.CurrentUser.UserID);

            changePassword.ShowDialog();
            _LoadDashbordData();
        }


        // class applications
        private void manageApplicationsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplicationsType frm = new frmManageApplicationsType();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void manageTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestsType frm = new frmManageTestsType();

            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void localLinceceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateLocalLicenseApplication frm = new frmAdd_UpdateLocalLicenseApplication();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void loacalDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplication ManageLDLApp = new frmManageLocalDrivingLicenseApplication();

            ManageLDLApp.ShowDialog();
            _LoadDashbordData();
        }

        private void CloseApp(bool WithoutMessage = false)
        {
            if (!WithoutMessage)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to Exit ?", "DVLD Manager",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    Application.Exit();
                }
            }
            else { this.CloseApp(); }
        }
        private void MinimizeForm()
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void MaximizeForm()
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                CloseApp(true);
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimizeForm();
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaximizeForm();
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageLocalDrivingLicenseApplication frm = new frmManageLocalDrivingLicenseApplication();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm = new frmManageDrivers();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicenseApps frm = new frmManageInternationalLicenseApps();    
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void renewDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDrivingLicense frm = new frmRenewDrivingLicense();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void replacementForLostOrDamageLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostDamageLicense frm = new frmReplaceLostDamageLicense();

            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void relToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicense frm = new frmManageDetainedLicense();  
            frm.ShowDialog();
            _LoadDashbordData();
        }

        private void releaseDetainDrivingLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _LoadDashbordData();

        }


    }
}
