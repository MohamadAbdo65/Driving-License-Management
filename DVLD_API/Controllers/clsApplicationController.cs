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
            if (applications == null || 
                applications.ApplicationID !< 1 ||
                applications.ApplicantPersonID !< 1 ||
                applications.ApplicationDate <= DateTime.MinValue ||
                (applications.ApplicationTypeID == 7 || applications.ApplicationTypeID < 1 || applications.ApplicationTypeID > 8) ||
                (applications.ApplicationStatus > 3 || applications.ApplicationStatus <1) ||
                applications.LastStatusDate <= DateTime.MinValue ||
                applications.PaidFees < 0 ||
                applications.CreatedByUserID < 0 )
            {
                return BadRequest("Invalid value");
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
    }
}
