namespace DVLD_Manage
{
    partial class ChangePasswordUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUser));
            this.txtbCurrent = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbNew = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlUserInfoCard1 = new DVLD_Manage.ctrlUserInfoCard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbCurrent
            // 
            this.txtbCurrent.BackColor = System.Drawing.Color.Transparent;
            this.txtbCurrent.BorderRadius = 15;
            this.txtbCurrent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbCurrent.DefaultText = "";
            this.txtbCurrent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbCurrent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbCurrent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCurrent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbCurrent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbCurrent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCurrent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCurrent.ForeColor = System.Drawing.Color.White;
            this.txtbCurrent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbCurrent.Location = new System.Drawing.Point(238, 322);
            this.txtbCurrent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCurrent.Name = "txtbCurrent";
            this.txtbCurrent.PasswordChar = '*';
            this.txtbCurrent.PlaceholderText = "";
            this.txtbCurrent.SelectedText = "";
            this.txtbCurrent.ShadowDecoration.BorderRadius = 15;
            this.txtbCurrent.ShadowDecoration.Depth = 10;
            this.txtbCurrent.ShadowDecoration.Enabled = true;
            this.txtbCurrent.Size = new System.Drawing.Size(257, 36);
            this.txtbCurrent.TabIndex = 21;
            this.txtbCurrent.Validating += new System.ComponentModel.CancelEventHandler(this.txtbCurrent_Validating);
            // 
            // txtbConfirm
            // 
            this.txtbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.txtbConfirm.BorderRadius = 15;
            this.txtbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbConfirm.DefaultText = "";
            this.txtbConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbConfirm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbConfirm.ForeColor = System.Drawing.Color.White;
            this.txtbConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbConfirm.Location = new System.Drawing.Point(238, 432);
            this.txtbConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbConfirm.Name = "txtbConfirm";
            this.txtbConfirm.PasswordChar = '*';
            this.txtbConfirm.PlaceholderText = "";
            this.txtbConfirm.SelectedText = "";
            this.txtbConfirm.ShadowDecoration.BorderRadius = 15;
            this.txtbConfirm.ShadowDecoration.Depth = 10;
            this.txtbConfirm.ShadowDecoration.Enabled = true;
            this.txtbConfirm.Size = new System.Drawing.Size(257, 36);
            this.txtbConfirm.TabIndex = 22;
            // 
            // txtbNew
            // 
            this.txtbNew.BackColor = System.Drawing.Color.Transparent;
            this.txtbNew.BorderRadius = 15;
            this.txtbNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbNew.DefaultText = "";
            this.txtbNew.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNew.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtbNew.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNew.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNew.ForeColor = System.Drawing.Color.White;
            this.txtbNew.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbNew.Location = new System.Drawing.Point(238, 377);
            this.txtbNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbNew.Name = "txtbNew";
            this.txtbNew.PasswordChar = '*';
            this.txtbNew.PlaceholderText = "";
            this.txtbNew.SelectedText = "";
            this.txtbNew.ShadowDecoration.BorderRadius = 15;
            this.txtbNew.ShadowDecoration.Depth = 10;
            this.txtbNew.ShadowDecoration.Enabled = true;
            this.txtbNew.Size = new System.Drawing.Size(257, 36);
            this.txtbNew.TabIndex = 23;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(36, 326);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(172, 27);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Current Password :";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(32, 440);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(176, 27);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "Confirm Password :";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(65, 385);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(143, 27);
            this.guna2HtmlLabel6.TabIndex = 25;
            this.guna2HtmlLabel6.Text = "New Password :";
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 10;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(560, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.BorderRadius = 10;
            this.btnClose.ShadowDecoration.Depth = 10;
            this.btnClose.ShadowDecoration.Enabled = true;
            this.btnClose.Size = new System.Drawing.Size(121, 45);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Enabled = false;
            this.btnSave.FillColor = System.Drawing.Color.SpringGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(560, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.BorderRadius = 10;
            this.btnSave.ShadowDecoration.Depth = 15;
            this.btnSave.ShadowDecoration.Enabled = true;
            this.btnSave.Size = new System.Drawing.Size(121, 45);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlUserInfoCard1
            // 
            this.ctrlUserInfoCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ctrlUserInfoCard1.Location = new System.Drawing.Point(0, -1);
            this.ctrlUserInfoCard1.Name = "ctrlUserInfoCard1";
            this.ctrlUserInfoCard1.Size = new System.Drawing.Size(731, 314);
            this.ctrlUserInfoCard1.TabIndex = 35;
            // 
            // ChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(732, 491);
            this.Controls.Add(this.ctrlUserInfoCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtbNew);
            this.Controls.Add(this.txtbConfirm);
            this.Controls.Add(this.txtbCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePasswordUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtbCurrent;
        private Guna.UI2.WinForms.Guna2TextBox txtbConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtbNew;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlUserInfoCard ctrlUserInfoCard1;
    }
}