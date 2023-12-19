using teknikServisMVC.Models.Entities.Abstract;

namespace teknikServisMVC.Models.Entities.Concrete
{
    public class Adres : BaseEntity
    {
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string CaddeAdres { get; set; }
        public string PostaKodu { get; set; }
        public int MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
    }

}
