using DefesaCivil.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Controllers
{
    public class AlertController : BaseController
    {
        public AlertController(DatabaseContext db) : base(db) { }

        public ActionResult Index()
        {
            List<Comunicate> alerts = new List<Comunicate>();
            for(int i = 0; i < 10; i++)
            {
                Comunicate alert = new Comunicate();
                alert.Title = "Titulo do alerta " + i;
                alert.Message = "Alerta de exemplo " + i;
                alert.Link = "http://google.com";
                alert.DatePublicated = DateTime.Now;
                alerts.Add(alert);
            }

            return View(alerts);
        }
    }
}
