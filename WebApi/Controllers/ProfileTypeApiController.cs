using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusniessLogic.SpecificRepository;
using DataAccess.Entity;

namespace WebApi.Controllers
{
    [AllowAnonymous]
    public class ProfileTypeApiController : ApiController
    {
        [HttpGet]
        [Route("api/ProfileTypeApi/LoadProfileType")]
        public List<ProfileType> LoadProfileType()
        {
            IProfileType obj = new ProfileTypeRepository();
            return obj.LoadProfileType();
        }
    }
}
