using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.GenericRepository;
using DataAccess.Context;
using DataAccess.Entity;

namespace BusniessLogic.SpecificRepository
{
    public class ProfileRepository:IProfile
    {
        public void SaveProfile(Profile P)
        {
            IGeneric<Profile> obj = new Generic<Profile>();
            obj.Save(P);
            obj.SaveChanges();
        }

        public Profile LoadProfile(string UserName, string Password)
        {
            ComplaintContext Con = new ComplaintContext();
            Profile P = new Profile();
            P = Con.Profile.Where(a => a.UserName == UserName && a.Password == Password).FirstOrDefault();

            return P;
        }
    }
}
