using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Cors;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    public class EducatorsController : Controller
    {
        private ApplicationDbContext context;


        public EducatorsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        // GET /educators
        [Route("educators")]
        [HttpGet]
        [EnableCors("AllowAll")]
        public JsonResult Get()
        {
            IQueryable<object> educators = from educator in context.Educator select educator;


            if (educators == null)
            {
                return Json(null);
            }
            
            return Json(educators);
            

        }
        //POST /educators
        [HttpPost]
        public IActionResult Post([FromBody] Educator educator)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Educator.Add(educator);
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AlreadyCreated(educator.EducatorId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }
            return Ok(educator);

        }

        private bool AlreadyCreated(int id)
        {
            return context.Educator.Count(e => e.EducatorId == id) > 0;
        }


    }
}
