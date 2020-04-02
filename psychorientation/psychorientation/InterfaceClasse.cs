﻿using System;
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
        private Random r = new Random();
        private Libelle libelle = Libelle.GetInstance();
        private int moisActuel = 8;
        private int anneeActuelle = 0;
        private GestionnaireEleve gestEleve = new GestionnaireEleve();

        private int[] positionElevex = { 322, 571, 698, 951, 322, 571, 698, 951 };
        private int[] positionElevey = { 398, 398, 398, 398, 505, 505, 505, 505 };
        
        public InterfaceClasse()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjouterEleveImage();
            lblDate.Text = libelle.Mois(moisActuel % 12);
            lblClasse.Text=libelle.Niveau(anneeActuelle);
            lblEffort.Text = "Effort de la classe : " + Math.Round(gestEleve.GetEffortClasse(),1).ToString();
            lblCompetence.Text = "Competence de la classe : " + Math.Round(gestEleve.GetCompetenceClasse(),1).ToString();
            lblMoyenne.Text = "Moyenne de la classe : " + Math.Round(gestEleve.GetMoyenneClasse(),1).ToString();

            Libelle lib = new Libelle();
            int y = 20;
            foreach (Eleve eleve in gestEleve.GetListeEleves())
            {
                InterfaceInfoEleve ii = new InterfaceInfoEleve();
                ii.setParam(eleve);
                ii.Location = new Point(0, y);
                pnlListeEleve.Controls.Add(ii);
                y += 220;
            }


            Message mAccueil = new Message("Bonjour apprenti prof, vous allez apprendre à éduquer des joueurs !! ", "Début", TypeMessage.INFORMATION);
            mAccueil.ShowDialog();
        }

        private void AjouterEleveImage()
        {
            for (int i = 1; i < 4; i++)
            {
                gestEleve.AjouterEleve(new Eleve(i));
            }

            int nb = gestEleve.GetListeEleves().Count;

            if (nb > 8)
            {
                nb = 8;
            }
            for (int i = 0; i < nb; i++)
            {
                PictureBox pbEleve = new PictureBox();

                pbEleve.Location = new System.Drawing.Point(572, 396);
                pbEleve.Size = new System.Drawing.Size(73, 85);
                pbEleve.Image = imgListPerso.Images[r.Next(0,4)];
                pbEleve.Left = positionElevex[i];
                pbEleve.Tag = gestEleve.GetEleve(i);
                pbEleve.BackColor = System.Drawing.Color.Transparent;
                pbEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbEleve.Top = positionElevey[i];
                pbEleve.Click += new System.EventHandler(PbOuvrirInfo);

                this.Controls.Add(pbEleve);
            }

            foreach (Eleve el in gestEleve.GetListeEleves())
            {
                el.AjouterNote("Controle " + lblClasse.Text + " " + lblDate.Text);
            }
        }

        private void PbOuvrirInfo(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Eleve tag = (Eleve)pb.Tag;
            InterfaceInfoCompletEleve iice = new InterfaceInfoCompletEleve();
            iice.setParam(tag);
            iice.ShowDialog();
        }

        private void Pb_action_suivante_Click(object sender, EventArgs e)
        {
            // Traite les actions à effectuer avant de passer au mois suivant.

            if (false)
            {
                // Lance l'interface appropriee.
                return;
            }

            Message mControle = new Message("C'est la fin du mois, comme chaque mois, les eleves vont passer un contrôle, à vous de choisir le niveau de compétence de votre enseignement.", "Début", TypeMessage.NOTATION);
            mControle.ShowDialog();


            foreach(Eleve el in gestEleve.GetListeEleves())
            {
                el.Progression(mControle.getReponseDouble);
                el.AjouterNote("Controle " + lblClasse.Text + " " + lblDate.Text);
            }

            lblEffort.Text = "Effort de la classe : " + Math.Round(gestEleve.GetEffortClasse(), 1).ToString();
            lblCompetence.Text = "Competence de la classe : " + Math.Round(gestEleve.GetCompetenceClasse(), 1).ToString();
            lblMoyenne.Text = "Moyenne de la classe : " + Math.Round(gestEleve.GetMoyenneClasse(), 1).ToString();
            ActualiserEleveCoter();

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
                    Message m_fin = new Message( 
                        "Vous avez fini la phase bêta de ce jeu !\n" + 
                        "Bravo à vous et n'hésitez pas à essayer à nouveau pour " + 
                        "améliorer votre compréhension du monde extérieur.", 
                        "Félicitations", 
                        TypeMessage.INFORMATION
                    );
                    m_fin.ShowDialog();
                    Close();
                    break;
            }

            // Cours.
            // Notation.
            // Cours particuliers.

            lblDate.Text = libelle.Mois(moisActuel % 12);
            lblClasse.Text= libelle.Niveau(anneeActuelle);
        }

        private void Pb_liste_eleves_Click(object sender, EventArgs e)
        {
            ListeEleve le = new ListeEleve(gestEleve);
            le.Show();
        }

        private void ActualiserEleveCoter()
        {
            foreach(Control c in pnlListeEleve.Controls)
            {
                if (c is InterfaceInfoEleve)
                {
                    InterfaceInfoEleve iie = (InterfaceInfoEleve)c;
                    iie.actualiser();
                }
                
            }
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
