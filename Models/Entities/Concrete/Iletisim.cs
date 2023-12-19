using teknikServisMVC.Models.Entities.Abstract;

namespace teknikServisMVC.Models.Entities.Concrete
{
    public class Iletisim : BaseEntity
    {
        public string TelefonNumarasi { get; set; }
        public string Eposta { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri? Musteri { get; set; }
    }

}
