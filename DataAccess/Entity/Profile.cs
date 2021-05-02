using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DataAccess.Validations;

namespace DataAccess.Entity
{
    public class Profile
    {
        public int ID { set; get; }

        [Required(ErrorMessage = "UserName is Required")]
        [MaxLength(50)]
        [UserNameValidation(ErrorMessage ="UserName is already Exist")]
        public string UserName { set; get; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Password is Required")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [NotMapped]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Profile type is Required")]
        [ForeignKey("PTRef")]
        public int ProfileTypeID { set; get; } //ForeignKey of ProfileTypeEntity
        public ProfileType PTRef { set; get; } //Reference Navidgation Property of ProfileTypeEntity
        public List<Complaint> LiComplaint { set; get; } //Collection Navidgation Property of ComplaintEntity
    }
}
