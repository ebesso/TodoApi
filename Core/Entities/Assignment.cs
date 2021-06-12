using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Assignment
    {

        public Assignment()
        {
            Completed = false;
        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Due { get; set; }

        public bool Completed { get; set; }

        [Required]
        public int FolderID { get; set; }
        public Folder Folder { get; set; }

    }
}
