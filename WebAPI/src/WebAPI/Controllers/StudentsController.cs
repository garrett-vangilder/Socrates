using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ProducesAttribute("application/json")]
    [Route("students")]
    public class StudentsController : Controller
    {
        private ApplicationDbContext context;
        public StudentsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // GET /students
        [HttpGet]
        public JsonResult Get()
        {
            IQueryable<object> students = from student in context.Student select student;

            if (students == null)
            {
                
               return Json("Sorry");
            }
            return Json(students);

        }

    }
}
