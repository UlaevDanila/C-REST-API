using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderProductService.Domain.Entities.Orders;

namespace OrderProductService.Infrastructure.OrderItemsPersistence;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
    }

    public void ConfigureOrderItemTable(EntityTypeBuilder<OrderItem> builder)
    {
        builder
            .ToTable("OrderItems");
        
        builder
            .HasKey(item => item.Order.Id);
        
        builder
            .Property(item => item.Order.Id)
            .ValueGeneratedNever();
        
        builder
            .Property(items => items.Products)
            .IsRequired();
    }
}