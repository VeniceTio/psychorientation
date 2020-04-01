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
        INFORMATION
    }

    public partial class Message : Form
    {
        int affichage = -1;
        string message = "";
        string titre = "";
        TypeMessage typeMessage;

        bool reponseBool = false;
        string reponseString = "";
        int reponseInt = 0;
        double reponseDouble = 0;


        public Message(int affichageChoisi,string messageAffiche,string titreAffiche,TypeMessage typeMessage)
        {
            InitializeComponent();
            this.typeMessage = typeMessage;
            affichage = affichageChoisi;
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
                case TypeMessage.INFORMATION:;
                break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
