using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class OrderConfig : BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.OrderDate).IsRequired();
            builder.Property(p => p.OrderDate).HasMaxLength(100);

            builder.Property(p => p.RequiredDate).IsRequired();
            builder.Property(p => p.RequiredDate).HasMaxLength(100);


            builder.Property(p => p.ShippedDate).IsRequired();
            builder.Property(p => p.ShippedDate).HasMaxLength(100);


            builder.Property(p => p.ShipVia).IsRequired();
            builder.Property(p => p.ShipVia).HasMaxLength(100);
            //builder.HasIndex(p => p.ShipVia).IsUnique();

            builder.Property(p => p.ShipAdress).IsRequired();
            builder.Property(p => p.ShipAdress).HasMaxLength(100);

            builder.Property(p => p.ShipCity).IsRequired();
            builder.Property(p => p.ShipCity).HasMaxLength(100);

            builder.HasOne(p => p.Shipper)
                .WithMany(p => p.Orders)
                .HasForeignKey(p => p.ShipperId);

        }
    }
}
