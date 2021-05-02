using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusniessLogic.SpecificRepository;
using DataAccess.Entity;
using WebApi.Authorization;

namespace WebApi.Controllers
{
    public class ComplaintApiController : ApiController
    {
        [Authorize(Roles = "Customer")]
        [HttpPost]
        [Route("api/ComplaintApi/SaveComplaint")]
        public IHttpActionResult SaveComplaint(Complaint C)
        {          
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                IComplaint obj = new ComplaintRepository();
                obj.SaveComplaint(C);
                return Ok();
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        [Route("api/ComplaintApi/UpdateComplaintStatus/{ComplaintID}/{StatusID}")]
        public void UpdateComplaintStatus([FromUri] int ComplaintID, [FromUri] int StatusID)
        {
            IComplaint obj = new ComplaintRepository();
            obj.UpdateComplaintStatus(ComplaintID, StatusID);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("api/ComplaintApi/LoadComplaintsWithDetails")]
        public List<Complaint> LoadComplaintsWithDetails()
        {
            IComplaint obj = new ComplaintRepository();
            return obj.LoadComplaintsWithDetails();
        }

        [Authorize(Roles = "Customer")]
        [HttpGet]
        [Route("api/ComplaintApi/LoadComplaintWithDetailsByProfileID/{ProfileID}")]
        public List<Complaint> LoadComplaintWithDetailsByProfileID(int ProfileID)
        {
            IComplaint obj = new ComplaintRepository();
            return obj.LoadComplaintWithDetailsByProfileID(ProfileID);
        }

        [Authorize]
        [HttpGet]
        [Route("api/ComplaintApi/LoadComplaintByComplaintID/{Complaintid}")]
        public Complaint LoadComplaintByComplaintID(int Complaintid)
        {
            IComplaint obj = new ComplaintRepository();
            return obj.LoadComplaintByComplaintID(Complaintid);
        }
    }
}
