using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using ClassLibrary1;
using API.Migrations;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly Application_Context _context;

    public StudentsController(Application_Context context)
    {
        _context = context;
    }

    // GET: api/students
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        return await _context.Students
            .Include(s => s.department).ThenInclude(dept => dept.College) // Include related Department
            .ToListAsync();
    }

    // POST: api/students
    [HttpPost]
    public async Task<ActionResult<IEnumerable<Student>>> PostStudents(IEnumerable<addStudents> studentsDto)
    {
        if (studentsDto == null || !studentsDto.Any())
        {
            return BadRequest("Students data is null or empty.");
        }

        var students = new List<Student>();

        // Validate the students data and map to Student entities
        foreach (var studentDto in studentsDto)
        {
            if (string.IsNullOrEmpty(studentDto.Name) || studentDto.Password <= 0 || studentDto.GPA <0 || studentDto.GPA > 4)
            {
                return BadRequest($"Invalid data for student: {studentDto.Name}");
            }


            // Map addStudents to Student entity
            var student = new Student
            {
                Name = studentDto.Name,
                Password = studentDto.Password,
                Age = studentDto.Age,
                GPA = studentDto.GPA,
                tot_achived = studentDto.tot_achived,
                sponser = studentDto.sponser,
                term = studentDto.term,
                LastModified =DateTime.Now,
                department = await _context.Departments
                    .SingleOrDefaultAsync(d => d.Name == studentDto.departmentName) // Fetch the department based on name
            };

            // Check if department exists
            if (student.department == null)
            {
                return BadRequest($"Department '{studentDto.departmentName}' not found for student: {studentDto.Name}");
            }

            students.Add(student);
        }

        // Add the students to the context
        _context.Students.AddRange(students);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetStudents), students);
    }

    [HttpPost("Registered")]
    public async Task<ActionResult<IEnumerable<addSchedule>>> PostRegistered(IEnumerable<addSchedule> studentsReg)
    {
        if (studentsReg == null || !studentsReg.Any())
        {
            return BadRequest("Students data is null or empty.");
        }

        var studentId = studentsReg.FirstOrDefault().studentId; // Assuming you're processing one student at a time.
        var existingRegistrations = _context.Registred.Where(r => r.Student.Id == studentId).Include(s=>s.Course).Include(s=>s.Lectsec).ToList();

        foreach (var existingRegistration in existingRegistrations)
        {
            // Increment the capacity for the group of the existing registration
            var existingLectSect = await _context.LectSects.FirstOrDefaultAsync(ls => ls.Id == existingRegistration.Lectsec.Id);
            if (existingLectSect != null)
            {
                existingLectSect.capacity++;
            }

            // Remove the existing registration
            _context.Registred.Remove(existingRegistration);
        }

        // Validate the students data and map to Registered entities
        foreach (var studentR in studentsReg)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == studentR.studentId);
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == studentR.CourseId);
            var lectSect = await _context.LectSects.FirstOrDefaultAsync(ls => ls.Courses.Id == studentR.CourseId && ls.Group.Id == studentR.GroupId);

            if (student == null || course == null || lectSect == null)
            {
                return BadRequest($"Invalid data for student with ID {studentR.studentId}");
            }

            // Check if there is space in the group (Capacity > 0)
            if (lectSect.capacity <= 0)
            {
                return BadRequest($"No available spots in the group for student with ID {studentR.studentId}");
            }
            

            // Decrement the group capacity by 1
            lectSect.capacity--;
            student.hasSchedule = true;

            // Add the new registered record to the context
            var regi = new Registered
            {
                Student = student,
                Course = course,
                LastModified = DateTime.Now,
                Lectsec = lectSect
            };

            // Save the Registered entity in the context
            _context.Registred.Add(regi);

            
        }

        // Save changes to both the registered records and the updated group capacity
        await _context.SaveChangesAsync();

        // Return the list of RegisteredDto objects
        return Created("", studentsReg);
    }


    // GET: api/students/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<StudentViewModel>> GetStudent(int id,int password)
    {
        var student = await _context.Students
            .Include(s => s.department).ThenInclude(dept=>dept.College) // Include related Department
            .FirstOrDefaultAsync(s => ((s.Id == id) && (s.Password==password)));


        if (student == null)
        {
            return NotFound();
        }
        else
        {
            var studentt = new StudentViewModel
            {
                Name = student.Name,
                Age = student.Age,
                GPA = student.GPA,
                term = student.term,
                tot_achived = student.tot_achived,
                sponser = student.sponser,
                departmrntId=student.department.Id,
                departmentName=student.department.Name,
                collegeName=student.department.College.Name,
                hasSchedule=student.hasSchedule,
                Id = id
            };

            return studentt;
        }
    }
    private int GetLecSlot(DateTime lecfrom)
        {
            // You can adjust these time conditions according to your slot system
            if (  (lecfrom.TimeOfDay >= new TimeSpan(8, 30, 0)) && (lecfrom.TimeOfDay <= new TimeSpan(10, 30, 0))  ) return 1;
            if (  (lecfrom.TimeOfDay >= new TimeSpan(10, 30, 0)) && (lecfrom.TimeOfDay <= new TimeSpan(12, 30, 0))  ) return 2;
            if (  (lecfrom.TimeOfDay >= new TimeSpan(12, 30, 0)) && (lecfrom.TimeOfDay <= new TimeSpan(14, 30, 0))  ) return 3;
            if (  (lecfrom.TimeOfDay >= new TimeSpan(14, 30, 0)) && (lecfrom.TimeOfDay <= new TimeSpan(16, 30, 0))  ) return 4;
           
            

            // Return 0 or another default value if no matching slot is found
            return 0;
        }
  
    // GET: api/students/{id}/registered
    [HttpGet("{id}/registered")]
    // GET: api/students/{id}/registered
   
    public async Task<ActionResult<IEnumerable<RegisteredCourseDto>>> GetRegistered(int id)
    {
        // Get the student's registered courses
        var registeredCourses = await _context.Registred
            .Where(r => r.Student.Id == id) // Filter by student ID
            .Include(r => r.Course) // Include course details
            .Include(r => r.Lectsec) // Include Lecture Section (Group) details
            .ThenInclude(ls => ls.Group) // Include Group inside LectSection
            .ToListAsync();

        if (registeredCourses == null || !registeredCourses.Any())
        {
            return NotFound($"Student with ID {id} has no registered courses.");
        }

        // Map the registered courses and group IDs to DTOs
        var registeredCoursesDto = registeredCourses
            .Where(r => r.Course != null && r.Lectsec != null && r.Lectsec.Group != null) // Filter out null values
            .Select(r => new RegisteredCourseDto
            {
                CourseId = r.Course?.Id ?? 0, // Use null-coalescing operator to handle null
                GroupId = r.Lectsec?.Group?.Id ?? 0 // Use null-coalescing operator to handle null
            })
            .ToList();

        return Ok(registeredCoursesDto);
    }


    [HttpGet("{id}/availableCourses")]
    public async Task<ActionResult<IEnumerable<ScheduleGroupViewModel>>> GetAvailableCourses(int id)
    {
        
        var student = await _context.Students
            .Include(s => s.department).ThenInclude(dept => dept.College) // Include related Department
            .FirstOrDefaultAsync(s => ((s.Id == id)));
        var finishedCourseIds = await _context.FinishedCourses
    .Where(fc => fc.Student.Id == id)
    .Select(fc => fc.Courses.Id)
    .OrderByDescending(id => id) // Order by course ID in descending order
    .Take(6) // Take the top 6 highest course IDs
    .ToListAsync();
        var availableCourses = await _context.Courses
    .Where(c => finishedCourseIds.Contains(c.prequisiteId)).Select(fc=> fc.Id)
    .ToListAsync();
        var availableschedules = await _context.LectSects
            .Where(c => availableCourses.Contains(c.Courses.Id))
            .Include(ls => ls.TA)
            .Include(ls => ls.Doctor)
            .Include(ls => ls.Courses)
            .Include(ls => ls.department)
            .Include(ls => ls.RoomL)
            .Include(ls => ls.RoomS)
            .Include(ls => ls.Group)
            .ToListAsync();

        Console.WriteLine(availableschedules);
            
            if (student == null)
        {
            return NotFound();
        }
        else
        {
            var groupedSchedules = availableschedules
       .GroupBy(schedule => schedule.Courses.Id) // Grouping by CourseId

       .Select(group => new ScheduleGroupViewModel
       {
           CourseId = group.Key, // CourseId
           CourseName = group.First().Courses?.Name ?? "N/A",
           CourseCreditHours = group.First().Courses?.crd_hrs ?? 0,
           CoursePeriod = group.First().Courses?.term_given ?? "N/A",
           
           Schedules = group.Select(schedule => new ScheduleviewModel
           {
               
           capacity = schedule.capacity,
               TAName = schedule.TA?.Name ?? "N/A",
               DoctorName = schedule.Doctor?.Name ?? "N/A",
               Lecday = schedule.Lectday,
               Secday = schedule.Sectday,
               LecSlot = GetLecSlot(schedule.LectFrom),
               SecSlot = GetLecSlot(schedule.SectFrom),
               Id = schedule.Id,
               CourseGroupId= schedule.Group.Id,
               
           }).ToList()
       }).ToList();

            return Ok(groupedSchedules);
        }

// ViewModel to group schedules

}
    


    // PUT: api/students/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudent(int id, Student student)
    {
        if (id != student.Id)
        {
            return BadRequest();
        }

        _context.Entry(student).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Students.Any(e => e.Id == id))
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

    // DELETE: api/students/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}

// DTO for adding students
public class addStudents
{
    public int Id { get; set; }
    public int Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }
    public int tot_achived { get; set; }
    public string sponser { get; set; }
    public int term { get; set; }
    public string departmentName { get; set; }
}
