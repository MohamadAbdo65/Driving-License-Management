using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest;
using DVLD_Manage.ClassManageDrivers;
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
    public partial class frmManageLocalDrivingLicenseApplication : Form
    {
        private DataTable _dtLocalDrivingLicenseApplications;

        public frmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _dtLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplication.GetAllLDLApplications();
            dgvLDLAppData.DataSource = _dtLocalDrivingLicenseApplications;

            lblTotalLDLApp.Text = dgvLDLAppData.Rows.Count.ToString();
            if (dgvLDLAppData.RowCount > 0 ) 
            {
            dgvLDLAppData.Columns[0].HeaderText = "L.D.L App ID";
            dgvLDLAppData.Columns[0].Width = 65 ;

            dgvLDLAppData.Columns[1].HeaderText = "Class Name";
            dgvLDLAppData.Columns[1].Width = 155;

            dgvLDLAppData.Columns[2].HeaderText = "National No";
            dgvLDLAppData.Columns[2].Width = 65;
                                  
            dgvLDLAppData.Columns[3].HeaderText = "Full Name";
            dgvLDLAppData.Columns[3].Width = 130;
                                  
            dgvLDLAppData.Columns[4].HeaderText = "Application Date";
            dgvLDLAppData.Columns[4].Width = 100;
                                  
            dgvLDLAppData.Columns[5].HeaderText = "Passed Test";
            dgvLDLAppData.Columns[5].Width = 60;
                                  
            dgvLDLAppData.Columns[6].HeaderText = "Status";
                dgvLDLAppData.Columns[6].Width = 110;
            }
        }

        private void frmManageLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnAddNewLDLApp_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateLocalLicenseApplication frm = new frmAdd_UpdateLocalLicenseApplication();
            frm.ShowDialog();
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_UpdateLocalLicenseApplication frm = new frmAdd_UpdateLocalLicenseApplication((int)dgvLDLAppData.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this Application ?", "DVLD" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (clsLocalDrivingLicenseApplication.Delete((int)dgvLDLAppData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Done delete succesfully." , "DVLD");
                    _LoadData() ;
                }
                else { MessageBox.Show("Error in Delete Local driving license application"); }
            }
        }

        private void CancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel this Application ?", "DVLD", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID((int)dgvLDLAppData.CurrentRow.Cells[0].Value);
                
                if (clsApplication.Cancel(LDLApp.ApplicationID))
                { 
                    _LoadData(); 
                }
                else
                {
                    MessageBox.Show("Error in Cancel Local driving license application");
                }
            }
        }

        private void mnustLDLAPP_Opening(object sender, CancelEventArgs e)
        {
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID((int)dgvLDLAppData.CurrentRow.Cells[0].Value);

            int TotalPassedTests = (int)dgvLDLAppData.CurrentRow.Cells[5].Value;

            // new
            if (LDLApp.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.New)
            {
                CancelApplication.Enabled = true;
                SechdlueTests.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                SechdlueTests.Enabled = true;
                if (TotalPassedTests == 0)
                {
                    visionTestToolStripMenuItem.Enabled = true;
                    writtenTestToolStripMenuItem.Enabled = false;
                    practicalTestToolStripMenuItem.Enabled = false;
                }
                else if (TotalPassedTests == 1)
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = true;
                    practicalTestToolStripMenuItem.Enabled = false;
                }
                else if (TotalPassedTests == 2)
                {
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = false;
                    practicalTestToolStripMenuItem.Enabled = true;
                }
                else { SechdlueTests.Enabled = false; 
                editToolStripMenuItem.Enabled = true;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;}

            }
            // Cancel
             if (LDLApp.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.Canceled)
            {
                CancelApplication.Enabled = false;
                SechdlueTests.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                SechdlueTests.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

            }
            // complete
            if (LDLApp.ApplicationInfo.ApplicationStatus == clsApplication.enApplicationStatus.Complete)
            {
                CancelApplication.Enabled = false;
                SechdlueTests.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
                SechdlueTests.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

            }
        }

        private void showDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowApplicationInfo frm = new frmShowApplicationInfo((int)dgvLDLAppData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadData();
        }

        private void txtbSearsh_TextChanged(object sender, EventArgs e)
        {
            int CountRow = 0;
            clsDGV_Filter.Filter(txtbSearsh.Text, cmbbFilterBy.Text, dgvLDLAppData, _dtLocalDrivingLicenseApplications, ref CountRow);
            lblTotalLDLApp.Text = CountRow.ToString();

        }

        private void cmbbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbFilterBy.SelectedIndex == 0) 
            {
                txtbSearsh.Visible = false;
            }
            else
            {
                txtbSearsh.Visible = true;
            }
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestAppoitment frm = new frmManageTestAppoitment((int)dgvLDLAppData.CurrentRow.Cells[0].Value , clsTestType.enTestType.VisionTest);

            frm.ShowDialog();

            _LoadData();
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestAppoitment frm = new frmManageTestAppoitment((int)dgvLDLAppData.CurrentRow.Cells[0].Value, clsTestType.enTestType.WrittenTest);

            frm.ShowDialog();

            _LoadData();
        }

        private void practicalTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestAppoitment frm = new frmManageTestAppoitment((int)dgvLDLAppData.CurrentRow.Cells[0].Value, clsTestType.enTestType.StreetTest);

            frm.ShowDialog();

            _LoadData();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicense frm = new frmIssueDrivingLicense((int)dgvLDLAppData.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _LoadData();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLAppData.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindByID(LDLAppID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLAppData.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LDLApp = clsLocalDrivingLicenseApplication.FindByID(LDLAppID);

            frmShowLicenseHistory frm = new frmShowLicenseHistory(LDLApp.ApplicantPersonID);

            frm.ShowDialog();
        }
    }
}
