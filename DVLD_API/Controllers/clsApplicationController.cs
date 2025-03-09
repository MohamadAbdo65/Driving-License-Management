using Microsoft.AspNetCore.Mvc;
using DVLD_Businuss;
using DVLD_Data;

namespace DVLD_API.Controllers
{
    [Route("api/ApplicationsAPI")]
    [ApiController]
    public class clsApplicationController : ControllerBase
    {
        [HttpGet("GetAll", Name = "GetAllApplications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<clsApplication>> GetAllApplications()
        {
            List <clsApplicationsDTO> applications = clsApplication.GetAllApplications();

            if (applications.Count <= 0) return NoContent();

            return Ok(applications);
        }

        [HttpPost("Add", Name = "AddApplication")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsApplicationsDTO> AddNewApplication
            (clsApplicationsDTO applications)
        {
            if (!applications.IsValid(out string? ErrorMessage))
            {
                return BadRequest(ErrorMessage);
            }

            clsApplication NewApplication = new clsApplication(
                new clsApplicationsDTO(
                    applications.ApplicationID,
                    applications.ApplicantPersonID,
                    applications.ApplicationDate,
                    applications.ApplicationTypeID,
                    applications.ApplicationStatus,
                    applications.LastStatusDate,
                    applications.PaidFees,
                    applications.CreatedByUserID), 
                clsApplication.enMode.Add);

            if (!NewApplication.Save()) return StatusCode(500, "Error in save Applicaion.");

            applications.ApplicationID = NewApplication.ApplicationID;

            return CreatedAtRoute("GetApplicationByID" , new {ID = applications.ApplicationID} , applications);
        }

        [HttpPut("Update", Name = "UpdateApplicationByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<clsApplicationsDTO> UpdateApplicationByID(int ApplicationID , clsApplicationsDTO NewData)
        {
            if (NewData.IsValid(out string? ErrorMessage))
            {
                return BadRequest(ErrorMessage);
            }

            clsApplication application = clsApplication.GetBaseApplication(ApplicationID);

            if (application == null) return NotFound($"Application with ID : {ApplicationID} is Not found.");

            application.ApplicantPersonID = NewData.ApplicantPersonID;
            application.ApplicationDate = NewData.ApplicationDate;
            application.ApplicationTypeID = NewData.ApplicationTypeID;
            application.ApplicationStatus = (clsApplication.enApplicationStatus)NewData.ApplicationStatus;
            application.LastUpdateStatus = NewData.LastStatusDate;
            application.PaidFees = NewData.PaidFees;
            application.CreateByUserID = NewData.CreatedByUserID;

            if (!application.Save()) return StatusCode(500, "Error in Update Application.");

            return Ok(application.ApplicationDTO);
        }


    }
}
