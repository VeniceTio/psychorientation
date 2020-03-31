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
    public partial class Message : Form
    {
        int affichage = -1;
        string message = "";
        string titre = "";


        bool reponseBool = false;
        string reponseString = "";
        int reponseInt = 0;
        double reponseDouble = 0;


        public Message(int affichageChoisi,string messageAffiche,string titreAffiche)
        {
            InitializeComponent();
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
            switch (affichage)
            {
                case 1: //affichage
                break;
            }
        }
    }
}
