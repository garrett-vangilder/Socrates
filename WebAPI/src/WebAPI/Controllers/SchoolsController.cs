using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ProducesAttribute("application/json")]
    [Route("schools")]
    public class SchoolsController : Controller
    {
        private ApplicationDbContext context;
        
        public SchoolsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // GET /schools
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<object> schools = from school in context.School select school;

            if (schools == null)
            {
               return NotFound();
            }
            return Ok(schools);

        }

    }
}