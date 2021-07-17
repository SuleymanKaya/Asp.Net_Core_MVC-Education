using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ders2_Kitaplik.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders2_Kitaplik.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var KitapListesi = new List<Kitaplar>
            {
                new Kitaplar {Id=4, KitapAdi="Harikalar Diyarı", Yazar="Micheal Scott"},
                new Kitaplar {Id=5, KitapAdi="Almanyanın Güzellikleri", Yazar="Dwight Schrutz"}
            };

            return View(KitapListesi);
        }
        

    }
}
