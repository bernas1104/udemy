using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Services
{
    public class DepartamentService
    {
        private readonly ASP_ProjectContext _context;

        public DepartamentService(ASP_ProjectContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
