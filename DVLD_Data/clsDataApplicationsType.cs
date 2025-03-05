using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
        public class clsApplicationTypeDTO
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public int Fees { get; set; }

            public clsApplicationTypeDTO(int id, string title, int fees)
            {
                ID = id;
                Title = title;
                Fees = fees;
            }

        }

        public static class clsDataApplicationsType
        {
            public static List<clsApplicationTypeDTO> GetAllData()
            {
                List<clsApplicationTypeDTO> applicationTypes = new List<clsApplicationTypeDTO>();

                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_ApplicationTypes_GetAll", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    applicationTypes.Add(new clsApplicationTypeDTO(
                                        (int)reader["ID"],
                                        (string)reader["Title"],
                                        (int)reader["Fees"]
                                    ));
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }

                return applicationTypes;
            }

            public static clsApplicationTypeDTO GetApplicationTypeByID(int ID)
            {
                clsApplicationTypeDTO applicationType = null;

                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_ApplicationTypes_GetBy_ID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", ID);

                        try
                        {
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    applicationType = new clsApplicationTypeDTO(
                                        (int)reader["ID"],
                                        (string)reader["Title"],
                                        (int)reader["Fees"]
                                    );
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }

                return applicationType;
            }

            public static bool UpdateApplicationType(clsApplicationTypeDTO applicationType)
            {
                int rowsAffected = 0;

                using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_ApplicationTypes_Update", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ID", applicationType.ID);
                        command.Parameters.AddWithValue("@NewTitle", applicationType.Title);
                        command.Parameters.AddWithValue("@NewFees", applicationType.Fees);

                        try
                        {
                            connection.Open();
                            rowsAffected = command.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                    }
                }

                return rowsAffected > 0;
            }

        }


    
}
