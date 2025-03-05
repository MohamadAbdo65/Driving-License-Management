using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
    public class clsUserDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUserDTO(int userID, int personID, string username, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            Username = username;
            Password = password;
            IsActive = isActive;
        }
    }

    public static class clsDataUsers
    {
        public static clsUserDTO GetUserByID(int userID)
        {
            clsUserDTO user = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_SelectByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new clsUserDTO(
                                (int)reader["UserID"],
                                (int)reader["PersonID"],
                                (string)reader["UserName"],
                                (string)reader["Password"],
                                (bool)reader["IsActive"]
                            )
                            {
                                UserID = userID
                            };
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return user;
        }

        public static clsUserDTO GetUserByUsername(string username)
        {
            clsUserDTO user = null;

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_SelectByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new clsUserDTO(
                                (int)reader["UserID"],
                                (int)reader["PersonID"],
                                username,
                                (string)reader["Password"],
                                (bool)reader["IsActive"]
                            );
                        }
                    }
                }
                catch { /* Handle error */ }
            }

            return user;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_SelectAll", connection))
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

        public static bool AddNewUser(ref clsUserDTO user)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_Insert", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        user.UserID = newID;
                        return true;
                    }
                }
                catch { return false; }
                return false;
            }
        }

        public static bool UpdateUser(clsUserDTO user)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_Update", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.Parameters.AddWithValue("@PersonID", user.PersonID);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@IsActive", user.IsActive);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static bool DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_Delete", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch { return false; }
            }
        }

        public static bool UserIsExist(int userID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_ExistsByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static bool UserIsExist(string username)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_ExistsByUsername", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    return (bool)command.ExecuteScalar();
                }
                catch { return false; }
            }
        }

        public static bool UserIsExistByPersonID(int personID)
        {
            using (SqlConnection connection = new SqlConnection(clsConnectionSettingsDVLD.ConnectionString))
            using (SqlCommand command = new SqlCommand("SP_Users_ExistsByPersonID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PersonID", personID);

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
