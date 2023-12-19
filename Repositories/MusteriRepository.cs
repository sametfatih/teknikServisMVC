using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Repositories.Context;

namespace teknikServisMVC.Repositories
{
    public class MusteriRepository : Repository<Musteri>
    {
        readonly serviceDbContext _context;
        public MusteriRepository(serviceDbContext context) : base(context)
        {
            _context = context;
        }

        public Task<Musteri> GetByEmail(string email)
        {
            return _context.Musteriler.Where(c => c.Iletisim.Eposta == email).FirstOrDefaultAsync();

        }
    }
}
