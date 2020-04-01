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
    public partial class ListeEleve : Form
    {
        public ListeEleve()
        {
            InitializeComponent();
        }


        private void ListeEleve_Load(object sender, EventArgs e)
        {
            GestionnaireEleve gestEleve = new GestionnaireEleve();
            Libelle lib = new Libelle();

            // TEST
            Eleve e1 = new Eleve(4);
            Eleve e2 = new Eleve(5);
            e1.AjouterNote("une");
            e1.AjouterNote("deux");
            e1.AjouterNote("trois");
            gestEleve.AjouterEleve(e1);
            gestEleve.AjouterEleve(e2);

            List<Eleve> listEleve = gestEleve.GetListeEleves();
            int y = 0;
            foreach ( Eleve eleve in listEleve)
            {
                InterfaceInfoEleve ii = new InterfaceInfoEleve();
                ii.setParam(eleve);
                ii.Location = new Point(10, y);
                pnlListeEleve.Controls.Add(ii);
                y += 220;
            }
        }
    }
}
