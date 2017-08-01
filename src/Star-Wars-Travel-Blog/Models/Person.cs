using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWarsTravelBlog.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int id { get; set;  }
        public string name { get; set; }
        public string species { get; set;  }
        public string affiliation { get; set; }
    }
}
