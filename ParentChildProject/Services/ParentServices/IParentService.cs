using ParentChildProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Services.ParentServices
{
    public interface IParentService
    {
        IQueryable<Parent> GetAll();
    }
}
