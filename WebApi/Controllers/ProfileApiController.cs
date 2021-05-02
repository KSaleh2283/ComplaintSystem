using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusniessLogic.SpecificRepository;
using DataAccess.Entity;
using System.Web.Http.Results;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    
    public class ProfileApiController : ApiController
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("api/ProfileApi/SaveProfile")]
        public IHttpActionResult SaveProfile(Profile C)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                IProfile obj = new ProfileRepository();
                obj.SaveProfile(C);
                return Ok();
            }
  
        }

        [Authorize]
        [HttpGet]
        [Route("api/ProfileApi/LoadProfile/{UserName}/{Password}")]
        public Profile LoadProfile(string UserName, string Password)
        {
            IProfile obj = new ProfileRepository();
            return obj.LoadProfile(UserName, Password);
        }
    }
}
