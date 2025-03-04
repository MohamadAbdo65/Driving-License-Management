using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinussLayer
{
    public class clsTest
    {
        public enum enMode { Add ,Update}
        enMode _Mode;

        public clsTestDTO TestDTO
        {
            get
            {
                return new clsTestDTO(TestID, TestAppointmentID, TestResult, Notes, CreateByUserID);
            }
        }

        public int TestID {  get; set; }
        public int TestAppointmentID {  get; set; }
        public bool TestResult { get; set; } 
        public string Notes { get; set; }
        public int CreateByUserID { get; set; }

        public clsTestAppointment TestAppointmentInfo { get; set; }

        public clsTest(clsTestDTO testDTO , enMode mode = enMode.Add)
        {            
            TestID = testDTO.TestID;
            TestAppointmentID = testDTO.TestAppointmentID;
            TestResult = testDTO.TestResult;
            Notes = testDTO.Notes;
            CreateByUserID = testDTO.CreatedByUserID;
            TestAppointmentInfo = clsTestAppointment.GetTestAppointment(TestAppointmentID);

            _Mode = mode;
        }
    
        
        public static List<clsTestDTO> GelAllTests()
        {
            return clsDataTest.GetAllTests();
        }

        bool _AddTest()
        {
            clsTestDTO testDTO = TestDTO;

            bool Result = clsDataTest.AddNewTests(ref testDTO);

            TestDTO.TestID = testDTO.TestID;

            return Result;
        }
        bool _UpdateTest()
        {
            return clsDataTest.UpdateTests(TestDTO);
        }

        public bool Save()
        {
            if (enMode.Add == _Mode)
            {
                if (_AddTest())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else return false;
            }
            else if (enMode.Update == _Mode)
            {
                return _UpdateTest();
            }
            return false;
        }


        public static clsTest Find(int TestID)
        {
            clsTestDTO testDTO = clsDataTest.FindTestsByTestID(TestID);

            if (testDTO != null)
                return new clsTest(testDTO, enMode.Update);
            else
                return null;
        }

        public static clsTest FindLastTestPerPersonAndLicenseClass(int PersonID , int LicenseClassID , int TestTypeID)
        {
            clsTestDTO testDTO = clsDataTest.GetLastTestByPersonAndTestTypeAndLicenseClass
                (PersonID , LicenseClassID , TestTypeID);

            if (testDTO != null)
                return new clsTest(testDTO, enMode.Update);
            else
                return null;
        }

        public static int GetCountOfPassedTest(int LDLAppID)
        {
            return clsDataTest.GetPassedTestCount( LDLAppID );
        }

        public static bool IsPassedAllTests(int LDLAppID)
        {
            return (GetCountOfPassedTest(LDLAppID) == 3);
        }

    }
}
