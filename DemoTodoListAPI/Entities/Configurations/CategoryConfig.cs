using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoTodoListAPI.Entities.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(prop => prop.Description)
                .HasMaxLength(500);
        }
    }
}
