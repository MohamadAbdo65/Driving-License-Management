namespace DVLD_Manage.ClassManageDrivers
{
    partial class frmManageDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDrivers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDriversData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cnmstpDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowPersonLicenseHisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalDrivers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbSearsh = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversData)).BeginInit();
            this.cnmstpDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.BurlyWood;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(441, 110);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(239, 34);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDriversData
            // 
            this.dgvDriversData.AllowUserToAddRows = false;
            this.dgvDriversData.AllowUserToDeleteRows = false;
            this.dgvDriversData.AllowUserToResizeColumns = false;
            this.dgvDriversData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDriversData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDriversData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriversData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDriversData.ColumnHeadersHeight = 27;
            this.dgvDriversData.ContextMenuStrip = this.cnmstpDrivers;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDriversData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDriversData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDriversData.Location = new System.Drawing.Point(12, 196);
            this.dgvDriversData.MultiSelect = false;
            this.dgvDriversData.Name = "dgvDriversData";
            this.dgvDriversData.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDriversData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDriversData.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDriversData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDriversData.Size = new System.Drawing.Size(1097, 374);
            this.dgvDriversData.TabIndex = 18;
            this.dgvDriversData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDriversData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDriversData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDriversData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDriversData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDriversData.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dgvDriversData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDriversData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDriversData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDriversData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDriversData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDriversData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDriversData.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvDriversData.ThemeStyle.ReadOnly = true;
            this.dgvDriversData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDriversData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDriversData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvDriversData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDriversData.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDriversData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDriversData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cnmstpDrivers
            // 
            this.cnmstpDrivers.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnmstpDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowPersonInfoToolStripMenuItem,
            this.ShowPersonLicenseHisToolStripMenuItem});
            this.cnmstpDrivers.Name = "contextMenuStrip1";
            this.cnmstpDrivers.Size = new System.Drawing.Size(254, 48);
            // 
            // ShowPersonInfoToolStripMenuItem
            // 
            this.ShowPersonInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonInfoToolStripMenuItem.Image")));
            this.ShowPersonInfoToolStripMenuItem.Name = "ShowPersonInfoToolStripMenuItem";
            this.ShowPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ShowPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.ShowPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonInfoToolStripMenuItem_Click);
            // 
            // ShowPersonLicenseHisToolStripMenuItem
            // 
            this.ShowPersonLicenseHisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowPersonLicenseHisToolStripMenuItem.Image")));
            this.ShowPersonLicenseHisToolStripMenuItem.Name = "ShowPersonLicenseHisToolStripMenuItem";
            this.ShowPersonLicenseHisToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ShowPersonLicenseHisToolStripMenuItem.Text = "Show Person License History";
            this.ShowPersonLicenseHisToolStripMenuItem.Click += new System.EventHandler(this.ShowPersonLicenseHisToolStripMenuItem_Click);
            // 
            // lblTotalDrivers
            // 
            this.lblTotalDrivers.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDrivers.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDrivers.ForeColor = System.Drawing.Color.BurlyWood;
            this.lblTotalDrivers.Location = new System.Drawing.Point(1072, 150);
            this.lblTotalDrivers.Name = "lblTotalDrivers";
            this.lblTotalDrivers.Size = new System.Drawing.Size(18, 27);
            this.lblTotalDrivers.TabIndex = 21;
            this.lblTotalDrivers.Text = "0";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.BurlyWood;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(895, 149);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(168, 27);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "Total Drivers :";
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
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cmbbFilterBy.Location = new System.Drawing.Point(129, 94);
            this.cmbbFilterBy.Name = "cmbbFilterBy";
            this.cmbbFilterBy.ShadowDecoration.BorderRadius = 15;
            this.cmbbFilterBy.ShadowDecoration.Depth = 10;
            this.cmbbFilterBy.ShadowDecoration.Enabled = true;
            this.cmbbFilterBy.Size = new System.Drawing.Size(143, 36);
            this.cmbbFilterBy.StartIndex = 0;
            this.cmbbFilterBy.TabIndex = 23;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.BurlyWood;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 98);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(108, 25);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "Filter By : ";
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
            this.txtbSearsh.Location = new System.Drawing.Point(14, 145);
            this.txtbSearsh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbSearsh.Name = "txtbSearsh";
            this.txtbSearsh.PasswordChar = '\0';
            this.txtbSearsh.PlaceholderText = "";
            this.txtbSearsh.SelectedText = "";
            this.txtbSearsh.ShadowDecoration.BorderRadius = 15;
            this.txtbSearsh.ShadowDecoration.Depth = 10;
            this.txtbSearsh.ShadowDecoration.Enabled = true;
            this.txtbSearsh.Size = new System.Drawing.Size(257, 36);
            this.txtbSearsh.TabIndex = 24;
            this.txtbSearsh.TextChanged += new System.EventHandler(this.txtbSearsh_TextChanged);
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1121, 582);
            this.Controls.Add(this.txtbSearsh);
            this.Controls.Add(this.cmbbFilterBy);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lblTotalDrivers);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.dgvDriversData);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageDrivers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Drivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriversData)).EndInit();
            this.cnmstpDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDriversData;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalDrivers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbFilterBy;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearsh;
        private System.Windows.Forms.ContextMenuStrip cnmstpDrivers;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowPersonLicenseHisToolStripMenuItem;
    }
}