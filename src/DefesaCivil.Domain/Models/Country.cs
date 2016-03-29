using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Country : BaseModel
    {
        [Required]
        public String Name { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
