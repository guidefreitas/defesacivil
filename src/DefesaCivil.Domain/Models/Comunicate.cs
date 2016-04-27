using System;
using System.ComponentModel.DataAnnotations;

namespace DefesaCivil.Domain.Models
{
    public class Comunicate : BaseModel
    {
        [Required]
        [StringLength(1000)]
        public String Message { get; set; }

        [StringLength(300)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public String Link { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/1990", "1/1/2300")]
        public DateTime DatePublicated { get; set; }

        [Required]
        public bool SendToMobile { get; set; }

        [Required]
        public Institute Institute { get; set; }

        [Required]
        public User Creator { get; set; }

    }
}
