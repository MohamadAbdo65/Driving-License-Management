using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
 
    public class clsLicenseDTO
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }


        public clsLicenseDTO(
            int licenseID,
            int applicationID,
            int driverID,
            int licenseClass,
            DateTime issueDate,
            DateTime expirationDate,
            string notes,
            decimal paidFees,
            bool isActive,
            byte issueReason,
            int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }
    }


    public static class clsDataLicenses
    {
        public static bool IsLicenseExistByPersonID(int personID, int licenseClassID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Exists_ByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static bool AddNewLicenses(ref clsLicenseDTO license)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", license.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", license.LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(license.Notes) ? DBNull.Value : (object)license.Notes);
                command.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                command.Parameters.AddWithValue("@IsActive", license.IsActive);
                command.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        license.LicenseID = newID;
                        return true;
                    }
                }
                catch { return false; }
                return false;
            }
        }

        public static bool UpdateLicenses(clsLicenseDTO license)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@LicenseID", license.LicenseID);
                command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", license.DriverID);
                command.Parameters.AddWithValue("@LicenseClass", license.LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(license.Notes) ? DBNull.Value : (object)license.Notes);
                command.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                command.Parameters.AddWithValue("@IsActive", license.IsActive);
                command.Parameters.AddWithValue("@IssueReason", license.IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_SelectAll", connection))
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

        public static clsLicenseDTO FindLicensesByLicenseID(int licenseID)
        {
            clsLicenseDTO license = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Select_ByID", connection))
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
                            license = new clsLicenseDTO(
                                (int)reader["LicenseID"],
                                (int)reader["ApplicationID"],
                                (int)reader["DriverID"],
                                (int)reader["LicenseClass"],
                                (DateTime)reader["IssueDate"],
                                (DateTime)reader["ExpirationDate"],
                                reader["Notes"] as string ?? string.Empty,
                                (decimal)reader["PaidFees"],
                                (bool)reader["IsActive"],
                                (byte)reader["IssueReason"],
                                (int)reader["CreatedByUserID"]
                            )
                            {
                                LicenseID = licenseID
                            };
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return license;
        }

        public static bool DeActiveLicense(int licenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Deactivate", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static DataTable GetAllLicenseForDriver(int driverID)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_SelectAll_ForDriver", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            table.Load(reader);
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return table;
        }

        public static int GetActiveLicenseIDByPersonID(int personID, int licenseClassID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_GetActiveID_ByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }

        public static bool LicensesIsExist(int licenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_Exists_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LicenseID", licenseID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static void VerifyLicenseActivity()
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Licenses_VerifyActivity", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch { /* تم إزالة الـ Logger */ }
            }
        }
    }


}
