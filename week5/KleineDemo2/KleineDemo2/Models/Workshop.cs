using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo2.Models
{
    public class Workshop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Collection<Student> Studenten { get; set; }

        public int TASStudentNummer { get; set; }

        [ForeignKey("TASStudentNummer")]
        public Student TA { get; set; }


    }
}
