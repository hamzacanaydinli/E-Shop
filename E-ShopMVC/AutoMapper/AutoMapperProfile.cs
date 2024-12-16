
using AutoMapper;
using E_Shop.Entities.Entities.Concrete;
using E_ShopMVC.Models.VMs.Account;

namespace Ticari.WebMVC.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserInsertVM, User>().ReverseMap();
        }

    }
}

