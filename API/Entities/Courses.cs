using API.Helper.Domain;
using System.Collections.Generic;

namespace API.Entities
{
    public class Courses:BaseClass
    {
       
        public string Name { get; set; }
        public int crd_hrs { get; set; }
        public string type { get; set; }
        public string term_given {  get; set; }
        
        public int prequisiteId {  get; set; }
        public Department department { get; set; }



      








    }
}
