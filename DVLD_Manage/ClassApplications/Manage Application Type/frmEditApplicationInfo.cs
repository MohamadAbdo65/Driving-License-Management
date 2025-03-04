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

namespace DVLD_Manage
{
    public partial class frmEditApplicationInfo : Form
    {
        private int _AppType;

        private clsApplicationsType _ApplicationsType;


        public frmEditApplicationInfo(int AppTypeID)
        {
            InitializeComponent();

            _AppType = AppTypeID;
        }

        private void frmEditApplicationInfo_Load(object sender, EventArgs e)
        {
            _ApplicationsType = clsApplicationsType.GetApplicationType(_AppType);


            if (_ApplicationsType == null)
            {
                MessageBox.Show("Error in find Application.", "DVLD");
                this.Close();
                return;
            }


            lblID.Text = _ApplicationsType.ID.ToString();
            txtbTitle.Text = _ApplicationsType.Title;
            txtbFees.Text = _ApplicationsType.Fees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbFees.Text != string.Empty && txtbTitle.Text != string.Empty)
            {
                _ApplicationsType.Title = txtbTitle.Text;
                _ApplicationsType.Fees = Convert.ToInt32(txtbFees.Text);

                if (_ApplicationsType.Save())
                {
                    MessageBox.Show("Done Save succesfully.");
                }
                else
                {
                    MessageBox.Show("Error in Save.");
                }

            }
            else
            {
                MessageBox.Show("Some Value are missing.");
            }
        }
    }
}
