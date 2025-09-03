using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderProductService.Domain.Entities.Categories;

namespace OrderProductService.Infrastructure.CategoryPersistence;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder) => ConfigureCategoryTable(builder);

    private void ConfigureCategoryTable(EntityTypeBuilder<Category> builder)
    {
        builder
            .ToTable("categories");

        builder
            .HasKey(x => x.Id);

        builder
            .Property(x => x.Id)
            .ValueGeneratedNever();

        builder
            .Property(x => x.Name)
            .IsRequired();

        builder
            .Property(x => x.Description)
            .IsRequired();

        builder
            .HasMany(x => x.Products)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}