using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinussLayer
{
    public class clsApplicationsType
    {
        public clsApplicationTypeDTO AppTypeDTO
        {
            get
            {
                return (new clsApplicationTypeDTO(this.ID, this.Title, this.Fees));
            }
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public int Fees { get; set; }

        public clsApplicationsType(clsApplicationTypeDTO AppTypeDTO)
        {
            this.ID =    AppTypeDTO.ID;
            this.Title = AppTypeDTO.Title;
            this.Fees =  AppTypeDTO.Fees;
        }

        private bool _UpdateAppTypeInfo()
        {
            return clsDataApplicationsType.UpdateApplicationType(AppTypeDTO);
        }

        public static clsApplicationsType GetApplicationType(int ID)
        {
            clsApplicationTypeDTO AppTypeDTO = clsDataApplicationsType.GetApplicationTypeByID(ID);

            if (AppTypeDTO != null)
                return new clsApplicationsType(AppTypeDTO);
            else
                return null;
        }

        public static List<clsApplicationTypeDTO> GellAllTypes()
        {
            return clsDataApplicationsType.GetAllData();
        }

        public bool Save()
        {
            return _UpdateAppTypeInfo();
        }


    }
}
