namespace DVLD_Manage
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalUsers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvUsersData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cnmstpUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetaileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbSearsh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbbActiveFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).BeginInit();
            this.cnmstpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(452, 110);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(215, 34);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Manage Users";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUsers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTotalUsers.Location = new System.Drawing.Point(996, 152);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(19, 27);
            this.lblTotalUsers.TabIndex = 16;
            this.lblTotalUsers.Text = "X";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(811, 152);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(149, 27);
            this.guna2HtmlLabel3.TabIndex = 15;
            this.guna2HtmlLabel3.Text = "Total Users :";
            // 
            // dgvUsersData
            // 
            this.dgvUsersData.AllowUserToAddRows = false;
            this.dgvUsersData.AllowUserToDeleteRows = false;
            this.dgvUsersData.AllowUserToResizeColumns = false;
            this.dgvUsersData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsersData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsersData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersData.ColumnHeadersHeight = 27;
            this.dgvUsersData.ContextMenuStrip = this.cnmstpUsers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersData.Location = new System.Drawing.Point(12, 198);
            this.dgvUsersData.MultiSelect = false;
            this.dgvUsersData.Name = "dgvUsersData";
            this.dgvUsersData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUsersData.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsersData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsersData.Size = new System.Drawing.Size(1097, 374);
            this.dgvUsersData.TabIndex = 17;
            this.dgvUsersData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsersData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsersData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsersData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsersData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvUsersData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsersData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsersData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsersData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsersData.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvUsersData.ThemeStyle.ReadOnly = true;
            this.dgvUsersData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvUsersData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsersData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsersData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cnmstpUsers
            // 
            this.cnmstpUsers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnmstpUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetaileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cnmstpUsers.Name = "contextMenuStrip1";
            this.cnmstpUsers.Size = new System.Drawing.Size(185, 142);
            // 
            // showDetaileToolStripMenuItem
            // 
            this.showDetaileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showDetaileToolStripMenuItem.Image")));
            this.showDetaileToolStripMenuItem.Name = "showDetaileToolStripMenuItem";
            this.showDetaileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showDetaileToolStripMenuItem.Text = "Show Detailes";
            this.showDetaileToolStripMenuItem.Click += new System.EventHandler(this.showDetaileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
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
            this.txtbSearsh.TabIndex = 20;
            this.txtbSearsh.Visible = false;
            this.txtbSearsh.TextChanged += new System.EventHandler(this.txtbSearsh_TextChanged);
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
            "User ID",
            "Person ID",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Username",
            "IsActive"});
            this.cmbbFilterBy.Location = new System.Drawing.Point(136, 99);
            this.cmbbFilterBy.Name = "cmbbFilterBy";
            this.cmbbFilterBy.ShadowDecoration.BorderRadius = 15;
            this.cmbbFilterBy.ShadowDecoration.Depth = 10;
            this.cmbbFilterBy.ShadowDecoration.Enabled = true;
            this.cmbbFilterBy.Size = new System.Drawing.Size(143, 36);
            this.cmbbFilterBy.StartIndex = 0;
            this.cmbbFilterBy.TabIndex = 19;
            this.cmbbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cmbbFilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 103);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(108, 25);
            this.guna2HtmlLabel2.TabIndex = 18;
            this.guna2HtmlLabel2.Text = "Filter By : ";
            // 
            // cmbbActiveFilter
            // 
            this.cmbbActiveFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbbActiveFilter.BorderRadius = 15;
            this.cmbbActiveFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbActiveFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbActiveFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cmbbActiveFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbActiveFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbActiveFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbActiveFilter.ForeColor = System.Drawing.Color.White;
            this.cmbbActiveFilter.ItemHeight = 30;
            this.cmbbActiveFilter.Items.AddRange(new object[] {
            "None",
            "Active",
            "Not Active"});
            this.cmbbActiveFilter.Location = new System.Drawing.Point(22, 146);
            this.cmbbActiveFilter.Name = "cmbbActiveFilter";
            this.cmbbActiveFilter.ShadowDecoration.BorderRadius = 15;
            this.cmbbActiveFilter.ShadowDecoration.Depth = 10;
            this.cmbbActiveFilter.ShadowDecoration.Enabled = true;
            this.cmbbActiveFilter.Size = new System.Drawing.Size(257, 36);
            this.cmbbActiveFilter.StartIndex = 0;
            this.cmbbActiveFilter.TabIndex = 21;
            this.cmbbActiveFilter.Visible = false;
            this.cmbbActiveFilter.SelectedIndexChanged += new System.EventHandler(this.cmbbActiveFilter_SelectedIndexChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Animated = true;
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.White;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewUser.Image")));
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(60, 60);
            this.btnAddNewUser.Location = new System.Drawing.Point(1055, 136);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewUser.Size = new System.Drawing.Size(50, 50);
            this.btnAddNewUser.TabIndex = 14;
            this.btnAddNewUser.Tag = "-1";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1121, 582);
            this.Controls.Add(this.cmbbActiveFilter);
            this.Controls.Add(this.txtbSearsh);
            this.Controls.Add(this.cmbbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dgvUsersData);
            this.Controls.Add(this.lblTotalUsers);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUsers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Users";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersData)).EndInit();
            this.cnmstpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNewUser;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersData;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearsh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbActiveFilter;
        private System.Windows.Forms.ContextMenuStrip cnmstpUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetaileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}