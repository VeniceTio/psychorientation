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
    public partial class Form1 : Form
    {
        List<string> listClasse = new List<string>();
        GestionnaireEleve gestEleve = new GestionnaireEleve();

        int nombreEleve = 5;


        public Form1()
        {
            InitializeComponent();
        }

        private void InitialiserTableau()
        {
            listClasse.Add("Seconde");
            listClasse.Add("Premiere");
            listClasse.Add("Terminale");
        }

        private void CreerEleve(int nbEleve)
        {
            for(int i = 0; i < nbEleve; i++)
            {
                Eleve elev = new Eleve(i);
                gestEleve.ajouterEleve(elev);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitialiserTableau();
            CreerEleve(nombreEleve);

            TypeMessage tm = TypeMessage.INFORMATION;
            Message m = new Message(-1,"Bonjour apprenti prof, vous allez apprendre à éduquer des joueurs !! ","Début",tm);
            m.ShowDialog();
            
            
            InterfaceInfoEleve ii = new InterfaceInfoEleve();
            ii.setParam(gestEleve.getEleve(0),listClasse);
            ii.Left = 0;
            ii.Top = 0;
            ii.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(ii);


        }
    }
}
