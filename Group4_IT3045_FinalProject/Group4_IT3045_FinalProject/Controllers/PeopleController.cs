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
    public class PeopleController : ControllerBase
    {
        private readonly Group4_IT3045_FinalProjectContext _context;

        public PeopleController(Group4_IT3045_FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        public IActionResult GetPerson()
        {
            var people = _context.Person.ToList();
            return Ok(people);
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            var person = _context.Person.Find(id);

            if (person == null)
            {
                var people = (from s in _context.Person
                               orderby s.id
                               select s).Take(5);
                return Ok(people);
            }

            return Ok(person);
        }

        // PUT: api/People/5
        [HttpPut("{id}")]
        public IActionResult PutPerson(Person person)
        {
            try
            {
                _context.Entry(person).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            return Ok();
        }

        // POST: api/People
        [HttpPost]
        public IActionResult PostPerson(Person person)
        {
            try
            {
                _context.Person.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            var person = _context.Person.Find(id);

            if (person == null)
            {
                return NotFound();
            }
            try
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            return Ok();
        }
    }
}
