using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using teknikServisMVC.Models.ViewModels;
using teknikServisMVC.Repositories;

namespace teknikServisMVC.Controllers
{
    public class DashboardController : Controller
    {
        readonly ArizaRepository repository;

        public DashboardController(ArizaRepository arizaRepository)
        {
            repository = arizaRepository;
        }
        public IActionResult Index()
        {
            DashboardViewModel model = new()
            {
                SonArizalar = repository.GetAll().OrderByDescending(f => f.CreatedDate).Take(5).ToList(),
                SonGuncellenenler = repository.GetAll().OrderByDescending(f => f.UpdatedDate).Take(5).ToList(),
                ToplamArizaSayisi = repository.GetAll().Count(),
                ToplamSonuclanan = repository.GetAllFinalized().Count(),
                ToplamCihaz = repository.GetAllInProgress().Count(),
                ToplamKargo = repository.GetAllInCargo().Count(),
            };

            return View(model);
        }

    }
}
