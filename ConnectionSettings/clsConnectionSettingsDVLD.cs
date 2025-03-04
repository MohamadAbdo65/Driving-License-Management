using System;

namespace ConnectionSettings
{
    public static class clsConnectionSettingsDVLD
    {
        public static string ConnectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION");
    }
}
