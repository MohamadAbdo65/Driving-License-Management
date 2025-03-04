using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinussLayer
{
    public class clsLocalDrivingLicenseApplication /*: clsApplication*/
    {
        public enum enMode { Add, Update };

        enMode _Mode;

        public clsLocalDrivingLicenseApplicationDTO LDLAppDTO
        {
            get
            {
                return new clsLocalDrivingLicenseApplicationDTO(this.LDLAppID , this.BaseApplicationID , this.LicenseClassID);
            }
        }
         

        public int LDLAppID { get; set; }
        public int BaseApplicationID { get; set; }
        public int LicenseClassID { get; set; }


        public clsLicenseClass licenseClassInfo;
        public clsApplication ApplicationInfo;

        public  clsLocalDrivingLicenseApplication(clsLocalDrivingLicenseApplicationDTO LDLappId , enMode mode = enMode.Add)
        {
            this.LDLAppID = LDLappId.LDLAppID;
            this.BaseApplicationID = LDLappId.BaseAppID;
            this.LicenseClassID = LDLappId.LicenseClassID;

            this.licenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            this.ApplicationInfo = clsApplication.GetBaseApplication(BaseApplicationID);

            _Mode = mode;
        }



        public static List<clsLocalDrivingLicenseApplicationDTO> GetAllLDLApplications()
        {
            return clsDataLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
        }

        public static clsLocalDrivingLicenseApplication FindByID(int LDLAppID)
        {
            clsLocalDrivingLicenseApplicationDTO LDLapp = 
                clsDataLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByID
                (LDLAppID);

            if (LDLapp != null)
                return new clsLocalDrivingLicenseApplication(LDLapp, enMode.Update);
            else
                return null;
        }

        public static clsLocalDrivingLicenseApplication FindByBaseAppID(int BaseAppID)
        {
            clsLocalDrivingLicenseApplicationDTO LDLapp =
               clsDataLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationInfoByBaseAppID
               (BaseAppID);

            if (LDLapp != null)
                return new clsLocalDrivingLicenseApplication(LDLapp, enMode.Update);
            else
                return null;
        }

        private bool _AddNewLocalDrivingLicenseApplication()
        {
            clsLocalDrivingLicenseApplicationDTO LDLappId = LDLAppDTO;

            bool Result = clsDataLocalDrivingLicenseApplication.AddNewLoacalDriveLicenseApplication(ref LDLappId);

            this.LDLAppID = LDLappId.LDLAppID;

            return Result;  
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return clsDataLocalDrivingLicenseApplication.UpdateLocalDrivingApplication(LDLAppDTO);
        }

        public bool Save()
        {
            //base._Mode = (clsApplication.enMode)_Mode;

            //if (!base.Save())
            //    return false;

            switch (_Mode)
            {
                case enMode.Add:
                    if (_AddNewLocalDrivingLicenseApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();
            }
            return false;
        }

        public static bool Delete(int LDLAppID)
        {
            return clsDataLocalDrivingLicenseApplication.DeleteLocalDApplication(LDLAppID);
        }

        public static bool AttendedTest(int LDLAppID, int TestTypeID)
        {
            return (clsDataLocalDrivingLicenseApplication.NumberOfTrialsPerTestType(LDLAppID, TestTypeID) > 0);
        }
        public bool AttendedTest(int TestTypeID)
        {
            return AttendedTest(this.LDLAppID, TestTypeID);
        }


        public static bool DoesAttendTest(int LDLAppID, int TestTypeID)
        {
            return clsDataLocalDrivingLicenseApplication.DoesAttendTestType(LDLAppID, TestTypeID);
        }
        public bool DoesAttendTest(int TestTypeID)
        {
            return DoesAttendTest(this.LDLAppID, TestTypeID);
        }


        public static int TotalTrialPerTest(int LDLAppID, int TestTypeID)
        {
            return clsDataLocalDrivingLicenseApplication.NumberOfTrialsPerTestType(LDLAppID, TestTypeID);
        }
        public int TotalTrialPerTest(int TestTypeID)
        {
            return TotalTrialPerTest(this.LDLAppID, TestTypeID);
        }


        public static bool IsThereActiveScheduledTest(int LDLAppID, int TestTypeID)
        {
            return clsDataLocalDrivingLicenseApplication.IsThereActiveScheduledTest(LDLAppID, TestTypeID);
        }
        public bool IsThereActiveScheduledTest(int TestTypeID)
        {
            return IsThereActiveScheduledTest(this.LDLAppID, TestTypeID);
        }

        public static bool DoesPassTestType(int LDLAppID , int TestTypeID)
        {
            return clsDataLocalDrivingLicenseApplication.DoesPassTestType(LDLAppID, TestTypeID);
        }
        public bool DoesPassTestType(int TestTypeID)
        {
            return DoesPassTestType(this.LDLAppID, TestTypeID);
        }

        public static clsTest GetLastTestPerTestType(int PersonID , int LicenseClassID , int TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(PersonID, LicenseClassID, TestTypeID);
        }
        public clsTest GetLastTestPerTestType(int TestTypeID)
        {
            return GetLastTestPerTestType(this.ApplicationInfo.ApplicantPersonID, this.LicenseClassID , TestTypeID);
        }

        public static bool IsPassAllTest(int LDLAppID)
        {
            bool PassVisionTest, PassWrittenTest, PassStreetTest;

            PassVisionTest  = DoesPassTestType(LDLAppID, (int)clsTestType.enTestType.VisionTest);
            PassWrittenTest = DoesPassTestType(LDLAppID, (int)clsTestType.enTestType.WrittenTest);
            PassStreetTest  = DoesPassTestType(LDLAppID, (int)clsTestType.enTestType.StreetTest);

            if (PassVisionTest)
            {
                if (PassWrittenTest)
                {
                    if (PassStreetTest)
                        { return true; }
                }
            }

            return false;
        }
        public bool IsPassAllTest()
        {
            return IsPassAllTest(this.LDLAppID);
        }

        public int GetActiveLicenseID () 
        {
            return clsLicense.GetActiveLicenseID(this.ApplicationInfo.ApplicantPersonID, this.LicenseClassID);
        }

        public int IssueLicenseForTheFistTime(string Notes , int CreatedBuUserID)
        {
            int DriverID = -1;

            clsDrivers Driver = clsDrivers.FindByPerson(this.ApplicationInfo.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDrivers(new clsDriverDTO(-1, this.ApplicationInfo.ApplicantPersonID,
                    CreatedBuUserID, DateTime.Now));

                if(Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }

            }
            else { 
                DriverID = Driver.DriverID;
            }


            //now we have a driver , so we will add new licesnse

            clsLicense license = new clsLicense
            (
                new clsLicenseDTO
                (
                    -1, this.BaseApplicationID, DriverID,
                    this.LicenseClassID, DateTime.Now,
                    DateTime.Now.AddYears(this.licenseClassInfo.DefaultValidLenght), 
                    Notes, this.licenseClassInfo.ClassFees,
                    true, (byte)clsLicense.enIssueReason.FirstTime, CreatedBuUserID
                )
            );


            if (license.Save())
            {
                if (!ApplicationInfo.SetComplete()) return -1;

                return license.LicenseID;
            }
            else
                return -1;

        }

    }
}
