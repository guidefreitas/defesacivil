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
        private DatabaseContext context;

        public HomeController(DatabaseContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        } 
    }
}
