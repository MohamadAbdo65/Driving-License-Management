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
    public partial class frmManageTestsType : Form
    {
        public frmManageTestsType()
        {
            InitializeComponent();
        }     

        private void _LoadData()
        {
            dgvTestsType.DataSource = clsTestType.GetAllTestsType();

            if (dgvTestsType.Rows.Count > 0)
            {
                dgvTestsType.Columns[0].Width = 35;
                dgvTestsType.Columns[1].Width = 150;
                dgvTestsType.Columns[2].Width = 565;
            }
        }

        private void frmManageTestsType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestInfo frm = new frmEditTestInfo((clsTestType.enTestType)dgvTestsType.CurrentRow.Cells[0].Value);
        
            frm.ShowDialog();

            _LoadData();
                
        }
    }
}
