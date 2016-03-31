using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class City : BaseModel
    {
        [Required]
        [StringLength(200)]
        public String Name { get; set; }

        [Required]
        public State State { get; set; }
    }
}
