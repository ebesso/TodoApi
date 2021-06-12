using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Application.DTO;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [ApiController]
    [Route("api/folders")]
    public class FolderController : ControllerBase
    {
        private readonly IFolderHandler _handler;
        private readonly IMapper _mapper;
        public FolderController(IFolderHandler handler, IMapper mapper)
        {
            _handler = handler;
            _mapper = mapper;

        }

        [HttpGet]
        public ActionResult<IEnumerable<FolderReadDTO>> GetAllFolders()
        {
            var folders = _handler.GetAllFolders();
            return Ok(_mapper.Map<IEnumerable<FolderReadDTO>>(folders));
        }
        [HttpPost]
        public ActionResult<FolderReadDTO> CreateFolder(FolderCreateDTO folderCreateDTO)
        {
            var folder = _mapper.Map<Folder>(folderCreateDTO);
            _handler.CreateFolder(folder);
            return _mapper.Map<FolderReadDTO>(folder);
        }
    }
}
