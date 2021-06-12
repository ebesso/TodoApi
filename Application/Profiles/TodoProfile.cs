using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Profiles
{
    class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Folder, FolderReadDTO>();
            CreateMap<Assignment, AssignmentReadDTO>();
            CreateMap<FolderCreateDTO, Folder>();
            CreateMap<AssignmentCreateDTO, Assignment>();

        }
    }
}
