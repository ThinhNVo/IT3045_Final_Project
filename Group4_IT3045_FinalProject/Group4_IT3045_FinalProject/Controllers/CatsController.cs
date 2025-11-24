using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Group4_IT3045_FinalProject.Data;
using Group4_IT3045_FinalProject.Models;

namespace Group4_IT3045_FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsController : ControllerBase
    {
        private readonly Group4_IT3045_FinalProjectContext _context;

        public CatsController(Group4_IT3045_FinalProjectContext context)
        {
            _context = context;
        }

        // POST: api/Cats
        [HttpPost]
        public IActionResult PostCat(Cat cat)
        {
            try
            {
                _context.Cat.Add(cat);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // GET: api/Cats
        [HttpGet]
        public IActionResult GetCat()
        {
            var cats = _context.Cat.ToList();
            return Ok(cats);
        }

        // GET: api/Cats/5
        [HttpGet("{id}")]
        public IActionResult GetCat(int id)
        {
            var cat = _context.Cat.Find(id);

            if (cat == null)
            {
                var cats = (from s in _context.Cat
                            orderby s.Id
                            select s).Take(5);
                return Ok(cats);
            }

                return Ok(cat);
        }

        // DELETE: api/Cats/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCat(int id)
        {
            var Cat = _context.Cat.Find(id);

            if (Cat == null)
            {
                return NotFound();
            }

            try
            {
                _context.Cat.Remove(Cat);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // PUT: api/Cats
        [HttpPut]
        public IActionResult PutCat(Cat cat)
        {
            try
            {
                _context.Entry(cat).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

    }
}
