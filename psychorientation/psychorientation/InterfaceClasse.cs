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

        double effortInitial = 0.0;
        double competenceInitial = 0.0;
        double moyenneInitiale = 0.0;


        private Random r = new Random();
        private Libelle libelle = Libelle.GetInstance();
        private int moisActuel = 8;
        private int anneeActuelle = 0;
        private GestionnaireEleve gestEleve = new GestionnaireEleve();

        private int[] positionElevex = { 322, 571, 698, 951, 322, 571, 698, 951 };
        private int[] positionElevey = { 398, 398, 398, 398, 505, 505, 505, 505 };
        private Image[] imageEleve;

        private string notaText = "Coefficients de prise en compte de l'effort et de la compétence pour noter :";
        private string coursText = "Type de cours visant à aider les élèves de compétence : ";

        private double valCours = 5.0;
        private double valNotation = 10.0;
        private Label lblValEffort = new Label();
        private Label lblValCompetence = new Label();

        private bool isRandom=true;

        public InterfaceClasse(bool isRandom)
        {
            InitializeComponent();
            this.isRandom = isRandom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            AjouterEleveImage();
            GenererBase();
            TransmitKeyDown();

            /*
            Message mAccueil = new Message("Bonjour apprenti prof, vous allez apprendre à éduquer des joueurs !! ", "Début", TypeMessage.INFORMATION);
            mAccueil.ShowDialog();
            */
        }

        private void GenererBase()
        {
            lblDate.Text = libelle.Mois(moisActuel % 12);
            lblClasse.Text = libelle.Niveau(anneeActuelle);
            effortInitial = Math.Round(gestEleve.GetEffortClasse(), 1);
            competenceInitial = Math.Round(gestEleve.GetCompetenceClasse(), 1);
            moyenneInitiale = Math.Round(gestEleve.GetMoyenneClasse(), 1);
            lblEffort.Text = "Effort de la classe : " + effortInitial.ToString();
            lblCompetence.Text = "Competence de la classe : " + competenceInitial.ToString();
            lblMoyenne.Text = "Moyenne de la classe : " + moyenneInitiale.ToString();

            Libelle lib = new Libelle();
            int y = 40;
            foreach (Eleve eleve in gestEleve.GetListeEleves())
            {
                InterfaceInfoEleve ii = new InterfaceInfoEleve();
                ii.setParam(eleve);
                ii.Tag = eleve;
                ii.Location = new Point(6, y);
                ii.Click += new System.EventHandler(PbOuvrirInfo);
                pnlListeEleve.Controls.Add(ii);
                y += 220;
            }

            TrackBar tbNota = new TrackBar();
            tbNota.Location = new System.Drawing.Point(0, lblNotation.Location.Y + lblNotation.Size.Height);
            tbNota.Size = new System.Drawing.Size(184, 45);
            tbNota.Maximum = 20;
            tbNota.BackColor = System.Drawing.Color.Tan; 
            tbNota.Value = 10;
            tbNota.SmallChange = 1;
            tbNota.LargeChange = 1;
            tbNota.TickStyle = TickStyle.TopLeft;
            tbNota.Scroll += new System.EventHandler(tbNota_Scroll);
            pnlChoix.Controls.Add(tbNota);
            lblNotation.Text = notaText;

            lblValEffort.Tag = "Effort : ";
            lblValCompetence.Tag = "Compétence : ";
            lblValEffort.Location = new Point(130, 5 + tbNota.Location.Y + tbNota.Size.Height);
            lblValCompetence.Location = new Point(1, 5 + tbNota.Location.Y + tbNota.Size.Height);
            lblValEffort.Text = lblValEffort.Tag + ((20 - tbNota.Value) / 10.0).ToString();
            lblValCompetence.Text = lblValCompetence.Tag + (tbNota.Value / 10.0).ToString();
            lblValCompetence.BackColor= System.Drawing.Color.Transparent;
            lblValEffort.BackColor= System.Drawing.Color.Transparent;
            pnlChoix.Controls.Add(lblValEffort);
            pnlChoix.Controls.Add(lblValCompetence);

            TrackBar tbCours = new TrackBar();
            tbCours.BackColor= System.Drawing.Color.Tan;
            tbCours.Location = new System.Drawing.Point(0, 10 + lblCours.Location.Y + lblCours.Size.Height);
            tbCours.Size = new System.Drawing.Size(184, 45);
            tbCours.Value = 5;
            tbCours.SmallChange = 1;
            tbCours.LargeChange = 1;
            tbCours.Scroll += new System.EventHandler(tbCours_Scroll);
            pnlChoix.Controls.Add(tbCours);
            lblCours.Text = coursText + tbCours.Value.ToString();
        }

        private void AjouterPictureboxEleve()
        {
            imageEleve = new Image[gestEleve.GetListeEleves().Count];
            for (int i = 0; i < gestEleve.GetListeEleves().Count; i++)
            {
                PictureBox pbEleve = new PictureBox();

                pbEleve.Location = new System.Drawing.Point(572, 396);
                pbEleve.Size = new System.Drawing.Size(73, 85);
                pbEleve.Image = imgListPerso.Images[r.Next(0, 4)];
                pbEleve.Left = positionElevex[i];
                pbEleve.Tag = gestEleve.GetEleve(i);
                pbEleve.BackColor = System.Drawing.Color.Transparent;
                pbEleve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbEleve.Top = positionElevey[i];
                pbEleve.Click += new System.EventHandler(PbOuvrirInfo);
                imageEleve[i] = pbEleve.Image;
                this.Controls.Add(pbEleve);
            }
        }

        private void AjouterEleveImage()
        {
            if (isRandom)
            {
                for (int i = 1; i < r.Next(6,9); i++)
                {
                    gestEleve.AjouterEleve(new Eleve(i));
                }
            }
            else
            {
                gestEleve.AjouterEleve(new Eleve(1,0,1.0,9.0,0));
                gestEleve.AjouterEleve(new Eleve(2,0,5.0,5.0,0));
                gestEleve.AjouterEleve(new Eleve(3,0,9.0,1.0,0));
            }
            AjouterPictureboxEleve();
            
            gestEleve.FaireControle("Controle " + lblClasse.Text + " " + lblDate.Text, valNotation / 10.0);
        }

        private void PbOuvrirInfo(object sender, EventArgs e)
        {
            Eleve tag;
            if (sender is PictureBox)
            {
                tag = (Eleve)(sender as PictureBox).Tag;
            }
            else
            {
                tag = (Eleve)(sender as InterfaceInfoEleve).Tag;
            }
            int id = tag.GetId();
            InterfaceInfoCompletEleve iice = new InterfaceInfoCompletEleve();
            iice.setParam(tag,imageEleve[id-1]);
            iice.Show();
        }

        private void ActionSuivante()
        {
            // Traite les actions à effectuer avant de passer au mois suivant.

            foreach (Eleve el in gestEleve.GetListeEleves())
            {
                el.Progression(valCours);
            }
            gestEleve.FaireControle("Controle " + lblClasse.Text + " " + lblDate.Text, valNotation / 10.0);

            lblEffort.Text = "Effort de la classe : " + Math.Round(gestEleve.GetEffortClasse(), 2).ToString();
            lblCompetence.Text = "Competence de la classe : " + Math.Round(gestEleve.GetCompetenceClasse(), 2).ToString();
            lblMoyenne.Text = "Moyenne de la classe : " + Math.Round(gestEleve.GetMoyenneClasse(), 2).ToString();
            ActualiserEleveCoter();

            // Passe au mois suivant.
            moisActuel++;
            switch (moisActuel)
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
                    double moyenneFinale = gestEleve.GetMoyenneClasse();
                    double effortFinal = gestEleve.GetEffortClasse();
                    double competenceFinal = gestEleve.GetCompetenceClasse();

                    Message m_fin = new Message(
                        "Vous avez fini la phase bêta de ce jeu !\n" +
                        "Bravo à vous et n'hésitez pas à essayer à nouveau pour " +
                        "améliorer votre compréhension du monde extérieur.\n",
                        "Félicitations",
                        TypeMessage.RESULTAT
                    );
                    m_fin.setParamRes(
                        effortInitial,
                        competenceInitial,
                        moyenneInitiale,
                        effortFinal,
                        competenceFinal,
                        moyenneFinale,
                        isRandom
                    );
                    m_fin.ShowDialog();
                    UntransmitKeyDown();
                    pb_action_suivante.Click -= new System.EventHandler(Pb_action_suivante_Click);
                    this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(InterfaceClasse_FormClosing);
                    Close();
                    break;
            }

            // Cours.
            // Notation.
            // Cours particuliers.

            lblDate.Text = libelle.Mois(moisActuel % 12);
            lblClasse.Text = libelle.Niveau(anneeActuelle);
        }

        private void Pb_action_suivante_Click(object sender, EventArgs e)
        {
            ActionSuivante();
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
        }

        private void tbNota_Scroll(object sender, EventArgs e)
        {
            TrackBar tbNota = (TrackBar)sender;
            valNotation = (double)tbNota.Value;

            lblValEffort.Text = lblValEffort.Tag + ( (20 - valNotation) / 10.0).ToString();
            lblValCompetence.Text = lblValCompetence.Tag + (valNotation / 10.0).ToString();
        }

        private void tbCours_Scroll(object sender, EventArgs e)
        {
            TrackBar tbCours = (TrackBar)sender;
            valCours = (double)tbCours.Value;
            lblCours.Text = coursText + valCours.ToString();
        }

        private void InterfaceClasse_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("Souhaitez-vous quitter le jeu ?\nVous perdrez alors votre progression dans la partie en cours.",
                                "Confirmation de fermeture", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Warning, 
                                MessageBoxDefaultButton.Button2
                                )
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TransmitKeyDown()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control c2 in (c as Panel).Controls)
                    {
                        c2.KeyDown += new System.Windows.Forms.KeyEventHandler(InterfaceClasse_KeyDown);
                    }
                }
                c.KeyDown += new System.Windows.Forms.KeyEventHandler(InterfaceClasse_KeyDown);
            }
        }

        private void UntransmitKeyDown()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control c2 in (c as Panel).Controls)
                    {
                        c2.KeyDown -= new System.Windows.Forms.KeyEventHandler(InterfaceClasse_KeyDown);
                    }
                }
                c.KeyDown -= new System.Windows.Forms.KeyEventHandler(InterfaceClasse_KeyDown);
            }
        }

        private void InterfaceClasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ActionSuivante();
            }
        }
    }
}
