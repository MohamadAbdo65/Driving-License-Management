using DVLD_Data;

namespace DVLD_Businuss
{
    public class clsInternationalLicense
    {
        public enum enMode { Add, Update }
        enMode _Mode;

        public clsInternationalLicenseDTO InternationalLicenseDTO
        {
            get
            {
                return new clsInternationalLicenseDTO(this.InterLicenseID, this.ApplicationID,
                this.DriverID, this.LocalLicensID, this.IssueDate, this.ExpirationDate, this.IsActive,
                this.CreatedByUserID);
            }
        }

        public int InterLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LocalLicensID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense LocalLicenseInfo { get; set; }
        public clsApplication ApplicationInfo { get; set; }


        public clsInternationalLicense(clsInternationalLicenseDTO internationalLicenseDTO,
            enMode mode = enMode.Add)
        {
            InterLicenseID = internationalLicenseDTO.InternationalLicenseID;
            ApplicationID = internationalLicenseDTO.ApplicationID;
            DriverID = internationalLicenseDTO.DriverID;
            LocalLicensID = internationalLicenseDTO.IssuedUsingLocalLicenseID;
            IssueDate = internationalLicenseDTO.IssueDate;
            ExpirationDate = internationalLicenseDTO.ExpirationDate;
            IsActive = internationalLicenseDTO.IsActive;
            CreatedByUserID = internationalLicenseDTO.CreatedByUserID;

            LocalLicenseInfo = clsLicense.Find(this.LocalLicensID);
            ApplicationInfo = clsApplication.GetBaseApplication(ApplicationID);

            _Mode = mode;
        }


        public static clsInternationalLicense Find(int InternationalID)
        {
            clsInternationalLicenseDTO internationalLicenseDTO =
                clsDataInternationalLicense.FindInternationalLicensesByInternationalLicenseID
                (InternationalID);

            if (internationalLicenseDTO != null)
                return new clsInternationalLicense(internationalLicenseDTO, enMode.Update);
            return null;
        }

        public static List<clsInternationalLicenseDTO> GetAllInternationalLicenses()
        {
            return clsDataInternationalLicense.GetAllInternationalLicenses();
        }

        private bool _Add()
        {
            clsInternationalLicenseDTO internationalLicenseDTO =
                InternationalLicenseDTO;

            bool Result = clsDataInternationalLicense.AddNewInternationalLicenses(ref internationalLicenseDTO);

            this.InterLicenseID = internationalLicenseDTO.InternationalLicenseID;

            return Result;
        }

        private bool _Update()
        {
            return clsDataInternationalLicense.UpdateInternationalLicenses(InternationalLicenseDTO);
        }

        public bool Save()
        {
            if (_Mode == enMode.Add)
            {
                if (_Add())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else { return false; }
            }
            else if (_Mode == enMode.Update)
            {
                return _Update();
            }
            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            return clsDataInternationalLicense.GetActiveInternationalLicenseIDByDriverID(DriverID);
        }

        public static bool IsInterLicenseExist(int InterLicenseID)
        {
            return clsDataInternationalLicense.InternationalLicensesIsExist(InterLicenseID);
        }

        public static List<clsInternationalLicenseDTO> GetAllInterLicensesForDriver(int DriverID)
        {
            List<clsInternationalLicenseDTO> Licenses =
                clsDataInternationalLicense.GetAllInternationalLicensesByDriverID
                (DriverID);

            return Licenses;
        }

        public static void VerifyLicenseActivity()
        {
            clsDataInternationalLicense.VerifyLicenseActivity();
        }

    }


}
