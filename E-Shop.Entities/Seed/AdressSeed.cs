using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(

                new Address
                {
                    Id = 1,
                    MyUserId = 1,
                    AddressName = "Home",
                    AddressDescription = "İstiklal Caddesi,Mehmet Akif Sokağı,Aydınlı Apartmanı No:6 / Daire:1",
                    District = "Üsküdar",
                    Province = "İstanbul"
                },
                new Address
                {
                    Id = 2,
                    MyUserId = 2,
                    AddressName = "Evim",
                    AddressDescription = "Cantürk Sokak, Aydınlı Apt. No:28 Daire:4",
                    District = "Terme",
                    Province = "Samsun"
                },
                new Address
                {
                    Id = 3,
                    MyUserId = 3,
                    AddressName = "Office",
                    AddressDescription = "Gökcan Mahallesi, Ateş Apartmanı No:14 Daire:2",
                    District = "Canik",
                    Province = "Samsun"
                }
                //new Address
                //{
                //    Id = 4,
                //    MyUserId = 4,
                //    AddressName = "Friends",
                //    AddressDescription = "Kuşluk Mahallesi, Çaylık Sokak, Güven Apt. No:2 Daire:11",
                //    District = "Maltepe",
                //    Province = "İstanbul"
                //}
            );
        }
    }
}