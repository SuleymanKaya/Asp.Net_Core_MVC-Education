using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ders3.Models;
using Microsoft.EntityFrameworkCore;

namespace Ders3.Controllers
{
    public class Departments : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Departments.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Department d)
        {
            c.Departments.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var dep = c.Departments.Find(id);
            c.Departments.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var deger = c.Departments.Find(id);
            return View("DepartmanGetir", deger);
        }

        public IActionResult DepartmanGüncelle(Department d)
        {
            var dep = c.Departments.Find(d.Id);
            dep.DepartmentName = d.DepartmentName;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanDetay(int id)
        {
            var degerler = c.Personnels.Where(x => x.DepartmentID == id).Include(x => x.Department).ToList();
            var dptad = c.Departments.Where(x => x.Id == id).Select(y=>y.DepartmentName).FirstOrDefault();
            ViewBag.brmad = dptad;
            return View(degerler);
        }
    }

}
