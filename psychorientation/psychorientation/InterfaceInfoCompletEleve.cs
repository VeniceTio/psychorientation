using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychorientation
{
    public partial class InterfaceInfoCompletEleve : Form
    {
        Eleve eleve;
        public InterfaceInfoCompletEleve()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void InterfaceInfoCompletEleve_Load(object sender, EventArgs e)
        {

        }

        private void InterfaceInfoCompletEleve_Load(object sender, EventArgs e, Eleve el)
        {
            this.eleve = el;
            actualiser();
        }

        private void actualiser()
        {
            Libelle lib = new Libelle();
            lblNomEleve.Text = "Eleve n°" + eleve.GetId();
            lblNiveau.Text = lib.Niveau(eleve.GetClasse());
            double moyenne = eleve.GetMoyenne();
            if (moyenne == -1)
            {
                lblMoyenneNote.Text = "Pas encore d'évaluation";
            }
            else
            {
                lblMoyenneNote.Text = eleve.GetMoyenne().ToString() + "/20";
            }

            MajPanel(pnlCompetence, eleve.GetCompetence());
            MajPanel(pnlEffort, eleve.GetEffort());
        }
        private void MajPanel(Panel p, double valeur)
        {
            int val = (int)valeur;
            p.Size = new Size(val * 133 / 10, p.Height);
        }
    }
}
