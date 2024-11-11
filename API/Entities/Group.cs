using API.Helper.Domain;
using System.Collections.Generic;

namespace API.Entities
{
    public class Group:BaseClass
    {
        public char Name { get; set; }
        
        public int capacity { get; set; }
        public Department department { get; set; }
       


    }
}
