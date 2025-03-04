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
    public partial class usCtrlScheduledTestInfo : UserControl
    {
       
        int _TestAppointmentID = -1;
        clsTestAppointment _TestAppointmetInfo;

        clsLocalDrivingLicenseApplication _LDLApp;

        clsTestType.enTestType _TestTypeID;
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

        int _TestID = -1;
        public int TestID
        {
            get { return _TestID; }
            set { _TestID = value; 
            
                lblTestID.Text = _TestID.ToString();
            
            }
        }


        public usCtrlScheduledTestInfo()
        {
            InitializeComponent();
        }

        public void LoadScheduledTestInfo(int TestAppointmentID)
        {

            _TestAppointmentID = TestAppointmentID;
            

            _TestAppointmetInfo = clsTestAppointment.GetTestAppointment(_TestAppointmentID);
            _LDLApp = clsLocalDrivingLicenseApplication.FindByID(_TestAppointmetInfo.LDLAppID);

            if ((_TestAppointmetInfo == null) || (_LDLApp == null))
            {
                MessageBox.Show("Error in load Scheduled Test Info" , "DVLD Load");
                return;
            }

            TestTypeID = _TestAppointmetInfo.TestTypeID;
            TestID = _TestAppointmetInfo.TestID;

            lblDLAppID.Text = _TestAppointmetInfo.LDLAppID.ToString();
            lblName.Text = _LDLApp.ApplicantFullName;
            lblLClass.Text = _LDLApp.licenseClassInfo.ClassName;
            lblDate.Text = _TestAppointmetInfo.AppointmentDate.ToShortDateString();
            lblFees.Text = _TestAppointmetInfo.PaidFees.ToString();
            lblTrial.Text = _LDLApp.TotalTrialPerTest((int)TestTypeID).ToString();
            

        }

    }
}
