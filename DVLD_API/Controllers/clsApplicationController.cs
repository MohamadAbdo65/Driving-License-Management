using Microsoft.AspNetCore.Mvc;
using DVLD_Businuss;
using DVLD_Data;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_API.Controllers
{
    [Route("api/ApplicationsAPI")]
    [ApiController]
    public class clsApplicationController : ControllerBase
    {
        [HttpGet("GetAll", Name = "GetAllApplications")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<IEnumerable<clsApplicationsDTO>> GetAllApplications()
        {
            List <clsApplicationsDTO> applications = clsApplication.GetAllApplications();

            if (applications.Count <= 0) return NoContent();

            return Ok(applications);
        }

        [HttpGet("ByID/{ApplicationID}", Name = "GetApplicationByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsApplicationsDTO> GetApplicationByID(int ApplicationID)
        {
            if (ApplicationID < 0) return BadRequest($"Not Accepted ID : {ApplicationID}");

            clsApplication application = clsApplication.GetBaseApplication(ApplicationID);

            if (application == null) return NotFound($"Application with ID : {ApplicationID} Not found");

            clsApplicationsDTO AppDTO = application.ApplicationDTO;

            return Ok(AppDTO);
        }

        [HttpGet("Application/{ApplicationID}/IsExistsByID")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult ApplicationIsExist(int ApplicationID)
        {
            if (ApplicationID < 0) return BadRequest($"Not Accepted ID {ApplicationID}");

            bool IsExist = clsApplication.IsApplicationExist(ApplicationID);

            return Ok(IsExist);
        }

        [HttpGet("DoesPersonHaveActiveApplication" , Name = "DoesPersonHaveActiveApplicationSameType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DoesPersonHaveActiveApplicationSameType(int PersonID , int ApplicationTypeID)
        {
            if (PersonID < 0 || ApplicationTypeID < 0 || ApplicationTypeID > 8 || ApplicationTypeID == 7)
                return BadRequest($"Not Accepted Values");

            if (!clsPerson.PersonIsExist(PersonID)) return NotFound($"Person with ID : {PersonID} is Not found.");

            bool Result = clsApplication.DoesPersonHaveActiveApp(PersonID , ApplicationTypeID);

            return Ok(Result);
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

        [HttpPut("CancelApplication" , Name = "CancelApplicationByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Cancel(int ApplicationID)
        {
            if (ApplicationID < 0) return BadRequest($"Not Accepted ID {ApplicationID}");

            if(!clsApplication.Cancel(ApplicationID)) return NotFound($"Application with ID : {ApplicationID} Not found");

            return Ok("Canceled successfully");
        }

        [HttpPut("SetCompleteApplication", Name = "SetCompleteApplicationByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult SetComplete(int ApplicationID)
        {
            if (ApplicationID < 0) return BadRequest($"Not Accepted ID {ApplicationID}");

            if (!clsApplication.SetComplete(ApplicationID)) return NotFound($"Application with ID : {ApplicationID} Not found");

            return Ok("Completed successfully");
        }




        [HttpDelete("DeleteApplication", Name = "DeleteApplicationByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteApplicationByID(int ApplicationID)
        {
            if (ApplicationID < 0) return BadRequest($"Not Accepted ID {ApplicationID}");

            if (!clsApplication.Delete(ApplicationID)) return NotFound($"Application with ID : {ApplicationID} Not found");

            return Ok("Deleted successfully");
        }

    }
}
