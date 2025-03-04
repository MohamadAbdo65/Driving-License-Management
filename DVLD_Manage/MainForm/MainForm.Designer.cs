using System.Diagnostics;

namespace DVLD_Manage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.elLicense = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLicense = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberOfActiveLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNumberOfLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.applicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLinceceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamageLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainDrivingLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loacalDrivingLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicansesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationsTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gfgfToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlBaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlApplications = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberOfNewApplication = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNumberOfApplication = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlDetainLicense = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberOfRealesedLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNumberOfDetainLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlDrivers = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberOfDrivers = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlInternationalLicense = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberOfInternationalLicense = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.elApplication = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elDetain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elDrivers = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elInternational = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlLicense.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.pnlApplications.SuspendLayout();
            this.pnlDetainLicense.SuspendLayout();
            this.pnlDrivers.SuspendLayout();
            this.pnlInternationalLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // elLicense
            // 
            this.elLicense.BorderRadius = 25;
            this.elLicense.TargetControl = this.pnlLicense;
            // 
            // pnlLicense
            // 
            this.pnlLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlLicense.BorderRadius = 20;
            this.pnlLicense.Controls.Add(this.lblNumberOfActiveLicense);
            this.pnlLicense.Controls.Add(this.lblNumberOfLicense);
            this.pnlLicense.Controls.Add(this.guna2HtmlLabel1);
            this.pnlLicense.Location = new System.Drawing.Point(12, 463);
            this.pnlLicense.Name = "pnlLicense";
            this.pnlLicense.Size = new System.Drawing.Size(200, 170);
            this.pnlLicense.TabIndex = 3;
            // 
            // lblNumberOfActiveLicense
            // 
            this.lblNumberOfActiveLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfActiveLicense.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfActiveLicense.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfActiveLicense.Location = new System.Drawing.Point(20, 119);
            this.lblNumberOfActiveLicense.Name = "lblNumberOfActiveLicense";
            this.lblNumberOfActiveLicense.Size = new System.Drawing.Size(76, 27);
            this.lblNumberOfActiveLicense.TabIndex = 2;
            this.lblNumberOfActiveLicense.Text = "0 Active";
            // 
            // lblNumberOfLicense
            // 
            this.lblNumberOfLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfLicense.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLicense.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfLicense.Location = new System.Drawing.Point(20, 66);
            this.lblNumberOfLicense.Name = "lblNumberOfLicense";
            this.lblNumberOfLicense.Size = new System.Drawing.Size(17, 33);
            this.lblNumberOfLicense.TabIndex = 1;
            this.lblNumberOfLicense.Text = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(80, 27);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Licenses";
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.AutoSize = false;
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem,
            this.ControlBaxToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.ShowItemToolTips = true;
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1127, 60);
            this.MainFormMenuStrip.TabIndex = 2;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // applicToolStripMenuItem
            // 
            this.applicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicensesServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicansesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.manageApplicationsTypeToolStripMenuItem,
            this.manageTestTypeToolStripMenuItem});
            this.applicToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicToolStripMenuItem.Image = global::DVLD_Manage.Properties.Resources.icons8_order_35;
            this.applicToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicToolStripMenuItem.Name = "applicToolStripMenuItem";
            this.applicToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.applicToolStripMenuItem.Size = new System.Drawing.Size(153, 56);
            this.applicToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicensesServicesToolStripMenuItem
            // 
            this.drivingLicensesServicesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.drivingLicensesServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenceToolStripMenuItem,
            this.renewDrivingLicenceToolStripMenuItem,
            this.toolStripMenuItem2,
            this.replacementForLostOrDamageLicenceToolStripMenuItem,
            this.toolStripMenuItem3,
            this.releaseDetainDrivingLicenceToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicensesServicesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.drivingLicensesServicesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drivingLicensesServicesToolStripMenuItem.Image")));
            this.drivingLicensesServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicensesServicesToolStripMenuItem.Name = "drivingLicensesServicesToolStripMenuItem";
            this.drivingLicensesServicesToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drivingLicensesServicesToolStripMenuItem.Size = new System.Drawing.Size(337, 54);
            this.drivingLicensesServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenceToolStripMenuItem
            // 
            this.newDrivingLicenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newDrivingLicenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLinceceToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newDrivingLicenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingLicenceToolStripMenuItem.Image")));
            this.newDrivingLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenceToolStripMenuItem.Name = "newDrivingLicenceToolStripMenuItem";
            this.newDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(474, 54);
            this.newDrivingLicenceToolStripMenuItem.Text = "New Driving License";
            // 
            // localLinceceToolStripMenuItem
            // 
            this.localLinceceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.localLinceceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.localLinceceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localLinceceToolStripMenuItem.Image")));
            this.localLinceceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLinceceToolStripMenuItem.Name = "localLinceceToolStripMenuItem";
            this.localLinceceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.localLinceceToolStripMenuItem.Size = new System.Drawing.Size(325, 54);
            this.localLinceceToolStripMenuItem.Text = "Local License";
            this.localLinceceToolStripMenuItem.Click += new System.EventHandler(this.localLinceceToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.internationalLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.internationalLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseToolStripMenuItem.Image")));
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(325, 54);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenceToolStripMenuItem
            // 
            this.renewDrivingLicenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.renewDrivingLicenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.renewDrivingLicenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renewDrivingLicenceToolStripMenuItem.Image")));
            this.renewDrivingLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenceToolStripMenuItem.Name = "renewDrivingLicenceToolStripMenuItem";
            this.renewDrivingLicenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renewDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(474, 54);
            this.renewDrivingLicenceToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(471, 6);
            // 
            // replacementForLostOrDamageLicenceToolStripMenuItem
            // 
            this.replacementForLostOrDamageLicenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.replacementForLostOrDamageLicenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.replacementForLostOrDamageLicenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replacementForLostOrDamageLicenceToolStripMenuItem.Image")));
            this.replacementForLostOrDamageLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForLostOrDamageLicenceToolStripMenuItem.Name = "replacementForLostOrDamageLicenceToolStripMenuItem";
            this.replacementForLostOrDamageLicenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.replacementForLostOrDamageLicenceToolStripMenuItem.Size = new System.Drawing.Size(474, 54);
            this.replacementForLostOrDamageLicenceToolStripMenuItem.Text = "Replacement for Lost or Damage License";
            this.replacementForLostOrDamageLicenceToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamageLicenceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(471, 6);
            // 
            // releaseDetainDrivingLicenceToolStripMenuItem
            // 
            this.releaseDetainDrivingLicenceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.releaseDetainDrivingLicenceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.releaseDetainDrivingLicenceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainDrivingLicenceToolStripMenuItem.Image")));
            this.releaseDetainDrivingLicenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainDrivingLicenceToolStripMenuItem.Name = "releaseDetainDrivingLicenceToolStripMenuItem";
            this.releaseDetainDrivingLicenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.releaseDetainDrivingLicenceToolStripMenuItem.Size = new System.Drawing.Size(474, 54);
            this.releaseDetainDrivingLicenceToolStripMenuItem.Text = "Release Detain Driving License";
            this.releaseDetainDrivingLicenceToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainDrivingLicenceToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.retakeTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.retakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retakeTestToolStripMenuItem.Image")));
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(474, 54);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loacalDrivingLicenseApplicationToolStripMenuItem,
            this.internationalLicenseApplicationToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsToolStripMenuItem.Image")));
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(337, 54);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // loacalDrivingLicenseApplicationToolStripMenuItem
            // 
            this.loacalDrivingLicenseApplicationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loacalDrivingLicenseApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loacalDrivingLicenseApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loacalDrivingLicenseApplicationToolStripMenuItem.Image")));
            this.loacalDrivingLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loacalDrivingLicenseApplicationToolStripMenuItem.Name = "loacalDrivingLicenseApplicationToolStripMenuItem";
            this.loacalDrivingLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(375, 54);
            this.loacalDrivingLicenseApplicationToolStripMenuItem.Text = "Loacal Driving License Application";
            this.loacalDrivingLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.loacalDrivingLicenseApplicationToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationToolStripMenuItem
            // 
            this.internationalLicenseApplicationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.internationalLicenseApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.internationalLicenseApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseApplicationToolStripMenuItem.Image")));
            this.internationalLicenseApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseApplicationToolStripMenuItem.Name = "internationalLicenseApplicationToolStripMenuItem";
            this.internationalLicenseApplicationToolStripMenuItem.Size = new System.Drawing.Size(375, 54);
            this.internationalLicenseApplicationToolStripMenuItem.Text = "International License Application";
            this.internationalLicenseApplicationToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationToolStripMenuItem_Click);
            // 
            // detainLicansesToolStripMenuItem
            // 
            this.detainLicansesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.detainLicansesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.relToolStripMenuItem});
            this.detainLicansesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.detainLicansesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicansesToolStripMenuItem.Image")));
            this.detainLicansesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicansesToolStripMenuItem.Name = "detainLicansesToolStripMenuItem";
            this.detainLicansesToolStripMenuItem.Size = new System.Drawing.Size(337, 54);
            this.detainLicansesToolStripMenuItem.Text = "Detain Licanses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manageDetainedLicensesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageDetainedLicensesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicensesToolStripMenuItem.Image")));
            this.manageDetainedLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(370, 54);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.detainLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.detainLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainLicenseToolStripMenuItem.Image")));
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(370, 54);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // relToolStripMenuItem
            // 
            this.relToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.relToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relToolStripMenuItem.Image")));
            this.relToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relToolStripMenuItem.Name = "relToolStripMenuItem";
            this.relToolStripMenuItem.Size = new System.Drawing.Size(370, 54);
            this.relToolStripMenuItem.Text = "Release Detain License";
            this.relToolStripMenuItem.Click += new System.EventHandler(this.relToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(334, 6);
            // 
            // manageApplicationsTypeToolStripMenuItem
            // 
            this.manageApplicationsTypeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manageApplicationsTypeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageApplicationsTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageApplicationsTypeToolStripMenuItem.Image")));
            this.manageApplicationsTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsTypeToolStripMenuItem.Name = "manageApplicationsTypeToolStripMenuItem";
            this.manageApplicationsTypeToolStripMenuItem.Size = new System.Drawing.Size(337, 54);
            this.manageApplicationsTypeToolStripMenuItem.Text = "Manage Applications Type";
            this.manageApplicationsTypeToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypeToolStripMenuItem_Click);
            // 
            // manageTestTypeToolStripMenuItem
            // 
            this.manageTestTypeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.manageTestTypeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageTestTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageTestTypeToolStripMenuItem.Image")));
            this.manageTestTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            this.manageTestTypeToolStripMenuItem.Size = new System.Drawing.Size(337, 54);
            this.manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            this.manageTestTypeToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypeToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.peopleToolStripMenuItem.Image = global::DVLD_Manage.Properties.Resources.icons8_account_35;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(110, 56);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(111, 56);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(98, 56);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.gfgfToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountSettingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("accountSettingsToolStripMenuItem.Image")));
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 56);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.currentUserInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentUserInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("currentUserInfoToolStripMenuItem.Image")));
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // gfgfToolStripMenuItem
            // 
            this.gfgfToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gfgfToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.gfgfToolStripMenuItem.Name = "gfgfToolStripMenuItem";
            this.gfgfToolStripMenuItem.Size = new System.Drawing.Size(211, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // ControlBaxToolStripMenuItem
            // 
            this.ControlBaxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.closeAppToolStripMenuItem});
            this.ControlBaxToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ControlBaxToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ControlBaxToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ControlBaxToolStripMenuItem.Image")));
            this.ControlBaxToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ControlBaxToolStripMenuItem.Name = "ControlBaxToolStripMenuItem";
            this.ControlBaxToolStripMenuItem.Size = new System.Drawing.Size(160, 56);
            this.ControlBaxToolStripMenuItem.Text = "Control Box";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.minimizeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.minimizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToolStripMenuItem.Image")));
            this.minimizeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeAppToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeAppToolStripMenuItem.Image")));
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.closeAppToolStripMenuItem.Text = "Close App";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // pnlApplications
            // 
            this.pnlApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlApplications.BorderRadius = 20;
            this.pnlApplications.Controls.Add(this.lblNumberOfNewApplication);
            this.pnlApplications.Controls.Add(this.lblNumberOfApplication);
            this.pnlApplications.Controls.Add(this.guna2HtmlLabel4);
            this.pnlApplications.Location = new System.Drawing.Point(241, 463);
            this.pnlApplications.Name = "pnlApplications";
            this.pnlApplications.Size = new System.Drawing.Size(200, 170);
            this.pnlApplications.TabIndex = 4;
            // 
            // lblNumberOfNewApplication
            // 
            this.lblNumberOfNewApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfNewApplication.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfNewApplication.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfNewApplication.Location = new System.Drawing.Point(21, 119);
            this.lblNumberOfNewApplication.Name = "lblNumberOfNewApplication";
            this.lblNumberOfNewApplication.Size = new System.Drawing.Size(61, 27);
            this.lblNumberOfNewApplication.TabIndex = 3;
            this.lblNumberOfNewApplication.Text = "0 New";
            // 
            // lblNumberOfApplication
            // 
            this.lblNumberOfApplication.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfApplication.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfApplication.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfApplication.Location = new System.Drawing.Point(21, 66);
            this.lblNumberOfApplication.Name = "lblNumberOfApplication";
            this.lblNumberOfApplication.Size = new System.Drawing.Size(17, 33);
            this.lblNumberOfApplication.TabIndex = 3;
            this.lblNumberOfApplication.Text = "0";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 26);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(116, 27);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = "Applications";
            // 
            // pnlDetainLicense
            // 
            this.pnlDetainLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDetainLicense.BorderRadius = 20;
            this.pnlDetainLicense.Controls.Add(this.lblNumberOfRealesedLicense);
            this.pnlDetainLicense.Controls.Add(this.lblNumberOfDetainLicense);
            this.pnlDetainLicense.Controls.Add(this.guna2HtmlLabel11);
            this.pnlDetainLicense.Location = new System.Drawing.Point(470, 463);
            this.pnlDetainLicense.Name = "pnlDetainLicense";
            this.pnlDetainLicense.Size = new System.Drawing.Size(200, 170);
            this.pnlDetainLicense.TabIndex = 5;
            // 
            // lblNumberOfRealesedLicense
            // 
            this.lblNumberOfRealesedLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfRealesedLicense.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRealesedLicense.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfRealesedLicense.Location = new System.Drawing.Point(22, 119);
            this.lblNumberOfRealesedLicense.Name = "lblNumberOfRealesedLicense";
            this.lblNumberOfRealesedLicense.Size = new System.Drawing.Size(102, 27);
            this.lblNumberOfRealesedLicense.TabIndex = 4;
            this.lblNumberOfRealesedLicense.Text = "0 Released";
            // 
            // lblNumberOfDetainLicense
            // 
            this.lblNumberOfDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDetainLicense.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDetainLicense.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfDetainLicense.Location = new System.Drawing.Point(22, 66);
            this.lblNumberOfDetainLicense.Name = "lblNumberOfDetainLicense";
            this.lblNumberOfDetainLicense.Size = new System.Drawing.Size(17, 33);
            this.lblNumberOfDetainLicense.TabIndex = 4;
            this.lblNumberOfDetainLicense.Text = "0";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(22, 26);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(146, 27);
            this.guna2HtmlLabel11.TabIndex = 4;
            this.guna2HtmlLabel11.Text = "Detain Licenses";
            // 
            // pnlDrivers
            // 
            this.pnlDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDrivers.BorderRadius = 20;
            this.pnlDrivers.Controls.Add(this.lblNumberOfDrivers);
            this.pnlDrivers.Controls.Add(this.guna2HtmlLabel7);
            this.pnlDrivers.Location = new System.Drawing.Point(699, 463);
            this.pnlDrivers.Name = "pnlDrivers";
            this.pnlDrivers.Size = new System.Drawing.Size(200, 170);
            this.pnlDrivers.TabIndex = 5;
            // 
            // lblNumberOfDrivers
            // 
            this.lblNumberOfDrivers.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfDrivers.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDrivers.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfDrivers.Location = new System.Drawing.Point(23, 66);
            this.lblNumberOfDrivers.Name = "lblNumberOfDrivers";
            this.lblNumberOfDrivers.Size = new System.Drawing.Size(17, 33);
            this.lblNumberOfDrivers.TabIndex = 4;
            this.lblNumberOfDrivers.Text = "0";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(23, 26);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(66, 27);
            this.guna2HtmlLabel7.TabIndex = 4;
            this.guna2HtmlLabel7.Text = "Drivers";
            // 
            // pnlInternationalLicense
            // 
            this.pnlInternationalLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlInternationalLicense.BorderRadius = 20;
            this.pnlInternationalLicense.Controls.Add(this.lblNumberOfInternationalLicense);
            this.pnlInternationalLicense.Controls.Add(this.guna2HtmlLabel9);
            this.pnlInternationalLicense.Location = new System.Drawing.Point(928, 463);
            this.pnlInternationalLicense.Name = "pnlInternationalLicense";
            this.pnlInternationalLicense.Size = new System.Drawing.Size(200, 170);
            this.pnlInternationalLicense.TabIndex = 5;
            // 
            // lblNumberOfInternationalLicense
            // 
            this.lblNumberOfInternationalLicense.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfInternationalLicense.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInternationalLicense.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfInternationalLicense.Location = new System.Drawing.Point(19, 66);
            this.lblNumberOfInternationalLicense.Name = "lblNumberOfInternationalLicense";
            this.lblNumberOfInternationalLicense.Size = new System.Drawing.Size(17, 33);
            this.lblNumberOfInternationalLicense.TabIndex = 5;
            this.lblNumberOfInternationalLicense.Text = "0";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(19, 26);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(121, 27);
            this.guna2HtmlLabel9.TabIndex = 5;
            this.guna2HtmlLabel9.Text = "International";
            // 
            // elApplication
            // 
            this.elApplication.BorderRadius = 25;
            this.elApplication.TargetControl = this.pnlApplications;
            // 
            // elDetain
            // 
            this.elDetain.BorderRadius = 25;
            this.elDetain.TargetControl = this.pnlDetainLicense;
            // 
            // elDrivers
            // 
            this.elDrivers.BorderRadius = 25;
            this.elDrivers.TargetControl = this.pnlDrivers;
            // 
            // elInternational
            // 
            this.elInternational.BorderRadius = 25;
            this.elInternational.TargetControl = this.pnlInternationalLicense;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1127, 633);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInternationalLicense);
            this.Controls.Add(this.pnlDrivers);
            this.Controls.Add(this.pnlDetainLicense);
            this.Controls.Add(this.pnlApplications);
            this.Controls.Add(this.pnlLicense);
            this.Controls.Add(this.MainFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnlLicense.ResumeLayout(false);
            this.pnlLicense.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.pnlApplications.ResumeLayout(false);
            this.pnlApplications.PerformLayout();
            this.pnlDetainLicense.ResumeLayout(false);
            this.pnlDetainLicense.PerformLayout();
            this.pnlDrivers.ResumeLayout(false);
            this.pnlDrivers.PerformLayout();
            this.pnlInternationalLicense.ResumeLayout(false);
            this.pnlInternationalLicense.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elLicense;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicansesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamageLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainDrivingLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLinceceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loacalDrivingLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator gfgfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ControlBaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Panel pnlLicense;
        private Guna.UI2.WinForms.Guna2Panel pnlApplications;
        private Guna.UI2.WinForms.Guna2Panel pnlDetainLicense;
        private Guna.UI2.WinForms.Guna2Panel pnlDrivers;
        private Guna.UI2.WinForms.Guna2Panel pnlInternationalLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfActiveLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Elipse elApplication;
        private Guna.UI2.WinForms.Guna2Elipse elDetain;
        private Guna.UI2.WinForms.Guna2Elipse elDrivers;
        private Guna.UI2.WinForms.Guna2Elipse elInternational;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfNewApplication;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfApplication;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfDrivers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfRealesedLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfDetainLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNumberOfInternationalLicense;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
    }
}

