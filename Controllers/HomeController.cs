using Ders2_Kitaplik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ders2_Kitaplik.Controllers
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

        public IActionResult Index1()
        {
            var ktp = new List<Kitaplar>()
            {
                new Kitaplar(){Id=1, KitapAdi="80 Günde Devri Alem", Yazar="Jules Verne" },
                new Kitaplar(){Id=2, KitapAdi="Masumiyet Müzesi", Yazar="Orhan Pamuk"},
                new Kitaplar(){Id=3, KitapAdi="Nefes Nefese", Yazar="Ayşe Kulin"}
            };

            return View(ktp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public  IActionResult Deneme()
        {
            return View();
        }

        public IActionResult StatikTema()
        {
            return View();
        }
    }
}
