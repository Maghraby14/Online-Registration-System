using API.Helper.Domain;

namespace API.Entities
{
    public class Registered:BaseClass
    {
        public Student Student { get; set; }
        public Courses Course { get; set; }
        public LectSect Lectsec {  get; set; }
    }
}
