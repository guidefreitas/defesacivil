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
        public String Nome { get; set; }

        [Required]
        public Cidade Cidade { get; set; }

        public ApplicationUser Administrador { get; set; }
    }
}
