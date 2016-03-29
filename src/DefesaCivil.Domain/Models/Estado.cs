using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Estado : BaseModel
    {
        [Required]
        public String Sigla { get; set; }

        [Required]
        public String Nome { get; set; }

        [Required]
        public Pais Pais { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
