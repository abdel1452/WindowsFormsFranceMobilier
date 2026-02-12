using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire de gestion des produits.
    /// Permet l'affichage, la recherche et la navigation vers les détails d'un produit.
    /// </summary>
    public partial class Fm_Produit : Form
    {

        /// <summary>
        /// Constructeur.
        /// Initialise le formulaire, affiche la liste des produits et remplit les listes déroulantes Catégories et Gammes.
        /// </summary>
        public Fm_Produit()
        {
            InitializeComponent();
            int numCategorie = 0;
            int numGamme = 0;
            string designation = "";
            string reference = "";
            
            AfficheProduit(numCategorie,numGamme,designation,reference);
            AfficherListeCategories();
            cbCategorie.SelectedIndex = 0; //On se replace sur la 1ère ligne de la liste des marques
            AfficherListeGammes();
            cbGamme.SelectedIndex = 0; //On se replace sur la 1ère ligne de la liste des gammes
        }

        /// <summary>
        /// Affiche la liste des produits filtrés selon les critères fournis.
        /// </summary>
        /// <param name="uneCategorie">ID de la catégorie sélectionnée (0 = toutes)</param>
        /// <param name="uneGamme">ID de la gamme sélectionnée (0 = toutes)</param>
        /// <param name="uneDesignation">Filtre par désignation</param>
        /// <param name="uneReference">Filtre par référence</param>
        private void AfficheProduit(int uneCategorie, int uneGamme, string uneDesignation, string uneReference)
        {

            Modele_Produit modeleProduit = new Modele_Produit();

            foreach (Produit unProduit in modeleProduit.GetListe(uneCategorie, uneGamme, uneDesignation, uneReference))
            {
                string[] ligne = { unProduit.GetId().ToString(), unProduit.GetReference().ToString(), unProduit.GetDesignation(), Math.Round(unProduit.GetPrixHt(), 2).ToString() + " €" };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewProduit.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Remplit la liste déroulante des catégories disponibles.
        /// </summary>
        private void AfficherListeCategories()
        {
            cbCategorie.Items.Clear();
            cbCategorie.DisplayMember = "Text";
            cbCategorie.ValueMember = "Value";
            cbCategorie.Items.Add(new { Text = "TOUTES", Value = 0 });

            Modele_Categorie modeleCategorie = new Modele_Categorie();

            foreach (Categorie uneCategorie in modeleCategorie.GetListe())
            {
                cbCategorie.Items.Add(new { Text = uneCategorie.GetLibelle(), Value = uneCategorie.GetId() });
            }
        }


        /// <summary>
        /// Remplit la liste déroulante des gammes disponibles.
        /// </summary>
        private void AfficherListeGammes()
        {

            cbGamme.Items.Clear();
            cbGamme.DisplayMember = "Text";
            cbGamme.ValueMember = "Value";
            cbGamme.Items.Add(new { Text = "TOUTES", Value = 0 });

            Modele_Gamme modeleGamme = new Modele_Gamme();

            foreach (Gamme uneGamme in modeleGamme.GetListe())
            {
                cbGamme.Items.Add(new { Text = uneGamme.GetLibelle(), Value = uneGamme.GetId() });
            }
        }

        /// <summary>
        /// Ouverture du formulaire détail produit
        /// pour modifier un produit existant
        /// </summary>
        private void listViewProduit_DoubleClick(object sender, EventArgs e)
        {
            Fm_Detail_Produit fm_produit = new Fm_Detail_Produit(int.Parse(listViewProduit.SelectedItems[0].SubItems[0].Text)); // recupere le texte de la premiere colonne de la ligne selectionnée
            fm_produit.Show();
            Close();
        }

        /// <summary>
        /// Ouverture du formulaire détail produit
        /// pour créer un nouveau produit
        /// </summary>
        private void btNouveauProduit_Click(object sender, EventArgs e)
        {
            Fm_Detail_Produit fm_produit = new Fm_Detail_Produit(0); // on envoie 0 à la fenêtre détail_produit pour indiquer qu'il faut créer un nouveau produit
            fm_produit.Show();
            Close();
        }

        /// <summary>
        /// Recherche les produits correspondant aux critères saisis (catégorie, gamme, désignation, référence).
        /// </summary>
        private void btRechercher_Click(object sender, EventArgs e)
        {
            listViewProduit.Items.Clear(); //On efface le contenu de la listView avant la MAJ
            int numCategorie = (cbCategorie.SelectedItem as dynamic).Value;
            int numGamme = (cbGamme.SelectedItem as dynamic).Value;   
            AfficheProduit(numCategorie, numGamme, tbDesignation.Text, tbReference.Text);
        }

        /// <summary>
        /// Réinitialise tous les critères de recherche et affiche tous les produits.
        /// </summary>
        private void btReset_Click(object sender, EventArgs e)
        {
            tbDesignation.Clear();
            tbReference.Clear();
            cbCategorie.SelectedIndex = 0;
            cbGamme.SelectedIndex = 0;
            btRechercher.PerformClick();
        }

        /// <summary>
        /// Retour au menu principal
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();
            fm_menu.Show();
            Close();
        }
    }
}
