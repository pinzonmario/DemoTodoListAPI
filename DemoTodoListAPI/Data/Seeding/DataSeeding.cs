using DemoTodoListAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoTodoListAPI.Data.Seeding
{
    public static class DataSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            #region Categories
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000001"),
                    Name = "University",
                    Description = "Software Development coursework and assignments",
                    Order = 1
                },
                new Category
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000002"),
                    Name = "Home",
                    Description = "Personal chores, maintenance, and finance",
                    Order = 2
                },
                new Category
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000003"),
                    Name = "Work",
                    Description = "Professional tasks, meetings, and project deadlines",
                    Order = 3
                }
            );
            #endregion

            #region Subcategories
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000a"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000001"),
                    Name = "Backend Development",
                    Description = "C#, ASP.NET Core, and Database assignments",
                    Order = 1
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000b"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000001"),
                    Name = "Frontend Development",
                    Description = "Angular, React, and UI/UX design",
                    Order = 2
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000c"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000001"),
                    Name = "DevOps & Cloud",
                    Description = "Docker, CI/CD pipelines, and AWS",
                    Order = 3
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000d"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000002"),
                    Name = "Household Chores",
                    Description = "Cleaning, grocery shopping, and maintenance",
                    Order = 1
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000e"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000002"),
                    Name = "Personal Finance",
                    Description = "Budgeting, bills, and investments",
                    Order = 2
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000011"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000002"),
                    Name = "Health & Wellness",
                    Description = "Exercise routines, doctor appointments, and meal prepping",
                    Order = 3
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-00000000000f"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000003"),
                    Name = "Core Projects",
                    Description = "Sprint tasks and feature development",
                    Order = 1
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000010"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000003"),
                    Name = "Meetings & Admin",
                    Description = "Standups, 1-on-1s, and timesheets",
                    Order = 2
                },
                new Subcategory
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000012"),
                    CategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000003"),
                    Name = "Professional Development",
                    Description = "Certifications, technical reading, and skill building",
                    Order = 3
                }
            );
            #endregion

            #region TodoItems
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000101"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000a"),
                    Title = "Implement EF Core Migrations",
                    Description = "Set up PostgreSQL and configure initial migrations.",
                    DueDate = DateTime.Parse("2026-06-03 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-02 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000102"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000a"),
                    Title = "Design REST API Endpoints",
                    Description = "Create the spec for Task Management endpoints.",
                    DueDate = DateTime.Parse("2026-06-05 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-04 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000103"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000a"),
                    Title = "Add JWT Authentication",
                    Description = "Secure the API using modern token authentication.",
                    DueDate = DateTime.Parse("2026-06-02 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-02 00:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000104"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000a"),
                    Title = "Write Repository Unit Tests",
                    Description = "Achieve 80% coverage on data access layer.",
                    DueDate = DateTime.Parse("2026-06-08 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-07 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000105"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000b"),
                    Title = "Create Task Board UI Component",
                    Description = "Build a responsive Kanban board drag-and-drop view.",
                    DueDate = DateTime.Parse("2026-06-06 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-05 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000106"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000b"),
                    Title = "Integrate State Management",
                    Description = "Set up SignalR or state store for live task updates.",
                    DueDate = DateTime.Parse("2026-06-09 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-08 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000107"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000b"),
                    Title = "Fix CSS Layout Bugs on Mobile",
                    Description = "Repair the sidebar collapse glitch on screens under 768px.",
                    DueDate = DateTime.Parse("2026-05-31 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-05-30 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Completed
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000108"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000b"),
                    Title = "Submit UI Accessibility Audit",
                    Description = "Ensure contrast and aria-labels pass WCAG compliance.",
                    DueDate = DateTime.Parse("2026-06-11 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-10 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000109"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000c"),
                    Title = "Dockerize the Application",
                    Description = "Write Dockerfile and compose setup for local testing.",
                    DueDate = DateTime.Parse("2026-06-04 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-03 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000110"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000c"),
                    Title = "Configure GitHub Actions CI",
                    Description = "Automate building and running tests on pull requests.",
                    DueDate = DateTime.Parse("2026-06-07 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-06 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000111"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000c"),
                    Title = "Deploy Staging to AWS ECS",
                    Description = "Provision ECS cluster using standard infrastructure.",
                    DueDate = DateTime.Parse("2026-06-13 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-12 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000112"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000c"),
                    Title = "Setup Prometheus Monitoring",
                    Description = "Hook up metrics to track API response times.",
                    DueDate = DateTime.Parse("2026-06-15 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-14 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000113"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000d"),
                    Title = "Weekly Grocery Shopping",
                    Description = "Buy meal prep ingredients, fruits, and snacks.",
                    DueDate = DateTime.Parse("2026-06-01 18:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-01 14:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000114"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000d"),
                    Title = "Deep Clean Kitchen",
                    Description = "Clean the oven, fridge shelves, and countertops.",
                    DueDate = DateTime.Parse("2026-06-03 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-02 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000115"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000d"),
                    Title = "Fix Hallway Light Fixture",
                    Description = "Replace the driver module or old LED panel.",
                    DueDate = DateTime.Parse("2026-05-29 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-05-28 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Overdue
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000116"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000e"),
                    Title = "Pay Electricity & Internet Bills",
                    Description = "Process via online banking portal.",
                    DueDate = DateTime.Parse("2026-06-02 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-01 16:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000117"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000e"),
                    Title = "Review Monthly Budget Spreadsheet",
                    Description = "Track savings and variance relative to goals.",
                    DueDate = DateTime.Parse("2026-06-05 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-04 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000118"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000011"),
                    Title = "Book Annual Dental Checkup",
                    Description = "Call local dental clinic to schedule routine cleaning.",
                    DueDate = DateTime.Parse("2026-06-10 09:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-09 09:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000119"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000f"),
                    Title = "Refactor Legacy Email Module",
                    Description = "Swap out old library for a modern, decoupled wrapper.",
                    DueDate = DateTime.Parse("2026-06-04 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-03 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000120"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000f"),
                    Title = "Implement Feature Flag Toggle",
                    Description = "Add runtime flag config for new dashboard module.",
                    DueDate = DateTime.Parse("2026-06-06 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-05 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000121"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000f"),
                    Title = "Resolve SQL Deadlock Issues",
                    Description = "Optimize query indexing on the active transactions table.",
                    DueDate = DateTime.Parse("2026-05-30 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-05-29 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Completed
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000122"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-00000000000f"),
                    Title = "Update SDK Documentation",
                    Description = "Write API integration setup guides for client teams.",
                    DueDate = DateTime.Parse("2026-06-10 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-09 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000123"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000010"),
                    Title = "Prepare Q3 Architecture Slides",
                    Description = "Draft diagrams highlighting planned system scalability changes.",
                    DueDate = DateTime.Parse("2026-06-05 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-03 12:00:00").ToUniversalTime(),
                    Priority = Priority.High,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000124"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000010"),
                    Title = "Submit Bi-Weekly Timesheet",
                    Description = "Log project allocation codes accurately.",
                    DueDate = DateTime.Parse("2026-06-07 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-06 12:00:00").ToUniversalTime(),
                    Priority = Priority.Medium,
                    Status = Status.Pending
                },
                new TodoItem
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000125"),
                    SubcategoryId = Guid.Parse("019f18a5-c200-7000-8000-000000000012"),
                    Title = "Complete Azure Developer Certification Chapter",
                    Description = "Finish the module on event-driven architectures and message queues.",
                    DueDate = DateTime.Parse("2026-06-12 12:00:00").ToUniversalTime(),
                    Reminder = DateTime.Parse("2026-06-11 12:00:00").ToUniversalTime(),
                    Priority = Priority.Low,
                    Status = Status.Pending
                }
            );
            #endregion

            #region TodoItemSteps
            modelBuilder.Entity<TodoItemStep>().HasData(
                new TodoItemStep
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000201"),
                    TodoItemId = Guid.Parse("019f18a5-c200-7000-8000-000000000101"),
                    Title = "Add EF Core Nuget Packages",
                    Order = 1
                },
                new TodoItemStep
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000202"),
                    TodoItemId = Guid.Parse("019f18a5-c200-7000-8000-000000000101"),
                    Title = "Create ApplicationDbContext class",
                    Order = 2
                },
                new TodoItemStep
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000203"),
                    TodoItemId = Guid.Parse("019f18a5-c200-7000-8000-000000000101"),
                    Title = "Run 'dotnet ef migrations add Initial'",
                    Order = 3
                }
            );
            #endregion

            #region TodoItemFiles
            modelBuilder.Entity<TodoItemFile>().HasData(
                new TodoItemFile
                {
                    Id = Guid.Parse("019f18a5-c200-7000-8000-000000000301"),
                    TodoItemId = Guid.Parse("019f18a5-c200-7000-8000-000000000119"),
                    Name = "refactoring-spec.pdf",
                    Path = "/files/work/refactoring-spec.pdf",
                    ContentType = "application/pdf",
                    UploadedAt = DateTime.Parse("2026-06-01 12:00:00").ToUniversalTime()
                }
            );
            #endregion

        }
    }
}
