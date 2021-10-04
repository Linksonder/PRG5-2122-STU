using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWeek6.Models
{
    public class ContactFormulier
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(200)]
        [DisplayName("Type hier je bericht:")]
        public string Bericht { get; set; }
    }
}
