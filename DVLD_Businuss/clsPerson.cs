using DVLD_Data;

namespace DVLD_Businuss
{
    public class clsPerson
    {
        public enum enMode { Update, Add }

        enMode Mode;

        public clsPeopleDTO PersonDTO
        {
            get
            {
                return new clsPeopleDTO(PersonID, NationalNo, FirstName,
                    SecondName, ThirdName, LastName, DateOfBith, Gender, Address, Phone,
                    Email, NationalityCountryID, ImagePath);
            }
        }

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
        public DateTime DateOfBith { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }

        public clsPerson(clsPeopleDTO peopleDTO, enMode mode = enMode.Add)
        {
            this.PersonID = peopleDTO.PersonID;
            this.FirstName = peopleDTO.FirstName;
            this.SecondName = peopleDTO.SecondName;
            this.LastName = peopleDTO.LastName;
            this.ThirdName = peopleDTO.ThirdName;
            this.LastName = peopleDTO.LastName;
            this.NationalNo = peopleDTO.NationalNo;
            this.Email = peopleDTO.Email;
            this.DateOfBith = peopleDTO.DateOfBirth;
            this.Phone = peopleDTO.Phone;
            this.Gender = peopleDTO.Gender;
            this.Address = peopleDTO.Address;
            this.NationalityCountryID = peopleDTO.NationalityCountryID;
            this.ImagePath = peopleDTO.ImagePath;

            Mode = mode;
        }

        public static clsPerson Find(int ID)
        {
            clsPeopleDTO personDTO =
                clsDataPeople.GetPersonInfoByID(ID);

            if (personDTO != null)
                return new clsPerson(personDTO, enMode.Update);
            else
                return null;
        }

        public static clsPerson Find(string NationalNo)
        {
            clsPeopleDTO personDTO =
                           clsDataPeople.FindPeopleByNationalNo(NationalNo);

            if (personDTO != null)
                return new clsPerson(personDTO, enMode.Update);
            else
                return null;
        }

        public static bool DeletePerson(int ID)
        {
            return clsDataPeople.DeleteInPeopleByPersonID(ID);
        }

        public static List<clsPeopleDTO> GetAllPeople()
        {
            return clsDataPeople.GetAllPeople();
        }

        public static bool PersonIsExist(int ID)
        {
            return clsDataPeople.PeopleIsExistByPersonID(ID);
        }

        public static bool PersonIsExist(string NationalNo)
        {
            return clsDataPeople.PeopleIsExistByNationalNo(NationalNo);
        }

        private bool _AddNewPerson()
        {
            clsPeopleDTO peopleDTO = PersonDTO;

            bool Result = clsDataPeople.AddInPeople(ref peopleDTO);

            PersonDTO.PersonID = peopleDTO.PersonID;

            return Result;
        }

        private bool _UpdatePerson()
        {
            return clsDataPeople.UpdateInPeople(PersonDTO);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return _UpdatePerson();
                    }

            }
            return false;
        }


    }


}
