using Ders1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public int Index3()
        {
            return 6;
        }

        public string Index4()
        {
            return "Merhaba burası index 4 bebeğim!";
        }

        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){Id=1, KitapAdi="80 Günde Devri Alem", Yazar="Jules Verne" },
                new Kitap(){Id=2, KitapAdi="Masumiyet Müzesi", Yazar="Orhan Pamuk"},
                new Kitap(){Id=3, KitapAdi="Nefes Nefese", Yazar="Ayşe Kulin"}
            };
            return View(ktp);
        }

        public IActionResult Index6()
        {
            ViewBag.deger1 = "Şimdi index 6 çalışıyor";
            return View();
        }

        public IActionResult Index7()
        {
            return View();
        }

        public IActionResult Index8()
        {
            return View();
        }

        public IActionResult Index9()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
