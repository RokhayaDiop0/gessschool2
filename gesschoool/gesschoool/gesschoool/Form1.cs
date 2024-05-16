using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gesschoool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtilisateurs formUtilisateurs = new FormUtilisateurs();
            formUtilisateurs.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse formClasse = new FormClasse();
            formClasse.Show();
        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormEtudiantcs formEtudiantcs = new FormEtudiantcs();
            formEtudiantcs.Show();
        }
    }
}
