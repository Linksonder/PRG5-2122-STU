using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WieIsDeMol.domain
{
    public class Suspect
    {
        public bool HasGlasses { get; set; }

        public Gender Gender {get; set;}


        public int Age { 
            get
            { 
                var age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }

        public DateTime DateOfBirth { get; set; }


        public double Balance { get; set; }

        public string HairColor { get; set; }

        public String Name { get; set; }

        public IEnumerable<string> Hobbies { get; set; }

        public Suspect()
        {
            this.Hobbies = new List<string>();
        }

        override public string ToString()
        {
            string hobbies = "";
            foreach(string hobby in this.Hobbies){

                if(this.Hobbies.Last() == hobby)
                {
                    hobbies = hobbies.Remove(hobbies.Length - 1); //remove last ,
                    hobbies += " and " + hobby;
                }    
                else
                    hobbies += (hobby + ",");
            }
          
            return String.Format("My name is {0}, i am {1} years old with {2} hair and i {3} have glasses. I am a {4} and my balance is currently {5} dollars. I love to practice{6} ",
                                        this.Name, this.Age, this.HairColor, this.HasGlasses ? "do" : "do not", this.Gender, this.Balance, hobbies);
        }
    }
}
