using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new STU_TelefoonboekContext())
            {
                List<Contact> contacts = context.Contacts.ToList();

                foreach (Contact c in contacts)
                {
                    Console.WriteLine(c.Achternaam);
                }

            }
        }
    }
}
