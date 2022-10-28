using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoPolymorfi.model
{
    public class Guppy:Animal
    {
        // instance fields
        protected string _colour;

        // Properties
        public string Coluor
        {
            get { return _colour; }
            set { _colour = value; }
        }
 
        // konstruktør
        public Guppy( string gender, string colour) : base(AnimalKindType.Fisk, gender)
        {
            _colour = colour;

        }

        public Guppy() : this( "none", "rød")
        {
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + $" Colour={_colour}";
        }

        public override string Drikker()
        {
            return "måske drikker jeg vand";
        }
    }
}
