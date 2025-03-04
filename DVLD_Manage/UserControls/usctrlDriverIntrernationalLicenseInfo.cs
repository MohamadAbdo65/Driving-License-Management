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

namespace DVLD_Manage.UserControls
{
    public partial class usctrlDriverIntrernationalLicenseInfo : UserControl
    {
        int _InterLicenseID;

        clsInternationalLicense internationalLicense;

        public usctrlDriverIntrernationalLicenseInfo()
        {
            InitializeComponent();
        }

        void _LoadImgPerson()
        {
            byte Gender = (byte)internationalLicense.LocalLicenseInfo.DriverInfo.PersonInfo.Gender;
            string ImgPath = internationalLicense.LocalLicenseInfo.DriverInfo.PersonInfo.ImagePath;

            if (Gender == 0)
                pbPersonImage.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-person-96 (1).PNG";
            else
                pbPersonImage.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-female-96.PNG";

            if (!string.IsNullOrEmpty(ImgPath))
            {
                pbPersonImage.ImageLocation = ImgPath;
            }
        }

        public void LoadInterLicenseInfo(int InterLicenseID)
        {
            _InterLicenseID = InterLicenseID;

            internationalLicense = clsInternationalLicense.Find(_InterLicenseID);

            if (internationalLicense == null)
            {
                MessageBox.Show("International License is not found", "DVLD");
                return;
            }


            lblName.Text = internationalLicense.ApplicationInfo.ApplicantFullName;
            lblInterLicenseID.Text = internationalLicense.InterLicenseID.ToString();
            lblLicenseID.Text = internationalLicense.LocalLicensID.ToString();
            lblNationalNo.Text = internationalLicense.LocalLicenseInfo.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = (internationalLicense.LocalLicenseInfo.DriverInfo.PersonInfo.Gender == 0) ? "Male" : "Female";
            lblIssueDate.Text = internationalLicense.IssueDate.ToShortDateString();
            lblIsActive.Text = (internationalLicense.IsActive) ? "Yes" : "No";
            lblApplicationID.Text = internationalLicense.ApplicationID.ToString();
            lblDateOfBirth.Text = internationalLicense.LocalLicenseInfo.DriverInfo.PersonInfo.DateOfBith.ToShortDateString();
            lblDriverID.Text = internationalLicense.DriverID.ToString();
            lblExpirationDate.Text = internationalLicense.ExpirationDate.ToShortDateString();

            _LoadImgPerson();
        }
    }
}
