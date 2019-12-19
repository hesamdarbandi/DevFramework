using System.Reflection;
using DevFramework.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevFramework.Data.Context
{
    public class DevContext : IdentityDbContext<User, Role, int>
    {

        public DbSet<Request> Requests { get; set; }
        public DbSet<Distance> Distances { get; set; }

        public DevContext(DbContextOptions<DevContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // define the database to use
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
