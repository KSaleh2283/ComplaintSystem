using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class Complaint
    {
        public int ID { set; get; }
        [MaxLength(50)]
        [Required]
        public string Title { set; get; }
        [Required]
        public string Description { set; get; }
        [ForeignKey("CTRef")]
        [Required]
        public int ComplaintTypeID { set; get; } //ForeignKey of ComplaintTypeEntity
        [ForeignKey("CSRef")]
        public int ComplaintStatusID { set; get; } //ForeignKey of ComplaintStatusEntity
        [ForeignKey("ProfileRef")]
        public int ProfileID { set; get; } //ForeignKey of ProfileEntity
        public DateTime EntryDate { set; get; }

        public ComplaintType CTRef { set; get; } //Reference Navidgation Property of ComplaintTypeEntity
        public ComplaintStatus CSRef { set; get; } //Reference Navidgation Property of ComplaintStatusEntity
        public Profile ProfileRef { set; get; } //Reference Navidgation Property of ProfileEntity

        [NotMapped]
        public string UserName { set; get; }
        [NotMapped]
        public string ComplaintStatus { set; get; }
        [NotMapped]
        public string ComplaintType { set; get; }
    }
}
