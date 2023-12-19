using teknikServisMVC.Models.Entities.Abstract;

namespace teknikServisMVC.Models.Entities.Concrete
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public virtual Adres? Adres { get; set; }
        public virtual Iletisim? Iletisim { get; set; }
        public virtual ICollection<Ariza>? Arizalar { get; set; }
    }

}
