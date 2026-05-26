using DemoTodoListAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddNewtonsoftJson();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer("name=DefaultConnection");
    option.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddAutoMapper((config) =>
{
    config.LicenseKey = builder.Configuration["AutoMapper"];
}, typeof(Program));

builder.Services.AddSwaggerGen();

builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
