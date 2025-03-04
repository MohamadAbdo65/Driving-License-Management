using DVLD_BusinussLayer;
using System;

using System.Windows.Forms;

namespace DVLD_Manage
{
    public partial class usctrlInfoCard : UserControl
    {

       private clsPerson _CurrentPerson;


        public int PersonID
        {
            get 
            {
                if (CurrentPerson != null)
                {
                    return CurrentPerson.PersonID;
                }
                else
                {
                    return -1;
                }
            }
        }

        public clsPerson CurrentPerson
        {
            get { return _CurrentPerson; }
        }

        public usctrlInfoCard()
        {
            InitializeComponent();           
        }

        public void LoadPersonInfo(int PerosnID)
        {
            _CurrentPerson = clsPerson.Find(PerosnID);

            if (_CurrentPerson == null) 
            {
                MessageBox.Show("No person with PersonID = " + PerosnID.ToString(), "Error");
                return;
            }
            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _CurrentPerson = clsPerson.Find(NationalNo);

            if (_CurrentPerson == null)
            {
                MessageBox.Show("No person with NationalNO = " + NationalNo.ToString(), "Error");
                return;
            }
            _FillPersonInfo();
        }

        private void _LoadPersonImage()
        {
            if (_CurrentPerson.Gender == 0)
                picbImagePersonal.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-person-96 (1).PNG";
            else
                picbImagePersonal.ImageLocation = @"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-female-96.PNG";

            if (_CurrentPerson.ImagePath != "")
            {
                picbImagePersonal.ImageLocation = _CurrentPerson.ImagePath;
            }

        }

        private void _FillPersonInfo()
        {
            btnEditPersonInfo.Enabled = true;

            lblID.Text = _CurrentPerson.PersonID.ToString();
            lblFullName.Text = _CurrentPerson.FirstName + " " + _CurrentPerson.SecondName + " " + _CurrentPerson.ThirdName + " " + _CurrentPerson.LastName;
            lblNationalNo.Text = _CurrentPerson.NationalNo;
            lblGender.Text = (_CurrentPerson.Gender == 0) ? "Male" : "Female";
            lblEmail.Text = _CurrentPerson.Email;
            lblPhone.Text = _CurrentPerson.Phone;
            lblDateBirth.Text = _CurrentPerson.DateOfBith.ToString("dd/MM/yyyy");
            lblAddress.Text = _CurrentPerson.Address;
            lblCountry.Text = clsCountries.Find(_CurrentPerson.NationalityCountryID).CountryName;

            _LoadPersonImage();
        }

        public void SetDefault()
        {
            btnEditPersonInfo.Enabled = false;

            lblID.Text = "N";
            lblFullName.Text = "N";
            lblNationalNo.Text = "N";
            lblGender.Text = "N";
            lblEmail.Text = "N";
            lblPhone.Text = "N";
            lblDateBirth.Text = "N";
            lblAddress.Text = "N";
            lblCountry.Text = "N";

            picbImagePersonal.ImageLocation = null;

        }

        private void usctrlInfoCard_Load(object sender, EventArgs e)
        {            

        }      

        private void btnEditPersonInfo_Click(object sender, EventArgs e)
        {
            if (_CurrentPerson != null)
            {
                Add_Update_Person form = new Add_Update_Person(_CurrentPerson.PersonID);

                form.ShowDialog();

                LoadPersonInfo(_CurrentPerson.PersonID);
            }
            else
            {

            }
        }
    }
}
