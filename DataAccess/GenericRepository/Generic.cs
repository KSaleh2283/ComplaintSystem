using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using System.Data.Entity;

namespace DataAccess.GenericRepository
{
    public class Generic<x> : IGeneric<x> where x : class
    {
        ComplaintContext con;
        DbSet<x> table = null;

        public Generic()
        {
            con = new ComplaintContext();
            table = con.Set<x>();
        }

        public void SaveChanges()
        {
            con.SaveChanges();
        }

        public void Save(x obj)
        {
            table.Add(obj);
        }
        public void Update(x obj)
        {
            table.Attach(obj);
            con.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            x obj = table.Find(id);
            table.Remove(obj);
        }

        public x loadByID(object id)
        {
            return table.Find(id);
        }
        public List<x> loadall()
        {
            List<x> data = table.ToList<x>();
            return data;
        }
    }
}
