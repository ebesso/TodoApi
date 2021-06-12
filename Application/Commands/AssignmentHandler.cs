using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    class AssignmentHandler : IAssignmentHandler
    {
        private readonly IApplicationDbContext _context;
        public AssignmentHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public void CreateAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            _context.SaveChanges();
        }
    }
}
