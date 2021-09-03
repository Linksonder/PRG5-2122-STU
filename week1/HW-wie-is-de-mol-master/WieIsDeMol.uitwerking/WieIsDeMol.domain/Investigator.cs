using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WieIsDeMol.domain
{
    public class Investigator
    {
        private List<Suspect> _suspects;
        private Suspect offender;

        public List<Suspect> Suspects
        {
            get { return _suspects;  }
            set
            {
                //suspects can only be updated of the value still contains the offender
                if (value.Contains(offender))
                {
                    _suspects = value;
                }
            }
        }


        public Investigator(IEnumerable<Suspect> suspects)
        {
            this._suspects = new List<Suspect>(suspects);
        }

        public void RandomOffender()
        {
            Random r = new Random();
            int random = r.Next(0, this._suspects.Count);
            this.offender = this._suspects[random];
        }

        public bool Accuse(string name)
        {
            if (name.ToUpper() == offender.Name.ToUpper())
            {
                this.Suspects = new List<Suspect> { offender };
                return true;
            }

            return false;
        }

        #region FilterMethods

        public bool FilterByGlasses()
        {
            this.Suspects = this.Suspects.Where(s => s.HasGlasses == offender.HasGlasses).ToList();
            return offender.HasGlasses;
        }

        public bool FilterByHairCollor(string hairColor)
        {
            if(offender.HairColor.ToUpper() == hairColor.ToUpper())
            {
                this.Suspects = this.Suspects.Where(s => s.HairColor.ToUpper() == hairColor.ToUpper()).ToList();
                return true;
            }
            else
            {
                this.Suspects = this.Suspects.Where(s => s.HairColor.ToUpper() != hairColor.ToUpper()).ToList();
                return false;
            }

        }

        public bool FilterByAge(int age)
        {
            if (offender.Age > age)
            {
                this.Suspects = this.Suspects.Where(s => s.Age > age).ToList();
                return true;
            }
            else
            {
                this.Suspects = this.Suspects.Where(s => s.Age <= age).ToList();
                return false;
            }
        }

        public bool FilterByBalance(double balance)
        {
            if(offender.Balance > balance)
            {
                this.Suspects = this.Suspects.Where(s => s.Balance > balance).ToList();
                return true;
            }
            else
            {
                this.Suspects = this.Suspects.Where(s => s.Balance <= balance).ToList();
                return false;
            }
        }

        public bool FilterByGender(Gender gender)
        {
            if(offender.Gender == gender)
            {
                this.Suspects = this.Suspects.Where(s => s.Gender == offender.Gender).ToList();
                return true;
            }
            else
            {
                this.Suspects = this.Suspects.Where(s => s.Gender != gender).ToList();
                return false;
            }
           
        }


        public bool FilterByHobby(string hobby)
        {
            if (offender.Hobbies.Contains(hobby))
            {
                this.Suspects = this.Suspects.Where(s => s.Hobbies.Contains(hobby)).ToList();
                return true;
            }
            else
            {
                this.Suspects = this.Suspects.Where(s => !s.Hobbies.Contains(hobby)).ToList();
                return false;
            }
        }

        #endregion
    }
}
