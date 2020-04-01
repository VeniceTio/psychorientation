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
    public partial class InterfaceClasse : Form
    {
        private List<String> libele_mois = new List<String>()
        {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
        private List<String> libele_niveau = new List<String>()
        {"Seconde", "Première", "Terminale"};
        private int mois_actuel = 8;
        private int annee_actuelle = 0;

        public InterfaceClasse()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_date.Text = libele_mois[(mois_actuel % 12)] + " " + libele_niveau[annee_actuelle];

            TypeMessage tm = TypeMessage.INFORMATION;
            Message m = new Message(-1,"Bonjour apprenti prof, vous allez apprendre à éduquer des joueurs !! ","Début",tm);
            m.ShowDialog();
        }

        private void Pb_action_suivante_Click(object sender, EventArgs e)
        {
            // Traite les actions à effectuer avant de passer au mois suivant.
            if (false)
            {
                // Lance l'interface appropriee.
                return;
            }

            // Passe au mois suivant.
            mois_actuel++;
            switch(mois_actuel)
            {
                case 17: // Fin de la 1ère année : Début Juin.
                    mois_actuel = 20;
                    annee_actuelle = 1;
                    break;
                case 29: // Fin de la 2nde année : Début Juin.
                    mois_actuel = 32;
                    annee_actuelle = 2;
                    break;
                case 42: // Fin de la 3ème année : Debut Juillet.
                    // Fin de la partie.
                    break;
            }

            lbl_date.Text = libele_mois[(mois_actuel % 12)] + " " + libele_niveau[annee_actuelle];
        }

        private void Pb_liste_eleves_Click(object sender, EventArgs e)
        {

        }
    }
}
