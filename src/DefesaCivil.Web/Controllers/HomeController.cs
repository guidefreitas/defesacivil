using DefesaCivil.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(DatabaseContext db) : base(db) { }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult System()
        {
            return View();
        }

        [HttpGet]
        public IActionResult App()
        {
            return View();
        }
    }
}
