using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinussLayer
{
    public class clsUsers
    {
        public enum enMode {Add , Update }

        private enMode _Mode;

        public clsUserDTO UserDTO
        {
            get
            {
                return new clsUserDTO(UserID , PersonID , Username , Password , IsActive);
            }
        }


        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsPerson PersonInfo;

        public clsUsers(clsUserDTO userDTO , enMode mode = enMode.Add)
        {
            _Mode = mode;

            this.UserID   = userDTO.UserID;
            this.PersonID = userDTO.PersonID;
            this.Username = userDTO.Username;
            this.Password = userDTO.Password;
            this.IsActive = userDTO.IsActive;

            this.PersonInfo = clsPerson.Find(PersonID);
        }

        public static DataTable GetAllUsers()
        {
            return clsDataUsers.GetAllUsers();
        }

        public static bool UserIsExist(int UserID)
        {
            return clsDataUsers.UserIsExist(UserID);
        }

        public static bool UserIsExist(string Username)
        {
            return clsDataUsers.UserIsExist(Username);
        }

        public static bool UserExistByPersonID(int PersonID)
        {
            return clsDataUsers.UserIsExistByPersonID(PersonID);
        }

        public static bool DeleteUser(int UserID)
        {
            return clsDataUsers.DeleteUser(UserID);
        }



        private bool _AddNewUser()
        {
            clsUserDTO userDTO = UserDTO;

            bool Result = clsDataUsers.AddNewUser(ref userDTO);

            this.UserID = userDTO.UserID;

            return Result;
        }

        private bool _UpdateUser()
        {
            return clsDataUsers.UpdateUser(UserDTO);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                {
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                case enMode.Update:
                {
                    return _UpdateUser();
                }
            }
            return false;
        }



        public static clsUsers GetUser(int UserID)
        {
            clsUserDTO userDTO = clsDataUsers.GetUserByID(UserID);

            if (userDTO != null)
                return new clsUsers(userDTO, enMode.Update);
            else
                return null;
        }

        public static clsUsers GetUser(string Username)
        {
            clsUserDTO userDTO = clsDataUsers.GetUserByUsername(Username);

            if (userDTO != null)
                return new clsUsers(userDTO, enMode.Update);
            else
                return null;
        }

    }
}
