using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI.Data;

namespace WebAPI.Controllers
{
    [ProducesAttribute("application/json")]
    [Route("educators")]
    public class EducatorsController : Controller
    {
        private ApplicationDbContext context;


        public EducatorsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // GET /educators
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<object> educators = from student in context.Student select student;

            if (educators == null)
            {
                return NotFound();
            }
            return Ok(educators);

        }

    }
}
