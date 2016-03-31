using DefesaCivil.Domain.Models;
using DefesaCivil.Web.Areas.Admin.ViewModels;
using DefesaCivil.Web.Controllers;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountryController : BaseController
    {

        public CountryController(ApplicationDbContext db) : base(db) { }

        public IActionResult Index()
        {
            List<Country> countries = this.db.Countries.OrderBy(c => c.Name).ToList();

            return View(countries);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Country country = new Country();

            return View(country);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name")] Country vm)
        {
            if (ModelState.IsValid)
            {
                Country country = new Country();
                this.db.Countries.Add(country);
                this.db.SaveChanges();
                RedirectToAction("Index");
            }

            return View(vm);
        }


    }
}
