using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPlivre
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void auteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_listeAuteur frm = new Form_listeAuteur();
            frm.ShowDialog();
        }
    }
}
