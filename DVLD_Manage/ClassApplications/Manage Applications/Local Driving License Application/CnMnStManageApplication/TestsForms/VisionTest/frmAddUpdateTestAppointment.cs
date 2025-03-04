using DVLD_BusinussLayer;
using System;
using System.Windows.Forms;

namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest
{
    public partial class frmAddUpdateTestAppointment : Form
    {
        int _LDLAppID = -1;
        clsTestType.enTestType _TestTypeID;
        int _AppointmentID = -1;

        public frmAddUpdateTestAppointment(int lDLAppID, clsTestType.enTestType testTypeID, int appointmentID = -1)
        {
            InitializeComponent();
            _LDLAppID = lDLAppID;
            _TestTypeID = testTypeID;
            _AppointmentID = appointmentID;
        }

        private void frmAddUpdateTestAppointment_Load(object sender, EventArgs e)
        {
            usctrlScheduleTest1.TestTypeID = _TestTypeID;
            usctrlScheduleTest1.LoadInfo(_LDLAppID , _AppointmentID);
        }
    }
}
