using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DefesaCivil.Domain.Models;
using DefesaCivil.Web.Areas.Api.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DefesaCivil.Web.Areas.Api.Controllers
{
    [Area("Api")]
    public class SensorsController : Controller
    {
        private DatabaseContext db;

        public SensorsController(DatabaseContext _db)
        {
            this.db = _db;
            if(this.db.Sensors.Count() == 0)
            {
                City city;
                State state;
                Country country;
                if(db.Countries.Count() == 0)
                {
                    country = new Country { Name = "Brasil" };
                    db.Countries.Add(country);
                    db.SaveChanges();
                }
                else
                {
                    country = db.Countries.Where(c => c.Name == "Brasil").FirstOrDefault();
                }

                if(db.States.Count() == 0)
                {
                    state = new State { Name = "Santa Catarina", Country = country, Code = "SC" };
                    db.States.Add(state);
                    db.SaveChanges();
                }else
                {
                    state = db.States.Where(s => s.Name == "Santa Catarina").FirstOrDefault();
                }

                if(db.Cities.Count() == 0)
                {
                    city = new City { Name = "Joinville", State = state };
                    db.Cities.Add(city);
                    db.SaveChanges();
                }else
                {
                    city = db.Cities.Where(c => c.Name == "Joinville").FirstOrDefault();
                }

                for(int i = 0; i < 100; i++)
                {
                    Sensor sensor = new Sensor();
                    sensor.Address = "Rua XV de Novembro " + i;
                    sensor.City = city;
                    sensor.Latitude = 10.0;
                    sensor.Longitude = 10.0;
                    sensor.Name = "Sensor " + i;
                    sensor.SerialNumber = i.ToString();
                    db.Sensors.Add(sensor);
                }

                db.SaveChanges();
                
            }
        }
 
        public ActionResult Index()
        {
            var sensors = db.Sensors.OrderBy(m => m.Id).Include(m => m.City).ToList();
            List<SensorViewModel> vm = new List<SensorViewModel>();
            foreach(var s in sensors)
            {
                SensorViewModel sensorVM = new SensorViewModel();
                sensorVM.Address = s.Address;
                if(s.City != null)
                    sensorVM.City = new CityViewModel { Id = s.City.Id, Name = s.City.Name };
                sensorVM.Id = s.Id;
                sensorVM.Latitude = s.Latitude;
                sensorVM.Longitude = s.Longitude;
                vm.Add(sensorVM);
            }
            return new JsonResult(vm);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var sensor = db.Sensors.Where(s => s.Id == id).FirstOrDefault();
            if (sensor == null)
                return new JsonResult(@"{ ""error"": ""Sensor not found"" }");

            SensorViewModel vm = new SensorViewModel();
            vm.Id = sensor.Id;
            vm.Address = sensor.Address;
            if(sensor.City != null)
                vm.City = new CityViewModel { Id = sensor.City.Id, Name = sensor.City.Name };
            vm.Latitude = sensor.Latitude;
            vm.Longitude = sensor.Longitude;
            return new JsonResult(vm);
        }

        [HttpGet]
        public ActionResult Statuses(int id)
        {
            try
            {
                var sensor = db.Sensors.Where(s => s.Id == id)
                                       .Include(s => s.Statuses)
                                       .FirstOrDefault();
                if (sensor == null)
                    return new JsonResult(@"{ ""error"": ""Sensor not found"" }");

                int countStatus = sensor.Statuses.Count;

                List<SensorStatusViewModel> vm = new List<SensorStatusViewModel>();
                foreach (var sensorStatus in sensor.Statuses)
                {
                    SensorStatusViewModel statusVM = new SensorStatusViewModel();
                    statusVM.Value = sensorStatus.Value;
                    statusVM.SensorSerialNumber = sensorStatus.Sensor.SerialNumber;
                    statusVM.StatusType = (int) sensorStatus.StatusType;
                    vm.Add(statusVM);
                }
                
                
                var retorno = new JsonResult(vm);
                return retorno;
            }
            catch
            {
                return new JsonResult(@"{ ""error"" : ""Internal server error"" }");
            }
            
        }


        [HttpPost]
        public ActionResult CreateStatus([FromBody]Newtonsoft.Json.Linq.JObject token)
        {
            try
            {
                String serialNumber = (string)token.SelectToken("SensorSerialNumber");
                int sensorId = (int)token.SelectToken("SensorId");
                var sensor = db.Sensors.Where(s => s.Id == sensorId).FirstOrDefault();
                if(sensor == null)
                    return new JsonResult(@"{ ""error"": ""Sensor serial number not found"" }");

                
                int statusType = (int)token.SelectToken("StatusType");
                String statusValue = (string)token.SelectToken("Value");

                var status = new SensorStatus();
                status.Sensor = sensor;
                sensor.Statuses.Add(status);
                status.StatusType = (SensorStatusType) statusType;
                status.Value = statusValue;
                status.UpdatedAt = DateTime.Now;
                status.CreatedAt = DateTime.Now;
                db.SensorStatuses.Add(status);
                db.SaveChanges();
                return Json("ok");
            }
            catch(Exception ex)
            {
                return new JsonResult(@"{ ""error"": ""Internal server error"" }");
            }
            

            
        }

        /*
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        */

        /*
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
