using Ders3.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Ders3.Controllers
{
    public class Logins : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }

        public async Task<IActionResult> GirisYap(Admin p)
        {
            var degerler = c.Admins.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi 
            && x.Sifre==p.Sifre);
            if (degerler!= null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.KullaniciAdi)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personnels");
            }
            return View();
        }
    }
}
