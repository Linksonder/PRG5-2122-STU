using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo.Models
{
    public class Weapon
    {
        [Key]
        public string RegistrionNumber { get; set; }

        public string Type { get; set; }

        public int Damage { get; set; }

        [ForeignKey("Hero")]
        public string HeroId { get; set; }

        public Hero Hero { get; set; }
    }
}
