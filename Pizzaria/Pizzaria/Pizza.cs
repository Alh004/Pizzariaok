namespace Pizzaria
{
    public class Pizza
    {
        /*
         * Instans Felter
         */
        private string _bund;
        private string _topping;
        private double _pris; // skal være nul eller over
        private string _størrelse;

        /*
         * Properties
         */
        public string Bund
        {
            get { return _bund; }
            set { _bund = value; }
        }

        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set {if ( !(value >= 0)) 
                    
                    throw new ArgumentException("Pris skal være nul eller positiv men var " + value);
            
                _pris = value; 
            }
        }
        public string Størrelse
        {
            get { return _størrelse; }
            set { _størrelse = value; }
        }
        /*
        * Constructor - kaldes kun een gang - når objektet laves
        */

        public Pizza() // default
        {
            _bund = "";
            _topping = "";
            _pris = 0;
            _størrelse = "";
        }

        public Pizza(string bund, string topping, double pris, string størrelse)
        {
            _bund = bund;
            _topping = topping;
            _pris = pris;
            _størrelse = størrelse;

            // Calculate tax (0.25% of _pris)
            double moms = _pris * 0.25;
            // Leveringsprisen
            double levering = 50;
            // Add tax and fee to the total price
            _pris += moms + levering;
        }

        public override string ToString()
        {
            // Formater prisen til kun 2 decimaler
            string formateredePris = Pris.ToString("0.0");
            return $"{nameof(Bund)} = {Bund}, {nameof(Topping)} = {Topping}, {nameof(Pris)} = {Pris.ToString()}, {nameof(Størrelse)} = {Størrelse}";
        }
    }
}