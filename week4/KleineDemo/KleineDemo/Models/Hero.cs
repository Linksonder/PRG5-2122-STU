using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo.Models
{
    public class Hero
    {
        public String Name { get; set; }

        public int Powerlevel { get; set; }
        public string Id { get; internal set; }

        public string Catchphrase { get; set; }

        public ICollection<Weapon> MyWeapons { get; set; }
    }
}
