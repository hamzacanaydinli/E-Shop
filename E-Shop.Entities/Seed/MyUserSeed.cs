using E_Shop.Entities.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Shop.Entities.Seed
{
    public class UserSeed : IEntityTypeConfiguration<MyUser>
    {
        public void Configure(EntityTypeBuilder<MyUser> builder)
        {
            builder.HasData(

                new MyUser
                {
                    Id = 1,
                    Name = "Hamza",
                    SurName = "Aydınlı",
                    //AdressId = 1,
                    Email = "hamza@gmail.com",
                    Gsm = "+90 555 555 55 55",
                    RoleId = 1,
                    Password = "qweasd"

                },
                new MyUser
                {
                    Id = 2,
                    Name = "Mehmet",
                    SurName = "Kaya",
                    //AdressId = 2,
                    Email = "furkan_yeneroğlu@gmail.com",
                    Gsm = "+90 555 555 55 44",
                    RoleId = 2,
                    Password = "qweasd"

                },
                new MyUser
                {
                    Id = 3,
                    Name = "Ahmet",
                    SurName = "Yilmaz",
                    //AdressId = 3,
                    Email = "ahmet@gmail.com",
                    Gsm = "+90 555 555 55 33",
                    RoleId = 2,
                    Password = "qweasd"
                }
            );
        }
    }
}