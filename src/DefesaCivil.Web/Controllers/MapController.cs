using DefesaCivil.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class MapController : BaseController
    {
        public MapController(DatabaseContext db) : base(db) { }

        public ActionResult Index()
        {
            return View();
        }
    }
}
