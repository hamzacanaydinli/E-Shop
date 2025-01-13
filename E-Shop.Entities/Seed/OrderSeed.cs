using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(

               new Order
               {
                   Id = 1,
                   MyUserId = 2,
                   AddressId = 1,
                   OrderDate = new DateOnly(2024, 10, 18), //18 Ekim 2024
                   RequiredDate = new DateOnly(2024, 10, 22), //Tahmini Teslimat Tarihi
                   ShippedDate = new DateOnly(2024, 10, 20), //kargoya verilen tarih
                   ShipperId = 1
               }
            );
        }
    }
}