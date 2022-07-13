using HomeWorkUpConstruction.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkUpConstruction.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
    }
}
