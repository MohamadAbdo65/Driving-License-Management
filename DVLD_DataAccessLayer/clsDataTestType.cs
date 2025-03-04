using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConnectionSettings;


namespace DVLD_DataAccessLayer
{


    public class clsTestTypeDTO
    {
        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }

        public clsTestTypeDTO(int testTypeID, string title, string description, decimal fees)
        {
            TestTypeID = testTypeID;
            Title = title;
            Description = description;
            Fees = fees;
        }

        public clsTestTypeDTO() { }
    }
    

    public static class clsDataTestType
    {
        public static List<clsTestTypeDTO> GetAllData()
        {
            List<clsTestTypeDTO> testTypes = new List<clsTestTypeDTO>();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestTypes_SelectAll", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            testTypes.Add(new clsTestTypeDTO(
                                (int)reader["TestTypeID"],
                                (string)reader["TestTypeTitle"],
                                (string)reader["TestTypeDescription"],
                                (decimal)reader["TestTypeFees"]
                            ));
                        }
                    }
                }
                catch { /* Error handling */ }
            }

            return testTypes;
        }

        public static clsTestTypeDTO GetTestTypeByID(int testTypeID)
        {
            clsTestTypeDTO testType = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestTypes_SelectByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            testType = new clsTestTypeDTO(
                                testTypeID,
                                (string)reader["TestTypeTitle"],
                                (string)reader["TestTypeDescription"],
                                (decimal)reader["TestTypeFees"]
                            );
                        }
                    }
                }
                catch { /* Error handling */ }
            }

            return testType;
        }

        public static bool UpdateTestTypeInfo(clsTestTypeDTO testType)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestTypes_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TestTypeID", testType.TestTypeID);
                command.Parameters.AddWithValue("@Title", testType.Title);
                command.Parameters.AddWithValue("@Description", testType.Description);
                command.Parameters.AddWithValue("@Fees", testType.Fees);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }
    }
}