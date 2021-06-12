using Application.DTO;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/assignments")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentHandler _handler;
        private readonly IMapper _mapper;
        public AssignmentController(IAssignmentHandler handler, IMapper mapper)
        {
            _handler = handler;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult<AssignmentReadDTO> CreateAssignment(AssignmentCreateDTO assignmentCreateDTO)
        {
            var assignment = _mapper.Map<Assignment>(assignmentCreateDTO);
            _handler.CreateAssignment(assignment);
            return _mapper.Map<AssignmentReadDTO>(assignment);
        }
    }
}
