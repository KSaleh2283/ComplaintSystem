using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;

namespace DataAccess.Validations
{
    class UserNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ComplaintContext Context = new ComplaintContext();
            bool Validation = Context.Profile.Any(a => a.UserName == (string)value);
            if (Validation)
            {
                return new ValidationResult(base.ErrorMessage);         
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
