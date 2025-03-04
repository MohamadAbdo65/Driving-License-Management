using DVLD_BusinussLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_Manage
{
    public partial class ManageUsers : Form
    {
        private static DataTable _dtAllUsers;

        public ManageUsers()
        {
            InitializeComponent();
        }



        private void _RefreshData()
        {
            _dtAllUsers = clsUsers.GetAllUsers();
            dgvUsersData.DataSource = _dtAllUsers;
            lblTotalUsers.Text = dgvUsersData.RowCount.ToString();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Form form = new Add_Update_User();

            form.ShowDialog();

            _RefreshData();
        }

        private void cmbbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbSearsh.Visible = false;
            cmbbActiveFilter.Visible = false;

            _RefreshData();

            if (cmbbFilterBy.SelectedIndex != 0)
            {
                txtbSearsh.Visible = true;
            }
            if(cmbbFilterBy.SelectedIndex == 8)
            {
                txtbSearsh.Visible = false;
                cmbbActiveFilter.Visible = true;
            }
        }

        private void txtbSearsh_TextChanged(object sender, EventArgs e)
        {
            int CountRow = 0;
            clsDGV_Filter.Filter(txtbSearsh.Text , cmbbFilterBy.Text , dgvUsersData, clsUsers.GetAllUsers() , ref CountRow);
            lblTotalUsers.Text = CountRow.ToString();
        }

        private void cmbbActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbActiveFilter.SelectedIndex == 1)
            {
                clsDGV_Filter.FilterActiveUsers(true, dgvUsersData , clsUsers.GetAllUsers());
                lblTotalUsers.Text = dgvUsersData.RowCount .ToString();
            }
            else if (cmbbActiveFilter.SelectedIndex == 2)
            {
                clsDGV_Filter.FilterActiveUsers(false, dgvUsersData, clsUsers.GetAllUsers());
                lblTotalUsers.Text = dgvUsersData.RowCount.ToString();
            }
            else
            {
                _RefreshData();
            }
        }

        //*-*-*-*-*-*-*-*-*

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ender Development !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ender Development !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        //**

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this User ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser((int)dgvUsersData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Done delete successfully.");
                    _RefreshData();
                }
                else
                {
                    MessageBox.Show("Failed to delete.");
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Update_User _Update_User = new Add_Update_User((int)dgvUsersData.CurrentRow.Cells[0].Value);

            _Update_User.ShowDialog();

            _RefreshData();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordUser change = new ChangePasswordUser((int)dgvUsersData.CurrentRow.Cells[0].Value);
        
            change.ShowDialog();

            _RefreshData();
        }

        private void showDetaileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetailes frmUser = new frmUserDetailes((int)dgvUsersData.CurrentRow.Cells[0].Value);

            frmUser.ShowDialog();

            _RefreshData();
        }
    }

}
