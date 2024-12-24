using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class CommUser : BaseEntity
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}


