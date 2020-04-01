using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    class Libele
    {
        private List<string> libele_mois = new List<string>()
        {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
        private List<string> libele_niveau = new List<string>()
        {"Seconde", "Première", "Terminale"};
        private static Libele instance;

        public Libele() {}

        public static Libele GetInstance()
        {
            if(Libele.instance == null)
            {
                Libele.instance = new Libele();
                return Libele.instance;
            }
            else
            {
                return Libele.instance;
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
