using API.Helper.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class Lecture:BaseClass
    {
        public Doctor doctor { get; set; }
        public Courses  Course { get; set; } 

        public Room Room { get; set; }
        
        
        public DateTime from { get; set; }
        public DateTime to { get; set; }

        public Group Group { get; set; }



        public string Day {  get; set; }



    }
}
