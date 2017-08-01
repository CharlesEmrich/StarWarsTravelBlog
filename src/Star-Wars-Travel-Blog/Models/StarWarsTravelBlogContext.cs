using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StarWarsTravelBlog.Models
{
    public class StarWarsTravelBlogContext : DbContext
    {
        public virtual DbSet<Location> Locations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Travel-Blog;integrated security=True");
        }
    }
}
