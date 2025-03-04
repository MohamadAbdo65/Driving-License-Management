using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Manage_Applications.International_License_application;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.ClassApplications.Driving_License_Servises.New_Driving_License.International_License
{
    public partial class frmNewInternationalLicense : Form
    {
        int _InternationalLicenseID;

        public frmNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            clsLicense LocalLicense = clsLicense.Find(SelectedLicenseID);

            if (LocalLicense == null) return;

            btnShowLicenseHistory.Enabled = true;

            lblLocalLicenseID.Text = SelectedLicenseID.ToString();



            // cheak if Local license = class 3
            int LicenseClass = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.LicenseClassID;
            if (LicenseClass != 3)
            {
                MessageBox.Show($"The license must be a Class 3 , Class of selected license : {LicenseClass}", "DVLD");
                usctrlDriverlicenseInfoWithFilter1.FocusOnTextBoxSearsh();
                btnIssue.Enabled = false;
                return ;
            }
            
            if (LocalLicense.IsLicenseExpired())
            {               
                MessageBox.Show($"This license has expired from {  (DateTime.Now - LocalLicense.ExpirationDate).Days } Day(s), please choose another license", "DVLD");
                return;
            }

            int ActiveLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverID);

            if (ActiveLicenseID != -1)
            {

                _InternationalLicenseID = ActiveLicenseID;

                if (MessageBox.Show($"Person already have a active international license with ID : {ActiveLicenseID} " +
                    $", Do you want to Show License Information ?", "DVLD" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) 
                    == DialogResult.Yes)
                {
                    frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
                    frm.ShowDialog();
                }
                

                btnShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;
        }

        private void frmNewInternationalLicense_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = DateTime.Now.ToShortDateString(); 
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.NewInternationalLicense).Fees.ToString();
            lblCreatedBy.Text = GlobalClass.CurrentUser.Username;
        
        }


        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory 
                frm = new frmShowLicenseHistory(usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID);
        
            frm .ShowDialog();
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            if (_InternationalLicenseID == -1)
                return;

            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
            frm .ShowDialog();  
        }


        private void btnIssue_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to issue ?"
                , "DVLD" , MessageBoxButtons.YesNo ,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsApplication application = new clsApplication();

            application.ApplicantPersonID = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
            application.LastUpdateStatus = DateTime.Now;
            application.PaidFees = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.NewInternationalLicense).Fees;
            application.CreateByUserID = GlobalClass.CurrentUser.UserID;

            if (!application.Save())
            {
                MessageBox.Show("Error in save Application", "DVLD");
                return;
            }

            clsInternationalLicense InterLicense = new clsInternationalLicense();

            InterLicense.ApplicationID = application.ApplicationID;
            InterLicense.DriverID = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverID;
            InterLicense.LocalLicensID = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.LicenseID;
            InterLicense.IssueDate = DateTime.Now;
            InterLicense.ExpirationDate = DateTime.Now.AddYears(1);
            InterLicense.IsActive = true;
            InterLicense.CreatedByUserID = GlobalClass.CurrentUser.UserID;


            if(!InterLicense.Save())
            {
                MessageBox.Show("Error in save International License", "DVLD");
                return;
            }

            lblInterLicenseID.Text = InterLicense.InterLicenseID.ToString();
            lblIinterLicenseAppID.Text = application.ApplicationID.ToString();
            _InternationalLicenseID = InterLicense.InterLicenseID;

            MessageBox.Show("International License Issued Successfully", "DVLD");

            btnIssue.Enabled = false;
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
            btnShowLicenseInfo.Enabled = true;
        }
    }
}
