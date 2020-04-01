using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    public class GestionnaireEleve
    {
        private List<Eleve> listEleve = new List<Eleve>();

        public GestionnaireEleve()
        {
        }

        public void ajouterEleve(Eleve e)
        {
            this.listEleve.Add(e);
        }

        public void supprimerEleve(Eleve e)
        {
            this.listEleve.Remove(e);
        }

        public void supprimerEleve(int indice)
        {
            this.listEleve.RemoveAt(indice);
        }

        public List<Eleve> getListEleve()
        {
            return this.listEleve;
        }

        public Eleve getEleve(int indice)
        {
            return this.listEleve[indice];
        }

        public double getMoyenneClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.getMoyenne();
                }
            }
            return res / this.listEleve.Count;
        }

        public double getCompetenceClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.getCompetence();
                }
            }
            return res / this.listEleve.Count;
        }

        public double getEffortClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.getEffort();
                }
            }
            return res / this.listEleve.Count;
        }

        public void faireControle(string nom)
        {
            foreach(Eleve e in this.listEleve)
            {
                e.ajouterNote(nom);
            }
        }

    }
}
