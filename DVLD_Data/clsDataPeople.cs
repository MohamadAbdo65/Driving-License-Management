using Microsoft.Data.SqlClient;
using DVLD_ConnectionSettings;
using System.Data;

namespace DVLD_Data
{
     public class clsPeopleDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
            set
            {
                FirstName = value;
            }
        }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string? ImagePath { get; set; }

        public clsPeopleDTO(int ID, string NationalNO, string FirstName, string SecondName, string ThirdName,
        string LastName, DateTime DateOfBirth, int Gender, string Address, string Phone, string Email,
         int NationalityCountryID, string? PathImage)
        {
            this.PersonID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNO;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Gender = Gender;
            this.Address = Address;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = PathImage;
        }
    }


    public static class clsDataPeople
    {
        // Get - Person - By - ID
        public static clsPeopleDTO GetPersonInfoByID(int PersonID)
        {
            clsPeopleDTO Person = null;

            string ConnectionString = clsConnectionSettingsDVLD.ConnectionString;

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("SP_People_FindBy_ID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        Connection.Open();

                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string? ImgPath = null;
                                if (reader["ImagePath"] != DBNull.Value)
                                    ImgPath = (string)reader["ImagePath"];

                                Person = new clsPeopleDTO(
                                    PersonID ,
                                    (string)reader["NationalNo"] ,
                                    (string)reader["FirstName"],
                                    (string)reader["SecondName"],
                                    (string)reader["ThirdName"] ,
                                    (string)reader["LastName"] ,
                                    (DateTime)reader["DateOfBirth"] ,
                                    (int)reader["Gender"] ,
                                    (string)reader["Address"] ,
                                    (string)reader["Phone"] ,
                                    (string)reader["Email"] ,
                                    (int)reader["NationalityCountryID"] , 
                                    ImgPath
                                    );

                              
                            }
                            else
                            {
                                Person = null;
                            }
                        }
                    }
                    catch { Person = null; }
                }
            }
            return Person;
        }

        // Get - Person - By - NO
        public static clsPeopleDTO FindPeopleByNationalNo(System.String NationalNo)
        {
            clsPeopleDTO Person = null;

            string Connection = clsConnectionSettingsDVLD.ConnectionString;

            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_FindBy_NO", connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Person.NationalNo = (System.String)reader["NationalNo"];
                                Person.FirstName = (System.String)reader["FirstName"];
                                Person.SecondName = (System.String)reader["SecondName"];
                                Person.ThirdName = (System.String)reader["ThirdName"];
                                Person.LastName = (System.String)reader["LastName"];
                                Person.DateOfBirth = (System.DateTime)reader["DateOfBirth"];
                                Person.Gender = (System.Int32)reader["Gender"];
                                Person.Address = (System.String)reader["Address"];
                                Person.Phone = (System.String)reader["Phone"];
                                Person.Email = (System.String)reader["Email"];
                                Person.NationalityCountryID = (System.Int32)reader["NationalityCountryID"];
                                Person.ImagePath = (System.String)reader["ImagePath"];
                            }
                        }
                    }
                    catch { Person = null; }
                }
            }
            return Person;
        }

        //Code Of Is Exist - ID : 
        public static bool PeopleIsExistByPersonID(System.Int32 PersonID)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettingsDVLD.ConnectionString;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_IsExist_ID", connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        IsFound = ((string)command.ExecuteScalar() != null) ? true : false;
                    }
                    catch { }
                }
            }
            return IsFound;
        }

        //Code Of Is Exist - NO : 
        public static bool PeopleIsExistByNationalNo(System.String NationalNo)
        {
            bool IsFound = false;
            string Connection = clsConnectionSettingsDVLD.ConnectionString;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_IsExist_NO", connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {
                        connection.Open();
                        IsFound = ((string)command.ExecuteScalar() != null) ? true : false;
                    }
                    catch { }
                }
            }
            return IsFound;
        }

        //Code Of Insert : 
        public static bool AddInPeople(ref clsPeopleDTO Person)
        {
            bool IsAdded = false;

            if (PeopleIsExistByNationalNo(Person.NationalNo)) return false;

            string connectionString = clsConnectionSettingsDVLD.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_People_Insert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NationalNo", Person.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                    command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                    command.Parameters.AddWithValue("@ThirdName", Person.ThirdName);
                    command.Parameters.AddWithValue("@LastName", Person.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Person.Gender);
                    command.Parameters.AddWithValue("@Address", Person.Address);
                    command.Parameters.AddWithValue("@Phone", Person.Phone);
                    command.Parameters.AddWithValue("@Email", Person.Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", Person.NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);


                    SqlParameter outputIdParam = new SqlParameter("@PersonID", SqlDbType.Int) { Direction = ParameterDirection.Output };

                    command.Parameters.Add(outputIdParam);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Person.PersonID = (int)command.Parameters["@PersonID"].Value;
                        IsAdded = true;
                    }
                    catch { }
                }
            }
            return IsAdded;
        }

        //Code Of Update : 
        public static bool UpdateInPeople(clsPeopleDTO Person)
        {
            short RowEffected = 0;

            string connectionString = clsConnectionSettingsDVLD.ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_People_Update", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", Person.PersonID);
                    command.Parameters.AddWithValue("@NationalNo", Person.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", Person.FirstName);
                    command.Parameters.AddWithValue("@SecondName", Person.SecondName);
                    command.Parameters.AddWithValue("@ThirdName", Person.ThirdName);
                    command.Parameters.AddWithValue("@LastName", Person.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", Person.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", Person.Gender);
                    command.Parameters.AddWithValue("@Address", Person.Address);
                    command.Parameters.AddWithValue("@Phone", Person.Phone);
                    command.Parameters.AddWithValue("@Email", Person.Email);
                    command.Parameters.AddWithValue("@NationalityCountryID", Person.NationalityCountryID);
                    command.Parameters.AddWithValue("@ImagePath", Person.ImagePath);


                    try
                    {
                        connection.Open();
                        RowEffected = (short)command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }

        //Code Of Delete : 
        public static bool DeleteInPeopleByPersonID(System.Int32 PersonID)
        {
            int RowEffected = 0;
            string Connection = clsConnectionSettingsDVLD.ConnectionString;
            using (SqlConnection connection = new SqlConnection(Connection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_Delete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open(); RowEffected = command.ExecuteNonQuery();
                    }
                    catch { }
                }
            }
            return (RowEffected > 0) ? true : false;
        }

        //Code Of Get All : 
        public static List<clsPeopleDTO> GetAllPeople()
        {
            var AllPeople = new List<clsPeopleDTO>();

            string StConnection = clsConnectionSettingsDVLD.ConnectionString;
            using (SqlConnection connection = new SqlConnection(StConnection))
            {
                using (SqlCommand command = new SqlCommand("SP_People_GetAll", connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AllPeople.Add(
                                    new clsPeopleDTO(
                                    reader.GetInt32(reader.GetOrdinal("PersonID")),
                                    reader.GetString(reader.GetOrdinal("NationalNo")),
                                    reader.GetString(reader.GetOrdinal("FirstName")),
                                    reader.GetString(reader.GetOrdinal("SecondName")),
                                    reader.GetString(reader.GetOrdinal("ThirdName")),
                                    reader.GetString(reader.GetOrdinal("LastName")),
                                    reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                    reader.GetInt32(reader.GetOrdinal("Gender")),
                                    reader.GetString(reader.GetOrdinal("Address")),
                                    reader.GetString(reader.GetOrdinal("Phone")),
                                    reader.GetString(reader.GetOrdinal("Email")),
                                    reader.GetInt32(reader.GetOrdinal("NationalityCountryID")),
                                    reader.GetString(reader.GetOrdinal("ImagePath"))
                                                    )
                                             );
                            }
                        }
                    }
                    catch { }
                }
            }
            return AllPeople;
        }





    }

}
