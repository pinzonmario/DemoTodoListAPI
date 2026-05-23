using DemoTodoListAPI.Data.Seeding;
using DemoTodoListAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DemoTodoListAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataSeeding.Seed(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoItemStep> TodoItemSteps { get; set; }
        public DbSet<TodoItemFile> TodoItemFiles { get; set; }
    }
}
