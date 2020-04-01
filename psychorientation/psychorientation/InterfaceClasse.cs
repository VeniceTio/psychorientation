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
        private Libelle libelle = Libelle.GetInstance();
        private int moisActuel = 8;
        private int anneeActuelle = 0;

        public InterfaceClasse()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_date.Text = libelle.Mois(moisActuel % 12) + " " + libelle.Niveau(anneeActuelle);

            Message m_accueil = new Message(-1, "Bonjour apprenti prof, vous allez apprendre à éduquer des joueurs !! ", "Début", TypeMessage.INFORMATION);
            m_accueil.ShowDialog();

            

            ListeEleve listE = new ListeEleve();
            listE.ShowDialog();
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
            moisActuel++;
            switch(moisActuel)
            {
                case 17: // Fin de la 1ère année : Début Juin.
                    moisActuel = 20;
                    anneeActuelle = 1;
                    break;
                case 29: // Fin de la 2nde année : Début Juin.
                    moisActuel = 32;
                    anneeActuelle = 2;
                    break;
                case 42: // Fin de la 3ème année : Debut Juillet.
                    // Fin de la partie.
                    Message m_fin = new Message(-1, "Vous avez fini la phase bêta de ce jeu !\n" + 
                                                "Bravo à vous et n'hésitez pas à essayer à nouveau pour " + 
                                                "améliorer votre compréhension du monde extérieur.", 
                                                "Félicitations", 
                                                TypeMessage.INFORMATION
                    );
                    m_fin.ShowDialog();
                    Close();
                    break;
            }

            lbl_date.Text = libelle.Mois(moisActuel % 12) + " " + libelle.Niveau(anneeActuelle);
        }

        private void Pb_liste_eleves_Click(object sender, EventArgs e)
        {
            ListeEleve le = new ListeEleve();
            le.Show();
        }

        private void InterfaceClasse_SizeChanged(object sender, EventArgs e)
        {
            PictureBox pb1 = pb_action_suivante;
            pb1.Location = new Point(Size.Width - pb1.Width - 32, Size.Height - pb1.Height - 32);

            PictureBox pb2 = pb_sortir;
            pb2.Location = new Point(Size.Width - pb2.Width, 0);
        }

        private void Pb_sortir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhaitez-vous quitter le jeu ?\nVous perdrez alors votre progression dans la partie en cours.",
                                "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
