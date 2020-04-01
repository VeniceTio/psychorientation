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
            List<Note> listNote = this.eleve.GetlisteNotes();
            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.ColumnCount = 4;
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tlp.RowCount = 1 + listNote.Count;
            for(int i=0; i<tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            }
            pnlNote.Controls.Add(tlp);

            /*this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 50);
            this.tableLayoutPanel1.TabIndex = 0;*/
        }


    }
}
