using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public interface IComplaint
    {
        void SaveComplaint(Complaint obj);
        void UpdateComplaintStatus(int ComplaintID,int StatusID); 
        List<Complaint> LoadComplaintsWithDetails(); //ForAdminPage
        List<Complaint> LoadComplaintWithDetailsByProfileID(int ProfileID); //ForCustomerPage
        Complaint LoadComplaintByComplaintID(int Complaintid); //ForAdminPage
    }
}
