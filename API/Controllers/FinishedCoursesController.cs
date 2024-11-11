using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinishedCoursesController : ControllerBase
    {
        private readonly Application_Context _context;

        public FinishedCoursesController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/finishedcourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinishedCourses>>> GetFinishedCourses()
        {
            return await _context.FinishedCourses
                .Include(fc => fc.Courses)
                .Include(fc => fc.Student)
                .ToListAsync();
        }

        // POST: api/finishedcourses/addmultiple
        [HttpPost("addmultiple")]
        
        public async Task<ActionResult<IEnumerable<FinishedCourses>>> AddMultipleFinishedCourses( List<addFinished> finishedCourses)
        {
           

            var newFinishedCourses = new List<FinishedCourses>();

            foreach (var finished in finishedCourses)
            {
                var course = await _context.Courses.FindAsync(finished.CourseId);
                var student = await _context.Students.FindAsync(finished.StudentId);

                if (course == null || student == null)
                {
                    return NotFound($"Invalid CourseId {finished.CourseId} or StudentId {finished.StudentId}.");
                }

                var finishedCourse = new FinishedCourses
                {
                    Courses = course,
                    Student = student,
                    LastModified = DateTime.Now
                };

                newFinishedCourses.Add(finishedCourse);
            }

            // Add and save all new records
            _context.FinishedCourses.AddRange(newFinishedCourses);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFinishedCourses), newFinishedCourses);
        }

        // PUT: api/finishedcourses/update
        [HttpPut("update")]
        public async Task<IActionResult> UpdateFinishedCourses([FromBody] List<addFinished> updatedFinishedCourses)
        {
            if (updatedFinishedCourses == null || !updatedFinishedCourses.Any())
            {
                return BadRequest("No finished courses provided for update.");
            }

            foreach (var finished in updatedFinishedCourses)
            {
                var finishedCourse = await _context.FinishedCourses
                    .Include(fc => fc.Courses)
                    .Include(fc => fc.Student)
                    .FirstOrDefaultAsync(fc => fc.Courses.Id == finished.CourseId && fc.Student.Id == finished.StudentId);

                if (finishedCourse == null)
                {
                    return NotFound($"No record found for CourseId {finished.CourseId} and StudentId {finished.StudentId}.");
                }

                // Modify any properties if necessary (none in this case since only IDs are provided)
                // Example: finishedCourse.SomeProperty = someValue;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
