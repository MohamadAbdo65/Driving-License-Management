using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinussLayer.clsLicense;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinussLayer
{
    public class clsLicense
    {
        public  enum enMode { Add , Update} 
        enMode _Mode;        

        public clsLicenseDTO LicenseDTO
        {
            get
            {
                return new clsLicenseDTO(this.LicenseID , this.ApplicationID , this.DriverID , this.LicenseClassID,
                    this.IssueDate , this.ExpirationDate , this.Notes , this.PaidFees , 
                    this.IsActive , (byte)this.IssueReason , this.CreatedByUserID);
            }
        }

        public enum enIssueReason { FirstTime = 1 , Renew = 2 , DamagedReplacement = 3 , LostReplacement = 4 }

        public int LicenseID {  get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public string IssueReasonText
        {
            get 
            {
                if (IssueReason == enIssueReason.FirstTime)
                    return "First Time";
                else if (IssueReason == enIssueReason.Renew)
                    return "Renew";
                else if (IssueReason == enIssueReason.LostReplacement)
                    return "Lost Replacement";
                else if (IssueReason == enIssueReason.DamagedReplacement)
                    return "Damaged Replacement";
                else return "Unkown";
            }
        }
        public int CreatedByUserID { get; set; }

        public clsDrivers DriverInfo { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }

        //
        public clsDetainLicense DetainLicenseInfo { get; set; }
        public bool IsDetain
        {
            get { return clsDetainLicense.LicenseIsDetain(this.LicenseID); } 
        } 

        public clsLicense(clsLicenseDTO licenseDTO , enMode mode = enMode.Add)
        {            
            LicenseID = licenseDTO.LicenseID;
            ApplicationID = licenseDTO.ApplicationID;
            DriverID = licenseDTO.DriverID;
            LicenseClassID = licenseDTO.LicenseID;
            IssueDate = licenseDTO.IssueDate;
            ExpirationDate = licenseDTO.ExpirationDate;
            Notes = licenseDTO.Notes;
            PaidFees = licenseDTO.PaidFees;
            IsActive = licenseDTO.IsActive;
            IssueReason = (enIssueReason)licenseDTO.IssueReason;
            CreatedByUserID = licenseDTO.CreatedByUserID;

            DriverInfo = clsDrivers.FindByDriver(licenseDTO.DriverID);
            LicenseClassInfo = clsLicenseClass.Find(licenseDTO.LicenseClass);
            DetainLicenseInfo = clsDetainLicense.FindByLicenseID(LicenseID);

            _Mode = mode;
        }

        public static bool LicenseIsExist(int LicenseID)
        {
            return clsDataLicenses.LicensesIsExist(LicenseID);
        }

        public static bool IsLicenseExistByPersonID(int PersonID , int LicenseClassID)
        {
            return clsDataLicenses.IsLicenseExistByPersonID(PersonID , LicenseClassID);
        }

        bool _AddLicense()
        {
            clsLicenseDTO licenseDTO = LicenseDTO;

            bool Result = clsDataLicenses.AddNewLicenses(ref licenseDTO);

            this.LicenseID = licenseDTO.LicenseID;

            return Result;
                       
        }
        bool _UpdateLicense()
        {
            return clsDataLicenses.UpdateLicenses(LicenseDTO);
        }

        public bool Save()
        {
            if(enMode.Add == _Mode)
            {
                if (_AddLicense())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else if (enMode.Update == _Mode)
            {
                return _UpdateLicense();
            }
            return false;
        }

        public static DataTable GetAllLicense()
        {
            return clsDataLicenses.GetAllLicenses();
        }

        public static DataTable GetAllLicenseForDriver(int DriverID)
        {
            return clsDataLicenses.GetAllLicenseForDriver(DriverID);
        }

        public static clsLicense Find(int LicenseID)
        {
            clsLicenseDTO licenseDTO = 
                clsDataLicenses.FindLicensesByLicenseID(LicenseID);

            if (licenseDTO != null)
                return new clsLicense(licenseDTO , enMode.Update);
            return null;
        }

        public static int GetActiveLicenseID(int PersonID , int LicenseClassID)
        {
            return clsDataLicenses.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now);
        }

        public int DetainLicense (int FineFees , int UserID)
        {
            clsDetainLicense DL = new clsDetainLicense
            (
                new clsDetainLicenseDTO
                (
                    -1 , this.LicenseID ,
                    DateTime.Now , FineFees , UserID ,
                    false , null , null , null
                ) , 
                clsDetainLicense.enMode.add
            );

            if (!DL.Save())
            {
                return -1;
            }

            return DL.DetainID;
        }

        public bool ReleaseDetainLicense(int UserID , ref int AppID)
        {
            clsApplication Application = new clsApplication
            (
                new clsApplicationsDTO
                (
                    AppID , 
                    this.DriverInfo.PersonID,
                    DateTime.Now,
                    (int)clsApplication.enApplicationType.ReleaseDetainDrivingLicense,
                    (byte)clsApplication.enApplicationStatus.Complete , 
                    DateTime.Now ,
                    clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.ReleaseDetainDrivingLicense).Fees , 
                    UserID
                ) , 
                clsApplication.enMode.Add                
            );

            if (!Application.Save())
            {
                AppID = -1;
                return false;
            }

            AppID = Application.ApplicationID;

            return this.DetainLicenseInfo.ReleaseLicense(UserID, AppID);
        }

        public bool DeActiveCurrentLicense()
        {
            return clsDataLicenses.DeActiveLicense(this.LicenseID);
        }

        public clsLicense RenewLicense(string Notes, int UserID)
        {

            clsApplication application = new clsApplication
            (
                new clsApplicationsDTO(
                    -1,
                    this.DriverInfo.PersonID,
                    DateTime.Now,
                    (int)clsApplication.enApplicationType.RenewDrivingLicense,
                    (byte)clsApplication.enApplicationStatus.Complete,
                    DateTime.Now,
                    clsApplicationsType.GetApplicationType((int)clsApplication.enApplicationType.RenewDrivingLicense).Fees,
                    UserID ) , 
                clsApplication.enMode.Add
            );

            if(!application.Save())
            {
                return null;
            }

            clsLicense license = new clsLicense
            (
                new clsLicenseDTO
                (-1 , 
                application.ApplicationID,
                this.DriverID,
                this.LicenseClassID,
                DateTime.Now,
                DateTime.Now.AddYears(clsLicenseClass.Find(this.LicenseClassID).DefaultValidLenght),
                Notes,
                clsLicenseClass.Find(this.LicenseClassID).ClassFees,
                true,
                (byte)enIssueReason.Renew,
                UserID ) , enMode.Add                        
            );

            if (!license.Save())
            {
                return null;
            }

            DeActiveCurrentLicense();

            return license;
        }

        public clsLicense Replace(enIssueReason IssueReason , int UserID)
        {
            int applicationTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
                (int)clsApplication.enApplicationType.ReplaceDamageDrivingLecense :
                (int)clsApplication.enApplicationType.ReplaceLostDrivingLecense;

            clsApplication app = new clsApplication
            (
                new clsApplicationsDTO
                (-1 ,
                this.DriverInfo.PersonID,
                DateTime.Now,
                applicationTypeID ,
                (byte)clsApplication.enApplicationStatus.Complete,
                DateTime.Now,
                clsApplicationsType.GetApplicationType(applicationTypeID).Fees , 
                UserID) , clsApplication.enMode.Add               
            );

            if (!app.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense
            (
                new clsLicenseDTO 
                ( -1 ,
                app.ApplicationID , 
                this.DriverID ,
                this.LicenseClassID,
                this.IssueDate ,
                this.ExpirationDate ,
                this.Notes ,
                0,
                this.IsActive ,
                (byte)IssueReason ,
                UserID) , enMode.Add                
            );

            if(!NewLicense.Save())
            {
                return null;
            }

            DeActiveCurrentLicense();

            return NewLicense;
        }

        public static void VerifyLicenseActivity()
        {
             clsDataLicenses.VerifyLicenseActivity();
        }
    }
}