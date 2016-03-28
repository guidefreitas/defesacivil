using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Sensor : BaseModel
    {
        public Sensor()
        {
            this.Statuses = new List<SensorStatus>();
        }

        [Required]
        public String Name { get; set; }

        [Required]
        public long Latitude { get; set; }

        [Required]
        public long Longitude { get; set; }

        [Required]
        public String SerialNumber { get; set; }

        public virtual ICollection<SensorStatus> Statuses { get; set; }
    }
}
