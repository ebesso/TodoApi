using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Application.Interfaces;

namespace Infrastructure.Data
{
    public class DatabaseContext : DbContext, IApplicationDbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> opt) : base(opt)
        {

        }

        public DbSet<Folder> Folders { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        bool IApplicationDbContext.SaveChanges()
        {
            return (base.SaveChanges() == 0);
        }
    }
}
