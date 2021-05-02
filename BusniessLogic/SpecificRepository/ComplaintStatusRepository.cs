using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GenericRepository;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public class ComplaintStatusRepository:IComplaintStatus
    {
        public List<ComplaintStatus> LoadComplaintStatus()
        {
            IGeneric<ComplaintStatus> obj = new Generic<ComplaintStatus>();
            return obj.loadall();
        }
    }
}
