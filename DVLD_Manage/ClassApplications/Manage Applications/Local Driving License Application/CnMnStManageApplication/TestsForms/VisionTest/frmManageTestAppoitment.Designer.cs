namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest
{
    partial class frmManageTestAppoitment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestAppoitment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picbTestTypePic = new System.Windows.Forms.PictureBox();
            this.lblTestTypeTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNewTestAppointment = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mnustTestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumberOfAppointment = new System.Windows.Forms.Label();
            this.usctrlLDLApp_BaseApp_Info1 = new DVLD_Manage.usctrlLDLApp_BaseApp_Info();
            ((System.ComponentModel.ISupportInitialize)(this.picbTestTypePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.mnustTestAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbTestTypePic
            // 
            this.picbTestTypePic.Image = ((System.Drawing.Image)(resources.GetObject("picbTestTypePic.Image")));
            this.picbTestTypePic.Location = new System.Drawing.Point(955, -1);
            this.picbTestTypePic.Name = "picbTestTypePic";
            this.picbTestTypePic.Size = new System.Drawing.Size(90, 90);
            this.picbTestTypePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbTestTypePic.TabIndex = 0;
            this.picbTestTypePic.TabStop = false;
            // 
            // lblTestTypeTitle
            // 
            this.lblTestTypeTitle.AutoSize = true;
            this.lblTestTypeTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTypeTitle.ForeColor = System.Drawing.Color.White;
            this.lblTestTypeTitle.Location = new System.Drawing.Point(833, 103);
            this.lblTestTypeTitle.Name = "lblTestTypeTitle";
            this.lblTestTypeTitle.Size = new System.Drawing.Size(317, 37);
            this.lblTestTypeTitle.TabIndex = 1;
            this.lblTestTypeTitle.Text = "Type Test Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(703, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 423);
            this.panel1.TabIndex = 3;
            // 
            // btnAddNewTestAppointment
            // 
            this.btnAddNewTestAppointment.Animated = true;
            this.btnAddNewTestAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewTestAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTestAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewTestAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewTestAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewTestAppointment.FillColor = System.Drawing.Color.White;
            this.btnAddNewTestAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewTestAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTestAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTestAppointment.Image")));
            this.btnAddNewTestAppointment.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddNewTestAppointment.Location = new System.Drawing.Point(1232, 204);
            this.btnAddNewTestAppointment.Name = "btnAddNewTestAppointment";
            this.btnAddNewTestAppointment.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddNewTestAppointment.Size = new System.Drawing.Size(35, 35);
            this.btnAddNewTestAppointment.TabIndex = 18;
            this.btnAddNewTestAppointment.Tag = "-1";
            this.btnAddNewTestAppointment.Click += new System.EventHandler(this.btnAddNewTestAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(721, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Appointment :";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeight = 27;
            this.dgvAppointments.ContextMenuStrip = this.mnustTestAppointment;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.Location = new System.Drawing.Point(726, 249);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.Size = new System.Drawing.Size(550, 199);
            this.dgvAppointments.TabIndex = 20;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAppointments.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointments.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvAppointments.ThemeStyle.ReadOnly = true;
            this.dgvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // mnustTestAppointment
            // 
            this.mnustTestAppointment.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnustTestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.TakeTest});
            this.mnustTestAppointment.Name = "mnustPerson";
            this.mnustTestAppointment.Size = new System.Drawing.Size(136, 54);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // TakeTest
            // 
            this.TakeTest.Image = ((System.Drawing.Image)(resources.GetObject("TakeTest.Image")));
            this.TakeTest.Name = "TakeTest";
            this.TakeTest.Size = new System.Drawing.Size(135, 22);
            this.TakeTest.Text = "Take Test";
            this.TakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // lblNumberOfAppointment
            // 
            this.lblNumberOfAppointment.AutoSize = true;
            this.lblNumberOfAppointment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAppointment.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfAppointment.Location = new System.Drawing.Point(1186, 204);
            this.lblNumberOfAppointment.Name = "lblNumberOfAppointment";
            this.lblNumberOfAppointment.Size = new System.Drawing.Size(28, 32);
            this.lblNumberOfAppointment.TabIndex = 21;
            this.lblNumberOfAppointment.Text = "0";
            // 
            // usctrlLDLApp_BaseApp_Info1
            // 
            this.usctrlLDLApp_BaseApp_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlLDLApp_BaseApp_Info1.Location = new System.Drawing.Point(3, 16);
            this.usctrlLDLApp_BaseApp_Info1.Name = "usctrlLDLApp_BaseApp_Info1";
            this.usctrlLDLApp_BaseApp_Info1.Size = new System.Drawing.Size(692, 437);
            this.usctrlLDLApp_BaseApp_Info1.TabIndex = 2;
            // 
            // frmManageTestAppoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1288, 466);
            this.Controls.Add(this.lblNumberOfAppointment);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewTestAppointment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.usctrlLDLApp_BaseApp_Info1);
            this.Controls.Add(this.lblTestTypeTitle);
            this.Controls.Add(this.picbTestTypePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageTestAppoitment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Test Appointment";
            this.Load += new System.EventHandler(this.frmTestAppoitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbTestTypePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.mnustTestAppointment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbTestTypePic;
        private System.Windows.Forms.Label lblTestTypeTitle;
        private usctrlLDLApp_BaseApp_Info usctrlLDLApp_BaseApp_Info1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddNewTestAppointment;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblNumberOfAppointment;
        private System.Windows.Forms.ContextMenuStrip mnustTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TakeTest;
    }
}