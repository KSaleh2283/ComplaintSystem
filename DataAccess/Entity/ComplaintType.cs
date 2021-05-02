using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class ComplaintType
    {
        public int ID { set; get; }
        [MaxLength(50)]
        public string Name { set; get; }
        public List<Complaint> LiComplaint { set; get; } //Collection Navidgation Property of ComplaintEntity
    }
}
