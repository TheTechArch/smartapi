using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartAPI.Models;
using SmartAPI.Models.Consent;
using SmartAPI.Utils;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SamtykkeDataController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult Get()
        {
            Rootobject? consentInfo = ConsentUtil.GetConsentInfo(User);

            if(consentInfo == null)
            {
                return NotFound("Consent information not found in maskinporten token. Did you use a consent token?" + User.Claims);
            }

            return Ok(consentInfo);
        }
    }
}
