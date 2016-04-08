using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DefesaCivil.Domain.Models;
using DefesaCivil.Web.Areas.Api.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        }
 
        public IEnumerable<Sensor> Index()
        {
            return db.Sensors.OrderBy(m => m.Id).ToList();
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            var sensor = db.Sensors.Where(s => s.Id == id).FirstOrDefault();
            if (sensor == null)
                return new JsonResult("{ error: \"Sensor not found\" }");

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
                var sensor = db.Sensors.Where(s => s.Id == id).FirstOrDefault();
                if (sensor == null)
                    return new JsonResult("{ error: \"Sensor not found\" }");

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
                return new JsonResult("{ error: \"Internal server error\" }");
            }
            
        }

        [HttpPost]
        public ActionResult CreateStatus([FromBody]Newtonsoft.Json.Linq.JObject token)
        {
            try
            {
                
                String serialNumber = (string)token.SelectToken("SensorSerialNumber");
                int SensorId = (int)token.SelectToken("SensorId");
                int StatusType = (int)token.SelectToken("StatusType");
                String StatusValue = (string)token.SelectToken("Value");
                return Json("ok");
            }
            catch(Exception ex)
            {
                return new JsonResult("error: " + ex.Message);
            }
            

            
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
