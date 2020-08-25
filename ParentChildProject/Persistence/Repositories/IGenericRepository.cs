using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Persistence.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        DbSet<T> GetAll();
    }
}
