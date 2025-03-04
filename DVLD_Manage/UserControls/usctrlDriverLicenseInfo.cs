using DVLD_BusinussLayer;
using DVLD_Manage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage.UserControls
{
    public partial class usctrlDriverLicenseInfo : UserControl
    {
        int _LicenseID = -1;

        clsLicense _LicenseInfo;

        public int LicenseID
        {
            get { return _LicenseID; }

        }
        public clsLicense License
        {
            get { return _LicenseInfo; }
        }

        public usctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        void _LoadPersonalImage()
        {
            if (_LicenseInfo.DriverInfo.PersonInfo.Gender == 0)
                picbImagePersonal.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-person-96 (1).PNG";
            else
                picbImagePersonal.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-female-96.PNG";

            string ImgPath = _LicenseInfo.DriverInfo.PersonInfo.ImagePath;

            if (!string.IsNullOrEmpty(ImgPath))
                if (File.Exists(ImgPath))
                    picbImagePersonal.Image = Image.FromFile(_LicenseInfo.DriverInfo.PersonInfo.ImagePath);


        }

        public void LoadLicenseInfo(int licenseID)
        {
            _LicenseID = licenseID;

            _LicenseInfo = clsLicense.Find(_LicenseID);

            if (_LicenseInfo == null )
            {
                MessageBox.Show($"License By ID : {_LicenseID} not found.", "DVLD");
                return;            
            }

            lblClass.Text = _LicenseInfo.LicenseClassInfo.ClassName;
            lblPersonName.Text = _LicenseInfo.DriverInfo.PersonInfo.FullName;
            lblLicenseID.Text = _LicenseInfo.LicenseID.ToString();
            lblNationalNo.Text = _LicenseInfo.DriverInfo.PersonInfo.NationalNo;
            lblGender.Text = (_LicenseInfo.DriverInfo.PersonInfo.Gender == 0) ? "Male" : "Female";
            lblIssueDate.Text = _LicenseInfo.IssueDate.ToShortDateString();
            lblIssueReason.Text = _LicenseInfo.IssueReasonText;
            lblNotes.Text = _LicenseInfo.Notes;
            lblIsActive.Text = (_LicenseInfo.IsActive) ? "Yes" : "No";
            lblDateOfBirth.Text = _LicenseInfo.DriverInfo.PersonInfo.DateOfBith.ToShortDateString();
            lblDriverID.Text = _LicenseInfo.DriverID.ToString();
            lblExpirationDate.Text = _LicenseInfo.ExpirationDate.ToShortDateString();
            lblIsDetained.Text = (_LicenseInfo.IsDetain) ? "Yes" : "No";
            _LoadPersonalImage();
        }

    }
}
