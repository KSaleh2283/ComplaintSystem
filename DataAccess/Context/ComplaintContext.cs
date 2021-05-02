using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccess.Entity;

namespace DataAccess.Context
{
    public class ComplaintContext:DbContext
    {
        public ComplaintContext() : base("name=complaintsystemConn") { }

        //here is the dbset properties to convert the entities to tables based on the CS = ComplaintSystemCS
        public virtual DbSet<ComplaintType> ComplaintType { set; get; }

        public virtual DbSet<ComplaintStatus> ComplaintStatus { set; get; }

        public virtual DbSet<ProfileType> ProfileType { set; get; }

        public virtual DbSet<Profile> Profile { set; get; }

        public virtual DbSet<Complaint> Complaint { set; get; }

    }
}
