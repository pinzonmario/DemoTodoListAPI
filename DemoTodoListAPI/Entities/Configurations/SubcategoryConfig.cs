using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoTodoListAPI.Entities.Configurations
{
    public class SubcategoryConfig : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.Property(prop => prop.Name)
                 .IsRequired()
                 .HasMaxLength(60);

            builder.Property(prop => prop.Description)
                .HasMaxLength(500);
        }
    }
}
