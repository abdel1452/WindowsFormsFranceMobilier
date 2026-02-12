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
    /// Formulaire pour la gestion des gammes.
    /// Permet d'afficher la liste des gammes, de créer une nouvelle gamme,
    /// de consulter/modifier une gamme existante et de revenir au menu principal.
    /// </summary>
    public partial class Fm_Gamme : Form
    {
        /// <summary>
        /// Initialise le formulaire Fm_Gamme et affiche la liste des gammes.
        /// </summary>
        public Fm_Gamme()
        {
            InitializeComponent();
            AfficheGamme();
        }

        /// <summary>
        /// Affiche la liste des gammes dans le contrôle ListView.
        /// Chaque ligne contient l'identifiant et le libellé de la gamme.
        /// </summary>
        private void AfficheGamme()
        {

            Modele_Gamme modeleGamme = new Modele_Gamme();

            foreach (Gamme uneGamme in modeleGamme.GetListe())
            {
                string[] ligne = { uneGamme.GetId().ToString(), uneGamme.GetLibelle() };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewGamme.Items.Add(lvi);
            }
        }


        /// <summary>
        /// Gestionnaire de l'événement double-clic sur une gamme.
        /// Ouvre le formulaire Fm_Detail_Gamme pour afficher ou modifier les détails de la gamme sélectionnée.
        /// </summary>
        /// <param name="sender">Objet ayant déclenché l'événement.</param>
        /// <param name="e">Arguments de l'événement.</param>
        private void listViewCategorie_DoubleClick(object sender, EventArgs e)
        {
            Fm_Detail_Gamme fm_detail_gamme = new Fm_Detail_Gamme(int.Parse(listViewGamme.SelectedItems[0].SubItems[0].Text)); // recupere le texte de la premiere colonne de la ligne selectionnée
            fm_detail_gamme.Show();
            Close();
        }

        /// <summary>
        /// Gestionnaire du clic sur le bouton "Nouvelle Gamme".
        /// Ouvre le formulaire Fm_Detail_Gamme pour créer une nouvelle gamme.
        /// </summary>
        /// <param name="sender">Objet ayant déclenché l'événement.</param>
        /// <param name="e">Arguments de l'événement.</param>
        private void btNouvelleGamme_Click(object sender, EventArgs e)
        {
            Fm_Detail_Gamme fm_nouvelle_gamme = new Fm_Detail_Gamme(0); // on envoie 0 à la fenêtre detail_categorie pour indiquer qu'il faut créer une nouvelle catégorie
            fm_nouvelle_gamme.Show();
            Close();
        }

        /// <summary>
        /// Gestionnaire du clic sur le bouton "Retour".
        /// Ferme le formulaire actuel et retourne au menu principal.
        /// </summary>
        /// <param name="sender">Objet ayant déclenché l'événement.</param>
        /// <param name="e">Arguments de l'événement.</param>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();
            fm_menu.Show();
            Close();
        }
    }
}
