using DVLD_BusinussLayer;
using DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication;
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

namespace DVLD_Manage.ClassApplications.Driving_License_Servises.ReplacementLostOrDamageLicense
{
    public partial class frmReplaceLostDamageLicense : Form
    {
        int _ReplecedLicenseID = -1;

        enum enReplaceType { Damage , Lost}
        enReplaceType _ReplaceType;

        enReplaceType ReplaceType
        {
            get { return _ReplaceType; }
            set 
            {
                _ReplaceType = value; 
                
                if(_ReplaceType == enReplaceType.Damage)
                {
                    lblAppFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.ReplaceDamageDrivingLecense).Fees.ToString();
                    lblTitle_Damage.Visible = true;
                    lblTitle_Lost.Visible = false;
                }
                else if (_ReplaceType == enReplaceType.Lost)
                {
                    lblAppFees.Text = clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.ReplaceLostDrivingLecense).Fees.ToString();
                    lblTitle_Damage.Visible = false;
                    lblTitle_Lost.Visible = true;
                }
            }
        }

        public frmReplaceLostDamageLicense()
        {
            InitializeComponent();
        }

        private void frmReplaceLostDamageLicense_Load(object sender, EventArgs e)
        {
            ReplaceType = enReplaceType.Damage;

            lblAppDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedBy.Text = GlobalClass.CurrentUser.Username;
        }

        private void usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int LicenseID = obj;

            if (!clsLicense.LicenseIsExist(LicenseID))
            {
                return;
            }

            lblOldLicenseID.Text = LicenseID.ToString();
            btnShowLicenseHistory.Enabled = true;


            if (!usctrlDriverlicenseInfoWithFilter1.SelectedLicense.IsActive)
            {
                MessageBox.Show("This License is not active , Please choose active license", "DVLD");
                btnIssue.Enabled = false;
                return;
            }

            btnIssue.Enabled = true;    
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            clsLicense.enIssueReason IR = (ReplaceType == enReplaceType.Damage) ? clsLicense.enIssueReason.DamagedReplacement : clsLicense.enIssueReason.LostReplacement;

            clsLicense NewLicense = usctrlDriverlicenseInfoWithFilter1.SelectedLicense.Replace(IR, GlobalClass.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Error in load New License", "DVLD");
                return;
            }

            lblAppID.Text = NewLicense.ApplicationID.ToString();
            _ReplecedLicenseID = NewLicense.LicenseID;
            lblRLicenseID.Text = _ReplecedLicenseID.ToString();

            MessageBox.Show("Licensed Replaced Successfully with ID=" + _ReplecedLicenseID.ToString(), "License Issued", MessageBoxButtons.OK);

            btnIssue.Enabled = false;
            btnShowLicenseInfo.Enabled = true;
            usctrlDriverlicenseInfoWithFilter1.FilterEnabled = false;
            rdbDamage.Enabled = false;
            rdbLost.Enabled = false;

        }


        private void rdbDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDamage.Checked)
            {
                ReplaceType = enReplaceType.Damage;
            }
        }
        private void rdbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLost.Checked)
            {
                ReplaceType = enReplaceType.Lost;
            }
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(_ReplecedLicenseID);
            frm .ShowDialog();

        }

        private void btnShowLicenseHistory_Click(object sender, EventArgs e)
        {
            frmShowLicenseHistory frm = new frmShowLicenseHistory(usctrlDriverlicenseInfoWithFilter1.SelectedLicense.DriverInfo.PersonID);
            frm .ShowDialog();
        }
    }
}
