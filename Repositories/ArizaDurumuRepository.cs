using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Repositories.Context;

namespace teknikServisMVC.Repositories
{
    public class ArizaDurumuRepository : Repository<ArizaDurumu>
    {
        readonly serviceDbContext _context;
        public ArizaDurumuRepository(serviceDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
