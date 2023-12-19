using NuGet.Protocol.Plugins;
using System.Linq;
using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Repositories.Context;

namespace teknikServisMVC.Repositories
{
    public class ArizaRepository : Repository<Ariza>
    {
        readonly serviceDbContext _context;
        public ArizaRepository(serviceDbContext context) : base(context)
        {
            _context = context;
        }
        public ICollection<Ariza> GetAllFinalized()
        {
            return _context.Arizalar.Where(fs => fs.ArizaDurumuId == 5).ToList();
        }

        public ICollection<Ariza> GetAllInCargo()
        {
            return _context.Arizalar.Where(fs => fs.ArizaDurumuId == 4).ToList();
        }

        public ICollection<Ariza> GetAllInProgress()
        {
            return _context.Arizalar.Where(fs => fs.ArizaDurumuId == 2).ToList();
        }

        public Ariza GetFaultbyTN(string faultTrackNumber)
        {
            return _context.Arizalar.Where(fs => fs.ArizaTakipNumarasi == faultTrackNumber).Single();
        }
    }
}
