using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychorientation
{
    class eleve
    {
        private int classe = 0;
        private double competence = 0;
        private double effort = 0;
        private int orientation = 0;


        public eleve()
        {
            this.classe = 0;
            this.competence = 10;
            this.effort = 10;
            this.orientation = 0;
        }

        public eleve(int classe, double competence, double effort, int orientation)
        {
            this.classe = classe;
            this.competence = competence;
            this.effort = effort;
            this.orientation = orientation;
        }

        public void setClasse(int classe)
        {
            this.classe = classe;
        }

        public void setOrientation(int orientation)
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
        public int getClasse()
        {
            return this.classe;
        }
        public int getOrientation()
        {
            return this.orientation;
        }
        public double getEffort()
        {
            return this.effort;
        }
    }
}
