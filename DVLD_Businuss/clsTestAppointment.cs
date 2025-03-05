using DVLD_Data;
using System.Data;

namespace DVLD_Businuss
{   
    public class clsTestAppointment
    {
        public enum enMode { Add, Update }

        enMode Mode;

        public clsTestAppointmentDTO TestAppointmentDTO
        {
            get
            {
                return new clsTestAppointmentDTO(TestAppointmentID, (int)TestTypeID, LDLAppID, AppointmentDate, PaidFees, CreateByUserID, IsLocked);
            }
        }

        public int TestAppointmentID { get; set; }
        public clsTestType.enTestType TestTypeID { get; set; }
        public int LDLAppID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreateByUserID { get; set; }
        public bool IsLocked { get; set; }

        public int RetakeTestApplicationID { get; set; }
        public clsApplication RetakeTestAppInfo { get; set; }

        public int TestID
        {
            get { return GetTestID(); }
        }

        public clsTestAppointment(clsTestAppointmentDTO testAppointmentDTO, enMode mode = enMode.Add)
        {
            this.TestAppointmentID = testAppointmentDTO.TestAppointmentID;
            this.TestTypeID = (clsTestType.enTestType)testAppointmentDTO.TestTypeID;
            this.LDLAppID = testAppointmentDTO.LocalDrivingLicenseApplicationID;
            this.AppointmentDate = testAppointmentDTO.AppointmentDate;
            this.PaidFees = testAppointmentDTO.PaidFees;
            this.CreateByUserID = testAppointmentDTO.CreatedByUserID;
            this.IsLocked = testAppointmentDTO.IsLocked;

            // Where I should get "RetakeTestApplicationID" ?? 
            this.RetakeTestApplicationID = -1;
            this.RetakeTestAppInfo = clsApplication.GetBaseApplication(RetakeTestApplicationID);

            this.Mode = mode;
        }

        public static clsTestAppointment GetTestAppointment(int TestAppointmentID)
        {
            clsTestAppointmentDTO testAppointmentDTO =
                clsDataTestAppointment.FindTestAppointmentsByTestAppointmentID(TestAppointmentID);

            if (testAppointmentDTO != null)
                return new clsTestAppointment(testAppointmentDTO, enMode.Update);
            else
                return null;

        }

        public static clsTestAppointment GetLastTestAppointment(int LDLAppID, int TestTypeID)
        {
            clsTestAppointmentDTO testAppointmentDTO =
                clsDataTestAppointment.GetLastTestAppointment(LDLAppID, TestTypeID);

            if (testAppointmentDTO != null)
                return new clsTestAppointment(testAppointmentDTO, enMode.Update);
            else return null;

        }

        public static DataTable GetTestAppointmentPerTestType(int LDLAppID, int TestTypeID)
        {
            return clsDataTestAppointment.GetTestAppointmentPerTestType(LDLAppID, TestTypeID);
        }

        public static bool Delete(int TestAppointmentID)
        {
            return clsDataTestAppointment.DeleteTestAppointments(TestAppointmentID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsDataTestAppointment.GetAllTestAppointments();
        }

        private bool _Add()
        {
            clsTestAppointmentDTO testAppointmentDTO = TestAppointmentDTO;

            bool Result = clsDataTestAppointment.AddNewTestAppointments(ref testAppointmentDTO);

            this.TestAppointmentID = testAppointmentDTO.TestAppointmentID;

            return Result;
        }

        private bool _Update()
        {
            return clsDataTestAppointment.UpdateTestAppointments
                (TestAppointmentDTO);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
            {
                if (_Add())
                {
                    Mode = enMode.Update;
                    return true;
                }
                else { return false; }
            }
            else if (Mode == enMode.Update)
            {
                return _Update();
            }
            return false;
        }


        private int GetTestID()
        {
            return clsDataTestAppointment.GetTestID(this.TestAppointmentID);
        }

    }


}
