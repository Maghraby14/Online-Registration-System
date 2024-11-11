using API.Helper.Domain;

namespace API.Entities
{
    public class FinishedCourses:BaseClass
    {
        public Courses Courses { get; set; }
        public Student Student { get; set; }
    }
}
