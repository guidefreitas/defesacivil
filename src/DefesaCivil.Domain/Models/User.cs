using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class User : IdentityUser
    {
        [Key]
        public String Username { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
    }
}
