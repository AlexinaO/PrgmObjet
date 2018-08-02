using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrgmObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            var personne1 = new Personne("Franck");
            var personne2 = new Personne("Franck","Dupont");
            var personne3 = new Personne("Franck","Dupont", "Toto");

            var date = new DateTime();
        }
    }
    class Personne
    {
        public Personne(string nom)
        {

        }
        public Personne(string nom, string prenom)
        {

        }
        public Personne (string nom, string prenom, string surnom)
        {

        }
    }

}
