using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Folder
    {
        [Key]
        public int ID{ get; set; }

        [Required]
        public string Name { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}
