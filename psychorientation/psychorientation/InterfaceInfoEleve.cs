using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychorientation
{
    public partial class InterfaceInfoEleve : UserControl
    {
        Eleve eleve;
        public InterfaceInfoEleve()
        {
            InitializeComponent();
        }

        public void setParam(Eleve el)
        {
            this.eleve = el;
            actualiser();
        }

        public void actualiser()
        {
            Libelle lib = new Libelle();
            lblEleve.Text = "Élève n°" + eleve.GetId();
            lblClasse.Text = lib.Niveau(eleve.GetClasse());
            lblEffort.Text = Math.Round(eleve.GetEffort(), 2).ToString() ;
            lblCompetence.Text = Math.Round(eleve.GetCompetence(), 2).ToString();

            lblMoyenne.Text = Math.Round(eleve.GetListeNotes().Last().GetNote(), 2).ToString()+"/20";
            
            MajPanel(pnlCompetence,eleve.GetCompetence());
            MajPanel(pnlEffort, eleve.GetEffort());
        }
        private void MajPanel(Panel p, double valeur)
        {
            int val = (int)valeur;
            p.Size = new Size(val * 84 / 10, p.Height);
        }

        private void InterfaceInfoEleve_Load(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is Panel)
                {
                    foreach(Control c2 in (c as Panel).Controls)
                    {
                        c2.Tag = eleve;
                    }
                }
                c.Tag = eleve;
            }
        }
    }
}
