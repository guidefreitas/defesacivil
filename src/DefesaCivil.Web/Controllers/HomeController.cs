using DefesaCivil.Domain.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
        
            Country c = new Country();
            c.Name = "Brasil";
            c.CreatedAt = DateTime.Now;
            c.UpdatedAt = DateTime.Now;

            context.Countries.Add(c);
            context.SaveChanges();

            var pais = context.Countries.Where(country => country.Name.StartsWith("Bra")).First();

            return View();
        } 
    }
}
