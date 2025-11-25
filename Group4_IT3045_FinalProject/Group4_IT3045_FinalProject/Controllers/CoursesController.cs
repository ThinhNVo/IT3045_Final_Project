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
    public class CoursesController : ControllerBase
    {
        private readonly Group4_IT3045_FinalProjectContext _context;

        public CoursesController(Group4_IT3045_FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]

        public IActionResult GetCourses()
        {
            var courses = _context.Course.ToList();
            return Ok(courses);
        }

        // POST: api/Courses
        [HttpPost]
        public IActionResult PostCourse(Course courses)
        {
            _context.Course.Add(courses);
            _context.SaveChanges();
            return Ok();
        }

        // GET: api/Courses/5
        [HttpGet("{courseID}")]
        public IActionResult GetCourse(int courseID)
        {
            var course = _context.Course.Find(courseID);

            if (course == null)
            {
                var courses = (from s in _context.Course
                            orderby s.CourseID
                            select s).Take(5);
                return Ok(courses);
            }

            return Ok(course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{courseID}")]
        public IActionResult DeleteCourse(int courseID)
        {
            var Course = _context.Course.Find(courseID);

            if (Course == null)
            {
                return NotFound();
            }
            try
            {
                _context.Course.Remove(Course);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
            return Ok();
        }

        // PUT: api/Course
        [HttpPut]
        public IActionResult PutCourse(Course course)
        {
            try
            {
                _context.Entry(course).State = EntityState.Modified;
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
