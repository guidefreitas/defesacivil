using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefesaCivil.Domain.Models
{
    public class BaseModel
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
