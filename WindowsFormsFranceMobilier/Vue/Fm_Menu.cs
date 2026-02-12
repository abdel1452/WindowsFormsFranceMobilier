using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFranceMobilier.Vue;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire principal du menu de l'application FranceMobilier.
    /// Affiche les différentes options accessibles selon le profil de l'utilisateur connecté.
    /// Permet la navigation vers les modules : Catégories, Gammes, Produits, Clients, Employés, Saisie et édition de ventes.
    /// </summary>
    public partial class Fm_Menu : Form
    {

        /// <summary>
        /// Initialise le formulaire de menu principal.
        /// Configure les boutons accessibles en fonction du rôle de l'utilisateur connecté.
        /// Affiche le nom et prénom de l'employé connecté.
        /// </summary>
        public Fm_Menu()
        {
            InitializeComponent();

            try
            {
                Modele_Magasin modeleMagasin = new Modele_Magasin();
                Program.magasin = modeleMagasin.GetMagasin(Program.employe.GetMagasin()); //On récupère les infos sur le magasin

                lblEmploye.Text = "Bienvenue " + Program.employe.GetPrenom() + " " + Program.employe.GetNom(); //On affiche les informations sur l'employe

                btCategories.Enabled = false;
                btGammes.Enabled = false;
                btProduits.Enabled = false;
                btClients.Enabled = false;
                btEmployes.Enabled = false;
                btSaisirVente.Enabled = false;
                btEditerVente.Enabled = false;

                //Affichage du menu en fonction du profil utilisateur
                switch (Program.employe.GetFonction())
                {

                    case "fm_dr": //Directeur
                        btCategories.Enabled = true;
                        btGammes.Enabled = true;
                        btProduits.Enabled = true;
                        btClients.Enabled = true;
                        btEmployes.Enabled = true;
                        btSaisirVente.Enabled = true;
                        btEditerVente.Enabled = true;   
                        break;

                    case "fm_rp": //Responsable magasin
                        btCategories.Enabled = true;
                        btGammes.Enabled = true;
                        btProduits.Enabled = true;
                        btClients.Enabled = true;
                        btEmployes.Enabled = true;
                        btSaisirVente.Enabled = true; 
                        btEditerVente.Enabled = true;
                        break;

                    case "fm_ve": //Vendeur
                        btCategories.Enabled = true;
                        btGammes.Enabled = true;
                        btProduits.Enabled = true;
                        btClients.Enabled = true;
                        btSaisirVente.Enabled = true;
                        btEditerVente.Enabled = true; 
                        break;              
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        /// <summary>
        /// Ouvre le module de gestion des catégories.
        /// </summary>
        private void btCategories_Click(object sender, EventArgs e)
        {
            Fm_Categorie fm_categorie = new Fm_Categorie();
            fm_categorie.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le module de gestion des gammes.
        /// </summary>
        private void btGammes_Click(object sender, EventArgs e)
        {
            Fm_Gamme fm_gamme = new Fm_Gamme();   
            fm_gamme.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le module de gestion des produits.
        /// </summary>
        private void btProduits_Click(object sender, EventArgs e)
        {
            Fm_Produit fm_produit = new Fm_Produit();
            fm_produit.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le module de gestion des clients.
        /// </summary>
        private void btClients_Click(object sender, EventArgs e)
        {
            Fm_Client fm_client = new Fm_Client();
            fm_client.Show();
            Close();
        }


        /// <summary>
        /// Ouvre le module de gestion des employés.
        /// </summary>
        private void btEmployes_Click(object sender, EventArgs e)
        {
            Fm_Employe fm_employe = new Fm_Employe();
            fm_employe.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le formulaire pour saisir une nouvelle vente.
        /// </summary>
        private void btSaisirVente_Click(object sender, EventArgs e)
        {
            Fm_Detail_Vente fm_detail_vente = new Fm_Detail_Vente(null, null); //Création d'une nouvelle Vente 
            fm_detail_vente.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le formulaire pour éditer une vente existante.
        /// </summary>
        private void btEditerVente_Click(object sender, EventArgs e)
        {
            Fm_Vente fm_vente = new Fm_Vente(null);
            fm_vente.Show();
            Close();
        }

        /// <summary>
        /// Déconnecte l'utilisateur et retourne au formulaire de login.
        /// Ferme la connexion à la base de données.
        /// </summary>
        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            Program.maConnexion.Close();

            Fm_Login fm_login = new Fm_Login();
            fm_login.Show();
            Close();
        } 
       
    }
}
