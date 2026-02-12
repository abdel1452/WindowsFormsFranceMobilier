using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsFranceMobilier.Vue
{
    /// <summary>
    /// Fenêtre de sélection d’un client dans le cadre d’une vente.
    /// Cette vue permet :
    /// - de rechercher un client à partir de critères (nom, numéro),
    /// - de sélectionner un client pour l’associer à une vente,
    /// - de créer un nouveau client si nécessaire,
    /// - d’adapter son comportement selon la fenêtre d’origine.
    /// </summary>
    public partial class Fm_Client_Vente : Form
    {

        /// <summary>
        /// Indique la fenêtre appelante (ex : "fm_vente", "fm_detail_vente").
        /// </summary>
        string origine;

        /// <summary>
        /// Identifiant du client sélectionné.
        /// Nullable afin de gérer l’absence de sélection.
        /// </summary>
        private Nullable<int> idClient;


        /// <summary>
        /// Constructeur
        /// </summary>
        public Fm_Client_Vente(string origineForm, Nullable<int> numClient)
        {
            InitializeComponent();
      
            //nomClient = "";
            idClient = numClient;
            origine = origineForm;
            if (origine == "fm_vente") //vient de la fenêtre Fm_Vente
            {
                btNouveauClient.Enabled = false;
            }

        }


        /// <summary>
        /// Affichage de la liste des clients
        /// </summary>
        /// <param name="uneMarque"></param>
        
        private void AfficheClient(string unNom, string unNumClient)
        {

            Modele_Client modeleClient = new Modele_Client();

            //List<Client> clients = modeleClient.GetListe(unNom, unNumClient);

            int nbClients = (modeleClient.GetListe(unNom, unNumClient)).Count();
           
            progressBarRecherche.Maximum = nbClients;
            progressBarRecherche.Value = 0;

            
            int compteur = 0;

            listViewClient.BeginUpdate(); //empêche le contrôle ListView de commencer l'affichage avant la fin du foreach

            foreach (Client unClient in modeleClient.GetListe(unNom, unNumClient))
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
        /// Recherche d'un client en fonction des critères choisis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRechercher_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            AfficheClient(tbNom.Text, tbNumClient.Text);
        }

        /// <summary>
        /// Selection d'un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewClient_DoubleClick(object sender, EventArgs e)
        {
            if (origine == "fm_detail_vente") //vient de la fenêtre Fm_Detail_Vente
            {
                idClient = int.Parse(listViewClient.SelectedItems[0].SubItems[0].Text);
                Fm_Detail_Vente.SetIdClient(idClient);
            }
            else if (origine == "fm_vente") //vient de la fenêtre Fm_Vente
            {
                idClient = int.Parse(listViewClient.SelectedItems[0].SubItems[0].Text);
                Fm_Vente.SetIdClient(idClient);
            }
            
            Close();
        }

        /// <summary>
        /// Réinitilaisation de la recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReset_Click(object sender, EventArgs e)
        {
            tbNom.Clear();
            tbNumClient.Clear();
            listViewClient.Items.Clear();
        }

        /// <summary>
        /// Création d'un nouveau client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNouveauClient_Click(object sender, EventArgs e)
        {     
            Fm_Detail_Client fm_detail_client = new Fm_Detail_Client(0); // on envoie 0 à la fenêtre détail_client pour indiquer qu'il faut créer un nouveau client
            fm_detail_client.ShowDialog();
        }

        /// <summary>
        /// Timer pour la barre de progression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRecherche_Tick(object sender, EventArgs e)
        {
            if (progressBarRecherche.Value < 100)
            {
                progressBarRecherche.Value += 1;
                progressBarRecherche.Refresh();
            }
            else
            {
                timerRecherche.Enabled = false;
            }
        }

        /// <summary>
        /// Affichage de la barre de progression
        /// </summary>
        /// <param name="milliseconds"></param>
        public void AnimatedProgBar(int milliseconds)
        {
            if (!timerRecherche.Enabled)
            {
                progressBarRecherche.Value = 0;
                timerRecherche.Interval = milliseconds / 100;
                timerRecherche.Enabled = true;
            }
        }

        /// <summary>
        /// Retour au formulaire précédent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
