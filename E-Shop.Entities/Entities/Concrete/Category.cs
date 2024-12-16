using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Category : BaseEntity
    {


        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
