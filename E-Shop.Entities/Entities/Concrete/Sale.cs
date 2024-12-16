using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class Sale : BaseEntity
    {

        public int UrunId { get; set; }


        public int Quantity { get; set; }


        public decimal Price { get; set; }


        public DateTime Date { get; set; }


        public string Image { get; set; }


        public int UserId { get; set; }


    }
}
