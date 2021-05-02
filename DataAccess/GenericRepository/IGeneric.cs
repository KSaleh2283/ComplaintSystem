using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.GenericRepository
{
    public interface IGeneric<x> where x : class
    {
        void Save(x obj);
        void Update(x obj);
        void Delete(object id);
        x loadByID(object id);
        List<x> loadall();
        void SaveChanges();
    }
}
