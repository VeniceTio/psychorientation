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

        public void AjouterEleve(Eleve e)
        {
            this.listEleve.Add(e);
        }

        public void SupprimerEleve(Eleve e)
        {
            this.listEleve.Remove(e);
        }

        public void SupprimerEleve(int indice)
        {
            this.listEleve.RemoveAt(indice);
        }

        public List<Eleve> GetListEleve()
        {
            return this.listEleve;
        }

        public Eleve GetEleve(int indice)
        {
            return this.listEleve[indice];
        }

        public double GetMoyenneClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.GetMoyenne();
                }
            }
            return res / this.listEleve.Count;
        }

        public double GetCompetenceClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.GetCompetence();
                }
            }
            return res / this.listEleve.Count;
        }

        public double GetEffortClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.GetEffort();
                }
            }
            return res / this.listEleve.Count;
        }

        public void FaireControle(string nom)
        {
            foreach (Eleve e in this.listEleve)
            {
                e.AjouterNote(nom);
            }
        }

        public double GetAppreciationClasse()
        {
            double res = -1;
            if (this.listEleve.Count > 0)
            {
                foreach (Eleve el in this.listEleve)
                {
                    res += el.GetAppreciation();
                }
            }
            return res / this.listEleve.Count;
        }

    }
}
