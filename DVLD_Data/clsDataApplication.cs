using Microsoft.Data.SqlClient;
using System.Data;
using DVLD_ConnectionSettings;

namespace DVLD_Data
{
        public class clsApplicationsDTO : IValidatable
        {
            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public byte ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public int PaidFees { get; set; }
            public int CreatedByUserID { get; set; }

            public clsApplicationsDTO(int applicationID, int applicantPersonID, DateTime applicationDate,
                                 int applicationTypeID, byte applicationStatus, DateTime lastStatusDate,
                                 int paidFees, int createdByUserID)
            {
                this.ApplicationID = applicationID;
                this.ApplicantPersonID = applicantPersonID;
                this.ApplicationDate = applicationDate;
                this.ApplicationTypeID = applicationTypeID;
                this.ApplicationStatus = applicationStatus;
                this.LastStatusDate = lastStatusDate;
                this.PaidFees = paidFees;
                this.CreatedByUserID = createdByUserID;
            }

            public bool IsValid(out string? ErrorMessage)
            {
                if (this.ApplicantPersonID < 0) { ErrorMessage = "Person ID is not valid"; return false; }
                if (this.ApplicationDate > DateTime.Now) { ErrorMessage = "Application cannot be in the future"; return false; }
                if (this.ApplicationTypeID == 7 || this.ApplicationTypeID < 1 || this.ApplicationTypeID > 8) { ErrorMessage = "Application type ID is not valid"; return false; }
                if (this.ApplicationStatus < 1 || this.ApplicationStatus > 3) { ErrorMessage = "Application status is not valid"; return false; }
                if (this.LastStatusDate > DateTime.Now) { ErrorMessage = "The Date cannot be in the future"; return false; }
                if (this.PaidFees < 0) { ErrorMessage = "The amount is not valid"; return false; }
                if (this.CreatedByUserID < 0) { ErrorMessage = "User ID is not valid"; return false; }

                ErrorMessage = null;
                return true;
            }
        }

        public static class clsDataApplications
        {

            public static bool AddApplication(ref clsApplicationsDTO application)
            {
                bool isAdded = false;
                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_Insert", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ApplicantPersonID", application.ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", application.CreatedByUserID);

                        SqlParameter outputIdParam = new SqlParameter("@ApplicationID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(outputIdParam);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            application.ApplicationID = (int)outputIdParam.Value;
                            isAdded = true;
                        }
                        catch
                        {
                        }
                    }
                }
                return isAdded;
            }

            public static List<clsApplicationsDTO> GetAllApplications()
            {
                var AllApplications = new List<clsApplicationsDTO>();

                string StConnection = clsConnectionSettingsDVLD.ConnectionString;

                using (SqlConnection connection = new SqlConnection(StConnection))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_GetAll", connection))
                    {
                    command.CommandType = CommandType.StoredProcedure;

                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    AllApplications.Add(
                                        new clsApplicationsDTO(
                                            reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                            reader.GetInt32(reader.GetOrdinal("ApplicantPersonID")),
                                            reader.GetDateTime(reader.GetOrdinal("ApplicationDate")),
                                            reader.GetInt32(reader.GetOrdinal("ApplicationTypeID")),
                                            reader.GetByte(reader.GetOrdinal("ApplicationStatus")),
                                            reader.GetDateTime(reader.GetOrdinal("LastStatusDate")),
                                            reader.GetInt32(reader.GetOrdinal("PaidFees")),
                                            reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                        )
                                    );
                                }
                            }
                        }
                        catch { }
                    }
                }
                return AllApplications;
            }

            public static clsApplicationsDTO GetApplicationByID(int appID)
            {
                clsApplicationsDTO application = null;
                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_FindBy_ID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", appID);

                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    application = new clsApplicationsDTO(
                                    (int)reader["ApplicationID"],
                                    (int)reader["ApplicantPersonID"],
                                    (DateTime)reader["ApplicationDate"],
                                    (int)reader["ApplicationTypeID"],
                                    (byte)reader["ApplicationStatus"],
                                    (DateTime)reader["LastStatusDate"],
                                    (int)reader["PaidFees"],
                                    (int)reader["CreatedByUserID"]
                                    );
                                }
                            }
                        }
                        catch { }
                    }
                }
                return application;
            }

            public static bool UpdateApplication(clsApplicationsDTO application)
            {
                bool isUpdated = false;
                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_Update", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ApplicationID", application.ApplicationID);
                        command.Parameters.AddWithValue("@ApplicantPersonID", application.ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", application.ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", application.ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", application.ApplicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", application.LastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", application.PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", application.CreatedByUserID);

                        try
                        {
                            connection.Open();
                            isUpdated = command.ExecuteNonQuery() > 0;
                        }
                        catch
                        {
                        }
                    }
                }
                return isUpdated;
            }

            public static bool DeleteApplication(int applicationID)
            {
                bool isDeleted = false;
                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_Delete", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", applicationID);

                        try
                        {
                            connection.Open();
                            isDeleted = command.ExecuteNonQuery() > 0;
                        }
                        catch
                        {
                        }
                    }
                }
                return isDeleted;
            }

            public static bool ApplicationIsExist(int applicationID)
            {
                bool exists = false;
                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_Applications_IsExist_ID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", applicationID);

                        try
                        {
                            connection.Open();
                            exists = Convert.ToBoolean(command.ExecuteScalar());
                        }
                        catch
                        {
                        }
                    }
                }
                return exists;
            }

            public static bool DoesPersonHaveActiveApplication(int PersonID, int ApptypeID)
            {

                return (GetActiveApplicationID(PersonID, ApptypeID) != -1);

            }

            public static int GetActiveApplicationID(int PersonID, int AppTypeID)
            {
                int ActiveApplicationID = -1;
                string StConnection = clsConnectionSettingsDVLD.ConnectionString;

                using (SqlConnection connection = new SqlConnection(StConnection))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetActiveApplicationID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@AppTypeID", AppTypeID);

                        try
                        {
                            connection.Open();
                            var result = command.ExecuteScalar();
                            if (result != null)
                            {
                                ActiveApplicationID = Convert.ToInt32(result);
                            }
                        }
                        catch { }
                    }
                }

                return ActiveApplicationID;
            }

            public static int GetActiveApplicationIDForLicenseClass(int PersonID, int AppTypeID, int LicenseClassID)
            {
                int ActiveApplicationID = -1;
                string StConnection = clsConnectionSettingsDVLD.ConnectionString;

                using (SqlConnection connection = new SqlConnection(StConnection))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetActiveApplicationIDForLicenseClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        try
                        {
                            connection.Open();
                            var result = command.ExecuteScalar();
                            if (result != null && int.TryParse(result.ToString(), out int GetID))
                            {
                                ActiveApplicationID = GetID;
                            }
                        }
                        catch { ActiveApplicationID = -1; }
                    }
                }

                return ActiveApplicationID;
            }

            public static bool UpdateStatus(int AppID, short NewStatus)
            {
                int RowsAffected = 0;
                string StConnection = clsConnectionSettingsDVLD.ConnectionString;

                using (SqlConnection connection = new SqlConnection(StConnection))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateApplicationStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AppID", AppID);
                        command.Parameters.AddWithValue("@NewStatus", NewStatus);


                        try
                        {
                            connection.Open();
                            RowsAffected = command.ExecuteNonQuery();
                        }
                        catch { }
                    }
                }

                return (RowsAffected > 0);
            }


        }
        
}
