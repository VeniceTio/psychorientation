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
        private static Random r = new Random();
        
        public Eleve(int id)
        {
            
            this.id = id;
            this.classe = 0;
            this.competence = Eleve.r.NextDouble()*10;
            this.effort = Eleve.r.NextDouble()*10;
            this.orientation = 0;
            this.appreciation=CalculerAppreciation(1);
        }

        public Eleve(int id,int classe, double competence, double effort, int orientation)
        {
            this.id = id;
            this.classe = classe;
            this.competence = competence;
            this.effort = effort;
            this.orientation = orientation;
            this.appreciation = CalculerAppreciation(1);
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
        public List<Note> GetListeNotes()
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
            if (this.listeNotes.Count == 0) {return 0;}
            double res = 0;
            if (this.listeNotes.Count > 0)
            {
               foreach(Note n in listeNotes)
                {
                    res += n.GetNote();
                }
            }
            return res / this.listeNotes.Count;
        }



        public void Progression(double typeEducation)
        {
            if (competence != typeEducation)
                this.effort += Math.Min(Math.Max(((1 / Math.Abs(competence - typeEducation)) - (1.0 / 3)) * 3, -1), 1);
            else
                this.effort += 1;
            if (effort < 0) { effort = 0; }
            else if (effort > 10) { effort = 10; }

            this.competence += (((effort * 0.1) - 0.5) * (1.2 - (competence * 0.1))) * (1.0 / 4);

            if (competence < 0) { competence = 0; }
            else if (competence > 10) { competence = 10; }
        }


        public void AjouterNote(string nom, double coeff)
        {
            double note = CalculerNote(coeff);
            
            double note_convenable = 10 + (competence - 5);//((competence + effort) / 2 - 5);
            if (effort > 5)
            {
                if (note >= note_convenable)
                {
                    effort += 0.25 * (1 - (competence * 0.1));
                }
                else
                {
                    effort -= 0.5;
                }
            }
            else
            {
                if (note >= note_convenable)
                {
                    effort -= 0.5;
                }
                else
                {
                    effort -= 0.25;
                }
            }
            
            if (effort < 0) { effort = 0; }
            else if (effort > 10) { effort = 10; }

            Note n = new Note(nom, note, this.competence, this.effort);
            this.listeNotes.Add(n);
        }

        private double CalculerNote(double coeff)
        {
            return (this.effort * (2 - coeff) + this.competence * coeff);
        }

        private double CalculerAppreciation(double coeff)
        {
            return (this.effort * (2 - coeff) + this.competence * coeff);
        }
    }
}
