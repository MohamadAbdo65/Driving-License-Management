namespace DVLD_ConnectionSettings
{
    public class clsConnection
    {
        public static string ConnectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION");

    }
}
