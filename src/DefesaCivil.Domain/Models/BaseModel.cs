using System;
using System.ComponentModel.DataAnnotations;

namespace DefesaCivil.Domain.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
        }

        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
