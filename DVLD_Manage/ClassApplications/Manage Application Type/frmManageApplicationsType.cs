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
    public partial class frmManageApplicationsType : Form
    {
        public frmManageApplicationsType()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            dgvApplicationsType.DataSource = clsApplicationsType.GellAllTypes();
           
            dgvApplicationsType.Columns[0].Width = 125;
            dgvApplicationsType.Columns[1].Width = 450;
        }

        private void frmManageApplicationsType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationInfo frm = new frmEditApplicationInfo((int)dgvApplicationsType.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _LoadData();
        }
    }
}
