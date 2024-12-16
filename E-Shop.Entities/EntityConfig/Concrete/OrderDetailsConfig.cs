using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class OrderDetailsConfig : BaseConfig<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.UnitPrice).IsRequired();
            builder.Property(p => p.UnitPrice).HasMaxLength(100);

            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Quantity).HasMaxLength(100);

            builder.Property(p => p.Discount).IsRequired();
            builder.Property(p => p.Discount).HasMaxLength(100);

            builder.HasOne(p => p.Orders)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.OrderId);

            builder.HasOne(p => p.Products)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(p => p.ProductId);
        }
    }
}
