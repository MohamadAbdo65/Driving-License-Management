namespace DVLD_ConnectionSettings
{
    public class clsConnectionSettingsDVLD
    {
       // public static string? ConnectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION");

        //Temporarily
        public static string? ConnectionString
        {
            get
            {
                string? cs = Environment.GetEnvironmentVariable("DATABASE_CONNECTION");

                if (cs != null) return cs + "; TrustServerCertificate=True;";

                else return cs;
            }
        }
    }
}
