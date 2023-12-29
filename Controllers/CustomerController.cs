using Castle.Core.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Globalization;
using System.Text;
using teknikServisMVC.Models.Entities.Concrete;
using teknikServisMVC.Models.ViewModels;
using teknikServisMVC.Repositories;

namespace teknikServisMVC.Controllers
{
    public class CustomerController : Controller
    {
        readonly MusteriRepository musteriRepository;

        public CustomerController(MusteriRepository musteriRepository)
        {
            this.musteriRepository = musteriRepository;
        }

        public async Task<IActionResult> StatusChange(int id)
        {
            var model = await musteriRepository.GetByIdAsync(id);
            model.Status = model.Status ? false : true;
            var result = musteriRepository.Update(model);

            if (result)
            {
                await musteriRepository.SaveAsync();
                return RedirectToAction("AllCustomers", "Customer");
            }
            else
                return StatusCode(500);
        }
        [HttpGet()]
        public async Task<IActionResult> UpdateAsync(int id)
        {

            Musteri customer = await musteriRepository.GetByIdAsync(id);

            return View(customer);
        }
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] Musteri updateCustomer)
        {
            Musteri customer = await musteriRepository.GetByIdAsync(updateCustomer.Id);

            customer.Adres.Sehir = updateCustomer.Adres.Sehir;
            customer.Adres.CaddeAdres = updateCustomer.Adres.CaddeAdres;
            customer.Adres.PostaKodu = updateCustomer.Adres.PostaKodu;
            customer.Iletisim.TelefonNumarasi = updateCustomer.Iletisim.TelefonNumarasi;
            customer.Iletisim.Eposta = updateCustomer.Iletisim.Eposta;
            customer.Ad = updateCustomer.Ad;
            customer.Soyad = updateCustomer.Soyad;

            var result = musteriRepository.Update(customer);

            if (result)
            {
                await musteriRepository.SaveAsync();
                return RedirectToAction("AllCustomers", "Customer");
            }else
             return StatusCode(500);
        }
        [HttpGet]
        public IActionResult AllCustomers()
        {
            var musteriler = musteriRepository.GetAll();

            return View(Tuple.Create<object, List<object>, string>(new Musteri(), musteriler.Cast<object>().ToList(), "table table-hover dataTable js-exportable"));
        }
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerCreateViewModel model)
        {


            Musteri musteri = new()
            {
                Ad = model.Ad,
                Soyad = model.Soyad,
                Adres = new()
                {
                    Sehir = model.Sehir,
                    Ulke = model.Ulke,
                    PostaKodu = model.PostaKodu,
                    CaddeAdres = model.CaddeAdres
                },
                Iletisim = new()
                {
                    TelefonNumarasi = model.TelefonNumarasi,
                    Eposta = model.Eposta,
                }
            };

             var result = await musteriRepository.AddAsync(musteri);

            if (result)
            {
                await musteriRepository.SaveAsync();
                return RedirectToAction("AllCustomers");
            }
               
            return StatusCode(500);
        }
    }
}
