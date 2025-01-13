using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class ShipperSeed : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasData(

                new Shipper
                {
                    Id = 1,
                    CompanyName = "JetKargo",
                    Phone = "+90 555 444 55 55"
                },
                new Shipper
                {
                    Id = 2,
                    CompanyName = "Aras Kargo",
                    Phone = "444 25 52"
                },
                new Shipper
                {
                    Id = 3,
                    CompanyName = "PTT Kargo",
                    Phone = "+90 312 309 51 44"
                }
            );
        }
    }
}
