using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class ShipperConfig : BaseConfig<Shipper>
    {
        public override void Configure(EntityTypeBuilder<Shipper> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CompanyName).IsRequired();
            builder.Property(p => p.CompanyName).HasMaxLength(100);


            builder.Property(p => p.Phone).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(20);
            builder.HasIndex(p => p.Phone).IsUnique();

        }
    }
}
