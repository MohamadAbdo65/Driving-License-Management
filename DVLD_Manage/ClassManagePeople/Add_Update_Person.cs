using DVLD_BusinussLayer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;


namespace DVLD_Manage
{
    public partial class Add_Update_Person : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;

        enum enMode { Add , Update }

        private enMode _Mode;

        private int _ID;

        clsPerson _Person;

        public Add_Update_Person()
        {
            InitializeComponent();

            _Mode = enMode.Add;

        }

        public Add_Update_Person(int PersonID)
        {
            InitializeComponent();

            _ID = PersonID;

            _Mode =  enMode.Update;
            this.Text = "Update Person Info";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SetGenderCheck()
        {
            if (_Person.Gender == 0)
            {
                rdbMale.Checked = true;

            }
            else if (_Person.Gender == 1)
            {
                rdbFemale.Checked = true;
            }
        }

        private void SetDefaultImageByGender()
        {
            if (rdbMale.Checked)
            {
                picPersonalImage.Image = Image.FromFile(@"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-person-96 (1).PNG");

            }
            else
            {
                picPersonalImage.Image = Image.FromFile(@"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-female-96.PNG");

            }
        }

        private void _FillCombboxCountry()
        {
            DataTable dataTable = clsCountries.GetAllCountries();

            List<clsCountr> AllCountries = clsCountries.GetAllCountries();

            foreach (DataRow T in dataTable.Rows)
            {
                cmbbCountry.Items.Add(T["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _FillCombboxCountry();

            if (_Mode == enMode.Add) 
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.Find(_ID);

            if (_Person == null) 
            {
                MessageBox.Show("Error 320", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblTitle.Text = "Update Person Info";
            lblPersonID.Text = _Person.PersonID.ToString();
            txtbFirstName .Text = _Person.FirstName;
            txtbSecondName.Text = _Person.SecondName;
            txtbThirdName.Text = _Person.ThirdName;
            txtbLastName.Text = _Person.LastName;
            txtbNationalNo.Text = _Person.NationalNo;
            datiDateOfBirth.Value = _Person.DateOfBith;

            if (_Person.ImagePath != "")
            {
                picPersonalImage.SizeMode = PictureBoxSizeMode.StretchImage;
                picPersonalImage.ImageLocation = _Person.ImagePath;
            

                btnRemoveImage.Visible = true;
            }

            _SetGenderCheck();
            SetDefaultImageByGender();

            txtbPhoneNumber.Text = _Person.Phone;
            txtbEmail.Text = _Person.Email;
            cmbbCountry.SelectedIndex = _Person.NationalityCountryID - 1;
            txtbAddress.Text = _Person.Address;


        }

        private void Add_Update_Person_Load(object sender, EventArgs e)
        {
            _LoadData();

            // اصغر عمر يمكن 
            datiDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            // اكبر عمر يكمن
            datiDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

        }

        private bool _HandelePersonImage()
        {
            if (_Person.ImagePath != picPersonalImage.ImageLocation)
            {
                if(_Person.ImagePath != "" )
                {
                    try
                    {

                        File.Delete(_Person.ImagePath);
                          _Person.ImagePath = "";

                    }
                    catch (Exception ex) 
                    {
                        clsLogger.AddLog(clsLogger.enErrorLocation.ErrorInPresentation, ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                }

                if (picPersonalImage.ImageLocation != null)
                {
                    string SourseImageFile = picPersonalImage.ImageLocation.ToString();

                    if(clsMethodes.CopyImageToIMageFolder(ref SourseImageFile))
                    {
                        picPersonalImage.ImageLocation = SourseImageFile;
                        _Person.ImagePath = SourseImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error 806 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        //*-*-*-*-*

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.InitialDirectory = @"c:\";
            dlg.Filter = "PNG Files (*.png) | *.png|JPEG Files (*.jpg)|*.jpg";


            if (dlg.ShowDialog() == DialogResult.OK)
            {

                picPersonalImage.ImageLocation = dlg.FileName.ToString();

                btnRemoveImage.Visible = true;

                rdbMale.Tag = "A";
                rdbFemale.Tag = "B";

            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
         

            picPersonalImage.Image = null;
            picPersonalImage.ImageLocation = null;

            SetDefaultImageByGender();

            btnRemoveImage.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if((rdbFemale.Checked == false) && (rdbMale.Checked == false))
            {
                MessageBox.Show("Some values ​​are missing", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if(!this.ValidateChildren() || txtbNationalNo.Text == "")
            {
                MessageBox.Show("Some values ​​are missing", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            if (MessageBox.Show("Are you sure you want save this informetion ?" , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                int CountryID = clsCountries.Find(cmbbCountry.Text).ID ;

                _Person.FirstName = txtbFirstName.Text;
                _Person.SecondName = txtbSecondName.Text;
                _Person.ThirdName = txtbThirdName.Text;
                _Person.LastName = txtbLastName.Text;
                _Person.NationalNo = txtbNationalNo.Text;
                _Person.DateOfBith = datiDateOfBirth.Value;
                _Person.Gender = (rdbMale.Checked == true) ? 0 : 1;
                _Person.Address = txtbAddress.Text;
                _Person.Phone = txtbPhoneNumber.Text;
                _Person.Email = txtbEmail.Text;
                _Person.NationalityCountryID = CountryID;
                               

                _HandelePersonImage();


                // \/ Save

                if (_Person.Save())
                {
                    _Mode = enMode.Update;
                    lblTitle.Text = "Update Person Info";
                    lblPersonID.Text = _Person.PersonID.ToString();


                    MessageBox.Show("Data Saved succesfully.");

                    DataBack?.Invoke(this, _Person.PersonID);

                }
                else
                {
                    MessageBox.Show("Error 705.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        //*-*-*

        private void txtbNationalNo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if ( clsPerson.PersonIsExist(txtbNationalNo.Text))
            {
                if (txtbNationalNo.Text == _Person.NationalNo)
                    return;

                e.Cancel = true;
                txtbNationalNo.Focus();
                errprvTxtBoxes.SetError(txtbNationalNo, "This National No is Exist !");
            }
            else
            {
                e.Cancel= false;
                errprvTxtBoxes.SetError(txtbNationalNo, "");
            }
        }

        private void txtbPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(txtbPhoneNumber.Text.Length < 11)
            {
                e.Cancel = true;
                txtbPhoneNumber.Focus();
                errprvTxtBoxes.SetError(txtbPhoneNumber, "Invalid Phone Number !");
            }
        }


        // check to get no empty
        private void txtbNotNull_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2TextBox textBox = sender as Guna2TextBox;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errprvTxtBoxes.SetError(textBox, "Invalid Value !");
            }

        }


        private void cmbbCountry_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbbCountry.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmbbCountry.Focus();
                errprvTxtBoxes.SetError(cmbbCountry, "Invalid Value !");
            }
        }

        private void txtbEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsMethodes.IsValidEmail(txtbEmail.Text))
            {
                e.Cancel= true;
                txtbEmail.Focus();
                errprvTxtBoxes.SetError(txtbEmail, "Invalid Email !");
            }
        }

       
        private void rdbMale_Click(object sender, EventArgs e)
        {
            if (rdbMale.Tag.ToString() == "")
            {
                picPersonalImage.Image = Image.FromFile(@"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-person-96 (1).PNG");
            }
        }

        private void rdbFemale_Click(object sender, EventArgs e)
        {
            if (rdbFemale.Tag.ToString() == "")
            {
                picPersonalImage.Image = Image.FromFile(@"D:\Raod map !!\P الكورس التاسع عشر\DVLD_Manage\الصور المستخدمة\icons8-female-96.PNG");
            }
        }
    }
}
