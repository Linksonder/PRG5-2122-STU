using System;
using System.Collections.Generic;
using System.Text;
using WieIsDeMol.domain;

namespace WieIsDeMol
{
    class DummyData
    {
        public static IEnumerable<Suspect> GetDummyData()
        {
            return new List<Suspect>()
            {
                new Suspect(){ Name = "Noah", Gender = Gender.Male, DateOfBirth = new DateTime(1990, 1, 1), HairColor = "Zwart", HasGlasses = false, Balance = 3210.2, Hobbies = new List<string>{ "Werken", "Golf" }},
                new Suspect(){ Name = "Sem", Gender = Gender.Male, DateOfBirth = new DateTime(1990, 5, 22), HairColor = "Bruin", HasGlasses = true, Balance = 1123.2, Hobbies = new List<string>{ "Golf", "Schilderen" }},
                new Suspect(){ Name = "Finn", Gender = Gender.Male, DateOfBirth = new DateTime(1970, 4, 7), HairColor = "Wit", HasGlasses = false, Balance = 10320.64, Hobbies = new List<string>{ "Schilderen", "Schaken" }},
                new Suspect(){ Name = "Levi", Gender = Gender.Male, DateOfBirth = new DateTime(2001, 7, 11), HairColor = "Blond", HasGlasses = true, Balance = 700.00, Hobbies = new List<string>{ "Schaken", "Gamen" }},
                new Suspect(){ Name = "Lucas", Gender = Gender.Male, DateOfBirth = new DateTime(1988, 11, 29), HairColor = "Rood", HasGlasses = false, Balance = 5320.22, Hobbies = new List<string>{ "Gamen", "Dansen" }},
                new Suspect(){ Name = "Lissa", Gender = Gender.Female, DateOfBirth = new DateTime(1997, 7, 11), HairColor = "Zwart", HasGlasses = true, Balance = 213189.2, Hobbies = new List<string>{ "Werken", "Golf" }},
                new Suspect(){ Name = "Emma", Gender = Gender.Female, DateOfBirth = new DateTime(2004, 2, 23), HairColor = "Bruin", HasGlasses = false, Balance = 202.20, Hobbies = new List<string>{ "Golf", "Schilderen" }},
                new Suspect(){ Name = "Julia", Gender = Gender.Female, DateOfBirth = new DateTime(1950, 9, 4), HairColor = "Wit", HasGlasses = true, Balance = 9001, Hobbies = new List<string>{ "Schilderen", "Schaken" }},
                new Suspect(){ Name = "Sophie", Gender = Gender.Female, DateOfBirth = new DateTime(1982, 8, 18), HairColor = "Blond", HasGlasses = false, Balance = 22.32, Hobbies = new List<string>{ "Schaken", "Gamen" }},
                new Suspect(){ Name = "Tess", Gender = Gender.Female, DateOfBirth = new DateTime(2002, 3, 8), HairColor = "Rood", HasGlasses = true, Balance = 3292.15, Hobbies = new List<string>{ "Gamen", "Dansen" }},
            };
        }
    }
}
