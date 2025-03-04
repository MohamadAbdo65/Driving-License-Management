using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using ConnectionSettings;

namespace DVLD_DataAccessLayer
{
    public class clsInternationalLicenseDTO
    {
            public int InternationalLicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public int IssuedUsingLocalLicenseID { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public bool IsActive { get; set; }
            public int CreatedByUserID { get; set; }


        public clsInternationalLicenseDTO(
            int internationalLicenseID,
            int applicationID,
            int driverID,
            int issuedUsingLocalLicenseID,
            DateTime issueDate,
            DateTime expirationDate,
            bool isActive,
            int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;
        }
    }
    


    public static class clsDataInternationalLicense
    {
        public static bool AddNewInternationalLicenses(ref clsInternationalLicenseDTO license)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", license.DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", license.IsActive);
                command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        license.InternationalLicenseID = newID;
                        return true;
                    }
                }
                catch { /* تمت إزالة الـ Logger */ }
                return false;
            }
        }

        public static bool UpdateInternationalLicenses(clsInternationalLicenseDTO license)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@InternationalLicenseID", license.InternationalLicenseID);
                command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                command.Parameters.AddWithValue("@DriverID", license.DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", license.IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", license.IsActive);
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

        public static List<clsInternationalLicenseDTO> GetAllInternationalLicenses()
        {
            var AllInternationalLicense = new List<clsInternationalLicenseDTO> ();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_SelectAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllInternationalLicense.Add
                             (
                                new clsInternationalLicenseDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("InternationalLicenseID")),
                                    reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    reader.GetInt32(reader.GetOrdinal("IssuedUsingLocalLicenseID")),
                                    reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    reader.GetDateTime(reader.GetOrdinal("ExpirationDate")),
                                    reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                )
                             );
                        }
                    }
                }
                catch { /* تمت إزالة الـ Logger */ }
            }

            return AllInternationalLicense;
        }

        public static List<clsInternationalLicenseDTO> GetAllInternationalLicensesByDriverID(int DriverID)
        {
            var AllInternationalLicense = new List<clsInternationalLicenseDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("PS_InternationalLicenses_SelectAll_ByDriverID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@DriverID" , DriverID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllInternationalLicense.Add
                             (
                                new clsInternationalLicenseDTO
                                (
                                    reader.GetInt32(reader.GetOrdinal("InternationalLicenseID")),
                                    reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    reader.GetInt32(reader.GetOrdinal("IssuedUsingLocalLicenseID")),
                                    reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    reader.GetDateTime(reader.GetOrdinal("ExpirationDate")),
                                    reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                )
                             );
                        }
                    }
                }
                catch { /* تمت إزالة الـ Logger */ }
            }

            return AllInternationalLicense;
        }

        public static clsInternationalLicenseDTO FindInternationalLicensesByInternationalLicenseID(int internationalLicenseID)
        {
            clsInternationalLicenseDTO license = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_Select_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            license = new clsInternationalLicenseDTO(
                                (int)reader["InternationalLicenseID"],
                                (int)reader["ApplicationID"],
                                (int)reader["DriverID"],
                                (int)reader["IssuedUsingLocalLicenseID"],
                                (DateTime)reader["IssueDate"],
                                (DateTime)reader["ExpirationDate"],
                                (bool)reader["IsActive"],
                                (int)reader["CreatedByUserID"]
                            )
                            {
                                InternationalLicenseID = internationalLicenseID
                            };
                        }
                    }
                }
                catch { /* تمت إزالة الـ Logger */ }
            }

            return license;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int driverID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_GetActiveID_ByDriverID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }

        public static bool InternationalLicensesIsExist(int internationalLicenseID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_Exists_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

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
            using (SqlCommand command = new SqlCommand("SP_InternationalLicenses_VerifyActivity", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch {  }
            }
        }
    }
}