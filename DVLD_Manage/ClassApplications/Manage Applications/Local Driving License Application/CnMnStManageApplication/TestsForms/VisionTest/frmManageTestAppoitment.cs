using DVLD_BusinussLayer;
using DVLD_Manage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest
{
    public partial class frmManageTestAppoitment : Form
    {
        public int LDLAppID
        {
            get;
            set;
        }

        clsTestType.enTestType _TestTypeID;
        public clsTestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                 _TestTypeID = value;

                if (_TestTypeID == clsTestType.enTestType.VisionTest)
                {
                    lblTestTypeTitle.Text = "Vision Test Appointment";
                    picbTestTypePic.Image = Resources.Vision_Test;
                }
                else if (_TestTypeID == clsTestType.enTestType.WrittenTest)
                {
                    lblTestTypeTitle.Text = "Written Test Appointment";
                    picbTestTypePic.Image = Resources.Written_Test;
                }
                else if (_TestTypeID == clsTestType.enTestType.StreetTest)
                {
                    lblTestTypeTitle.Text = "Street Test Appointment";
                    picbTestTypePic.Image = Resources.Practical_Test;
                }
            }
        }

        public frmManageTestAppoitment(int _LDLAppID , clsTestType.enTestType __TestTypeID)
        {
            InitializeComponent();

            LDLAppID = _LDLAppID;
            TestTypeID = __TestTypeID;


        }

        private void frmTestAppoitment_Load(object sender, EventArgs e)
        {
            //load App info 
            usctrlLDLApp_BaseApp_Info1.ShowApplicationInfo(LDLAppID);

            DataTable AppointmentsTable = clsTestAppointment.GetTestAppointmentPerTestType(LDLAppID , (int)TestTypeID);

            dgvAppointments.DataSource = AppointmentsTable;

            lblNumberOfAppointment.Text = AppointmentsTable.Rows.Count.ToString();

            if (dgvAppointments.Columns.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "ID";
                dgvAppointments.Columns[0].Width = 150;

                dgvAppointments.Columns[1].HeaderText = "Date";
                dgvAppointments.Columns[1].Width = 250;

                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[2].Width = 200;

                dgvAppointments.Columns[3].HeaderText = "Is Locked";
                dgvAppointments.Columns[3].Width = 150;

            }

        }

        private void btnAddNewTestAppointment_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication LDLAppInfo = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            if (clsLocalDrivingLicenseApplication.IsThereActiveScheduledTest(LDLAppID , (int)TestTypeID))
            {
                MessageBox.Show("Person already have a active appointment for this test", "DVLD");
                return;
            }

            clsTest LastTest = clsTest.FindLastTestPerPersonAndLicenseClass(LDLAppInfo.ApplicantPersonID, LDLAppInfo.LicenseClassID , (int)TestTypeID);

            if (LastTest == null)
            {
                frmAddUpdateTestAppointment frm1 = new frmAddUpdateTestAppointment(LDLAppID, TestTypeID);
                frm1.ShowDialog();
                frmTestAppoitment_Load(null, null);
                return;
            }

            if (LastTest.TestResult == true)
            {
                MessageBox.Show("This person already passed this test before, you can only retake faild test", "DVLD" );
                return;
            }

            frmAddUpdateTestAppointment frm2 = new frmAddUpdateTestAppointment(LDLAppID, TestTypeID);
            frm2.ShowDialog();
            frmTestAppoitment_Load(null, null);


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
             int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmAddUpdateTestAppointment frm = new frmAddUpdateTestAppointment(LDLAppID, TestTypeID, AppointmentID);
            frm.ShowDialog();
            frmTestAppoitment_Load(null, null);
        }

        private void TakeTest_Click(object sender, EventArgs e)
        {


            int AppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;

            frmTakeTest frm = new frmTakeTest(AppointmentID , TestTypeID);
            frm.ShowDialog();
            frmTestAppoitment_Load(null, null);
 
        }
    }
}
