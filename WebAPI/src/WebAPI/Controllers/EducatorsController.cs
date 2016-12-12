using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Cors;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;

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
        public async Task<IActionResult> Get()
        {

            IQueryable<object> educators = from educator in context.Educator select educator;

            if (educators == null)
            {
                return Json(null);
            }

            return Ok(educators);
        }

        [Route("educators")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Educator educator)
        {
            if (ModelState.IsValid)
            {
                context.Add(educator);

                try
                {
                    await context.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return Json(ex);
                }

                return Json(new { success = "Works!" });
            }
            return BadRequest(ModelState);
        }

        private bool AlreadyCreated(int id)
        {
            return context.Educator.Count(e => e.EducatorId == id) > 0;
        }


    }
}
