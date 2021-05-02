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
    public class ComplaintStatusApiController : ApiController
    {  
        [HttpGet]
        [Route("api/ComplaintStatusApi/LoadComplaintStatus")]
        public List<ComplaintStatus> LoadComplaintStatus()
        {
            IComplaintStatus obj = new ComplaintStatusRepository();
            return obj.LoadComplaintStatus();
        }
    }
}
