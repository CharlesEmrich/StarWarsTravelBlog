using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarWarsTravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int id { get; set; }
        public string region { get; set; }
        public string planet { get; set; }
        public string biome { get; set; }
    }
}
