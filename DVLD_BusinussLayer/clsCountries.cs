using DVLD_DataAccessLayer;

using System.Collections.Generic;


namespace DVLD_BusinussLayer
{
    public class clsCountries
    {
        enum enMode { add , update}

        enMode Mode;

        public clsCountryDTO CountryDTO
        {
            get
            {
                return (new clsCountryDTO(this.ID , this.CountryName));
            }
        }

        public int ID { get; set; }
        public string CountryName { get; set; }

        private clsCountries(clsCountryDTO CountryDTO , enMode mode = enMode.add)
        {
            Mode = mode;

            this.ID =          CountryDTO.CountryID;
            this.CountryName = CountryDTO.CountryName;
        }

        public static List<clsCountryDTO> GetAllCountries()
        {
            return clsDataCountries.GetAllCountries();
        }

        public static clsCountries Find(string CountryName)
        {
            clsCountryDTO CountryDTO = clsDataCountries.FindCountryByName(CountryName);

            if (CountryDTO != null)
                return new clsCountries(CountryDTO, enMode.update);
            else 
                return null;

        }

        public static clsCountries Find(int CountryID)
        {
            clsCountryDTO CountryDTO = clsDataCountries.FindCountryById(CountryID);

            if (CountryDTO != null)
                return new clsCountries(CountryDTO, enMode.update);
            else
                return null;
        }

    }
}
