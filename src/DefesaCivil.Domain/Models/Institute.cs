using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Institute : BaseModel
    {
        [Required]
        [StringLength(100)]
        public String Name { get; set; }

        [Required]
        public City City { get; set; }

        public User Administrator { get; set; }
    }
}
