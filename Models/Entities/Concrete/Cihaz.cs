using teknikServisMVC.Models.Entities.Abstract;

namespace teknikServisMVC.Models.Entities.Concrete
{
    public class Cihaz : BaseEntity
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNumarasi { get; set; }
        public int ArizaId { get; set; }
        public virtual Ariza? Ariza { get; set; }
    }

}
