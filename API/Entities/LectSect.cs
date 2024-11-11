using API.Helper.Domain;
using System;

namespace API.Entities
{
    public class LectSect:BaseClass
    {
        public Doctor Doctor { get; set; }
        public TA TA { get; set; }
        public Group Group { get; set; }
        public Room RoomL { get; set; }
        public Room RoomS { get; set; }
        public string Term { get; set; }
        public Courses Courses { get; set; }
        public Department department { get; set; }
        public DateTime LectFrom { get; set; }

        public DateTime LectTo { get; set; }

        public string Lectday {  get; set; }

        public DateTime SectFrom { get; set; }

        public DateTime SectTo { get; set; }

        public string Sectday { get; set; }
        public int capacity { get; set; }

        




    }
}
