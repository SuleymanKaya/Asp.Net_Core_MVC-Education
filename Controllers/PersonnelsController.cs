using Ders3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders3.Controllers
{
    public class PersonnelsController : Controller
    {
        Context c = new Context();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = c.Personnels.Include(x=>x.Department).ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in c.Departments.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.DepartmentName,
                                                 Value = x.Id.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public IActionResult YeniPersonel(Personnel p)
        {
            var prs = c.Departments.Where(x => x.Id == p.Department.Id).FirstOrDefault();
            p.Department = prs;
            c.Personnels.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
