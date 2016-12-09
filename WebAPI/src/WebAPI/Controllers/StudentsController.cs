using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ProducesAttribute("application/json")]
    [Route("students")]
    public class StudentsController : Controller
    {

        public StudentsController()
        {
            //DB Context?
        }

        // GET /students
        [HttpGet]
        public IActionResult Get()
        {
            //IQueryable<object> students = from student in context.Student select student;

            //if (students == null)
            //{
            //    return NotFound();
            //}
            var students = "Student Info";
            return Ok(students);

        }

    }
}
