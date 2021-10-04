using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo2.Models
{
    public class Student
    {
        [Key]
        public int Studentnummer { get; set; }

        public string Name { get; set; }

        public Collection<Workshop> Workshops { get; set; }

    }
}
