using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoTodoListAPI.Entities.Configurations
{
    public class TodoItemStepConfig : IEntityTypeConfiguration<TodoItemStep>
    {
        public void Configure(EntityTypeBuilder<TodoItemStep> builder)
        {
            builder.ToTable("Steps");

            builder.Property(prop => prop.Title)
                .IsRequired()
                .HasMaxLength(60);
        }
    }
}
