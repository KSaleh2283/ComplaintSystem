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
    public class ComplaintTypeApiController : ApiController
    {
        [HttpGet]
        [Route("api/ComplaintTypeApi/LoadComplaintType")]
        public List<ComplaintType> LoadComplaintType()
        {
            IComplaintType obj = new ComplaintTypeRepository();
            return obj.LoadComplaintType();
        }
    }
}
