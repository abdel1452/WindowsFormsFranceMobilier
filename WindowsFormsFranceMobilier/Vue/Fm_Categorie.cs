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
    /// Fenêtre de gestion des catégories de produits.
    /// Cette vue permet :
    /// - d’afficher la liste des catégories existantes,
    /// - d’accéder au détail d’une catégorie,
    /// - de créer une nouvelle catégorie,
    /// - de revenir au menu principal.
    /// </summary>
    public partial class Fm_Categorie : Form
    {
        /// <summary>
        /// Indique si l’utilisateur quitte l’application via la croix de fermeture.
        /// Utilisé pour contrôler le comportement de fermeture.
        /// </summary>
        bool flagQuitter = false;

        /// <summary>
        /// Constructeur de la fenêtre Catégorie.
        /// Initialise les composants graphiques et affiche la liste des catégories.
        /// </summary>
        public Fm_Categorie()
        {
            InitializeComponent();
            AfficheCategories();
        }

        /// <summary>
        /// Récupère et affiche la liste des catégories dans le ListView.
        /// Chaque catégorie est affichée avec son identifiant et son libellé.
        /// </summary>
        private void AfficheCategories()
        {
            Modele_Categorie modeleCategorie = new Modele_Categorie();

            foreach (Categorie uneCategorie in modeleCategorie.GetListe())
            {
                string[] ligne = { uneCategorie.GetId().ToString(), uneCategorie.GetLibelle() };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewCategorie.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Événement déclenché lors du double-clic sur une catégorie.
        /// Ouvre la fenêtre de détail pour la catégorie sélectionnée.
        /// </summary>
        private void listViewCategorie_DoubleClick(object sender, EventArgs e)
        {
            Fm_Detail_Categorie fm_detail_categorie = new Fm_Detail_Categorie(int.Parse(listViewCategorie.SelectedItems[0].SubItems[0].Text)); // recupere le texte de la premiere colonne de la ligne selectionnée
            flagQuitter = false; //L'utilisateur n'a pas cliqué sur la croix - on ne quitte pas l'application
            fm_detail_categorie.Show();
            Close();
        }

        /// <summary>
        /// Bouton "Nouvelle catégorie".
        /// Ouvre la fenêtre de détail en mode création.
        /// </summary>
        private void btNouvelleCategorie_Click(object sender, EventArgs e)
        {
            Fm_Detail_Categorie fm_nouvelle_categorie = new Fm_Detail_Categorie(0); // on envoie 0 à la fenêtre detail_categorie pour indiquer qu'il faut créer une nouvelle catégorie
            flagQuitter = false; //L'utilisateur n'a pas cliqué sur la croix - on ne quitte pas l'application
            fm_nouvelle_categorie.Show();
            Close();
        }

        /// <summary>
        /// Bouton "Retour".
        /// Permet de revenir au menu principal.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();

            flagQuitter = false; //L'utilisateur n'a pas cliqué sur la croix - on ne quitte pas l'application
            fm_menu.Show();
            Close();
        }
    }
}
