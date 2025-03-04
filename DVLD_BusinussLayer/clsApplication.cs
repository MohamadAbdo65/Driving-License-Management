using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_BusinussLayer
{
    public class clsApplication
    {
        public enum enMode { Add, Update };

        public enum enApplicationType { NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLecense = 3
        , ReplaceDamageDrivingLecense = 4, ReleaseDetainDrivingLicense = 5, NewInternationalLicense = 6, RetakeTest = 8 };

        public enum enApplicationStatus { New = 1, Canceled = 2, Complete = 3 };

        protected enMode _Mode;
        
        
        public clsApplicationsDTO ApplicationDTO
        {
            get 
            {
                return (new clsApplicationsDTO(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate
                , this.ApplicationTypeID, (byte)this.ApplicationStatus, this.LastUpdateStatus, this.PaidFees
                , this.CreateByUserID));
            }
        }


        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public string ApplicantFullName { get { return clsPerson.Find(ApplicantPersonID).FullName; } }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationsType ApplicationsTypeInfo { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public string StatusText 
        {
            get
            {
                switch(ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        { return "New"; }
                    case enApplicationStatus.Canceled:
                        { return "Canceled"; }
                    case enApplicationStatus.Complete:
                        { return "Complete"; }
                    default:
                        return "Unknown";
                }
            }
        
        }
        public DateTime LastUpdateStatus { get; set; }
        public int PaidFees { get; set; }
        public int CreateByUserID { get; set; }
        public clsUsers CreateByUserInfo { get; set; }
              
        public clsApplication(clsApplicationsDTO applicationsDTO , enMode mode = enMode.Add)
        {
            _Mode = mode;

            this.ApplicationID        = applicationsDTO.ApplicationID;
            this.ApplicantPersonID    = applicationsDTO.ApplicantPersonID;
            this.ApplicationDate      = applicationsDTO.ApplicationDate;
            this.ApplicationTypeID    = applicationsDTO.ApplicationTypeID;
            this.ApplicationStatus    = (enApplicationStatus)applicationsDTO.ApplicationStatus;
            this.LastUpdateStatus     = applicationsDTO.LastStatusDate;
            this.PaidFees             = applicationsDTO.PaidFees;
            this.CreateByUserID       = applicationsDTO.CreatedByUserID;

            this.CreateByUserInfo     = clsUsers.GetUser(applicationsDTO.CreatedByUserID);
            this.ApplicationsTypeInfo = clsApplicationsType.GetApplicationType(ApplicationTypeID);
            this.PersonInfo           = clsPerson.Find(ApplicantPersonID);
                    
        }

        public static List<clsApplicationsDTO> GetAllApplications()
        {
            return clsDataApplications.GetAllApplications();
        }

        private bool _AddNewApplication()
        {
            clsApplicationsDTO applicationsDTO = ApplicationDTO;

            bool Result = clsDataApplications.AddApplication(ref applicationsDTO);

            this.ApplicationID = applicationsDTO.ApplicationID;

            return Result;
        }

        private bool _UpdateApplication()
        {
            return (clsDataApplications.UpdateApplication(ApplicationDTO));
        }

        public static clsApplication GetBaseApplication(int ApplicationID)
        {
            clsApplicationsDTO applicationsDTO = clsDataApplications.GetApplicationByID(ApplicationID);

            if (applicationsDTO != null)
                return new clsApplication(applicationsDTO, enMode.Update);
            else
                return null;
        }

        public bool Cancel()
        {
            return clsDataApplications.UpdateStatus(this.ApplicationID , (short)enApplicationStatus.Canceled);
        }

        public bool SetComplete()
        {
            return clsDataApplications.UpdateStatus (this.ApplicationID , (short)enApplicationStatus.Complete);
        }

        public static  bool Cancel(int AppID)
        {
            return clsDataApplications.UpdateStatus(AppID, (short)enApplicationStatus.Canceled);
        }

        public static bool SetComplete(int AppID)
        {
            return clsDataApplications.UpdateStatus(AppID, (short)enApplicationStatus.Complete);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                {
                    if (_AddNewApplication())
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
                    return _UpdateApplication();
                }
            }
            return false;
        }

        public static bool Delete(int BaseAppID)
        {
            return clsDataApplications.DeleteApplication(BaseAppID);
        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsDataApplications.ApplicationIsExist(ApplicationID);
        }

        public static bool DoesPersonHaveActiveApp(int PersonID , int ApplicationTypeID)
        {
            return clsDataApplications.DoesPersonHaveActiveApplication(PersonID , ApplicationTypeID);
        }

        public bool DoesPersonHaveActiveApp(int ApplicationTypeID)
        {
            return clsDataApplications.DoesPersonHaveActiveApplication(this.ApplicantPersonID , ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID , clsApplication.enApplicationType AppType)
        {
            return clsDataApplications.GetActiveApplicationID(PersonID, (int)AppType);
        }

        public int GetActiveApplicationTypeID(clsApplication.enApplicationType ApplicationType)
        {
            return clsDataApplications.GetActiveApplicationID(this.ApplicantPersonID , (int)ApplicationType);
        }

        public static int GetActiveApplicationTypeIDForLicense(int PersonId , clsApplication.enApplicationType ApplicationType , int LicenseClassID)
        {
            return clsDataApplications.GetActiveApplicationIDForLicenseClass(PersonId, (int)ApplicationType, LicenseClassID);
        }

    }
}
