using System;
using System.Data;
using System.Windows.Forms;
using DVLD_BusinussLayer;

namespace DVLD_Manage
{
    public partial class ManagePeople : Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshData()
        {
            dgvPeopleData.DataSource = clsPerson.GetAllPeople();
            lblTotalPeople.Text = clsPerson.GetAllPeople().Rows.Count.ToString();
        }  

        private void ManagePeople_Load(object sender, EventArgs e)
        {

            _RefreshData();
        }


        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Form AddUpdateInfo = new Add_Update_Person();

            AddUpdateInfo.ShowDialog();

            _RefreshData();
        }



        private void cmbbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtbSearsh.Visible = false;

            if (cmbbFilterBy.SelectedIndex != 0)
            {
               txtbSearsh.Visible = true;
            }
        }

        private void txtbSearsh_TextChanged(object sender, EventArgs e)
        {
            int CountRow = 0;
            clsDGV_Filter.Filter(txtbSearsh.Text, cmbbFilterBy.Text, dgvPeopleData, clsPerson.GetAllPeople() , ref CountRow);
            lblTotalPeople.Text = CountRow.ToString();
        }



        public void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Update_Person form = new Add_Update_Person((int)dgvPeopleData.CurrentRow.Cells[0].Value);

            form.ShowDialog();

            _RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this Person ?" , "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(clsPerson.DeletePerson((int)dgvPeopleData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted successfully.");
                    _RefreshData();

                }
                else
                {
                    MessageBox.Show("Sorry, this record cannot be deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under development.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under development.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmPersonDetails((int)dgvPeopleData.CurrentRow.Cells[0].Value);

            form.ShowDialog();

            _RefreshData();
        }

        private void btnCloseApp_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
