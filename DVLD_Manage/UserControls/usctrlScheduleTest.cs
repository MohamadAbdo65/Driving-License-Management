using DVLD_BusinussLayer;
using DVLD_Manage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.UserControls
{
    public partial class usctrlScheduleTest : UserControl
    {
        enum enMode { Add , Update }
        enum enCreationMode { FirstTimeSchedule, RetakeTestSchedule }

        enMode _Mode = enMode.Add;
        enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        clsLocalDrivingLicenseApplication _LDLApp;
        int _LDLAppID = -1;

        clsTestAppointment _TestAppointment;
        int _TestAppointmentID = -1;

        public clsTestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                if (clsTestType.enTestType.VisionTest == _TestTypeID)
                {
                    lblTestType.Text = "Schedule Vision Test";
                    picbTestTypePic.Image = Resources.Vision_Test;
                }
                else if (clsTestType.enTestType.WrittenTest == _TestTypeID)
                {
                    lblTestType.Text = "Schedule Written Test";
                    picbTestTypePic.Image = Resources.Written_Test;
                }
                else if (clsTestType.enTestType.StreetTest == _TestTypeID)
                {
                    lblTestType.Text = "Schedule Practical Test";
                    picbTestTypePic.Image = Resources.Practical_Test;
                }
            }
        }


        public usctrlScheduleTest()
        {
            InitializeComponent();
        }


        bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.GetTestAppointment(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show($"Test Appointment By ID : {_TestAppointmentID} Not founf", "DVLD");
                btnSave.Enabled = false;
                return false;
            }

            lblFees.Text = _TestAppointment.PaidFees.ToString();
            dtpAppointmentDate.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1)
            {
                lblRetakeAppFees.Text = "0";
            }
            else
            {
                lblRetakeAppFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                gbRetakeTestInfo.Enabled = true;
                //lblTestType.Text = "Schedule Retake Test";
            }

            return true;
        }
        bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.Add && clsLocalDrivingLicenseApplication.IsThereActiveScheduledTest
                (_LDLAppID , (int)TestTypeID))
            {
                lblUserMassege.Visible = true;
                lblUserMassege.Text = "Person already have a active Schedule for this Test";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return false ;
            }
            return true;
        }
        bool _HandleAppointmentLockedConstraint()
        {
            if (_TestAppointment.IsLocked)
            {
                lblUserMassege.Visible = true;
                lblUserMassege.Text = "Person already sat for the test, appointment loacked";
                dtpAppointmentDate.Enabled = false;
                btnSave.Enabled = false;
                return false;
            }
            else
                lblUserMassege.Visible = false;

            return true;
        }
        private bool _HandlePrviousTestConstraint()
        {
            //we need to make sure that this person passed the prvious required test before apply to the new test.
            //person cannno apply for written test unless s/he passes the vision test.
            //person cannot apply for street test unless s/he passes the written test.

            switch (TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    lblUserMassege.Visible = false;

                    return true;

                case clsTestType.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.
                    if (!_LDLApp.DoesPassTestType((int)clsTestType.enTestType.VisionTest))
                    {
                        lblUserMassege.Text = "Cannot Sechule, Vision Test should be passed first";
                        lblUserMassege.Visible = true;
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMassege.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                    }


                    return true;

                case clsTestType.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    if (!_LDLApp.DoesPassTestType((int)clsTestType.enTestType.WrittenTest))
                    {
                        lblUserMassege.Text = "Cannot Sechule, Written Test should be passed first";
                        lblUserMassege.Visible = true;
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblUserMassege.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                    }


                    return true;

            }
            return true;

        }

        public void LoadInfo(int LDLAppID , int AppointmentID = -1)
        {
            // select Add or Update Mode By Test Appointment ID :
            if (AppointmentID == -1)
                _Mode = enMode.Add;
            else
                _Mode = enMode.Update;


            _LDLAppID = LDLAppID;
            _TestAppointmentID = AppointmentID;
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (_LDLApp == null)
            {
                MessageBox.Show($"Local Driving License App By ID : {LDLAppID} Not found !", "DVLD");
                btnSave.Enabled = false;
                return;
            }


            // Select creation mode
            if (_LDLApp.DoesAttendTest((int)_TestTypeID))
                _CreationMode = enCreationMode.RetakeTestSchedule;
            else 
                _CreationMode = enCreationMode.FirstTimeSchedule;


            if (enCreationMode.RetakeTestSchedule == _CreationMode)
            {
                lblRetakeAppFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.RetakeTest).Fees.ToString();
                gbRetakeTestInfo.Enabled = true;
                //lblTestType.Text = "";
            }
            else if (enCreationMode.FirstTimeSchedule == _CreationMode)
            {
                lblRetakeAppFees.Text = "0";
                gbRetakeTestInfo.Enabled = false;
                //lblTestType.Text = "";
            }

            lblDLAppID.Text = _LDLApp.LDLAppID.ToString();
            lblLClass.Text = _LDLApp.licenseClassInfo.ClassName;
            lblName.Text = _LDLApp.ApplicantFullName;
            lblTrial.Text = _LDLApp.TotalTrialPerTest((int)TestTypeID).ToString();


            if (_Mode == enMode.Add)
            {
                lblFees.Text = clsTestType.GetTestType(_TestTypeID).Fees.ToString();
                dtpAppointmentDate.Value = DateTime.Now;

                _TestAppointment = new clsTestAppointment();
            }
            else if (_Mode == enMode.Update)
            {
                if (!_LoadTestAppointmentData()) return;
            }

            string TF = (Convert.ToInt32(Convert.ToDecimal(lblFees.Text)) + Convert.ToInt32(lblRetakeAppFees.Text)).ToString();
            lblTotalFees.Text = TF;


            if (!_HandleActiveTestAppointmentConstraint())
                return;
            if (!_HandleAppointmentLockedConstraint())
                return;
            if (!_HandlePrviousTestConstraint())
                return;

        }

        //*-*-*-*

        bool _HandleRetakeApplication()
        {
            if (enMode.Add == _Mode && enCreationMode.RetakeTestSchedule == _CreationMode)
            {

                clsApplication R_App = new clsApplication();

                R_App.ApplicantPersonID = _LDLApp.ApplicantPersonID;
                R_App.ApplicationDate = DateTime.Now;
                R_App.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                R_App.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
                R_App.LastUpdateStatus = DateTime.Now;
                R_App.PaidFees = Convert.ToInt32(lblFees.Text);
                R_App.CreateByUserID = GlobalClass.CurrentUser.UserID;



                if (!R_App.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = -1;
                    MessageBox.Show("Error in save application", "DVLD Save");
                    return false;
                }

                _TestAppointment.RetakeTestApplicationID = R_App.ApplicationID;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LDLAppID = _LDLAppID;
            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
            _TestAppointment.CreateByUserID = GlobalClass.CurrentUser.UserID ;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully" , "DVLD Save");
            }
            else
            {
                MessageBox.Show("Error in save Schedule" , "DVLD Save");
            }

        }
    }
}
