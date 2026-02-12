using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier.Vue
{
    /// <summary>
    /// Fenêtre de gestion et de consultation des clients.
    /// Cette vue permet :
    /// - de rechercher des clients par nom et/ou numéro,
    /// - d’afficher la liste des clients correspondants,
    /// - d’accéder au détail d’un client existant,
    /// - de créer un nouveau client,
    /// - de revenir au menu principal.
    /// </summary>
    public partial class Fm_Client : Form
    {

        /// <summary>
        /// Constructeur de la fenêtre client.
        /// Initialise les composants graphiques.
        /// </summary>
        public Fm_Client()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recherche et affiche les clients correspondant aux critères fournis.
        /// Les résultats sont affichés dans un ListView avec une barre de progression.
        /// </summary>
        /// <param name="unNom">Nom du client à rechercher (peut être vide).</param>
        /// <param name="unNumClient">Numéro du client à rechercher (peut être vide).</param>
        private void AfficheClient(string unNom, string unNumClient)
        {

            Modele_Client modeleClient = new Modele_Client();

            List<Client> lesClients = modeleClient.GetListe(unNom, unNumClient);
            int nbClients = lesClients.Count();

            progressBarRecherche.Maximum = nbClients;
            progressBarRecherche.Value = 0;


            int compteur = 0;

            listViewClient.BeginUpdate(); //empêche le contrôle ListView de commencer l'affichage avant la fin du foreach

            foreach (Client unClient in lesClients)
            {
                compteur++;
                if (progressBarRecherche.Value < nbClients)
                {
                    progressBarRecherche.Value++;
                }

                string[] ligne = { unClient.GetId().ToString(), unClient.GetNom(), unClient.GetPrenom(), unClient.GetCpVille() };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewClient.Items.Add(lvi);

            }

            listViewClient.EndUpdate(); //le contrôle ListView affiche la mise à jour
            progressBarRecherche.Value = 0;
        }

        /// <summary>
        /// Événement déclenché lors du double-clic sur un client dans la liste.
        /// Ouvre la fenêtre de détail du client sélectionné.
        /// </summary>
        private void listViewClient_DoubleClick(object sender, EventArgs e)
        {
                Fm_Detail_Client fmDetailClient = new Fm_Detail_Client(int.Parse(listViewClient.SelectedItems[0].SubItems[0].Text));
                fmDetailClient.Show();
        }

        /// <summary>
        /// Bouton "Rechercher".
        /// Lance la recherche des clients selon les critères saisis.
        /// </summary>
        private void btRechercher_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            AfficheClient(tbNom.Text, tbNumClient.Text);
        }

        /// <summary>
        /// Bouton "Réinitialiser".
        /// Efface les champs de recherche et la liste des clients.
        /// </summary>
        private void btReset_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbNumClient.Clear();
            listViewClient.Items.Clear();
        }

        /// <summary>
        /// Bouton "Nouveau client".
        /// Ouvre la fenêtre de détail client en mode création.
        /// </summary>
        private void btNouveauClient_Click(object sender, EventArgs e)
        {
            Fm_Detail_Client fm_detail_client = new Fm_Detail_Client(0); // on envoie 0 à la fenêtre détail_client pour indiquer qu'il faut créer un nouveau client
            fm_detail_client.ShowDialog();
        }

        /// <summary>
        /// Bouton "Retour".
        /// Permet de revenir au menu principal.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();
            fm_menu.Show();
            Close();
        }
    }
}
