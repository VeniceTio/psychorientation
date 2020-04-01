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
            List<Eleve> listEleve = gestEleve.getListEleve();

            foreach ( Eleve eleve in listEleve)
            {
                InterfaceInfoEleve ii = new InterfaceInfoEleve();
                ii.setParam(eleve, listeClasse);
                pnlListeEleve.Controls.Add(ii);
            }
        }
    }
}
