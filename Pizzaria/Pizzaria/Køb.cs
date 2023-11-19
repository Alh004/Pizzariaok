using System.Reflection.Metadata.Ecma335;

namespace Pizzaria;
    public class Køb
    {
        /*
         * Instans Felter
         */

        // Ingen attributter

        // MEN 2 associeringer
        private Pizza _pizza;
        private Kunde _kunde;

        /*
         * Properties
         */
        public Pizza Pizza
        {
            get { return _pizza; }
            set { _pizza = value; }
        }

        public Kunde Kunde
        {
            get { return _kunde; }
            set { _kunde = value; }
        }



        /*
         * Constructor
         */
        public Køb()
        {
            _pizza = null;
            _kunde = null;

        }

        public Køb (Pizza pizza, Kunde kunde)
        {
            _pizza = pizza;
            _kunde = kunde;
        }

        public override string ToString()
        {
            return $"{nameof(Pizza)}={Pizza}, {nameof(Kunde)}={Kunde}";
        }
    }


