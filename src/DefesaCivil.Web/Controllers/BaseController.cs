using DefesaCivil.Domain.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext db = null;

        public BaseController(ApplicationDbContext _db)
        {
            this.db = _db;
        }
    }
}
