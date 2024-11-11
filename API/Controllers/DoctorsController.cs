// Existing using statements
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
    public class DoctorsController : ControllerBase
    {
        private readonly Application_Context _context;

        public DoctorsController(Application_Context context)
        {
            _context = context;
        }

        // GET: api/doctors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
        {
            return await _context.Doctors
                .Include(d => d.Department).ThenInclude(dept => dept.College)
                .ToListAsync();
        }

        // GET: api/doctors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctor(int id)
        {
            var doctor = await _context.Doctors
                .Include(d => d.Department).ThenInclude(dept => dept.College)
                .FirstOrDefaultAsync(d => d.Id == id);

            if (doctor == null)
            {
                return NotFound();
            }

            return doctor;
        }

        // POST: api/doctors (for bulk creation)
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Doctor>>> PostDoctors(IEnumerable<CreateDTA> doctors)
        {
            var createdDoctors = new List<Doctor>();

            foreach (var doctor in doctors)
            {
                var college = await _context.Colleges
                    .SingleOrDefaultAsync(c => c.Name == doctor.CollegeName);

                if (college == null)
                {
                    return NotFound($"College with name '{doctor.CollegeName}' not found.");
                }

                var dept = await _context.Departments
                    .SingleOrDefaultAsync(c => c.College.Id == college.Id && c.Name == doctor.DeptName);

                if (dept == null)
                {
                    return NotFound($"Department with name '{doctor.DeptName}' not found in college '{doctor.CollegeName}'.");
                }

                var newDoctor = new Doctor
                {
                    Name = doctor.Name,
                    Department = dept,
                    LastModified = DateTime.UtcNow
                };

                createdDoctors.Add(newDoctor);
                _context.Doctors.Add(newDoctor);
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDoctors), createdDoctors);
        }

        // PUT: api/doctors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctor(int id, Doctor doctor)
        {
            if (id != doctor.Id)
            {
                return BadRequest();
            }

            _context.Entry(doctor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorExists(id))
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

        // DELETE: api/doctors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctors.Any(e => e.Id == id);
        }
    }
}
