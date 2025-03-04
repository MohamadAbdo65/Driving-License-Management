using DVLD_BusinussLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Manage
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        

        static void VerifyLicensesActive()
        {
            clsLicense.VerifyLicenseActivity();
            clsInternationalLicense.VerifyLicenseActivity();
        }
        
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            VerifyLicensesActive();

            Application.Run(new frmLoginScreen());
        }
    }
}
