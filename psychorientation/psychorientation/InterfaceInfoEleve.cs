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
        List<string> listClasse;
        public InterfaceInfoEleve()
        {
            InitializeComponent();
        }

        private void InterfaceInfoEleve_Load(object sender, EventArgs e)
        {

        }

        public void setParam(Eleve el, List<string> listClasse)
        {
            this.eleve = el;
            this.listClasse = listClasse;
            actualiser();
        }

        private void actualiser()
        {
            lblEleve.Text = "Eleve n°"+eleve.getId();
            lblClasse.Text = listClasse[eleve.getClasse()];
            lblEffort.Text = eleve.getEffort().ToString();
            lblCompetence.Text = eleve.getCompetence().ToString();
            double moyenne = eleve.getMoyenne();
            if (moyenne == -1)
            {
                lblMoyenne.Text="Pas encore d'évaluation";
            }
            else
            {
                lblMoyenne.Text = eleve.getMoyenne().ToString()+"/20";
            }
            
            MajPanel(pnlCompetence,eleve.getCompetence());
            MajPanel(pnlEffort, eleve.getEffort());
        }
        private void MajPanel(Panel p, double valeur)
        {
            int val = (int)valeur;
            p.Size = new Size(val * 133 / 10, p.Height);
        }
    }
}
