using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoTodoListAPI.Entities.Configurations
{
    public class TodoItemFileConfig : IEntityTypeConfiguration<TodoItemFile>
    {
        public void Configure(EntityTypeBuilder<TodoItemFile> builder)
        {
            builder.ToTable("Files");

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(prop => prop.Path)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
