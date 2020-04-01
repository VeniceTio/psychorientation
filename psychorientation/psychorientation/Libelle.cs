using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    class Libelle
    {
        private List<string> libele_mois = new List<string>()
        {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
        private List<string> libele_niveau = new List<string>()
        {"Seconde", "Première", "Terminale"};
        private static Libelle instance;

        public Libelle() {}

        public static Libelle GetInstance()
        {
            if(Libelle.instance == null)
            {
                Libelle.instance = new Libelle();
                return Libelle.instance;
            }
            else
            {
                return Libelle.instance;
            }
        }

        public string Mois(int n)
        {
            return this.libele_mois[n];
        }

        public string Niveau(int n)
        {
            return this.libele_niveau[n];
        }
    }
}
