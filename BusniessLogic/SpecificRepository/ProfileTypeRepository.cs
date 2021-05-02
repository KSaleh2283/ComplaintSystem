using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GenericRepository;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public class ProfileTypeRepository:IProfileType
    {
        public List<ProfileType> LoadProfileType()
        {
            IGeneric<ProfileType> obj = new Generic<ProfileType>();
            return obj.loadall();
        }
    }
}
