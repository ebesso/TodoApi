using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class FolderRequired : ValidationAttribute
    {

        public FolderRequired()
        {

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _context = (IApplicationDbContext)validationContext.GetService(typeof(IApplicationDbContext));
            int FolderID = (int)value;
            var exists = _context.Folders.Any(f => f.ID == FolderID);
            if (exists)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Folder does not exist");
            }
            
        }
    }
}
