using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoPolymorfi.model
{
    public class Skade:Animal
    {
        // instance fields
        protected string _preferedNest;

        // Properties
        public string PreferedNest
        {
            get { return _preferedNest; }
            set { _preferedNest = value; }
        }

        // konstruktør
        public Skade(string gender, string nest) : base(AnimalKindType.Fugl, gender)
        {
            _preferedNest = nest;

        }

        public Skade() : this( "none", "hvid,sort,blå")
        {
        }


        public override string Drikker()
        {
            return "jeg drikker vand";
        }
        // ToString
        public override string ToString()
        {
            return base.ToString() + $" Nest={_preferedNest}";
        }
    }
}
