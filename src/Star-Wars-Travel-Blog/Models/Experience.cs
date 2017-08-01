using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWarsTravelBlog.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int id { get; set;  }
        public string description { get; set; }
        public DateTime date { get; set;  }
        public int personId { get; set; }
        public int locationId { get; set;  }
    }
}
