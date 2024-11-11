using API.Helper.Domain;

namespace API.Entities
{
    public class Department:BaseClass
    {
        public string Name { get; set; }
        
        public int Num_of_Credit_to_be_achived { get; set; }
        public College College { get; set; }

       

    }
}
