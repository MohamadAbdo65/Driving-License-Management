namespace DVLD_Manage
{
    partial class ManagePeople
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvPeopleData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mnustPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbSearsh = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalPeople = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddNewPerson = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCloseApp = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleData)).BeginInit();
            this.mnustPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(440, 110);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(233, 34);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Manage People";
            // 
            // dgvPeopleData
            // 
            this.dgvPeopleData.AllowUserToAddRows = false;
            this.dgvPeopleData.AllowUserToDeleteRows = false;
            this.dgvPeopleData.AllowUserToResizeColumns = false;
            this.dgvPeopleData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeopleData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeopleData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeopleData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeopleData.ColumnHeadersHeight = 27;
            this.dgvPeopleData.ContextMenuStrip = this.mnustPerson;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeopleData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeopleData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvPeopleData.Location = new System.Drawing.Point(12, 198);
            this.dgvPeopleData.MultiSelect = false;
            this.dgvPeopleData.Name = "dgvPeopleData";
            this.dgvPeopleData.ReadOnly = true;
            this.dgvPeopleData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPeopleData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeopleData.Size = new System.Drawing.Size(1097, 374);
            this.dgvPeopleData.TabIndex = 6;
            this.dgvPeopleData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPeopleData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPeopleData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPeopleData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPeopleData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvPeopleData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.dgvPeopleData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPeopleData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeopleData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPeopleData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPeopleData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeopleData.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvPeopleData.ThemeStyle.ReadOnly = true;
            this.dgvPeopleData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPeopleData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeopleData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvPeopleData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPeopleData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPeopleData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPeopleData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mnustPerson
            // 
            this.mnustPerson.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnustPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailesToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.mnustPerson.Name = "mnustPerson";
            this.mnustPerson.Size = new System.Drawing.Size(164, 120);
            // 
            // showDetailesToolStripMenuItem
            // 
            this.showDetailesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showDetailesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetailesToolStripMenuItem.Image")));
            this.showDetailesToolStripMenuItem.Name = "showDetailesToolStripMenuItem";
            this.showDetailesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showDetailesToolStripMenuItem.Text = "Show Detailes";
            this.showDetailesToolStripMenuItem.Click += new System.EventHandler(this.showDetailesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.phoneCallToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 103);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(108, 25);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Filter By : ";
            // 
            // cmbbFilterBy
            // 
            this.cmbbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cmbbFilterBy.BorderRadius = 15;
            this.cmbbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbFilterBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cmbbFilterBy.ItemHeight = 30;
            this.cmbbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "National No",
            "Gender",
            "Phone ",
            "Email"});
            this.cmbbFilterBy.Location = new System.Drawing.Point(136, 99);
            this.cmbbFilterBy.Name = "cmbbFilterBy";
            this.cmbbFilterBy.ShadowDecoration.BorderRadius = 15;
            this.cmbbFilterBy.ShadowDecoration.Depth = 10;
            this.cmbbFilterBy.ShadowDecoration.Enabled = true;
            this.cmbbFilterBy.Size = new System.Drawing.Size(143, 36);
            this.cmbbFilterBy.StartIndex = 0;
            this.cmbbFilterBy.TabIndex = 10;
            this.cmbbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbbFilterBy_SelectedIndexChanged);
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
            this.txtbSearsh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbSearsh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearsh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearsh.ForeColor = System.Drawing.Color.White;
            this.txtbSearsh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearsh.Location = new System.Drawing.Point(22, 146);
            this.txtbSearsh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbSearsh.Name = "txtbSearsh";
            this.txtbSearsh.PasswordChar = '\0';
            this.txtbSearsh.PlaceholderText = "";
            this.txtbSearsh.SelectedText = "";
            this.txtbSearsh.ShadowDecoration.BorderRadius = 15;
            this.txtbSearsh.ShadowDecoration.Depth = 10;
            this.txtbSearsh.ShadowDecoration.Enabled = true;
            this.txtbSearsh.Size = new System.Drawing.Size(257, 36);
            this.txtbSearsh.TabIndex = 11;
            this.txtbSearsh.Visible = false;
            this.txtbSearsh.TextChanged += new System.EventHandler(this.txtbSearsh_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(811, 152);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(163, 27);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Total People :";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPeople.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPeople.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalPeople.Location = new System.Drawing.Point(996, 152);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(19, 27);
            this.lblTotalPeople.TabIndex = 13;
            this.lblTotalPeople.Text = "X";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Animated = true;
            this.btnAddNewPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPerson.FillColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewPerson.Image")));
            this.btnAddNewPerson.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewPerson.Location = new System.Drawing.Point(1055, 136);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewPerson.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewPerson.TabIndex = 8;
            this.btnAddNewPerson.Tag = "-1";
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCloseApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCloseApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCloseApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = global::DVLD_Manage.Properties.Resources.icons8_close_25;
            this.btnCloseApp.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCloseApp.Location = new System.Drawing.Point(1074, 12);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(35, 35);
            this.btnCloseApp.TabIndex = 14;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click_1);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1121, 582);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.lblTotalPeople);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtbSearsh);
            this.Controls.Add(this.cmbbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.dgvPeopleData);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List People";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleData)).EndInit();
            this.mnustPerson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPeopleData;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNewPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearsh;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalPeople;
        private System.Windows.Forms.ContextMenuStrip mnustPerson;
        private System.Windows.Forms.ToolStripMenuItem showDetailesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnCloseApp;
    }
}