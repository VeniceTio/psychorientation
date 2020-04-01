using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    public class GestionnaireEleve
    {
        private List<Eleve> listeEleves = new List<Eleve>();

        public GestionnaireEleve() {}

        public void AjouterEleve(Eleve e)
        {
            this.listeEleves.Add(e);
        }

        public void SupprimerEleve(Eleve e)
        {
            this.listeEleves.Remove(e);
        }

        public void SupprimerEleve(int indice)
        {
            this.listeEleves.RemoveAt(indice);
        }

        public List<Eleve> GetlisteEleves()
        {
            return this.listeEleves;
        }

        public Eleve GetEleve(int indice)
        {
            return this.listeEleves[indice];
        }

        public double GetMoyenneClasse()
        {
            double res = -1;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetMoyenne();
                }
            }
            return res / this.listeEleves.Count;
        }

        public double GetCompetenceClasse()
        {
            double res = -1;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetCompetence();
                }
            }
            return res / this.listeEleves.Count;
        }

        public double GetEffortClasse()
        {
            double res = -1;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetEffort();
                }
            }
            return res / this.listeEleves.Count;
        }

        public void FaireControle(string nom)
        {
            foreach (Eleve e in this.listeEleves)
            {
                e.AjouterNote(nom);
            }
        }

        public double GetAppreciationClasse()
        {
            double res = -1;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetAppreciation();
                }
            }
            return res / this.listeEleves.Count;
        }

    }
}
