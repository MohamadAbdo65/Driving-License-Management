using DVLD_Data;
using System.Data;

namespace DVLD_Businuss
{
    public class clsDrivers
    {
        public enum enMode { Add, Update }
        enMode _Mode;

        public clsDriverDTO DriverDTO
        {
            get
            {
                return new clsDriverDTO(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
            }
        }

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public clsPerson PersonInfo { get; set; }


        public clsDrivers(clsDriverDTO driverDTO, enMode mode = enMode.Add)
        {
            this.DriverID = driverDTO.DriverID;
            this.PersonID = driverDTO.PersonID;
            this.CreatedByUserID = driverDTO.CreatedByUserID;
            this.CreatedDate = driverDTO.CreatedDate;
            this.PersonInfo = clsPerson.Find(PersonID);

            _Mode = mode;
        }

        private bool _AddDriver()
        {
            clsDriverDTO driverDTO = DriverDTO;

            bool Result = clsDataDrivers.AddNewDrivers(ref driverDTO);

            this.DriverID = driverDTO.DriverID;

            return Result;
        }

        private bool _UpdateDriver()
        {
            return clsDataDrivers.UpdateDrivers(DriverDTO);
        }

        public bool Save()
        {
            if (_Mode == enMode.Add)
            {
                if (_AddDriver())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else return false;
            }
            else if (_Mode == enMode.Update)
            {
                return _UpdateDriver();
            }
            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDataDrivers.GetAllDrivers_View();
        }

        public static clsDrivers FindByDriver(int DriverID)
        {
            clsDriverDTO driverDTO = clsDataDrivers.FindDriversByDriverID(DriverID);

            if (driverDTO != null)
                return new clsDrivers(driverDTO, enMode.Update);

            else return null;

        }

        public static clsDrivers FindByPerson(int PersonID)
        {
            clsDriverDTO driverDTO = clsDataDrivers.FindDriversByPersonID(PersonID);

            if (driverDTO != null)
                return new clsDrivers(driverDTO, enMode.Update);

            else return null;
        }

        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicense.GetAllLicenseForDriver(DriverID);
        }

        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return new DataTable(); // Code Here !!
        }


    }


}
