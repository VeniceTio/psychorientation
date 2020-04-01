using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    public class Note
    {
        private string nom;
        private double note;
        private double competence;
        private double effort;

        public Note(string nom, double note, double competence, double effort)
        {
            this.nom = nom;
            this.note = note;
            this.competence = competence;
            this.effort = effort;
        }

        public string getNom()
        {
            return this.nom;
        }

        public double getNote()
        {
            return this.note;
        }

        public double getCompetence()
        {
            return this.competence;
        }

        public double getEffort()
        {
            return this.effort;
        }
    }
}
