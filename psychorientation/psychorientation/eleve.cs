using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    public class Eleve
    {
        private int classe = 0;
        private double competence = 0;
        private double effort = 0;
        private int orientation = 0;
        private int id;
        private List<Note> listeNotes = new List<Note>();
        private double appreciation;

        public Eleve(int id)
        {
            this.id = id;
            this.classe = 0;
            this.competence = 10;
            this.effort = 10;
            this.orientation = 0;
        }

        public Eleve(int id,int classe, double competence, double effort, int orientation)
        {
            this.id = id;
            this.classe = classe;
            this.competence = competence;
            this.effort = effort;
            this.orientation = orientation;
            this.appreciation = CalculerAppreciation();
        }
        public void SetClasse(int classe)
        {
            this.classe = classe;
        }

        public void SetOrientation(int orientation)
        {
            this.orientation = orientation;
        }

        public void SetEffort(double effort)
        {
            this.effort = effort;
        }

        public void SetCompetence(double competence)
        {
            this.competence = competence;
        }



        public double GetCompetence()
        {
            return this.competence;
        }
        public List<Note> GetlisteNotes()
        {
            return this.listeNotes;
        }
        public int GetId()
        {
            return this.id;
        }
        public int GetClasse()
        {
            return this.classe;
        }
        public int GetOrientation()
        {
            return this.orientation;
        }
        public double GetEffort()
        {
            return this.effort;
        }

        public double GetAppreciation()
        {
            return this.appreciation;
        }

        public double GetMoyenne()
        {
            if (this.listeNotes.Count == 0) {return -1;}
            double res = 0;
            if (this.listeNotes.Count > 0)
            {
               foreach(Note n in listeNotes)
                {
                    res += n.getNote();
                }
            }
            return res / this.listeNotes.Count;
        }



        public void AjouterNote(string nom)
        {
            Note n = new Note(nom, CalculerNote(), this.competence, this.effort);
            this.listeNotes.Add(n);
        }

        private double CalculerNote()
        {
            return (this.effort * Config.GetInstance().GetCoeffEffortEcrit() + this.competence * Config.GetInstance().GetCoeffCompetenceEcrit());
        }

        private double CalculerAppreciation()
        {
            return (this.effort * Config.GetInstance().GetCoeffEffortOral() + this.competence * Config.GetInstance().GetCoeffCompetenceOral());
        }
    }
}
