using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete
{

    public class AddressConfig : BaseConfig<Address>
    {
        public class AdressConfig : BaseConfig<Address>
        {
            public override void Configure(EntityTypeBuilder<Address> builder)
            {
                base.Configure(builder);

                builder.Property(p => p.AddressName).IsRequired().HasMaxLength(80);
                builder.Property(p => p.AddressDescription).IsRequired().HasMaxLength(300);
                builder.Property(p => p.District).IsRequired().HasMaxLength(20);
                builder.Property(p => p.Province).IsRequired().HasMaxLength(15);

                builder.HasOne(a => a.MyUser)
                    .WithMany(u => u.Addresses)
                    .HasForeignKey(a => a.MyUserId);

            }
        }
    }
}