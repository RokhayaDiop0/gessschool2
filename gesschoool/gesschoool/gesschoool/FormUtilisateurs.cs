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
    public partial class FormUtilisateurs : Form
    {
        gesscolaireEntities context = new gesscolaireEntities();
        public FormUtilisateurs()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Utilisateur ut = new Utilisateur();
            ut.login = txtlogin.Text;
            ut.password = txtpassword.Text;

            context.Utilisateur.Add(ut);
            context.SaveChanges();

            MessageBox.Show("Utilisateur enregistré ");

           
            dtaUser.DataSource = context.Utilisateur.ToList();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dtaUser.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dtaUser.SelectedRows[0].Cells["id"].Value);

                Utilisateur userToDelete = context.Utilisateur.FirstOrDefault(u => u.id == userId);

                if (userToDelete != null)
                {
                    
                    context.Utilisateur.Remove(userToDelete);
                    context.SaveChanges();

                    dtaUser.DataSource = context.Utilisateur.ToList();

                    MessageBox.Show("Utilisateur supprimé avec succès.");
                }
                else
                {
                    MessageBox.Show("Impossible de trouver l'utilisateur à supprimer.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtlogin.Text = "";
            txtpassword.Text = "";

            MessageBox.Show("Opération annulée.");

        }
    }
}
