using DefesaCivil.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class BaseController : Controller
    {
        protected DatabaseContext db = null;

        public BaseController(DatabaseContext _db)
        {
            this.db = _db;
        }
    }
}
