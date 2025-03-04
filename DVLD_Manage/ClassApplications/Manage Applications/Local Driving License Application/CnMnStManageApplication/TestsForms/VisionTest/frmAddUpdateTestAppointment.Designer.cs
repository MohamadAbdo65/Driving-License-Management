namespace DVLD_Manage.ClassApplications.Manage_Applications.Local_Driving_License_Application.CnMnStManageApplication.TestsForms.VisionTest
{
    partial class frmAddUpdateTestAppointment
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
            this.usctrlScheduleTest1 = new DVLD_Manage.UserControls.usctrlScheduleTest();
            this.SuspendLayout();
            // 
            // usctrlScheduleTest1
            // 
            this.usctrlScheduleTest1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.usctrlScheduleTest1.ForeColor = System.Drawing.Color.White;
            this.usctrlScheduleTest1.Location = new System.Drawing.Point(1, 3);
            this.usctrlScheduleTest1.Name = "usctrlScheduleTest1";
            this.usctrlScheduleTest1.Size = new System.Drawing.Size(726, 537);
            this.usctrlScheduleTest1.TabIndex = 0;
            this.usctrlScheduleTest1.TestTypeID = DVLD_BusinussLayer.clsTestType.enTestType.VisionTest;
            // 
            // frmAddUpdateTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(728, 544);
            this.Controls.Add(this.usctrlScheduleTest1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdateTestAppointment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Schedule Test";
            this.Load += new System.EventHandler(this.frmAddUpdateTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.usctrlScheduleTest usctrlScheduleTest1;
    }
}