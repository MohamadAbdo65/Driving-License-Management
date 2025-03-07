using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{

    public class clsDetainLicenseDTO : IValidatable
    {
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        public clsDetainLicenseDTO(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)

        {
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }

        public bool IsValid(out string? ErrorMessage)
        {
            if(this.LicenseID < 0) { ErrorMessage = "License ID is not valid"; return false; }
            if(this.FineFees < 0) { ErrorMessage = "The amount is not valid";return false; }
            if(this.CreatedByUserID < 0) { ErrorMessage = "User ID is not vlaid";return false; }
            if(this.ReleasedByUserID < 0) { ErrorMessage = "User ID is not valid";return false; }
            if(this.ReleaseApplicationID < 0) { ErrorMessage = "Application ID is not valid";return false; }

            ErrorMessage = null;
            return true;
        }
    }


    public static class clsDataDetain
    {
        public static bool AddNewDetainedLicenses(ref clsDetainLicenseDTO detain)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@LicenseID", detain.LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", detain.DetainDate);
                    command.Parameters.AddWithValue("@FineFees", detain.FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", detain.CreatedByUserID);
                    command.Parameters.AddWithValue("@IsReleased", detain.IsReleased);

                    // Nullable parameters
                    AddNullableParameter(command, "@ReleaseDate", detain.ReleaseDate);
                    AddNullableParameter(command, "@ReleasedByUserID", detain.ReleasedByUserID);
                    AddNullableParameter(command, "@ReleaseApplicationID", detain.ReleaseApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int newID))
                        {
                            detain.DetainID = newID;
                            return true;
                        }
                    }
                    catch { /* تم إزالة الـ Logger */ }

                    return false;
                }
            }
        }

        public static bool UpdateDetainedLicenses(clsDetainLicenseDTO detain)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_Update_ByDetainID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@DetainID", detain.DetainID);
                    command.Parameters.AddWithValue("@LicenseID", detain.LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", detain.DetainDate);
                    command.Parameters.AddWithValue("@FineFees", detain.FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", detain.CreatedByUserID);
                    command.Parameters.AddWithValue("@IsReleased", detain.IsReleased);

                    // Nullable parameters
                    AddNullableParameter(command, "@ReleaseDate", detain.ReleaseDate);
                    AddNullableParameter(command, "@ReleasedByUserID", detain.ReleasedByUserID);
                    AddNullableParameter(command, "@ReleaseApplicationID", detain.ReleaseApplicationID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch { /* تم إزالة الـ Logger */ }

                    return false;
                }
            }
        }

        public static List<clsDetainLicenseDTO> GetAllDetainedLicenses()
        {
            List<clsDetainLicenseDTO> detainedLicenses = new List<clsDetainLicenseDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_SelectAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detainedLicenses.Add(MapReaderToDTO(reader));
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return detainedLicenses;
        }

        public static clsDetainLicenseDTO FindDetainedLicensesByLicenseID(int licenseID)
        {
            clsDetainLicenseDTO detain = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_Select_ByLicenseID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            detain = MapReaderToDTO(reader);
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return detain;
        }

        public static bool ReleaseDetainLicense(int detainID, int userID, int appID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_Release_ByDetainID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DetainID", detainID);
                command.Parameters.AddWithValue("@UserID", userID);
                command.Parameters.AddWithValue("@AppID", appID);
                command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { /* تم إزالة الـ Logger */ }

                return false;
            }
        }

        public static DataTable GetAllDetainedLicenses_View()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_SelectAll_View", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return dataTable;
        }

        public static bool DetainedLicensesIsExist(int LicenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_IsExist_ByLicenseID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();
                        return (bool)command.ExecuteScalar();
                    }
                    catch { return false; }
                }
            }
        }

        public static bool LicensesIsDetain(int LicenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_DetainedLicenses_IsDetained_ByLicenseID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        connection.Open();
                        return (bool)command.ExecuteScalar();
                    }
                    catch { return false; }
                }
            }
        }


        private static clsDetainLicenseDTO MapReaderToDTO(SqlDataReader reader)
        {
            return new clsDetainLicenseDTO
            (
                (int)reader["DetainID"],
                (int)reader["LicenseID"],
                (DateTime)reader["DetainDate"],
                (decimal)reader["FineFees"],
                (int)reader["CreatedByUserID"],
                (bool)reader["IsReleased"],
                reader["ReleaseDate"] as DateTime?,
                reader["ReleasedByUserID"] as int?,
                reader["ReleaseApplicationID"] as int?
            );
        }

        private static void AddNullableParameter(SqlCommand command, string paramName, object value)
        {
            if (value == null)
            {
                command.Parameters.AddWithValue(paramName, DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue(paramName, value);
            }
        }


    }




}
