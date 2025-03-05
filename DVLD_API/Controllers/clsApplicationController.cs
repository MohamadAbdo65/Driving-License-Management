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

    }
}
