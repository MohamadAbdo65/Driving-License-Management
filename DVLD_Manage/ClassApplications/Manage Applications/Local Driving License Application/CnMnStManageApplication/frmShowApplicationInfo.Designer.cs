namespace DVLD_Manage
{
    partial class frmShowApplicationInfo
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
            this.usctrlLDLApp_BaseApp_Info1 = new DVLD_Manage.usctrlLDLApp_BaseApp_Info();
            this.SuspendLayout();
            // 
            // usctrlLDLApp_BaseApp_Info1
            // 
            this.usctrlLDLApp_BaseApp_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlLDLApp_BaseApp_Info1.Location = new System.Drawing.Point(1, 3);
            this.usctrlLDLApp_BaseApp_Info1.Name = "usctrlLDLApp_BaseApp_Info1";
            this.usctrlLDLApp_BaseApp_Info1.Size = new System.Drawing.Size(692, 437);
            this.usctrlLDLApp_BaseApp_Info1.TabIndex = 0;
            // 
            // frmShowApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 436);
            this.Controls.Add(this.usctrlLDLApp_BaseApp_Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Info";
            this.Load += new System.EventHandler(this.frmShowApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usctrlLDLApp_BaseApp_Info usctrlLDLApp_BaseApp_Info1;
    }
}