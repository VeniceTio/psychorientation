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

        public List<Eleve> GetListeEleves()
        {
            return this.listeEleves;
        }

        public Eleve GetEleve(int indice)
        {
            return this.listeEleves[indice];
        }

        public double GetMoyenneClasse()
        {
            double res = 0;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetMoyenne();
                }
                res /= this.listeEleves.Count;
            }
            return res;
        }

        public double GetCompetenceClasse()
        {
            double res = 0;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetCompetence();
                }
                res /= this.listeEleves.Count;
            }
            return res;
        }

        public double GetEffortClasse()
        {
            double res = 0;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetEffort();
                }
                res /= this.listeEleves.Count;
            }
            return res;
        }

        public void FaireControle(string nom, double coeff)
        {
            foreach (Eleve e in this.listeEleves)
            {
                e.AjouterNote(nom, coeff);
            }
        }

        public double GetAppreciationClasse()
        {
            double res = 0;
            if (this.listeEleves.Count > 0)
            {
                foreach (Eleve el in this.listeEleves)
                {
                    res += el.GetAppreciation();
                }
                res /= this.listeEleves.Count;
            }
            return res;
        }

    }
}
