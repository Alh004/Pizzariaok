using System.Security.Cryptography.X509Certificates;

namespace Pizzaria;

public class Kunde
{
    /*
     * Instans felter
     */
    private int _kundenummer;
    private string _navn;
    private string _tlf;
            
            /*
             * Propeties
             */

            public int kundenummer
            {
                get { return _kundenummer; }      
                set { _kundenummer = value; } 
            }
                public string Navn
            {
                get { return _navn; }
                set { _navn = value; }
            }

            public string Tlf
            {
                get { return _tlf; }
                set { _tlf = value; }
            }
            
            /*
             * Constructor
             */
            public Kunde()

            {
                _kundenummer = 0;
                _navn = "";
                _tlf = "";
            }



            public Kunde(int nr, string navn, string tlf)
            {
                _kundenummer = nr;
                _navn = navn;
                _tlf = tlf;
            }

            public override string ToString()
            {
                return $"{nameof(kundenummer)}={kundenummer},{nameof(Navn)}= {Navn}, {nameof(Tlf)}= {Tlf}";
                
            }
}
