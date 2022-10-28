using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoPolymorfi.model
{
    public enum AnimalKindType  {Fugl, Pattedyr, Fisk, Krypdyr};
    public abstract class Animal
    {
        // instance fields
        protected AnimalKindType _kindOfAnimal;
        protected string _gender;

        //properties
        public AnimalKindType KindOfAnimal
        {
            get { return _kindOfAnimal; }
            set { _kindOfAnimal = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        // konstruktør
        public Animal(AnimalKindType kind, string gender)
        {
            _kindOfAnimal = kind;
            _gender = gender;
        }

        public Animal():this(AnimalKindType.Pattedyr, "none")
        {
        }

        /*
         * Metoder
         */

        public virtual string Spiser() // brug virtual hvis den senere skal kunne overskrives (polymorfi)
        {
            return "det ved jeg ikke";
        }

        public abstract string Drikker(); // OBS ingen krop/kode

        // ToString
        public override string ToString()
        {
            return $"Kind={_kindOfAnimal} Gender={_gender}";
        }

    }
}
