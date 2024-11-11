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
    public class TAsController : ControllerBase
    {
        private readonly Application_Context _context;

        public TAsController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/tas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TA>>> GetTAs()
        {
            return await _context.TAs
                .Include(d => d.Department)
                .ThenInclude(dept => dept.College)
                .ToListAsync();
        }

        // GET: api/tas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TA>> GetTA(int id)
        {
            var ta = await _context.TAs
                .Include(d => d.Department)
                .ThenInclude(dept => dept.College)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (ta == null)
            {
                return NotFound();
            }

            return ta;
        }

        // POST: api/tas
        [HttpPost]
        public async Task<ActionResult<IEnumerable<TA>>> PostTAs(IEnumerable<CreateDTA> tas)
        {
            var createdTAs = new List<TA>();

            foreach (var ta in tas)
            {
                var college = await _context.Colleges
                    .SingleOrDefaultAsync(c => c.Name == ta.CollegeName);

                if (college == null)
                {
                    return NotFound($"College with name '{ta.CollegeName}' not found.");
                }

                var dept = await _context.Departments
                    .SingleOrDefaultAsync(d => d.College.Id == college.Id && d.Name == ta.DeptName);

                if (dept == null)
                {
                    return NotFound($"Department with name '{ta.DeptName}' not found in college '{ta.CollegeName}'.");
                }

                var taEntity = new TA
                {
                    Name = ta.Name,
                    Department = dept,
                    LastModified = DateTime.UtcNow
                };

                createdTAs.Add(taEntity);
                _context.TAs.Add(taEntity);
            }

            await _context.SaveChangesAsync();

            // Return a Created response with the created TAs
            return CreatedAtAction(nameof(GetTAs), new { count = createdTAs.Count }, createdTAs);
        }

        // PUT: api/tas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTA(int id, TA ta)
        {
            if (id != ta.Id)
            {
                return BadRequest();
            }

            _context.Entry(ta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/tas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTA(int id)
        {
            var ta = await _context.TAs.FindAsync(id);
            if (ta == null)
            {
                return NotFound();
            }

            _context.TAs.Remove(ta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TAExists(int id)
        {
            return _context.TAs.Any(e => e.Id == id);
        }
    }
}
