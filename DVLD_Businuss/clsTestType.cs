using DVLD_Data;

namespace DVLD_Businuss
{
    public class clsTestType
    {

        public clsTestTypeDTO TestTypeDTO
        {
            get
            {
                return new clsTestTypeDTO((int)ID, Title, Description, Fees);
            }
        }

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 }

        public enTestType ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Fees { get; set; }

        public clsTestType(clsTestTypeDTO testTypeDTO)
        {
            this.ID = (enTestType)testTypeDTO.TestTypeID;
            this.Title = testTypeDTO.Title;
            this.Description = testTypeDTO.Description;
            this.Fees = (int)testTypeDTO.Fees;
        }

        public static clsTestType GetTestType(enTestType ID)
        {
            clsTestTypeDTO testTypeDTO = clsDataTestType.GetTestTypeByID((int)ID);

            if (testTypeDTO != null)
                return new clsTestType(testTypeDTO);
            else
                return null;
        }

        public static List<clsTestTypeDTO> GetAllTestsType()
        {
            return clsDataTestType.GetAllData();
        }

        private bool _UpdateInfo()
        {
            return clsDataTestType.UpdateTestTypeInfo(TestTypeDTO);
        }

        public bool Save()
        {
            return _UpdateInfo();
        }



    }


}
