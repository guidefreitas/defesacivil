using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DefesaCivil.Domain.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DefesaCivil.Web.Areas.Api.Controllers
{
    [Area("Api")]
    public class SensorsController : Controller
    {
        Sensor[] sensors = new Sensor[]
        {
            new Sensor { Id = 1, Latitude = 10.0, Longitude = 10.0, Name = "Sensor 1", SerialNumber = "1" },
            new Sensor { Id = 2, Latitude = 10.0, Longitude = 10.0, Name = "Sensor 2", SerialNumber = "2" },
            new Sensor { Id = 3, Latitude = 10.0, Longitude = 10.0, Name = "Sensor 3", SerialNumber = "3" },
            new Sensor { Id = 4, Latitude = 10.0, Longitude = 10.0, Name = "Sensor 4", SerialNumber = "4" },
        };

        // GET: /<controller>/
        public IEnumerable<Sensor> Index()
        {
            return sensors;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
