using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
    public class clsTestAppointmentDTO : IValidatable
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointmentDTO(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID,
            DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
        }

        public bool IsValid(out string? ErrorMessage)
        {
            if (TestAppointmentID < 0)
            {
                ErrorMessage = "Test Appointment ID is not valid";
                return false;
            }

            if (TestTypeID < 0)
            {
                ErrorMessage = "Test Type ID is not valid";
                return false;
            }

            if (LocalDrivingLicenseApplicationID < 0)
            {
                ErrorMessage = "Local Driving License Application ID is not valid";
                return false;
            }        

            if (PaidFees < 0)
            {
                ErrorMessage = "Paid Fees cannot be negative";
                return false;
            }

            if (CreatedByUserID < 0)
            {
                ErrorMessage = "Created By User ID is not valid";
                return false;
            }

            ErrorMessage = null;
            return true;
        }


    }

    public static class clsDataTestAppointment
    {
        public static bool AddNewTestAppointments(ref clsTestAppointmentDTO appointment)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
                command.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        appointment.TestAppointmentID = newID;
                        return true;
                    }
                }
                catch { return false; }
                return false;
            }
        }

        public static bool UpdateTestAppointments(clsTestAppointmentDTO appointment)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TestAppointmentID", appointment.TestAppointmentID);
                command.Parameters.AddWithValue("@TestTypeID", appointment.TestTypeID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", appointment.LocalDrivingLicenseApplicationID);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUserID", appointment.CreatedByUserID);
                command.Parameters.AddWithValue("@IsLocked", appointment.IsLocked);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_SelectAll_View", connection))
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
                catch { /* Handle error */ }
            }

            return dataTable;
        }

        public static bool DeleteTestAppointments(int testAppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static clsTestAppointmentDTO FindTestAppointmentsByTestAppointmentID(int testAppointmentID)
        {
            clsTestAppointmentDTO appointment = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_Select_ByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appointment = new clsTestAppointmentDTO(
                                (int)reader["TestAppointmentID"],
                                (int)reader["TestTypeID"],
                                (int)reader["LocalDrivingLicenseApplicationID"],
                                (DateTime)reader["AppointmentDate"],
                                (decimal)reader["PaidFees"],
                                (int)reader["CreatedByUserID"],
                                (bool)reader["IsLocked"]
                            )
                            {
                                TestAppointmentID = testAppointmentID
                            };
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return appointment;
        }

        public static clsTestAppointmentDTO GetLastTestAppointment(int ldlAppID, int testTypeID)
        {
            clsTestAppointmentDTO appointment = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_SelectLast_ByLDLAppAndType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", ldlAppID);
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            appointment = new clsTestAppointmentDTO(
                                (int)reader["TestAppointmentID"],
                                testTypeID,
                                ldlAppID,
                                (DateTime)reader["AppointmentDate"],
                                (decimal)reader["PaidFees"],
                                (int)reader["CreatedByUserID"],
                                (bool)reader["IsLocked"]
                            )
                            {
                                TestAppointmentID = (int)reader["TestAppointmentID"]
                            };
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return appointment;
        }

        public static DataTable GetTestAppointmentPerTestType(int ldlAppID, int testTypeID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_TestAppointments_Select_ByLDLAppAndType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@LDLAppID", ldlAppID);
                command.Parameters.AddWithValue("@TestTypeID", testTypeID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                            dataTable.Load(reader);
                    }
                }
                catch { /* Handle error */ }
            }

            return dataTable;
        }

        public static int GetTestID(int testAppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Tests_SelectID_ByAppointmentID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
                catch { return -1; }
            }
        }
    }

}
