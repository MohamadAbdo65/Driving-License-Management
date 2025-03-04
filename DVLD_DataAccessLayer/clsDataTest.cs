using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConnectionSettings;


namespace DVLD_DataAccessLayer
{
    public class clsTestDTO
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTestDTO(int testId , int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testId;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;
        }

    }


    public static class clsDataTest
    {
        public static bool AddNewTests(ref clsTestDTO test)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
                command.Parameters.AddWithValue("@TestResult", test.TestResult);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(test.Notes) ? DBNull.Value : (object)test.Notes);
                command.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        test.TestID = newID;
                        return true;
                    }
                }
                catch { return false; }
                return false;
            }
        }

        public static bool UpdateTests(clsTestDTO test)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TestID", test.TestID);
                command.Parameters.AddWithValue("@TestAppointmentID", test.TestAppointmentID);
                command.Parameters.AddWithValue("@TestResult", test.TestResult);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(test.Notes) ? DBNull.Value : (object)test.Notes);
                command.Parameters.AddWithValue("@CreatedByUserID", test.CreatedByUserID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static List<clsTestDTO> GetAllTests()
        {
            var AllTests = new List<clsTestDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_SelectAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            AllTests.Add(
                                new clsTestDTO(
                                    (int)reader["TestID"],
                                    (int)reader["TestAppointmentID"],
                                    (bool)reader["TestResult"],
                                    (string)reader["Notes"],
                                    (int)reader["CreatedByUserID"]
                                    ));
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return AllTests;
        }

        public static clsTestDTO FindTestsByTestID(int testID)
        {
            clsTestDTO test = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_Select_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TestID", testID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            test = new clsTestDTO(
                                (int)reader["TestID"],
                                (int)reader["TestAppointmentID"],
                                (bool)reader["TestResult"],
                                reader["Notes"] as string ?? string.Empty,
                                (int)reader["CreatedByUserID"]
                            )
                            {
                                TestID = testID
                            };
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return test;
        }

        public static clsTestDTO GetLastTestByPersonAndTestTypeAndLicenseClass(int personID, int licenseClassID, int testTypeID)
        {
            clsTestDTO test = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_SelectLast_ByPersonAndType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);
                command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            test = new clsTestDTO(
                                (int)reader["TestID"],
                                (int)reader["TestAppointmentID"],
                                (bool)reader["TestResult"],
                                reader["Notes"] as string ?? string.Empty,
                                (int)reader["CreatedByUserID"]
                            )
                            {
                                TestID = (int)reader["TestID"]
                            };
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return test;
        }

        public static int GetPassedTestCount(int ldlAppID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_CountPassed_ByLDLApp", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", ldlAppID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
                catch { return 0; }
            }
        }
    }
}