﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psychorientation
{
    public partial class InterfaceInfoEleve : UserControl
    {
        Eleve eleve;
        public InterfaceInfoEleve()
        {
            InitializeComponent();
        }

        private void InterfaceInfoEleve_Load(object sender, EventArgs e)
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
            lblEleve.Text = "Eleve n°" + eleve.GetId();
            lblClasse.Text = lib.Niveau(eleve.GetClasse());
            lblEffort.Text = eleve.GetEffort().ToString();
            lblCompetence.Text = eleve.GetCompetence().ToString();
            double moyenne = eleve.GetMoyenne();
            if (moyenne == -1)
            {
                lblMoyenne.Text="Pas encore d'évaluation";
            }
            else
            {
                lblMoyenne.Text = eleve.GetMoyenne().ToString()+"/20";
            }
            
            MajPanel(pnlCompetence,eleve.GetCompetence());
            MajPanel(pnlEffort, eleve.GetEffort());
        }
        private void MajPanel(Panel p, double valeur)
        {
            int val = (int)valeur;
            p.Size = new Size(val * 133 / 10, p.Height);
        }
    }
}
