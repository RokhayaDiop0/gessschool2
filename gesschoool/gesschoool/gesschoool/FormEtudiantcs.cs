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
    public partial class FormEtudiantcs : Form
    {
        gesscolaireEntities context = new gesscolaireEntities();

        public FormEtudiantcs()
        {
            InitializeComponent();
            LoadData();
            LoadClasses();

            txtRecherche.TextChanged += txtRecherche_TextChanged;
        }

        private void LoadData()
        {
            dtaetudiant.DataSource = context.Etudiant.ToList();
        }

        private void LoadClasses()
        {
            
            cmbclasse.DataSource = context.classe.Select(c => c.libelle).ToList();
        }

        private void btnvalide_Click(object sender, EventArgs e)
        {
            try
            {
                Etudiant et = new Etudiant();
                et.prenom = txtprenom.Text;
                et.nom = txtnom.Text;
                et.reglement = int.Parse(txtcredit.Text);
                et.annescolaire = txtanneescolaire.Text;
                var selectedClasse = cmbclasse.SelectedItem as string;
                if (selectedClasse != null)
                {
                    var classe = context.classe.FirstOrDefault(c => c.libelle == selectedClasse);
                    if (classe != null)
                    {
                        et.idclasse = classe.id;
                        context.Etudiant.Add(et);
                        context.SaveChanges();
                        MessageBox.Show("Étudiant enregistré avec succès");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("La classe sélectionnée n'existe pas.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une classe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'enregistrement de l'étudiant : " + ex.ToString());
            }
        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtaetudiant.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dtaetudiant.SelectedRows[0].Index;
                    int etudiantId = Convert.ToInt32(dtaetudiant.Rows[selectedRowIndex].Cells["Id"].Value);

                    Etudiant etudiantAModifier = context.Etudiant.FirstOrDefault(et => et.id == etudiantId);
                    if (etudiantAModifier != null)
                    {
                        etudiantAModifier.prenom = txtprenom.Text;
                        etudiantAModifier.nom = txtnom.Text;
                        etudiantAModifier.reglement = int.Parse(txtcredit.Text);
                        etudiantAModifier.annescolaire = txtanneescolaire.Text;

                        context.SaveChanges();
                        MessageBox.Show("Étudiant modifié avec succès");
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un étudiant à modifier");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la modification de l'étudiant : " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtaetudiant.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dtaetudiant.SelectedRows[0].Index;
                    int etudiantId = Convert.ToInt32(dtaetudiant.Rows[selectedRowIndex].Cells["Id"].Value);

                    Etudiant etudiantASupprimer = context.Etudiant.FirstOrDefault(et => et.id == etudiantId);
                    if (etudiantASupprimer != null)
                    {
                        context.Etudiant.Remove(etudiantASupprimer);
                        context.SaveChanges();
                        MessageBox.Show("Étudiant supprimé avec succès");
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner un étudiant à supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de la suppression de l'étudiant : " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtcredit.Text = "";
            txtreglement.Text = "";
            txtanneescolaire.Text = "";
            cmbclasse.Text = "";
            
        }

        private void cmbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtRecherche.Text.Trim();

           
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadData();
                return;
            }

            var classe = context.classe.FirstOrDefault(c => c.libelle == searchTerm);
            if (classe != null)
            {
                dtaetudiant.DataSource = context.Etudiant.Where(et => et.classe.id == classe.id).ToList();
                return;
            }

          
            dtaetudiant.DataSource = context.Etudiant.Where(et => et.annescolaire.StartsWith(searchTerm)).ToList();
        }

    }
}
