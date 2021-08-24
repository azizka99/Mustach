using Microsoft.EntityFrameworkCore;
using MustacheEnt.Models;

namespace MustacheEnt.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Index> Index { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<AboutFields> About { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}