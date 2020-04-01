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

    }
}
