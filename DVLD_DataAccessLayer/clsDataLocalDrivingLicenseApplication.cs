using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConnectionSettings;


namespace DVLD_DataAccessLayer
{

    public class clsLocalDrivingLicenseApplicationDTO
    {
        public int LDLAppID { get; set; }
        public int BaseAppID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplicationDTO(int LDLAppId, int baseAppID, int licenseClassID)
        {
            LDLAppID = LDLAppId;
            BaseAppID = baseAppID;
            LicenseClassID = licenseClassID;
        }
    }

    public static class clsDataLocalDrivingLicenseApplication
    {
        public static clsLocalDrivingLicenseApplicationDTO GetLocalDrivingLicenseApplicationInfoByID(int LDLAppID)
        {
            clsLocalDrivingLicenseApplicationDTO dto = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_Select_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto = new clsLocalDrivingLicenseApplicationDTO(
                                (int)reader["LocalDrivingLicenseApplicationID"],
                                (int)reader["ApplicationID"],
                                (int)reader["LicenseClassID"]
                            )
                            {
                                LDLAppID = LDLAppID
                            };
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return dto;
        }

        public static clsLocalDrivingLicenseApplicationDTO GetLocalDrivingLicenseApplicationInfoByBaseAppID(int baseAppID)
        {
            clsLocalDrivingLicenseApplicationDTO dto = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_Select_ByBaseAppID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BaseAppID", baseAppID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto = new clsLocalDrivingLicenseApplicationDTO(
                                (int)reader["LocalDrivingLicenseApplicationID"],
                                baseAppID,
                                (int)reader["LicenseClassID"]
                            );                      
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return dto;
        }

        public static List<clsLocalDrivingLicenseApplicationDTO> GetAllLocalDrivingLicenseApplications()
        {
            var AllApps = new List<clsLocalDrivingLicenseApplicationDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_SelectAll_View", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            AllApps.Add(
                                new clsLocalDrivingLicenseApplicationDTO(
                                (int)reader["LocalDrivingLicenseApplicationID"],
                                (int)reader["ApplicationID"],
                                (int)reader["LicenseClassID"]));
                        }
                    }
                }
                catch {  }
            }

            return AllApps;
        }

        public static bool AddNewLoacalDriveLicenseApplication(ref clsLocalDrivingLicenseApplicationDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BaseAppID", dto.BaseAppID);
                command.Parameters.AddWithValue("@LicenseClassID", dto.LicenseClassID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        dto.LDLAppID = newID;
                        return true;
                    }
                }
                catch { return false; }
                return false;
            }
        }

        public static bool DeleteLocalDApplication(int LDLAppID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_Delete_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static bool UpdateLocalDrivingApplication(clsLocalDrivingLicenseApplicationDTO dto)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_Update_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", dto.LDLAppID);
                command.Parameters.AddWithValue("@BaseAppID", dto.BaseAppID);
                command.Parameters.AddWithValue("@LicenseClassID", dto.LicenseClassID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static int NumberOfTrialsPerTestType(int LDLAppID, int TestTypeID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_CountTrials_ByTestType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch { return 0; }
            }
        }

        public static bool DoesAttendTestType(int LDLAppID, int TestTypeID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_CheckTestAttendance", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static bool IsThereActiveScheduledTest(int LDLAppID, int TestTypeID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_CheckActiveSchedule", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static bool DoesPassTestType(int LDLAppID, int TestTypeID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_LocalDrivingLicenseApplications_CheckTestResult", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }
    }
}