using teknikServisMVC.Models.Entities.Concrete;

namespace teknikServisMVC.Models.ViewModels
{
    public class DashboardViewModel
    {
        public ICollection<Ariza> SonArizalar { get; set; }
        public ICollection<Ariza> SonGuncellenenler { get; set; }
        public int ToplamArizaSayisi { get; set; }
        public int ToplamSonuclanan { get; set; }
        public int ToplamCihaz { get; set; }
        public int ToplamKargo { get; set; }
    }
}
