using API.Helper.Domain;
using System;

namespace API.Entities
{
    public class Section:BaseClass
    {
        public TA ta { get; set; }
        public Courses Course { get; set; }

        public Room Room { get; set; }

        
        public DateTime from { get; set; }
        public DateTime to { get; set; }

        public Group Group { get; set; }



        public string Day { get; set; }
    }
}
