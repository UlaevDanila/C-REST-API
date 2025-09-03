using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderProductService.Domain.Entities.Products;

namespace OrderProductService.Infrastructure.ProductsPersistence;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder) => ConfigureProductTable(builder);

    private void ConfigureProductTable(EntityTypeBuilder<Product> builder)
    {
        builder
            .ToTable("products");

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
            .Property(x => x.Price)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder
            .Property(x => x.CreatedAt)
            .IsRequired();
    }
}