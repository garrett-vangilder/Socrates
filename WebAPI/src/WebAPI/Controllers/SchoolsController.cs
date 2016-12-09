using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ProducesAttribute("application/json")]
    [Route("schools")]
    public class SchoolsController : Controller
    {

        public SchoolsController()
        {
            //DB Context?
        }

        // GET /schools
        [HttpGet]
        public IActionResult Get()
        {
            //IQueryable<object> students = from student in context.Student select student;

            //if (students == null)
            //{
            //    return NotFound();
            //}
            var schools = "School Info";
            return Ok(schools);

        }

    }
}