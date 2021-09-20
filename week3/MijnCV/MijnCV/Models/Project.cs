using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MijnCV.Models
{
    public class Project
    {
        public String Naam { get; set; }

        public DateTime Start { get; set; }
        public DateTime Einde { get; set; }

        public String Omschrijving { get; set; }

        public String ImageUri { get; set; }


    }
}
