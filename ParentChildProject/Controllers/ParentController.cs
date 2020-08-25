using Microsoft.AspNetCore.Mvc;
using ParentChildProject.Entities;
using ParentChildProject.Services;
using ParentChildProject.Services.ParentServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParentChildProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController: ControllerBase
    {
        private IParentService _parentService;

        public ParentController(IParentService parentService)
        {
            _parentService = parentService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Parent>> Get()
        {
            var res = _parentService.GetAll();
            return Ok(res);
        }
    }
}
