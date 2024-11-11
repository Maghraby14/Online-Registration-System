using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using ClassLibrary1;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegesController : ControllerBase
    {
        private readonly Application_Context _context;

        public CollegesController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/colleges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<College>>> GetColleges()
        {
            return await _context.Colleges.ToListAsync();
        }

        // GET: api/colleges/name/{name}
        [HttpGet("name/{name}")]
        public async Task<ActionResult<College>> GetCollegeByName(string name)
        {
            var college = await _context.Colleges
                .SingleOrDefaultAsync(c => c.Name == name);

            if (college == null)
            {
                return NotFound();
            }

            return college;
        }

        // POST: api/colleges
        [HttpPost]
        public async Task<ActionResult<IEnumerable<College>>> PostColleges(MultipleCollegesAdd collegesRequest)
        {
            if (collegesRequest.Colleges == null || !collegesRequest.Colleges.Any())
            {
                return BadRequest("No colleges provided.");
            }

            var colleges = new List<College>();

            foreach (var college in collegesRequest.Colleges)
            {
                var c = new College { Name = college.Name, LastModified = DateTime.UtcNow };
                colleges.Add(c);
            }

            await _context.Colleges.AddRangeAsync(colleges);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetColleges), colleges);
        }

        // PUT: api/colleges/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCollege(int id, College college)
        {
            if (id != college.Id)
            {
                return BadRequest();
            }

            _context.Entry(college).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CollegeExists(id))
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

        // DELETE: api/colleges/name/{name}
        [HttpDelete("name/{name}")]
        public async Task<IActionResult> DeleteCollegeByName(string name)
        {
            var college = await _context.Colleges
                .SingleOrDefaultAsync(c => c.Name == name);

            if (college == null)
            {
                return NotFound();
            }

            _context.Colleges.Remove(college);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CollegeExists(int id)
        {
            return _context.Colleges.Any(e => e.Id == id);
        }
    }

    // Request class to add multiple colleges
    public class CollegesAdd
    {
        public string Name { get; set; }
    }

    public class MultipleCollegesAdd
    {
        public List<CollegesAdd> Colleges { get; set; }
    }
}
 