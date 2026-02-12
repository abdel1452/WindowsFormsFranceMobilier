using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Fenêtre de détail d'une catégorie de produit.
    /// Cette vue permet :
    /// - d’afficher les informations d’une catégorie existante,
    /// - de créer une nouvelle catégorie,
    /// - de modifier une catégorie existante,
    /// - de supprimer une catégorie selon le profil de l’utilisateur.
    /// </summary>
    public partial class Fm_Detail_Categorie : Form
    {
        /// <summary>
        /// Indique si la fenêtre est utilisée pour la création
        /// d'une nouvelle catégorie.
        /// </summary>
        bool nouvelleCategorie = false;

        /// <summary>
        /// Modèle permettant l’accès aux données des catégories.
        /// </summary>
        Modele_Categorie modeleCategorie = new Modele_Categorie();

        /// <summary>
        /// Constructeur de la fenêtre de détail catégorie.
        /// </summary>
        /// <param name="idCategorie">
        /// Identifiant de la catégorie :
        /// - 0 : création d’une nouvelle catégorie,
        /// - autre valeur : modification d’une catégorie existante.
        /// </param>
        public Fm_Detail_Categorie(int idCategorie)
        {
            InitializeComponent();

            if (idCategorie == 0) //Création d'une nouvelle catégorie
            {
                nouvelleCategorie = true;
                CreeNouvelleCategorie();
            }
            else //Modification d'une catégorie existante
            {
                AffficheDetailCategorie(idCategorie);
            }
        }

        /// <summary>
        /// Affiche les informations d’une catégorie existante
        /// dans les champs du formulaire.
        /// </summary>
        /// <param name="idCategorie">Identifiant de la catégorie à afficher.</param>
        private void AffficheDetailCategorie(int idCategorie)
        {
            Categorie uneCategorie = modeleCategorie.GetCategorie(idCategorie);

            tbIdCategorie.Enabled = false;
            tbIdCategorie.Text = uneCategorie.GetId().ToString();
            tbLibelleCategorie.Text = uneCategorie.GetLibelle();

            //Affichage des boutons en fonction du profil utilisateur
            if (Program.employe.GetFonction() == "fm_dr" || Program.employe.GetFonction() == "fm_rp")
            {
                btSupprimer.Enabled = true;
            }
            else
            {
                btSupprimer.Enabled = false;
            }
        }

        /// <summary>
        /// Prépare l’interface pour la création d’une nouvelle catégorie.
        /// </summary>
        private void CreeNouvelleCategorie()
        {
            tbIdCategorie.Visible = false;
            btSupprimer.Enabled = false; //Suppression impossible

        }

        /// <summary>
        /// Enregistre les modifications ou la création d’une catégorie
        /// après validation des données saisies.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {

            bool validated = true;
            string errorMsg;

            if (string.IsNullOrEmpty(tbLibelleCategorie.Text.Trim()))
            {
                tbLibelleCategorie.Select(0, tbLibelleCategorie.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Libellé catégorie incorrect";
                this.errorProviderDetailCategorie.SetError(tbLibelleCategorie, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailCategorie.SetError(tbLibelleCategorie, string.Empty);
            }

            if (validated)
            {
       
                if (nouvelleCategorie == true) //Création d'une nouvelle catégorie
                {

                    modeleCategorie.InsertCategorie(tbLibelleCategorie.Text);

                }
                else //Modification d'une catégorie existante
                {
                   
                    modeleCategorie.UpdateCategorie(int.Parse(tbIdCategorie.Text), tbLibelleCategorie.Text);
                }

                btRetour.PerformClick(); //Retour au menu
            }


        }

        /// <summary>
        /// Suppression d’une catégorie après confirmation utilisateur.
        /// </summary>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Button buttonYes = new Button();
            buttonYes.Text = "Oui";
            buttonYes.DialogResult = DialogResult.OK;

            Button buttonNo = new Button();
            buttonNo.Text = "non";
            buttonNo.DialogResult = DialogResult.Cancel;

            DialogResult dialogResult = MessageBox.Show("Attention, toutes les données seront définitivement effacées ! \nVoulez-vous vraiment supprimer cette catégorie ?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modeleCategorie.DeleteCategorie(int.Parse(tbIdCategorie.Text));
                btRetour.PerformClick(); //Retour au menu

            }
            
        }

        /// <summary>
        /// Retour à la fenêtre de gestion des catégories.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Categorie fm_categorie = new Fm_Categorie();
            fm_categorie.Show();
            Close();
        }

    }
}
