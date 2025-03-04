namespace DVLD_Manage
{
    partial class usctrlLDLApp_BaseApp_Info
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
            this.usctrlLDLAppInfo1 = new DVLD_Manage.usctrlLDLAppInfo();
            this.usctrlShowBaseApp1 = new DVLD_Manage.usctrlShowBaseApp();
            this.SuspendLayout();
            // 
            // usctrlLDLAppInfo1
            // 
            this.usctrlLDLAppInfo1.BackColor = System.Drawing.Color.White;
            this.usctrlLDLAppInfo1.Location = new System.Drawing.Point(0, 0);
            this.usctrlLDLAppInfo1.Name = "usctrlLDLAppInfo1";
            this.usctrlLDLAppInfo1.Size = new System.Drawing.Size(690, 125);
            this.usctrlLDLAppInfo1.TabIndex = 0;
            // 
            // usctrlShowBaseApp1
            // 
            this.usctrlShowBaseApp1.BackColor = System.Drawing.Color.White;
            this.usctrlShowBaseApp1.Location = new System.Drawing.Point(0, 124);
            this.usctrlShowBaseApp1.Name = "usctrlShowBaseApp1";
            this.usctrlShowBaseApp1.Size = new System.Drawing.Size(690, 310);
            this.usctrlShowBaseApp1.TabIndex = 1;
            // 
            // usctrlLDLApp_BaseApp_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.usctrlShowBaseApp1);
            this.Controls.Add(this.usctrlLDLAppInfo1);
            this.Name = "usctrlLDLApp_BaseApp_Info";
            this.Size = new System.Drawing.Size(692, 437);
            this.Load += new System.EventHandler(this.usctrlLDLApp_BaseApp_Info_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usctrlLDLAppInfo usctrlLDLAppInfo1;
        private usctrlShowBaseApp usctrlShowBaseApp1;
    }
}
