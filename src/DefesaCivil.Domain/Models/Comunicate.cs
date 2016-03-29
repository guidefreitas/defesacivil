using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class Comunicate : BaseModel
    {
        [Required]
        public String Message { get; set; }

        public String Link { get; set; }

        [Required]
        public DateTime DatePublicated { get; set; }

        [Required]
        public bool SendToMobile { get; set; }

        [Required]
        public Institute Institute { get; set; }

        [Required]
        public ApplicationUser Creator { get; set; }

        public float? Nota { get; set; }

    }
}
