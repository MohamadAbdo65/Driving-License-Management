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
    public partial class usctrlInfoCardWithFind : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;

            if (handler != null)
            {
                handler(PersonID);
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson=value;
                btnAddNewPerson.Enabled = _ShowAddPerson;
            }
        }

        private bool _EnableGrpbxFind = true;
        public bool ShowGrpbxFind
        {
            get { return _EnableGrpbxFind; }
            set
            {
                _EnableGrpbxFind = value;
                grpxFind.Enabled = _EnableGrpbxFind;
            }
        }
                
        public string TextFindBox
        {
            get { return txtbSearsh.Text; }
            set {  txtbSearsh.Text = value; }
        }

        public int IndexFindBy
        {
            get {return cmbbFindBy.SelectedIndex; }
        }

        public usctrlInfoCard CardInfo
        {
            get { return usctrlInfoCard1; }

        }

        private bool _HasPersonInfo  = false;
        public bool HasPersonInfo
        {
            get { return _HasPersonInfo; }
        }
        

        public usctrlInfoCardWithFind()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return usctrlInfoCard1.PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return usctrlInfoCard1.CurrentPerson; }
        }

        private void usctrlInfoCardWithFind_Load(object sender, EventArgs e)
        {
        }

        public void SetDefaultCard()
        {
            CardInfo.SetDefault();
        }

        public void LoadPersonInfo(int PersonID)
        {
            txtbSearsh.Text = PersonID.ToString();
            FindNow();
        }

        public void FindNow()
        {
            bool PersonIsFound = false;

            byte SelectIndex = (byte)cmbbFindBy.SelectedIndex;

            if (SelectIndex == 0)
            {
                if ((int.TryParse(txtbSearsh.Text , out int x)))
                {
                    PersonIsFound = clsPerson.PersonIsExist(Convert.ToInt32(txtbSearsh.Text));

                    if (PersonIsFound)
                    {
                        usctrlInfoCard1.LoadPersonInfo(Convert.ToInt32(txtbSearsh.Text));
                        _HasPersonInfo = true;
                    }
                    else
                    {
                        usctrlInfoCard1.SetDefault();
                        MessageBox.Show($"Person with {txtbSearsh.Text} is Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {               
                    MessageBox.Show("Value is not Correct, Try to Find by NationalNo");

                   
                }
            }
            else if(SelectIndex == 1)
            {
                PersonIsFound = clsPerson.PersonIsExist(txtbSearsh.Text.ToString());

                if (PersonIsFound)
                {
                    usctrlInfoCard1.LoadPersonInfo(txtbSearsh.Text.ToString());
                    _HasPersonInfo = true;
                }
                else
                {
                    usctrlInfoCard1.SetDefault();
                    MessageBox.Show($"Person with {txtbSearsh.Text} is Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            } 

            if (OnPersonSelected != null )
            {
                OnPersonSelected(usctrlInfoCard1.PersonID);
            }

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_Update_Person AddNewPersonForm = new Add_Update_Person();
            AddNewPersonForm.DataBack += DataBackEnvent;
            AddNewPersonForm.ShowDialog();
        }

        private void DataBackEnvent(object sender , int PersonID)
        {
            txtbSearsh.Text = PersonID.ToString();
            usctrlInfoCard1.LoadPersonInfo(PersonID);
        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (txtbSearsh.Text != string.Empty)
            {
                FindNow();
            }
        }

        private void txtbSearsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFindPerson.PerformClick();
            }
        }

        private void usctrlInfoCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
