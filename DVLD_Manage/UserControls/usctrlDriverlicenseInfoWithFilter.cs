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
    public partial class usctrlDriverlicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;

            if (handler != null) handler(LicenseID);
        }
                      
        public usctrlDriverlicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set {
                _FilterEnabled = value;
                pnlFilter.Enabled = _FilterEnabled;
            }
        }


        int _LicenseID = -1;
        public int LicenseID
        {
            get { return usctrlDriverLicenseInfo1.LicenseID; }
        }

        //clsLicense _License;
        public clsLicense SelectedLicense
        {
            get { return usctrlDriverLicenseInfo1.License; }
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtbLicenseID.Text = LicenseID.ToString();

            usctrlDriverLicenseInfo1.LoadLicenseInfo(LicenseID);

            _LicenseID = usctrlDriverLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbLicenseID.Text))
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some values are missing", "DVLD" , MessageBoxButtons.OK);
                txtbLicenseID.Focus();
                return;

            }

            if (!int.TryParse(txtbLicenseID.Text, out int L))
                 return; 

            _LicenseID = L;
            LoadLicenseInfo(_LicenseID);
        }

        public void FocusOnTextBoxSearsh()
        {
            txtbLicenseID.Focus();
        }

    }
}
