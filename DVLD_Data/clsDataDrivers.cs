﻿using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;


namespace DVLD_Data
{

    public class clsDriverDTO : IValidatable
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsDriverDTO(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        public bool IsValid(out string? ErrorMessage)
        {
            if(DriverID < 0) { ErrorMessage = "Driver ID is not valid"; return false; }
            if(PersonID < 0) { ErrorMessage = "Person ID is not valid"; return false; }
            if(CreatedByUserID < 0) { ErrorMessage = "User ID is not valid"; return false; }

            ErrorMessage = null;
            return true;
        }
    }

    public static class clsDataDrivers
    {
        public static bool AddNewDrivers(ref clsDriverDTO driver)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        driver.DriverID = newID;
                        return true;
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
                return false;
            }
        }

        public static clsDriverDTO FindDriversByDriverID(int driverID)
        {
            clsDriverDTO driver = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_Select_ByDriverID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            driver = new clsDriverDTO(
                                (int)reader["DriverID"],
                                (int)reader["PersonID"],
                                (int)reader["CreatedByUserID"],
                                (DateTime)reader["CreatedDate"]
                            );
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return driver;
        }

        public static bool DeleteDrivers(int driverID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_Delete_ByDriverID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static DataTable GetAllDrivers_View()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_SelectAll_View", connection))
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

        public static bool UpdateDrivers(clsDriverDTO driver)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_Update_ByDriverID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DriverID", driver.DriverID);
                command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                command.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                command.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static clsDriverDTO FindDriversByPersonID(int personID)
        {
            clsDriverDTO driver = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Drivers_Select_ByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            driver = new clsDriverDTO(
                                (int)reader["DriverID"],
                                (int)reader["PersonID"],
                                (int)reader["CreatedByUserID"],
                                (DateTime)reader["CreatedDate"]
                            );
                        }
                    }
                }
                catch { /* تم إزالة الـ Logger */ }
            }

            return driver;
        }
    }


}
