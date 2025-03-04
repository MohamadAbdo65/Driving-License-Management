namespace DVLD_Manage
{
    partial class usctrlInfoCardWithFind
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usctrlInfoCardWithFind));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbSearsh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbbFindBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnFindPerson = new Guna.UI2.WinForms.Guna2CircleButton();
            this.grpxFind = new System.Windows.Forms.GroupBox();
            this.usctrlInfoCard1 = new DVLD_Manage.usctrlInfoCard();
            this.grpxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 19);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(88, 30);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Find By : ";
            // 
            // txtbSearsh
            // 
            this.txtbSearsh.BackColor = System.Drawing.Color.Transparent;
            this.txtbSearsh.BorderRadius = 15;
            this.txtbSearsh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearsh.DefaultText = "";
            this.txtbSearsh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSearsh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSearsh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearsh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearsh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.txtbSearsh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearsh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearsh.ForeColor = System.Drawing.Color.White;
            this.txtbSearsh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearsh.Location = new System.Drawing.Point(259, 16);
            this.txtbSearsh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbSearsh.Name = "txtbSearsh";
            this.txtbSearsh.PasswordChar = '\0';
            this.txtbSearsh.PlaceholderText = "";
            this.txtbSearsh.SelectedText = "";
            this.txtbSearsh.ShadowDecoration.BorderRadius = 15;
            this.txtbSearsh.ShadowDecoration.Depth = 10;
            this.txtbSearsh.ShadowDecoration.Enabled = true;
            this.txtbSearsh.Size = new System.Drawing.Size(257, 36);
            this.txtbSearsh.TabIndex = 22;
            this.txtbSearsh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbSearsh_KeyPress);
            // 
            // cmbbFindBy
            // 
            this.cmbbFindBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbbFindBy.BorderRadius = 15;
            this.cmbbFindBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbFindBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cmbbFindBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbFindBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbFindBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbFindBy.ForeColor = System.Drawing.Color.White;
            this.cmbbFindBy.ItemHeight = 30;
            this.cmbbFindBy.Items.AddRange(new object[] {
            "Person ID",
            "National NO"});
            this.cmbbFindBy.Location = new System.Drawing.Point(119, 16);
            this.cmbbFindBy.Name = "cmbbFindBy";
            this.cmbbFindBy.ShadowDecoration.BorderRadius = 15;
            this.cmbbFindBy.ShadowDecoration.Depth = 10;
            this.cmbbFindBy.ShadowDecoration.Enabled = true;
            this.cmbbFindBy.Size = new System.Drawing.Size(121, 36);
            this.cmbbFindBy.StartIndex = 0;
            this.cmbbFindBy.TabIndex = 21;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Animated = true;
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(43, 43);
            this.btnAddNewPerson.Location = new System.Drawing.Point(614, 19);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewPerson.Size = new System.Drawing.Size(35, 35);
            this.btnAddNewPerson.TabIndex = 23;
            this.btnAddNewPerson.Tag = "-1";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Animated = true;
            this.btnFindPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnFindPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindPerson.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFindPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindPerson.ForeColor = System.Drawing.Color.White;
            this.btnFindPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnFindPerson.Image")));
            this.btnFindPerson.ImageSize = new System.Drawing.Size(35, 35);
            this.btnFindPerson.Location = new System.Drawing.Point(543, 17);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnFindPerson.Size = new System.Drawing.Size(35, 35);
            this.btnFindPerson.TabIndex = 24;
            this.btnFindPerson.Tag = "-1";
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // grpxFind
            // 
            this.grpxFind.Controls.Add(this.guna2HtmlLabel1);
            this.grpxFind.Controls.Add(this.btnAddNewPerson);
            this.grpxFind.Controls.Add(this.btnFindPerson);
            this.grpxFind.Controls.Add(this.cmbbFindBy);
            this.grpxFind.Controls.Add(this.txtbSearsh);
            this.grpxFind.Location = new System.Drawing.Point(3, 3);
            this.grpxFind.Name = "grpxFind";
            this.grpxFind.Size = new System.Drawing.Size(713, 65);
            this.grpxFind.TabIndex = 26;
            this.grpxFind.TabStop = false;
            // 
            // usctrlInfoCard1
            // 
            this.usctrlInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlInfoCard1.Location = new System.Drawing.Point(-1, 74);
            this.usctrlInfoCard1.Name = "usctrlInfoCard1";
            this.usctrlInfoCard1.Size = new System.Drawing.Size(730, 233);
            this.usctrlInfoCard1.TabIndex = 27;
            // 
            // usctrlInfoCardWithFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.usctrlInfoCard1);
            this.Controls.Add(this.grpxFind);
            this.Name = "usctrlInfoCardWithFind";
            this.Size = new System.Drawing.Size(729, 307);
            this.Load += new System.EventHandler(this.usctrlInfoCardWithFind_Load);
            this.grpxFind.ResumeLayout(false);
            this.grpxFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearsh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbFindBy;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNewPerson;
        private Guna.UI2.WinForms.Guna2CircleButton btnFindPerson;
        private System.Windows.Forms.GroupBox grpxFind;
        private usctrlInfoCard usctrlInfoCard1;
    }
}
