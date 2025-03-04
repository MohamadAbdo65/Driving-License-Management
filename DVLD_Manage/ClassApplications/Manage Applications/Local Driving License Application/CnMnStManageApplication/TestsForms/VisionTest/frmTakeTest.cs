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

namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest
{
    public partial class frmTakeTest : Form
    {
        int _AppointmentID;

        clsTest _Test;

        clsTestType.enTestType _TestTypeID;         

        public frmTakeTest(int AppointmentID , clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _AppointmentID = AppointmentID;
            _TestTypeID = TestTypeID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            usCtrlScheduledTestInfo1.TestTypeID = _TestTypeID;

            usCtrlScheduledTestInfo1.LoadScheduledTestInfo(_AppointmentID);


            int TestID = usCtrlScheduledTestInfo1.TestID;
            if (TestID != -1)
            {
                _Test = clsTest.Find(TestID);

                if (_Test.TestResult)
                    rdbPass.Checked = true;
                else
                    rdbFaile.Checked = true;

                txtbNote.Text = _Test.Notes;
                lblUserMessage.Visible = true;
                rdbPass.Enabled = false;
                rdbFaile.Enabled = false;
                btnSave.Enabled = false;

            }
            else _Test = new clsTest();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save ? , " +
                " After that you cannot change the Pass/Fail results after you save?" , "Save Result Test" ,
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            _Test.TestAppointmentID = _AppointmentID;
            _Test.TestResult = rdbPass.Checked;
            _Test.Notes = txtbNote.Text;
            _Test.CreateByUserID = GlobalClass.CurrentUser.UserID;

            if (_Test.Save())
            {
                btnSave.Enabled = false;
                rdbPass.Enabled = false;
                rdbFaile.Enabled = false;
                txtbNote.Enabled = false;
                lblUserMessage.Visible  = true; 
                MessageBox.Show("Done Save Successfully.", "Done Save");
                usCtrlScheduledTestInfo1.TestID = _Test.TestID;
            }
            else
            {
                MessageBox.Show("Error in Save Test");
            }

        }
    }
}
