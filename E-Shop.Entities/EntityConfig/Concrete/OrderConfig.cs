using E_Shop.Entities.Entities.Concrete;
using E_Shop.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.EntityConfig.Concrete

{
    public class OrderConfig : BaseConfig<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.OrderDate).ValueGeneratedOnAdd()
                                              .HasDefaultValueSql("GETDATE()"); //varsayılan değer


            builder.HasOne(o => o.Shipper)
                .WithMany(s => s.Orders)
                .HasForeignKey(o => o.ShipperId);

            builder.HasOne(o => o.MyUser)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.MyUserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(o => o.Addresses) //order sınıfındaki adres navigation propertysi
                .WithMany(a => a.Orders) //adres sınıfınfaki order navigation propertysi
                .HasForeignKey(o => o.AddressId); // order sınıfındaki foreign key AdressId
        }
    }
}