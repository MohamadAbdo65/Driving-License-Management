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
    public partial class frmEditTestInfo : Form
    {
        private clsTestType.enTestType _TestTypeID;

        private clsTestType _TestType;

        public frmEditTestInfo(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void frmEditTestInfo_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.GetTestType(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show("Test not found");
                this.Close();   
                return;
            }

            lblID.Text = ((int)_TestType.ID).ToString();
            txtbTitle.Text = _TestType.Title.ToString();
            txtbFees.Text = _TestType.Fees.ToString();
            txtbDescreption.Text = _TestType.Description.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtbDescreption.Text != string.Empty && txtbFees.Text != string.Empty && txtbTitle.Text != string.Empty)
            {
                if (MessageBox.Show("Are you sure you want to Update this test type ?", "DVLD Save Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _TestType.Title = txtbTitle.Text;
                    _TestType.Description = txtbDescreption.Text;
                    _TestType.Fees = Convert.ToInt32(txtbFees.Text);

                    if (_TestType.Save())
                    {
                        MessageBox.Show("Saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error in Save Updates");
                    }
                }

            }
            else
            {
                MessageBox.Show("Somw value are missing.", "DVLD");
            }
        }
    }
}
