using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class OrderDetailSeed : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasData(

                new OrderDetail
                {
                    Id = 1,
                    OrderId = 1,
                    ProductId = 1,
                    Discount = 0,
                    Quantity = 1,
                    UnitPrice = 200
                }

            );
        }
    }
}

