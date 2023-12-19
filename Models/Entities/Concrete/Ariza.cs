using teknikServisMVC.Models.Entities.Abstract;

namespace teknikServisMVC.Models.Entities.Concrete
{
    public class Ariza : BaseEntity
    {
        public string Aciklama { get; set; }

        public int CihazId { get; set; }
        public virtual Cihaz? Cihaz { get; set; }
        public int ArizaDurumuId { get; set; }
        public virtual Musteri? Musteri { get; set; }
        public int MusteriId { get; set; }
        public virtual ArizaDurumu? ArizaDurumu { get; set; }
        public string ArizaTakipNumarasi { get; set; }
    }

}
