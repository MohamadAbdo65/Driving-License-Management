using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinussLayer
{
    public class clsDetainLicense
    {
        public enum enMode { add , update }
        enMode _Mode;

        public clsDetainLicenseDTO DetainDTO
        {
            get
            {
                return (new clsDetainLicenseDTO(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseAppID));
            }
        }

        public int      DetainID         { get; set; }
        public int      LicenseID        { get; set; }
        public DateTime DetainDate       { get; set; }
        public int      FineFees         { get; set; }
        public int      CreatedByUserID  { get; set; }
        public bool     IsReleased       { get; set; }
        public DateTime? ReleaseDate      { get; set; }
        public int   ?   ReleasedByUserID { get; set; }
        public int    ?  ReleaseAppID     { get; set; }


        public clsDetainLicense(clsDetainLicenseDTO DetainDTO , enMode mode = enMode.add)
        {
            this.DetainID =         DetainDTO.DetainID;
            this.LicenseID =        DetainDTO.LicenseID;
            this.DetainDate =       DetainDTO.DetainDate;
            this.FineFees =    (int)DetainDTO.FineFees;
            this.CreatedByUserID =  DetainDTO.CreatedByUserID;
            this.IsReleased =       DetainDTO.IsReleased;
            this.ReleaseDate =      DetainDTO.ReleaseDate;
            this.ReleasedByUserID = DetainDTO.ReleasedByUserID;
            this.ReleaseAppID =     DetainDTO.ReleaseApplicationID;

            _Mode = mode;
        }

        public static clsDetainLicense FindByLicenseID(int LicenseID)
        {
            clsDetainLicenseDTO detainDTO = clsDataDetain.FindDetainedLicensesByLicenseID(LicenseID);

            if (detainDTO != null)
                return new clsDetainLicense(detainDTO, enMode.update);
            else 
                return null;

        }

        public static List<clsDetainLicenseDTO> GetAllDetainLicenses()
        {
            return clsDataDetain.GetAllDetainedLicenses();
        }

        public static DataTable GetAllDetainLicenses_View()
        {
            return clsDataDetain.GetAllDetainedLicenses_View();
        }

        bool _Add()
        {
            clsDetainLicenseDTO detainDTO = DetainDTO;

            bool Result = clsDataDetain.AddNewDetainedLicenses(ref detainDTO);

            this.DetainID = detainDTO.DetainID;

            return Result;
        }

        bool _Update()
        {
            return clsDataDetain.UpdateDetainedLicenses(DetainDTO);
        }

        public bool Save()
        {
            if (_Mode == enMode.add)
            {
                if (_Add())
                {
                    _Mode = enMode.update;
                    return true;
                }
                else
                    return false;
            }
            else if (_Mode == enMode.update)
            {
                return _Update();
            }
            return false;
        }

        public bool LicenseIsDetain()
        {
            return LicenseIsDetain(this.LicenseID);
        }

        public static bool LicenseIsDetain(int LicenseID)
        {
            return clsDataDetain.LicensesIsDetain(LicenseID);
        }

        public bool ReleaseLicense(int UserID , int AppID)
        {
            return clsDataDetain.ReleaseDetainLicense(this.DetainID, UserID, AppID);
        }

    }
}
