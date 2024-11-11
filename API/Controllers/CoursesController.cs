using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly Application_Context _context;

        public CoursesController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Courses>>> GetCourses()
        {
            return await _context.Courses
                .Include(c => c.department).ThenInclude(dept=> dept.College)
                .ToListAsync();
        }

        // GET: api/courses/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Courses>> GetCourse(int id)
        {
            var course = await _context.Courses
                .Include(c => c.department)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        // POST: api/courses
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Courses>>> PostCourses(List<addCourses> addCoursesList)
        {
            var courses = new List<Courses>();

            foreach (var addCourse in addCoursesList)
            {
                var college = await _context.Colleges
                             .SingleOrDefaultAsync(c => c.Name == addCourse.CollegeId);
                var dept = await _context.Departments
                    .SingleOrDefaultAsync(d => d.Name == addCourse.DeptName && d.College.Name == addCourse.CollegeId);

                if (college == null)
                {
                    return NotFound($"College with name '{addCourse.CollegeId}' not found.");
                }
                else if (dept == null)
                {
                    return NotFound($"Dept with name '{addCourse.DeptName}' not found.");
                }

                var pre = 0;

                if (addCourse.prequisite == 0)
                {
                    pre = 0;
                }
                else
                {
                     var coursee = await _context.Courses
                             .SingleOrDefaultAsync(c => c.Id == addCourse.prequisite);
                    if (coursee == null)
                    {
                        return NotFound($"Prequisite with Id '{addCourse.prequisite}' not found.");
                    }
                    else
                    {
                        pre = addCourse.prequisite;
                    }
                }

                var course = new Courses
                {
                    Name = addCourse.Name,
                    crd_hrs = addCourse.crd_hrs,
                    type = addCourse.type,
                    term_given = addCourse.term_given,
                    department = dept,
                    LastModified = DateTime.UtcNow,
                    prequisiteId = pre
                };

                courses.Add(course);
            }

            _context.Courses.AddRange(courses);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCourses), courses);
        }

        // PUT: api/courses/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Courses course)
        {
            if (id != course.Id)
            {
                return BadRequest();
            }

            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/courses/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
