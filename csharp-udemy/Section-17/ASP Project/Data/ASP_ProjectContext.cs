using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_Project.Models;

namespace ASP_Project.Models
{
    public class ASP_ProjectContext : DbContext
    {
        public ASP_ProjectContext (DbContextOptions<ASP_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
