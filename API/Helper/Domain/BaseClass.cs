using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace API.Helper.Domain
{
    public class BaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime LastModified { get; set; }
    }
}
