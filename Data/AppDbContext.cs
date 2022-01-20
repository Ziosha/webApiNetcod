using netCod.Models;
using Microsoft.EntityFrameworkCore;

namespace netCod.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<Institutions> Institutions { get; set; }
        public DbSet<Rols> Rols { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}