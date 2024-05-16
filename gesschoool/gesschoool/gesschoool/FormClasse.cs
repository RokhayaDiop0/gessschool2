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
    public partial class FormClasse : Form
    {

        gesscolaireEntities context = new gesscolaireEntities();
        public FormClasse()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            classe c = new classe();
            c.libelle = cmbniveau.Text + cmbspecialite.Text;
            c.specialite = cmbspecialite.Text;
            c.niveau = cmbniveau.Text;

            context.classe.Add(c);
            context.SaveChanges();

            MessageBox.Show("Classe enregistrer");
            dtaclasse.DataSource = context.classe.ToList();
        }
    }
}
