using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassDemoPolymorfi.model
{
    public class Kat:Animal
    {
        // instance fields
        protected string _name;
        protected int _age;

        // Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // konstruktør
        public Kat(string gender, string name, int age):base(AnimalKindType.Pattedyr, gender)
        {
            _name = name;
            _age = age;
        }

        public Kat():this( "none", "kat", -1)
        {
        }


        public override string Spiser()
        {
            return "jeg spiser mus";
        }

        public override string Drikker()
        {
            return "jeg drikker fløde";
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + $" Name={_name} Age={_age}";
        }



    }
}
