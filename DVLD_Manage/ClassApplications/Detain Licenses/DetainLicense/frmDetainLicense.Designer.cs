namespace DVLD_Manage.ClassApplications.Detain_Licenses.DetainLicense
{
    partial class frmDetainLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usctrlDriverlicenseInfoWithFilter1 = new DVLD_Manage.UserControls.usctrlDriverlicenseInfoWithFilter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.txtbFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowLicenseHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowLicenseInfo = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // usctrlDriverlicenseInfoWithFilter1
            // 
            this.usctrlDriverlicenseInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlDriverlicenseInfoWithFilter1.FilterEnabled = true;
            this.usctrlDriverlicenseInfoWithFilter1.Location = new System.Drawing.Point(4, 47);
            this.usctrlDriverlicenseInfoWithFilter1.Name = "usctrlDriverlicenseInfoWithFilter1";
            this.usctrlDriverlicenseInfoWithFilter1.Size = new System.Drawing.Size(842, 476);
            this.usctrlDriverlicenseInfoWithFilter1.TabIndex = 5;
            this.usctrlDriverlicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.usctrlDriverlicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(297, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detain License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(9, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detain ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(396, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "License ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(9, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Detain Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCyan;
            this.label5.Location = new System.Drawing.Point(396, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Created By :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCyan;
            this.label6.Location = new System.Drawing.Point(9, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fine Fees :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 577);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(126, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(531, 577);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(20, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 38;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(523, 529);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(20, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 39;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(130, 529);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 40;
            this.pictureBox7.TabStop = false;
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.White;
            this.lblDetainID.Location = new System.Drawing.Point(153, 526);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(22, 28);
            this.lblDetainID.TabIndex = 41;
            this.lblDetainID.Text = "?";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.White;
            this.lblDetainDate.Location = new System.Drawing.Point(179, 573);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(22, 28);
            this.lblDetainDate.TabIndex = 42;
            this.lblDetainDate.Text = "?";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.White;
            this.lblLicenseID.Location = new System.Drawing.Point(546, 525);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(22, 28);
            this.lblLicenseID.TabIndex = 44;
            this.lblLicenseID.Text = "?";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lblCreatedBy.Location = new System.Drawing.Point(554, 573);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(22, 28);
            this.lblCreatedBy.TabIndex = 45;
            this.lblCreatedBy.Text = "?";
            // 
            // txtbFees
            // 
            this.txtbFees.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtbFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbFees.DefaultText = "";
            this.txtbFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbFees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFees.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFees.ForeColor = System.Drawing.Color.White;
            this.txtbFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbFees.Location = new System.Drawing.Point(163, 619);
            this.txtbFees.Name = "txtbFees";
            this.txtbFees.PasswordChar = '\0';
            this.txtbFees.PlaceholderText = "";
            this.txtbFees.SelectedText = "";
            this.txtbFees.Size = new System.Drawing.Size(423, 32);
            this.txtbFees.TabIndex = 46;
            // 
            // btnShowLicenseHistory
            // 
            this.btnShowLicenseHistory.Animated = true;
            this.btnShowLicenseHistory.BorderRadius = 10;
            this.btnShowLicenseHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowLicenseHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowLicenseHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowLicenseHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowLicenseHistory.Enabled = false;
            this.btnShowLicenseHistory.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnShowLicenseHistory.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicenseHistory.ForeColor = System.Drawing.Color.White;
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(16, 676);
            this.btnShowLicenseHistory.Name = "btnShowLicenseHistory";
            this.btnShowLicenseHistory.Size = new System.Drawing.Size(170, 34);
            this.btnShowLicenseHistory.TabIndex = 49;
            this.btnShowLicenseHistory.Text = "Show Licenses History";
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Animated = true;
            this.btnDetain.BorderRadius = 10;
            this.btnDetain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetain.Enabled = false;
            this.btnDetain.FillColor = System.Drawing.Color.LightGray;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.Black;
            this.btnDetain.Image = ((System.Drawing.Image)(resources.GetObject("btnDetain.Image")));
            this.btnDetain.Location = new System.Drawing.Point(673, 676);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(141, 34);
            this.btnDetain.TabIndex = 48;
            this.btnDetain.Text = "Detain";
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.Animated = true;
            this.btnShowLicenseInfo.BorderRadius = 10;
            this.btnShowLicenseInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowLicenseInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowLicenseInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowLicenseInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(203, 676);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(142, 34);
            this.btnShowLicenseInfo.TabIndex = 47;
            this.btnShowLicenseInfo.Text = "Show License Info";
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(848, 724);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.txtbFees);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblLicenseID);
            this.Controls.Add(this.lblDetainDate);
            this.Controls.Add(this.lblDetainID);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usctrlDriverlicenseInfoWithFilter1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.usctrlDriverlicenseInfoWithFilter usctrlDriverlicenseInfoWithFilter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblCreatedBy;
        private Guna.UI2.WinForms.Guna2TextBox txtbFees;
        private Guna.UI2.WinForms.Guna2Button btnShowLicenseHistory;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private Guna.UI2.WinForms.Guna2Button btnShowLicenseInfo;
    }
}