using Application.Interfaces;
using Application.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class AssignmentCreateDTO
    {
        [Required]
        public string Title{ get; set; }
        
        public string Description { get; set; }
        
        [Required]
        public DateTime Due { get; set; }

        [Required]
        [FolderRequired]
        public int FolderID { get; set; }
    }
}
