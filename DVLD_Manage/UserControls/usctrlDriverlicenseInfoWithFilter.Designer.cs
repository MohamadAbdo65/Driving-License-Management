namespace DVLD_Manage.UserControls
{
    partial class usctrlDriverlicenseInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usctrlDriverlicenseInfoWithFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.usctrlDriverLicenseInfo1 = new DVLD_Manage.UserControls.usctrlDriverLicenseInfo();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "License ID :";
            // 
            // txtbLicenseID
            // 
            this.txtbLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbLicenseID.DefaultText = "";
            this.txtbLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbLicenseID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.txtbLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLicenseID.ForeColor = System.Drawing.Color.White;
            this.txtbLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbLicenseID.Location = new System.Drawing.Point(281, 10);
            this.txtbLicenseID.Name = "txtbLicenseID";
            this.txtbLicenseID.PasswordChar = '\0';
            this.txtbLicenseID.PlaceholderText = "";
            this.txtbLicenseID.SelectedText = "";
            this.txtbLicenseID.Size = new System.Drawing.Size(216, 36);
            this.txtbLicenseID.TabIndex = 2;
            this.txtbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseID_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(532, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.txtbLicenseID);
            this.pnlFilter.Location = new System.Drawing.Point(13, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(816, 57);
            this.pnlFilter.TabIndex = 4;
            // 
            // usctrlDriverLicenseInfo1
            // 
            this.usctrlDriverLicenseInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlDriverLicenseInfo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usctrlDriverLicenseInfo1.ForeColor = System.Drawing.Color.White;
            this.usctrlDriverLicenseInfo1.Location = new System.Drawing.Point(2, 61);
            this.usctrlDriverLicenseInfo1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.usctrlDriverLicenseInfo1.Name = "usctrlDriverLicenseInfo1";
            this.usctrlDriverLicenseInfo1.Size = new System.Drawing.Size(840, 414);
            this.usctrlDriverLicenseInfo1.TabIndex = 5;
            // 
            // usctrlDriverlicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.usctrlDriverLicenseInfo1);
            this.Controls.Add(this.pnlFilter);
            this.Name = "usctrlDriverlicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(842, 476);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbLicenseID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlFilter;
        private usctrlDriverLicenseInfo usctrlDriverLicenseInfo1;
    }
}
