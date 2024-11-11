using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly Application_Context _context;

        public DepartmentsController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartments()
        {
            return await _context.Departments.Include(d => d.College).ToListAsync();
        }

        // GET: api/departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var department = await _context.Departments.Include(d => d.College).FirstOrDefaultAsync(d => d.Id == id);

            if (department == null)
            {
                return NotFound();
            }

            return department;
        }

        // POST: api/departments
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Department>>> PostDepartments(List<CreateDepartmentDto> departmentsDto)
        {
            var departments = new List<Department>();

            foreach (var departmentDto in departmentsDto)
            {
                // Find the college using the provided CollegeName
                var college = await _context.Colleges
                    .SingleOrDefaultAsync(c => c.Name == departmentDto.CollegeName);

                if (college == null)
                {
                    return NotFound($"College with name '{departmentDto.CollegeName}' not found.");
                }

                // Create the new department and assign the college
                var department = new Department
                {
                    Name = departmentDto.Name,
                    College = college,
                    Num_of_Credit_to_be_achived = departmentDto.num_of_Credit,
                    LastModified = DateTime.UtcNow
                };

                departments.Add(department);
            }

            _context.Departments.AddRange(departments);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDepartments), departments);
        }

        // PUT: api/departments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartment(int id, Department department)
        {
            if (id != department.Id)
            {
                return BadRequest();
            }

            _context.Entry(department).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
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

        // DELETE: api/departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
