namespace DVLD_Manage.ClassApplications.Detain_Licenses.ManageDetainedLicenses
{
    partial class frmManageDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainedLicense));
            this.dgvDetainLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetain = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnRelease = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblTotalLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbSearsh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetainLicenses
            // 
            this.dgvDetainLicenses.AllowUserToAddRows = false;
            this.dgvDetainLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainLicenses.AllowUserToResizeColumns = false;
            this.dgvDetainLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainLicenses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainLicenses.ColumnHeadersHeight = 27;
            this.dgvDetainLicenses.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainLicenses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainLicenses.Location = new System.Drawing.Point(12, 196);
            this.dgvDetainLicenses.MultiSelect = false;
            this.dgvDetainLicenses.Name = "dgvDetainLicenses";
            this.dgvDetainLicenses.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetainLicenses.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainLicenses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetainLicenses.Size = new System.Drawing.Size(1097, 374);
            this.dgvDetainLicenses.TabIndex = 19;
            this.dgvDetainLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetainLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetainLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetainLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetainLicenses.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvDetainLicenses.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainLicenses.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvDetainLicenses.ThemeStyle.ReadOnly = true;
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetainLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(320, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showPersonInfoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonInfoToolStripMenuItem.Image")));
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.showLicenseInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLicenseInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseInfoToolStripMenuItem.Image")));
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.showPersonLicensesHistoryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.showPersonLicensesHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonLicensesHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicensesHistoryToolStripMenuItem.Image")));
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            this.showPersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(316, 6);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.releaseLicenseToolStripMenuItem.Enabled = false;
            this.releaseLicenseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.releaseLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.releaseLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseLicenseToolStripMenuItem.Image")));
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(399, 120);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(323, 34);
            this.guna2HtmlLabel1.TabIndex = 23;
            this.guna2HtmlLabel1.Text = "List Detained License";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetain
            // 
            this.btnDetain.BorderRadius = 12;
            this.btnDetain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetain.FillColor = System.Drawing.Color.Red;
            this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDetain.Location = new System.Drawing.Point(1059, 136);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(50, 50);
            this.btnDetain.TabIndex = 24;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BorderRadius = 12;
            this.btnRelease.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRelease.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRelease.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRelease.FillColor = System.Drawing.Color.Lime;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRelease.ForeColor = System.Drawing.Color.White;
            this.btnRelease.Image = ((System.Drawing.Image)(resources.GetObject("btnRelease.Image")));
            this.btnRelease.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRelease.Location = new System.Drawing.Point(992, 136);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(50, 50);
            this.btnRelease.TabIndex = 25;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // lblTotalLicense
            // 
            this.lblTotalLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalLicense.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLicense.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTotalLicense.Location = new System.Drawing.Point(1089, 18);
            this.lblTotalLicense.Name = "lblTotalLicense";
            this.lblTotalLicense.Size = new System.Drawing.Size(18, 27);
            this.lblTotalLicense.TabIndex = 27;
            this.lblTotalLicense.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(912, 18);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(168, 27);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Total Drivers :";
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
            this.txtbSearsh.Location = new System.Drawing.Point(13, 144);
            this.txtbSearsh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbSearsh.Name = "txtbSearsh";
            this.txtbSearsh.PasswordChar = '\0';
            this.txtbSearsh.PlaceholderText = "";
            this.txtbSearsh.SelectedText = "";
            this.txtbSearsh.ShadowDecoration.BorderRadius = 15;
            this.txtbSearsh.ShadowDecoration.Depth = 10;
            this.txtbSearsh.ShadowDecoration.Enabled = true;
            this.txtbSearsh.Size = new System.Drawing.Size(257, 36);
            this.txtbSearsh.TabIndex = 30;
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
            this.cmbbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.cmbbFilterBy.ForeColor = System.Drawing.Color.White;
            this.cmbbFilterBy.ItemHeight = 30;
            this.cmbbFilterBy.Items.AddRange(new object[] {
            "Detain ID",
            "License ID",
            "Created By User ID",
            "Is Released",
            "Full Name",
            "National No"});
            this.cmbbFilterBy.Location = new System.Drawing.Point(128, 93);
            this.cmbbFilterBy.Name = "cmbbFilterBy";
            this.cmbbFilterBy.ShadowDecoration.BorderRadius = 15;
            this.cmbbFilterBy.ShadowDecoration.Depth = 10;
            this.cmbbFilterBy.ShadowDecoration.Enabled = true;
            this.cmbbFilterBy.Size = new System.Drawing.Size(143, 36);
            this.cmbbFilterBy.StartIndex = 0;
            this.cmbbFilterBy.TabIndex = 29;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 92);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(115, 33);
            this.guna2HtmlLabel2.TabIndex = 28;
            this.guna2HtmlLabel2.Text = "Filter By : ";
            // 
            // frmManageDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1121, 582);
            this.Controls.Add(this.txtbSearsh);
            this.Controls.Add(this.cmbbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblTotalLicense);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDetainLicenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDetainedLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Detained License";
            this.Load += new System.EventHandler(this.frmManageDetainedLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainLicenses;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton btnDetain;
        private Guna.UI2.WinForms.Guna2TileButton btnRelease;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearsh;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}