using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class FolderHandler : IFolderHandler
    {
        private readonly IApplicationDbContext _context;
        public FolderHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateFolder(Folder folder)
        {
            _context.Folders.Add(folder);
            _context.SaveChanges();

        }

        public IEnumerable<Folder> GetAllFolders()
        {
            return _context.Folders.Include(x => x.Assignments).ToList();
        }

    }
}
