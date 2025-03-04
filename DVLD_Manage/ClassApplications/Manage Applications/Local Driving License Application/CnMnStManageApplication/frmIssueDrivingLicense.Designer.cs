namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication
{
    partial class frmIssueDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueDrivingLicense));
            this.usctrlLDLApp_BaseApp_Info1 = new DVLD_Manage.usctrlLDLApp_BaseApp_Info();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIssue = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // usctrlLDLApp_BaseApp_Info1
            // 
            this.usctrlLDLApp_BaseApp_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlLDLApp_BaseApp_Info1.Location = new System.Drawing.Point(1, 1);
            this.usctrlLDLApp_BaseApp_Info1.Name = "usctrlLDLApp_BaseApp_Info1";
            this.usctrlLDLApp_BaseApp_Info1.Size = new System.Drawing.Size(692, 437);
            this.usctrlLDLApp_BaseApp_Info1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes : ";
            // 
            // txtbNote
            // 
            this.txtbNote.AllowDrop = true;
            this.txtbNote.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbNote.DefaultText = "";
            this.txtbNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNote.ForeColor = System.Drawing.Color.White;
            this.txtbNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNote.Location = new System.Drawing.Point(98, 445);
            this.txtbNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNote.Multiline = true;
            this.txtbNote.Name = "txtbNote";
            this.txtbNote.PasswordChar = '\0';
            this.txtbNote.PlaceholderText = "";
            this.txtbNote.SelectedText = "";
            this.txtbNote.Size = new System.Drawing.Size(582, 82);
            this.txtbNote.TabIndex = 103;
            // 
            // btnIssue
            // 
            this.btnIssue.Animated = true;
            this.btnIssue.BackColor = System.Drawing.Color.Transparent;
            this.btnIssue.BorderRadius = 10;
            this.btnIssue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIssue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIssue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIssue.FillColor = System.Drawing.Color.Gold;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.Black;
            this.btnIssue.Image = ((System.Drawing.Image)(resources.GetObject("btnIssue.Image")));
            this.btnIssue.Location = new System.Drawing.Point(553, 538);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.ShadowDecoration.BorderRadius = 10;
            this.btnIssue.ShadowDecoration.Depth = 15;
            this.btnIssue.ShadowDecoration.Enabled = true;
            this.btnIssue.Size = new System.Drawing.Size(121, 35);
            this.btnIssue.TabIndex = 104;
            this.btnIssue.Text = "Issue";
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(693, 584);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.txtbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usctrlLDLApp_BaseApp_Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDrivingLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License";
            this.Load += new System.EventHandler(this.frmIssueDrivingLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private usctrlLDLApp_BaseApp_Info usctrlLDLApp_BaseApp_Info1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtbNote;
        private Guna.UI2.WinForms.Guna2Button btnIssue;
    }
}