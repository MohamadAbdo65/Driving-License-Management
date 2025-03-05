using Microsoft.Win32;

namespace DVLD_ConnectionSettings
{
    public class clsConnectionSettingsDVLD
    {
       // public static string? ConnectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_DVLD");

        //Temporarily
        public static string? ConnectionString
        {
            get
            {
                string registryPath = @"Environment";
                string valueName = "DATABASE_CONNECTION_DVLD";

                string CS = Registry.GetValue(@"HKEY_CURRENT_USER\" + registryPath, valueName, null) as string;

                if (CS != null) return (CS + "; TrustServerCertificate=True;");

                else return CS;
            }
        }
    }
}
