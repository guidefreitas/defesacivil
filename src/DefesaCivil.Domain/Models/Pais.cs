using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Pais : BaseModel
    {
        [Required]
        public String Nome { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
