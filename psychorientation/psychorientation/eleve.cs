using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    class eleve
    {
        private string classe = "";
        private double competence = 0;
        private double effort = 0;
        private string orientation = "";


        public eleve()
        {
            this.classe = "seconde";
            this.competence = 10;
            this.effort = 10;
            this.orientation = "Inconnu";
        }

        public eleve(string classe, double competence, double effort, string orientation)
        {
            this.classe = classe;
            this.competence = competence;
            this.effort = effort;
            this.orientation = orientation;
        }

        public void setClasse(string classe)
        {
            this.classe = classe;
        }

        public void setOrientation(string orientation)
        {
            this.orientation = orientation;
        }

        public void setEffort(double effort)
        {
            this.effort = effort;
        }

        public void setCompetence(double competence)
        {
            this.competence = competence;
        }


        public double getCompetence()
        {
            return this.competence;
        }
        public string getClasse()
        {
            return this.classe;
        }
        public string getOrientation()
        {
            return this.orientation;
        }
        public double getEffort()
        {
            return this.effort;
        }
    }
}
