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

        public bool? FilterByHairColor(string haircolor)
        {
            if(offender.HairColor.ToLower() == haircolor.ToLower())
            {
                var over = new List<Suspect>();
                for (int i = 0; i < Suspects.Count; i++)
                {
                    if (Suspects[i].HairColor.ToLower() == haircolor.ToLower())
                    {
                        over.Add(Suspects[i]);
                    }
                }
                Suspects = over;
                return true;
            }
            else
            {
                var over = new List<Suspect>();
                for (int i = 0; i < Suspects.Count; i++)
                {
                    if (Suspects[i].HairColor.ToLower() != haircolor.ToLower())
                    {
                        over.Add(Suspects[i]);
                    }
                }
                Suspects = over;
                return false;
            }
        }

        //TODO: Add more filter methods

        #endregion
    }
}
