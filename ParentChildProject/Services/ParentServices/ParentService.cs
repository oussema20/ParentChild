using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParentChildProject.Entities;
using ParentChildProject.Persistence.Repositories;

namespace ParentChildProject.Services.ParentServices
{
    public class ParentService : IParentService
    {
        private IGenericRepository<Parent> _repo;

        public ParentService(IGenericRepository<Parent> repo)
        {
            _repo = repo;
        }
        public IQueryable<Parent> GetAll()
        {
            var res = _repo.GetAll().Include(x => x.Childs);
            return res;

        }
    }
}
