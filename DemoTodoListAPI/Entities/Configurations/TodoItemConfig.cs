using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoTodoListAPI.Entities.Configurations
{
    public class TodoItemConfig : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.ToTable("Tasks");

            builder.Property(prop => prop.Title)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(prop => prop.Description)
                .HasMaxLength(1000);

            builder.Property(prop => prop.Priority)
                .HasDefaultValue(Priority.Low);

            builder.Property(prop => prop.Status)
                .HasDefaultValue(Status.Pending);
        }
    }
}
