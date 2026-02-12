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
    /// Formulaire de gestion des employés.
    /// Permet d'afficher la liste des employés, d'accéder aux détails d'un employé,
    /// de créer un nouvel employé et de revenir au menu principal.
    /// </summary>
    public partial class Fm_Employe : Form
    {

        /// <summary>
        /// Initialise une nouvelle instance du formulaire.
        /// Remplit la liste des employés en fonction du rôle de l'utilisateur connecté.
        /// </summary>
        public Fm_Employe()
        {
            InitializeComponent();

            string codeMagasin = "";

            if (Program.employe.GetFonction() == "fm_rp")
            {
                codeMagasin = Program.employe.GetMagasin();
            }
            AfficheEmploye(codeMagasin);
        }

        /// <summary>
        /// Remplit le contrôle ListView avec la liste des employés.
        /// </summary>
        /// <param name="magasin">
        /// Code du magasin pour filtrer les employés.
        /// Si la chaîne est vide, tous les employés sont affichés.
        /// </param>
        private void AfficheEmploye(string magasin)
        {
            Modele_Employe modeleEmploye = new Modele_Employe();

            foreach (Employe unEmploye in modeleEmploye.GetListe(magasin))
            {
                string[] ligne = { unEmploye.GetId().ToString(), unEmploye.GetLogin(), unEmploye.GetNom(), unEmploye.GetPrenom(), unEmploye.GetMagasin(), unEmploye.GetFonction() };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewEmploye.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Ouvre le formulaire de détail pour l'employé sélectionné.
        /// </summary>
        /// <param name="sender">Objet ayant déclenché l'événement.</param>
        /// <param name="e">Données de l'événement.</param>
        private void listViewEmploye_DoubleClick(object sender, EventArgs e)
        {
            Fm_Detail_Employe fm_detail_employe = new Fm_Detail_Employe(int.Parse(listViewEmploye.SelectedItems[0].SubItems[0].Text)); // recupere le texte de la premiere colonne de la ligne selectionnée
            fm_detail_employe.Show();
            Close();
        }

        /// <summary>
        /// Ouvre le formulaire de création d'un nouvel employé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNouveauEmploye_Click(object sender, EventArgs e)
        {
            Fm_Detail_Employe fm_nouveau_employe = new Fm_Detail_Employe(0); // on envoie 0 à la fenêtre detail_employe pour indiquer qu'il faut créer un nouvel employé
            fm_nouveau_employe.Show();
            Close();
        }

        /// <summary>
        /// Retour au menu principal de l'application.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();
            fm_menu.Show();
            Close();
        }

    }
}
