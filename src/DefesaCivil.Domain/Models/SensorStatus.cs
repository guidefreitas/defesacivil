using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class SensorStatus : BaseModel
    {
        public Sensor Sensor { get; set; }
        public SensorStatusType StatusType { get; set; }
        public int Value { get; set; }
    }
}
