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


        public void setParam(Eleve el)
        {
            this.eleve = el;
            actualiser();
        }

        private void actualiser()
        {
            Libelle lib = new Libelle();
            string nom = "Eleve n°" + eleve.GetId();
            this.Text = nom;
            lblNomEleve.Text = nom;
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

            InitNote();
        }
        private void MajPanel(Panel p, double valeur)
        {
            int val = (int)valeur;
            p.Size = new Size(val * 133 / 10, p.Height);
        }

        private void InitNote()
        {
            int largeurLigne = 25;
            List<Note> listNote = this.eleve.GetlisteNotes();
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.ColumnCount = 4;
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.RowCount = 1 + listNote.Count;

            // Initialise la première ligne d'en-tête
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tlp.Controls.Add(CreerLabel("Nom :"), 0, 0);
            tlp.Controls.Add(CreerLabel("Note :"), 1, 0);
            tlp.Controls.Add(CreerLabel("Compétence :"), 2, 0);
            tlp.Controls.Add(CreerLabel("Effort :"), 3, 0);

            // Rajoute les lignes supplémentaires
            for (int i=1; i<tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                Note note = listNote[i - 1];
                tlp.Controls.Add(CreerLabel(note.GetNom()), 0, i);
                tlp.Controls.Add(CreerLabel(note.GetNote().ToString()), 1, i);
                tlp.Controls.Add(CreerLabel(note.GetCompetence().ToString()), 2, i);
                tlp.Controls.Add(CreerLabel(note.GetEffort().ToString()), 3, i);
            }

            tlp.Size = new System.Drawing.Size(413, largeurLigne* tlp.RowCount);
            tlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            pnlNote.Controls.Add(tlp);
        }

        private Label CreerLabel(string contenu)
        {
            Label lbl = new Label();
            lbl.Text = contenu;
            return lbl;
        }


    }
}
