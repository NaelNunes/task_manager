using Microsoft.EntityFrameworkCore;
using task_manager.Models;
using Task = task_manager.Models.Task;

namespace task_manager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(m => m.Id);
            builder.Entity<Task>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
