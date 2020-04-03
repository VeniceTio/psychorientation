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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            TransmitKeyDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterfaceClasse iC = new InterfaceClasse(false);
            iC.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            InterfaceClasse iC = new InterfaceClasse(true);
            iC.Show();
        }

        private void TransmitKeyDown()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    foreach (Control c2 in (c as Panel).Controls)
                    {
                        c2.KeyDown += new System.Windows.Forms.KeyEventHandler(Menu_KeyDown);
                    }
                }
                c.KeyDown += new System.Windows.Forms.KeyEventHandler(Menu_KeyDown);
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
