using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using ClassLibrary1;
using static Humanizer.In;
using System.Xml.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTable : ControllerBase
    {
        private readonly Application_Context _context;

        public TimeTable(Application_Context context)
        {
            _context = context;
        }

        // GET: api/lectsects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LectSect>>> GetLectSects()
        {
            return await _context.LectSects
                .Include(ls => ls.Doctor)
                .Include(ls => ls.TA)
                .Include(ls => ls.Group)
                .Include(ls => ls.RoomL)
                .Include(ls => ls.RoomS)
                .Include(ls => ls.Courses)
                .Include(ls=> ls.department)
                .ToListAsync();
        }

        // GET: api/lectsects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LectSect>> GetLectSect(int id)
        {
            var lectSect = await _context.LectSects
                .Include(ls => ls.Doctor)
                .Include(ls => ls.TA)
                .Include(ls => ls.Group)
                .Include(ls => ls.RoomL)
                .Include (ls => ls.RoomS)
                .Include(ls => ls.Courses)
                .FirstOrDefaultAsync(ls => ls.Id == id);

            if (lectSect == null)
            {
                return NotFound();
            }

            return lectSect;
        }

        // POST: api/lectsects
        [HttpPost]
        [HttpPost]
        public async Task<ActionResult<IEnumerable<LectSect>>> PostLectSect(IEnumerable<addTimeTable> lectSects)
        {
            if (lectSects == null || !lectSects.Any())
            {
                return BadRequest("No data provided.");
            }

            var createdLectSects = new List<LectSect>();

            foreach (var lectSect in lectSects)
            {
                // Retrieve related entities
                var doctor = await _context.Doctors.SingleOrDefaultAsync(c => c.Id == lectSect.DoctorId);
                var department = await _context.Departments.SingleOrDefaultAsync(c => c.Id == lectSect.departmentId);
                var ta = await _context.TAs.SingleOrDefaultAsync(c => c.Id == lectSect.TAId);
                var rooml = await _context.Rooms.SingleOrDefaultAsync(c => c.Id == lectSect.LecRoomId);
                var rooms = await _context.Rooms.SingleOrDefaultAsync(c => c.Id == lectSect.SecRoomId);
                var group = await _context.Groups.SingleOrDefaultAsync(c => c.Id == lectSect.GroupId);
                var course = await _context.Courses.SingleOrDefaultAsync(c => c.Id == lectSect.CourseId);

                // Validate required data
                if (doctor == null || ta == null || rooms == null || group == null || course == null || rooml == null)
                {
                    return NotFound("Invalid data for one or more entries.");
                }

                // Create a new LectSect entry
                var timeTable = new LectSect
                {
                    Doctor = doctor,
                    TA = ta,
                    RoomL = rooml,
                    RoomS = rooms,
                    Term = course.term_given,
                    Group = group,
                    Lectday = lectSect.Lectday,
                    LectTo = lectSect.LectTo,
                    LectFrom = lectSect.LectFrom,
                    Sectday = lectSect.Sectday,
                    SectFrom = lectSect.SectFrom,
                    SectTo = lectSect.SectTo,
                    Courses = course,
                    department = department,
                    capacity= group.capacity,
                };

                // Add to tracking list
                createdLectSects.Add(timeTable);
            }

            // Add the collection to the context
            _context.LectSects.AddRange(createdLectSects);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLectSects), createdLectSects);
        }


        // PUT: api/lectsects/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLectSect(int id, LectSect lectSect)
        {
            if (id != lectSect.Id)
            {
                return BadRequest();
            }

            _context.Entry(lectSect).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.LectSects.Any(ls => ls.Id == id))
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

        // DELETE: api/lectsects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLectSect(int id)
        {
            var lectSect = await _context.LectSects.FindAsync(id);
            if (lectSect == null)
            {
                return NotFound();
            }

            _context.LectSects.Remove(lectSect);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
