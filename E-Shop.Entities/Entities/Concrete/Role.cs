using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
