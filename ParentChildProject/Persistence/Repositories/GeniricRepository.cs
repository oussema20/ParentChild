using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Persistence.Repositories
{
    public class GeniricRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext _context;
        public DbSet<T> table = null;

        public GeniricRepository(AppDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public DbSet<T> GetAll()
        {
            return table;
        }
    }
}
