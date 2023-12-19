
using Castle.Core.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using teknik_servis.WebApp.Models;
using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Repositories;

namespace teknikServisMVC.Controllers
{
    public class FaultController : Controller
    {
        readonly ArizaRepository repository;
        readonly MusteriRepository musteriRepository;
        private Ariza ariza = new Ariza();

        public FaultController(ArizaRepository repository , MusteriRepository musteriRepository)
        {
            this.repository = repository;
            this.musteriRepository = musteriRepository;
        }
        [HttpGet]
        public IActionResult AllFaults()
        {
            ICollection<Ariza> arizalar = repository.GetAll().ToList();
            return View(Tuple.Create<object, List<object>, string>(new Ariza(), arizalar.Cast<object>().ToList(), "table table-hover js-exportable"));
        }
        [HttpGet]
        public IActionResult FinalizedFaults()
        {
            ICollection<Ariza> arizalar = repository.GetAllFinalized();
            return View(Tuple.Create<object, List<object>, string>(ariza, arizalar.Cast<object>().ToList(), "table table-hover js-exportable"));
        }
        [HttpGet]
        public IActionResult ProcessFaults()
        {
            ICollection<Ariza> arizalar = repository.GetAllInProgress();
            return View(Tuple.Create<object, List<object>, string>(ariza, arizalar.Cast<object>().ToList(), "table table-hover js-exportable"));
        }
        [HttpGet]
        public IActionResult NewFault()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> NewFault([FromForm] NewFaultModel faultModel)
        {

            Musteri customer = await musteriRepository.GetByEmail(faultModel.Eposta);

            if (customer != null)
            {
                Ariza fault = new Ariza()
                {
                    Aciklama = faultModel.Aciklama,
                    Cihaz = new Cihaz()
                    {
                        Marka = faultModel.Marka,
                        Model = faultModel.Model,
                        SeriNumarasi = faultModel.SeriNumarasi,
                    },
                    MusteriId = customer.Id,
                    Musteri = customer,
                    ArizaDurumuId = 1,
                    ArizaTakipNumarasi = faultModel.ArizaTakipNumarasi,
                };

                var result = await repository.AddAsync(fault);

                if (result)
                {
                    await repository.SaveAsync();
                    return RedirectToAction("AllFaults");
                }
                else
                {
                    return StatusCode(500);
                }
                
            }

            return StatusCode(500);
        }
        [HttpGet]
        public IActionResult LastFaults()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult LastUpdates()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult FaultStatus(string ArizaTakipNumarasi)
        {
            Ariza arıza = repository.GetFaultbyTN(ArizaTakipNumarasi);
            if (arıza.Status == true)
                return View(arıza);
            else
                return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> StatusUpdate(int id)
        {
            var updatestatusmodel = await repository.GetByIdAsync(id);
            updatestatusmodel.ArizaDurumuId = updatestatusmodel.ArizaDurumuId + 1;

            var result = repository.Update(updatestatusmodel);

            if (result)
            {
                await musteriRepository.SaveAsync();
                return RedirectToAction("AllFaults", "Fault");
            }
            else
                return StatusCode(500);
        }

        public async Task<IActionResult> StatusChange(int id)
        {
            var model = await repository.GetByIdAsync(id);
            model.Status = model.Status ? false : true;
            
            var result = repository.Update(model);

            if (result)
            {
                await musteriRepository.SaveAsync();
                return RedirectToAction("AllFaults", "Fault");
            }
            else
                return StatusCode(500);
        }
    }
}