using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Web.Areas.Api.ViewModels
{
    public class SensorViewModel
    {
        public long Id { get; set; }
        public String Address { get; set; }
        public CityViewModel City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
