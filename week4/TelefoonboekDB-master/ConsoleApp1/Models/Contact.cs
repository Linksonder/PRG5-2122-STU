using System;
using System.Collections.Generic;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class Contact
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime? Geboortedatum { get; set; }
        public string Telefoonummer { get; set; }
        public int Id { get; set; }
    }
}
