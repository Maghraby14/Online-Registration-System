using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly Application_Context _context;

        public GroupsController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> GetGroups()
        {
            return await _context.Groups
                .Include(g => g.department).ThenInclude(dept => dept.College) // Include related Department
                .ToListAsync();
        }

        // GET: api/groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(int id)
        {
            var group = await _context.Groups
                .Include(g => g.department).ThenInclude(dept => dept.College) // Include related Department
                .FirstOrDefaultAsync(g => g.Id == id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        // POST: api/groups
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Group>>> PostGroups(List<GroupCreationDto> groupDtos)
        {
            var createdGroups = new List<Group>();

            foreach (var groupDto in groupDtos)
            {
                var college = await _context.Colleges
                                .SingleOrDefaultAsync(c => c.Name == groupDto.CollegeName);

                if (college == null)
                {
                    return NotFound($"College with name '{groupDto.CollegeName}' not found.");
                }

                // Now find the department using the CollegeId
                var dept = await _context.Departments
                    .SingleOrDefaultAsync(c => c.College.Id == college.Id && c.Name == groupDto.DeptName);

                if (dept == null)
                {
                    return NotFound($"Department with name '{groupDto.DeptName}' not found in college '{groupDto.CollegeName}'.");
                }

                var group = new Group
                {
                    Name = groupDto.Name,
                    department = dept,
                    LastModified = DateTime.UtcNow
                };

                createdGroups.Add(group);
                _context.Groups.Add(group);
            }

            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGroups), createdGroups);
        }

        // PUT: api/groups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup(int id, Group group)
        {
            if (id != group.Id)
            {
                return BadRequest();
            }

            _context.Entry(group).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
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

        // DELETE: api/groups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup(int id)
        {
            var group = await _context.Groups.FindAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GroupExists(int id)
        {
            return _context.Groups.Any(e => e.Id == id);
        }
    }

    // DTO class to represent group creation data
    public class GroupCreationDto
    {
        public char Name { get; set; }
        public string DeptName { get; set; }
        public string CollegeName { get; set; }
    }
}
