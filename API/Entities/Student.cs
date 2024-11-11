using API.Helper.Domain;
using System.Collections.Generic;

namespace API.Entities
{
    public class Student:BaseClass
    {
        public int Id { get; set; }

        public int Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public int tot_achived { get; set; }
        public string sponser { get; set; }
        public int term { get; set; }
        public bool hasSchedule { get; set; }
        public Department department { get; set; }

        
       
    }
}
