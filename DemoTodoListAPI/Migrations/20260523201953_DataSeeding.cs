using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoTodoListAPI.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("019f18a5-c200-7000-8000-000000000001"), "Software Development coursework and assignments", "University", 1 },
                    { new Guid("019f18a5-c200-7000-8000-000000000002"), "Personal chores, maintenance, and finance", "Home", 2 },
                    { new Guid("019f18a5-c200-7000-8000-000000000003"), "Professional tasks, meetings, and project deadlines", "Work", 3 }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Order" },
                values: new object[,]
                {
                    { new Guid("019f18a5-c200-7000-8000-00000000000a"), new Guid("019f18a5-c200-7000-8000-000000000001"), "C#, ASP.NET Core, and Database assignments", "Backend Development", 1 },
                    { new Guid("019f18a5-c200-7000-8000-00000000000b"), new Guid("019f18a5-c200-7000-8000-000000000001"), "Angular, React, and UI/UX design", "Frontend Development", 2 },
                    { new Guid("019f18a5-c200-7000-8000-00000000000c"), new Guid("019f18a5-c200-7000-8000-000000000001"), "Docker, CI/CD pipelines, and AWS", "DevOps & Cloud", 3 },
                    { new Guid("019f18a5-c200-7000-8000-00000000000d"), new Guid("019f18a5-c200-7000-8000-000000000002"), "Cleaning, grocery shopping, and maintenance", "Household Chores", 1 },
                    { new Guid("019f18a5-c200-7000-8000-00000000000e"), new Guid("019f18a5-c200-7000-8000-000000000002"), "Budgeting, bills, and investments", "Personal Finance", 2 },
                    { new Guid("019f18a5-c200-7000-8000-00000000000f"), new Guid("019f18a5-c200-7000-8000-000000000003"), "Sprint tasks and feature development", "Core Projects", 1 },
                    { new Guid("019f18a5-c200-7000-8000-000000000010"), new Guid("019f18a5-c200-7000-8000-000000000003"), "Standups, 1-on-1s, and timesheets", "Meetings & Admin", 2 },
                    { new Guid("019f18a5-c200-7000-8000-000000000011"), new Guid("019f18a5-c200-7000-8000-000000000002"), "Exercise routines, doctor appointments, and meal prepping", "Health & Wellness", 3 },
                    { new Guid("019f18a5-c200-7000-8000-000000000012"), new Guid("019f18a5-c200-7000-8000-000000000003"), "Certifications, technical reading, and skill building", "Professional Development", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "DueDate", "Priority", "Reminder", "Status", "SubcategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("019f18a5-c200-7000-8000-000000000101"), "Set up PostgreSQL and configure initial migrations.", new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000a"), "Implement EF Core Migrations" },
                    { new Guid("019f18a5-c200-7000-8000-000000000102"), "Create the spec for Task Management endpoints.", new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000a"), "Design REST API Endpoints" },
                    { new Guid("019f18a5-c200-7000-8000-000000000103"), "Secure the API using modern token authentication.", new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 2, 5, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000a"), "Add JWT Authentication" },
                    { new Guid("019f18a5-c200-7000-8000-000000000104"), "Achieve 80% coverage on data access layer.", new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 7, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000a"), "Write Repository Unit Tests" },
                    { new Guid("019f18a5-c200-7000-8000-000000000105"), "Build a responsive Kanban board drag-and-drop view.", new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000b"), "Create Task Board UI Component" },
                    { new Guid("019f18a5-c200-7000-8000-000000000106"), "Set up SignalR or state store for live task updates.", new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 8, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000b"), "Integrate State Management" },
                    { new Guid("019f18a5-c200-7000-8000-000000000107"), "Repair the sidebar collapse glitch on screens under 768px.", new DateTime(2026, 5, 31, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Utc), 2, new Guid("019f18a5-c200-7000-8000-00000000000b"), "Fix CSS Layout Bugs on Mobile" },
                    { new Guid("019f18a5-c200-7000-8000-000000000108"), "Ensure contrast and aria-labels pass WCAG compliance.", new DateTime(2026, 6, 11, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000b"), "Submit UI Accessibility Audit" },
                    { new Guid("019f18a5-c200-7000-8000-000000000109"), "Write Dockerfile and compose setup for local testing.", new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000c"), "Dockerize the Application" },
                    { new Guid("019f18a5-c200-7000-8000-000000000110"), "Automate building and running tests on pull requests.", new DateTime(2026, 6, 7, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000c"), "Configure GitHub Actions CI" },
                    { new Guid("019f18a5-c200-7000-8000-000000000111"), "Provision ECS cluster using standard infrastructure.", new DateTime(2026, 6, 13, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 12, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000c"), "Deploy Staging to AWS ECS" },
                    { new Guid("019f18a5-c200-7000-8000-000000000112"), "Hook up metrics to track API response times.", new DateTime(2026, 6, 15, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 14, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000c"), "Setup Prometheus Monitoring" },
                    { new Guid("019f18a5-c200-7000-8000-000000000113"), "Buy meal prep ingredients, fruits, and snacks.", new DateTime(2026, 6, 1, 23, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 1, 19, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000d"), "Weekly Grocery Shopping" },
                    { new Guid("019f18a5-c200-7000-8000-000000000114"), "Clean the oven, fridge shelves, and countertops.", new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000d"), "Deep Clean Kitchen" },
                    { new Guid("019f18a5-c200-7000-8000-000000000115"), "Replace the driver module or old LED panel.", new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 5, 28, 17, 0, 0, 0, DateTimeKind.Utc), 3, new Guid("019f18a5-c200-7000-8000-00000000000d"), "Fix Hallway Light Fixture" },
                    { new Guid("019f18a5-c200-7000-8000-000000000116"), "Process via online banking portal.", new DateTime(2026, 6, 2, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 1, 21, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000e"), "Pay Electricity & Internet Bills" },
                    { new Guid("019f18a5-c200-7000-8000-000000000117"), "Track savings and variance relative to goals.", new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000e"), "Review Monthly Budget Spreadsheet" },
                    { new Guid("019f18a5-c200-7000-8000-000000000118"), "Call local dental clinic to schedule routine cleaning.", new DateTime(2026, 6, 10, 14, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 9, 14, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-000000000011"), "Book Annual Dental Checkup" },
                    { new Guid("019f18a5-c200-7000-8000-000000000119"), "Swap out old library for a modern, decoupled wrapper.", new DateTime(2026, 6, 4, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000f"), "Refactor Legacy Email Module" },
                    { new Guid("019f18a5-c200-7000-8000-000000000120"), "Add runtime flag config for new dashboard module.", new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000f"), "Implement Feature Flag Toggle" },
                    { new Guid("019f18a5-c200-7000-8000-000000000121"), "Optimize query indexing on the active transactions table.", new DateTime(2026, 5, 30, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 5, 29, 17, 0, 0, 0, DateTimeKind.Utc), 2, new Guid("019f18a5-c200-7000-8000-00000000000f"), "Resolve SQL Deadlock Issues" },
                    { new Guid("019f18a5-c200-7000-8000-000000000122"), "Write API integration setup guides for client teams.", new DateTime(2026, 6, 10, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 9, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-00000000000f"), "Update SDK Documentation" },
                    { new Guid("019f18a5-c200-7000-8000-000000000123"), "Draft diagrams highlighting planned system scalability changes.", new DateTime(2026, 6, 5, 17, 0, 0, 0, DateTimeKind.Utc), 3, new DateTime(2026, 6, 3, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-000000000010"), "Prepare Q3 Architecture Slides" },
                    { new Guid("019f18a5-c200-7000-8000-000000000124"), "Log project allocation codes accurately.", new DateTime(2026, 6, 7, 17, 0, 0, 0, DateTimeKind.Utc), 2, new DateTime(2026, 6, 6, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-000000000010"), "Submit Bi-Weekly Timesheet" },
                    { new Guid("019f18a5-c200-7000-8000-000000000125"), "Finish the module on event-driven architectures and message queues.", new DateTime(2026, 6, 12, 17, 0, 0, 0, DateTimeKind.Utc), 1, new DateTime(2026, 6, 11, 17, 0, 0, 0, DateTimeKind.Utc), 1, new Guid("019f18a5-c200-7000-8000-000000000012"), "Complete Azure Developer Certification Chapter" }
                });

            migrationBuilder.InsertData(
                table: "Files",
                columns: new[] { "Id", "ContentType", "Name", "Path", "TodoItemId", "UploadedAt" },
                values: new object[] { new Guid("019f18a5-c200-7000-8000-000000000301"), "application/pdf", "refactoring-spec.pdf", "/files/work/refactoring-spec.pdf", new Guid("019f18a5-c200-7000-8000-000000000119"), new DateTime(2026, 6, 1, 17, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Steps",
                columns: new[] { "Id", "Order", "Title", "TodoItemId" },
                values: new object[,]
                {
                    { new Guid("019f18a5-c200-7000-8000-000000000201"), 1, "Add EF Core Nuget Packages", new Guid("019f18a5-c200-7000-8000-000000000101") },
                    { new Guid("019f18a5-c200-7000-8000-000000000202"), 2, "Create ApplicationDbContext class", new Guid("019f18a5-c200-7000-8000-000000000101") },
                    { new Guid("019f18a5-c200-7000-8000-000000000203"), 3, "Run 'dotnet ef migrations add Initial'", new Guid("019f18a5-c200-7000-8000-000000000101") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Files",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000301"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000201"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000202"));

            migrationBuilder.DeleteData(
                table: "Steps",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000203"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000102"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000103"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000104"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000106"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000107"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000108"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000109"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000110"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000111"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000112"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000113"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000114"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000115"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000116"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000117"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000118"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000120"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000121"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000122"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000123"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000124"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000125"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000101"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000119"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("019f18a5-c200-7000-8000-000000000003"));
        }
    }
}
