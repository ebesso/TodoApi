using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class FolderReadDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<AssignmentReadDTO> Assignments { get; set; }
    }
}
