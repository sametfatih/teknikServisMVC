using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Repositories;

namespace teknikServisMVC.Controllers
{
    public class FaultStatusController : Controller
    {
        readonly ArizaDurumuRepository repository;

        public FaultStatusController(ArizaDurumuRepository arizaDurumuRepository)
        {
            repository = arizaDurumuRepository;
        }
        [HttpGet]
        public IActionResult CreateFaultStatus()
        {
            ICollection<ArizaDurumu> arizaDurumları = repository.GetAll().ToList();
            return View(arizaDurumları);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFaultStatus(ArizaDurumu model)
        {
            bool result = await repository.AddAsync(model);
            if (result)
            {
                await repository.SaveAsync();
                return RedirectToAction("CreateFaultStatus");
            }
               
            return StatusCode(500);
        }
    }
}
