using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{
    public class SalesConfig : BaseConfig<Sale>
    {
        public override void Configure(EntityTypeBuilder<Sale> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Quantity).HasMaxLength(100);


            builder.Property(p => p.UrunId).IsRequired();
            builder.Property(p => p.UrunId).HasMaxLength(100);
            builder.HasIndex(p => p.UrunId).IsUnique();

            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Price).HasMaxLength(100);


            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.Date).HasMaxLength(100);


            builder.Property(p => p.Image).IsRequired();
            builder.Property(p => p.Image).HasMaxLength(100);


            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.UserId).HasMaxLength(100);
            builder.HasIndex(p => p.UserId).IsUnique();
        }
    }
}
