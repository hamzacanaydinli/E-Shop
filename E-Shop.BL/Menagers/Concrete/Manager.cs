using E_Shop.BL.Menagers.Abstract;
using E_Shop.DAL.GenericRepository.Concrete;
using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.BL.Menagers.Concrete
{
    public class Manager<T> : Repository<T>, IManager<T> where T : BaseEntity
    {
    }
}
