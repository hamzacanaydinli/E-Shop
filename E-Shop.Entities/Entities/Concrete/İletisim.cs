using E_Shop.Entities.Entities.Abstract;

namespace E_Shop.Entities.Entities.Concrete
{
    public class İletisim : BaseEntity
    {
        public string Adi { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }
    }
}
