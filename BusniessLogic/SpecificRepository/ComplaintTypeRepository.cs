using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GenericRepository;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public class ComplaintTypeRepository:IComplaintType
    {
        public List<ComplaintType> LoadComplaintType()
        {
            IGeneric<ComplaintType> obj = new Generic<ComplaintType>();
            return obj.loadall();
        }
    }
}
