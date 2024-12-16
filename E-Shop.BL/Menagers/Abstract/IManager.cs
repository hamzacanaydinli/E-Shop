using E_Shop.DAL.GenericRepository.Abstract;
using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.BL.Menagers.Abstract
{
    public interface IManager<T> : IRepository<T> where T : BaseEntity
    {
    }
}
