using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class State : BaseModel
    {
        [Required]
        public String Code { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public Country Country { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
