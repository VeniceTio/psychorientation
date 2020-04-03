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

    public enum TypeMessage
    {
        INFORMATION,NOTATION,RESULTAT
    }

    public partial class Message : Form
    {
        string message = "";
        string titre = "";
        TypeMessage typeMessage;

        bool reponseBool = false;
        string reponseString = "";
        int reponseInt = 0;
        double reponseDouble = 0;

        bool effortScoreRouge = false;
        bool moyenneScoreRouge = false;
        bool competenceScoreRouge = false;

        double effortScore;
        double moyenneScore;
        double competenceScore;


        public Message(string messageAffiche,string titreAffiche,TypeMessage typeMessage)
        {
            InitializeComponent();
            this.typeMessage = typeMessage;
            message = messageAffiche;
            titre = titreAffiche;
        }

        public void setParamRes(double resEffort, double resCompetence, double resMoyenne,bool effortRouge, bool competenceRouge, bool moyenneRouge)
        {
            effortScore = resEffort;
            moyenneScore = resMoyenne;
            competenceScore = resCompetence; 
             effortScoreRouge = effortRouge;
            competenceScoreRouge = competenceRouge;
            moyenneScoreRouge = moyenneRouge;
        }

        public bool getReponseBool
        {
            get { return reponseBool; }
        }

        public string getReponseString
        {
            get { return reponseString; }
        }

        public int getReponseInt
        {
            get { return reponseInt; }
        }

        public double getReponseDouble
        {
            get { return reponseDouble; }
        }


        private void Message_Load(object sender, EventArgs e)
        {
            lblMessage.Text = message;
            lblScore.Text = message;
            lblTitre.Text = titre;
            switch (typeMessage)
            {
                case TypeMessage.INFORMATION:
                    lblMessage.Visible = true;
                    this.Size = new Size(986, 347);
                    Button b = new Button();
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Location = new System.Drawing.Point(784, 284);
                    b.Size = new System.Drawing.Size(190, 51);
                    b.TabIndex = 2;
                    b.Text = "Valider";
                    b.UseVisualStyleBackColor = true;
                    b.Click += new System.EventHandler(this.b_Click);
                    this.Controls.Add(b);
                    break;
                case TypeMessage.RESULTAT:
                    lblCompetence.Visible = true;
                    lblEffort.Visible = true;
                    lblMoyenen.Visible = true;
                    lblScore.Visible = true;
                    lblCompetence.Text = "L'évolution des compétences de vos élèves est de : " + competenceScore+" %";
                    lblEffort.Text = "L'évolution des efforts de vos élèves est de : " + effortScore + " %";
                    lblMoyenen.Text = "L'évolution des moyennes de vos élèves est de : " + moyenneScore + " %";
                    if (!effortScoreRouge)
                    {
                        lblEffort.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblEffort.ForeColor = Color.Green;
                    }
                    if (!competenceScoreRouge)
                    {
                        lblCompetence.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblCompetence.ForeColor = Color.Green;
                    }
                    if (!moyenneScoreRouge)
                    {
                        lblMoyenen.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblMoyenen.ForeColor = Color.Green;
                    }
                    this.Size = new Size(986, 347);
                    Button bh = new Button();
                    bh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bh.Location = new System.Drawing.Point(784, 284);
                    bh.Size = new System.Drawing.Size(190, 51);
                    bh.TabIndex = 2;
                    bh.Text = "Valider";
                    bh.UseVisualStyleBackColor = true;
                    bh.Click += new System.EventHandler(this.b_Click);
                    this.Controls.Add(bh);
                    break;
                case TypeMessage.NOTATION:
                    lblMessage.Visible = true;
                    this.Size = new Size(986, 347);
                    Button bu = new Button();
                    bu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    bu.Location = new System.Drawing.Point(784, 284);
                    bu.Size = new System.Drawing.Size(190, 51);
                    bu.TabIndex = 2;
                    bu.Text = "Valider";
                    bu.UseVisualStyleBackColor = true;
                    bu.Click += new System.EventHandler(this.b_Click);
                    this.Controls.Add(bu);

                    
                    Label l = new Label();
                   l.AutoSize = true;
                    l.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    l.Location = new System.Drawing.Point(10, 279);
                    l.Size = new System.Drawing.Size(477, 20);
                    l.TabIndex = 5;
                   
                    TrackBar tb = new TrackBar();
                    tb.Location = new System.Drawing.Point(533, 279);
                    tb.Size = new System.Drawing.Size(184, 45);
                    tb.Tag = l;
                    tb.Value = 5;
                    tb.Scroll += new System.EventHandler(tb_Scroll);
                    tb.TabIndex = 3;
                    l.Text = "Type de notation visant à aider les eleves de competence : "+tb.Value;
                    this.Controls.Add(l);
                    this.Controls.Add(tb);
                    break;
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            TrackBar tb = (TrackBar)sender;
            Label tag = (Label)tb.Tag;
            this.reponseDouble = (double)tb.Value;
            tag.Text= "Type de cours visant à aider les élèves de compétence : " + this.reponseDouble;
        }

        private void lblMoyenen_Click(object sender, EventArgs e)
        {

        }
    }
}
