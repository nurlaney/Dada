using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository.Data;

namespace Dada.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostApiController : ControllerBase
    {
        private readonly DadaDbContext db;
        public PostApiController(DadaDbContext _db)
        {
            db = _db;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var postTitle = db.Users.Where(p => p.FullName.Contains(term))
                                            .Select(p => p.FullName).ToList();
                return Ok(postTitle);
            }
            catch
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var postTitle = db.Posts.Where(p => p.Title.Contains(term))
                                            .Select(p => p.Title).ToList();
                return Ok(postTitle);
            }
        }
    }
}