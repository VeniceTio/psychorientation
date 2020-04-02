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
    }
}
