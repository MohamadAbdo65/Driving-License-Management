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
    public partial class frmAdd_UpdateLocalLicenseApplication : Form
    {
        private enum enMode { Add, Update }

        enMode _Mode;

        private int _LDLAppID;

        private clsLocalDrivingLicenseApplication _LDLApp;

        private int _SelectedPersonID;

        //*-*-*

        public frmAdd_UpdateLocalLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }

        public frmAdd_UpdateLocalLicenseApplication(int LDLAppID)
        {
            InitializeComponent();

            _LDLAppID = LDLAppID;
            _Mode = enMode.Update;
            this.Text = "Update Local Driving License Application";
        }

        private void _FillComboBoxLicenseClass()
        {
            DataTable dataTable = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow T in dataTable.Rows)
            {
                cmbbLicenseClass.Items.Add(T["ClassName"]);
            }
        }

        private void _LoadData()
        {
            _FillComboBoxLicenseClass();


            if (_Mode == enMode.Add)
            {
                lblAppDate.Text = DateTime.Now.ToString();
                lblAppFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.NewDrivingLicense).Fees.ToString();
                lblCreatedBy.Text = GlobalClass.CurrentUser.Username.ToString();

                lblTitle.Text = "Add local driving license Application";
                _LDLApp = new clsLocalDrivingLicenseApplication();
                return;
            }

            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_LDLAppID);
            lblTitle.Text = "Update local driving license Application";
            usctrlInfoCardWithFind1.ShowGrpbxFind = false;

            if (_LDLApp == null)
            {
                MessageBox.Show("Error in Find Application");
                this.Close();
                return;
            }

            usctrlInfoCardWithFind1.LoadPersonInfo(_LDLApp.ApplicantPersonID);

            lblAppID.Text = _LDLApp.LDLAppID.ToString();
            lblAppDate.Text = _LDLApp.ApplicationDate.ToString();
            cmbbLicenseClass.SelectedIndex = _LDLApp.LicenseClassID ;
            lblAppFees.Text = _LDLApp.PaidFees.ToString();
            lblCreatedBy.Text = _LDLApp.ApplicationInfo.CreateByUserInfo.Username.ToString();


            btnSave.Enabled = true;
        }

        private void frmLocalLicense_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void cmbbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;

            if (cmbbLicenseClass.SelectedIndex > 0)
                btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // cheak to select person 
            if (!usctrlInfoCardWithFind1.HasPersonInfo)
            {
                MessageBox.Show("Please select person to complete the Application");
                return;            
            }

            // are you sure to save ?
            if (MessageBox.Show("Are you sure you want to save ?" , "" , MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            int ApplicantPersonID = usctrlInfoCardWithFind1.PersonID;
            int LicenseClassID = clsLicenseClass.Find(cmbbLicenseClass.SelectedIndex).LicenseClassID;
            int ActiveApplicationID = clsApplication.GetActiveApplicationTypeIDForLicense(ApplicantPersonID, clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            // cheak if is has application same license class
            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class , the selected person already have a application" , "DVLD");
                return;
            }

            // cheak if is has License same class
            if (clsLicense.IsLicenseExistByPersonID(usctrlInfoCardWithFind1.PersonID , LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving license class");
                return;
            }
                        
            _LDLApp.ApplicantPersonID = ApplicantPersonID;
            _LDLApp.ApplicationDate = DateTime.Now;
            _LDLApp.ApplicationTypeID = (int)clsApplication.enApplicationType.NewDrivingLicense;
            _LDLApp.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LDLApp.LastUpdateStatus = DateTime.Now;
            _LDLApp.PaidFees = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.NewDrivingLicense).Fees;
            _LDLApp.CreateByUserID = GlobalClass.CurrentUser.UserID;            
            _LDLApp.LicenseClassID = LicenseClassID;


            if (_LDLApp.Save())
            {  
                _Mode = enMode.Update;
                lblAppID.Text = _LDLApp.LDLAppID.ToString();
                lblTitle.Text = "Update local driving license Application";
                MessageBox.Show("Saved done succesfully");
            }
            else
            {
                MessageBox.Show("Error in Save , try again");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usctrlInfoCardWithFind1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;    
        }
    }
}
