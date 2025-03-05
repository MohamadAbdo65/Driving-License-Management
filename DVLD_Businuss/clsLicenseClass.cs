using DVLD_Data;

namespace DVLD_Businuss
{
    public class clsLicenseClass
    {

        public clsLicenseClassDTO LicenseClassDTO
        {
            get
            {
                return new clsLicenseClassDTO(this.LicenseClassID, this.ClassName, this.ClassDescription
                    , (byte)this.MininumAllowAge, (byte)this.DefaultValidLenght, this.ClassFees);
            }
        }

        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MininumAllowAge { get; set; }
        public int DefaultValidLenght { get; set; }
        public int ClassFees { get; set; }

        private clsLicenseClass(clsLicenseClassDTO licenseClassDTO)
        {
            this.LicenseClassID = licenseClassDTO.LicenseClassID;
            this.ClassName = licenseClassDTO.ClassName;
            this.ClassDescription = licenseClassDTO.ClassDescription;
            this.MininumAllowAge = licenseClassDTO.MinimumAllowedAge;
            this.DefaultValidLenght = licenseClassDTO.DefaultValidityLength;
            this.ClassFees = licenseClassDTO.ClassFees;
        }


        public static List<clsLicenseClassDTO> GetAllLicenseClasses()
        {
            return clsDataLicensesClass.GetAllLicensesClass();
        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            clsLicenseClassDTO licenseClassDTO =
                clsDataLicensesClass.FindByLicenseClassID(LicenseClassID);

            if (licenseClassDTO != null)
                return new clsLicenseClass(licenseClassDTO);
            else
                return null;
        }

    }


}
