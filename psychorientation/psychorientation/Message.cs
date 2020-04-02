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
        INFORMATION,NOTATION
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


        public Message(string messageAffiche,string titreAffiche,TypeMessage typeMessage)
        {
            InitializeComponent();
            this.typeMessage = typeMessage;
            message = messageAffiche;
            titre = titreAffiche;
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
            lblTitre.Text = titre;
            switch (typeMessage)
            {
                case TypeMessage.INFORMATION:
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
                case TypeMessage.NOTATION:
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
    }
}
