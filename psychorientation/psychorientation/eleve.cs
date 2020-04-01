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
        public int getId()
        {
            return this.id;
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
