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
using WindowsFormsFranceMobilier.Vue;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire de gestion des ventes pour un client spécifique.
    /// Permet d'afficher les ventes existantes d'un client, 
    /// de rechercher un client et d'accéder aux détails des ventes.
    /// </summary>
    public partial class Fm_Vente : Form
    {
        /// <summary>
        /// Identifiant du client actuellement sélectionné.
        /// </summary>
        private static Nullable<int> idClient;

        /// <summary>
        /// Définit l'identifiant du client à afficher.
        /// </summary>
        /// <param name="numClient">Identifiant du client</param>
        public static void SetIdClient(Nullable<int> numClient) 
        {
            idClient = numClient;
        }


        /// <summary>
        /// Constructeur.
        /// Initialise le formulaire et définit l'identifiant du client.
        /// </summary>
        /// <param name="numClient">Identifiant du client</param>
        public Fm_Vente(Nullable<int> numClient)
        {
            idClient = numClient;
            InitializeComponent(); 
        }

        /// <summary>
        /// Événement déclenché à l'activation du formulaire.
        /// Affiche les informations du client et la liste de ses ventes.
        /// </summary>
        private void Fm_Vente_Activated(object sender, EventArgs e)
        {           
            if (idClient != null)
            {
                AfficherClient(idClient);
                Maj_listeVente();
            }
        }

        /// <summary>
        /// Affiche les informations détaillées du client.
        /// </summary>
        /// <param name="idClient">Identifiant du client</param>
        private void AfficherClient(Nullable<int> idClient)
        {           
            tbClient.Clear();

            Modele_Client modeleClient = new Modele_Client();

            if (idClient != null)
            {
                Client leClient = modeleClient.GetClient(int.Parse(idClient.ToString()));
                tbClient.Text = leClient.GetNom() + " " + leClient.GetPrenom() + " " + leClient.GetAdresse1() + " " + leClient.GetCpVille();
                tbClient.Enabled = false;

                tbContactClient.Text = leClient.GetTelFixe() + " / " + leClient.GetTelPortable() + " / " + leClient.GetMail();
                tbContactClient.Enabled = false;
            }
        }

        /// <summary>
        /// Met à jour la liste des ventes du client.
        /// Affiche pour chaque vente la date, l'employé, le nombre d'articles et le montant total HT.
        /// </summary>
        public void Maj_listeVente()
        {        
            Modele_Vente modeleVente = new Modele_Vente();

            List<Vente> lesVentes = new List<Vente>();
            lesVentes = modeleVente.GetListe((int)idClient);

            listViewVente.Items.Clear();

            foreach (Vente uneVente in lesVentes)
            {

                Modele_Employe modeleEmploye = new Modele_Employe();
                Employe unEmploye = new Employe();
                unEmploye = modeleEmploye.GetEmploye(uneVente.GetIdEmploye());

                string infos = $"Vente du {uneVente.GetDateCommande().ToString("d")} ({unEmploye.GetNom()} {unEmploye.GetPrenom()})";

                if (!string.IsNullOrEmpty(uneVente.GetDateFacture().ToString()))
                {
                    string dateFacture = ((DateTime)uneVente.GetDateFacture()).ToString("d");
                    infos = infos + $", Facture du {dateFacture}";
                }

                int nbArticles = 0;
                decimal montantTotalHt = 0;

                foreach (Contenir uneLigneVente in uneVente.GetListeLigneVente())
                {
                    nbArticles++;
                    montantTotalHt = montantTotalHt + Math.Round(uneLigneVente.GetQuantiteVendue() * uneLigneVente.GetPrixUnitaireHt(), 2); 
                }

                infos = infos + $", {nbArticles} article(s) pour {montantTotalHt} €";
                
                string[] ligne = { uneVente.GetIdVente().ToString(), infos };
                ListViewItem lvi = new ListViewItem(ligne);
                listViewVente.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Double-clic sur une vente pour ouvrir les détails correspondants.
        /// </summary>
        private void listViewVente_DoubleClick(object sender, EventArgs e)
        {
            Fm_Detail_Vente fm_detail_vente = new Fm_Detail_Vente(int.Parse(listViewVente.SelectedItems[0].SubItems[0].Text), idClient); // envoie le texte de la premiere colonne de la ligne selectionnée (id de la vente) et l'id du client
            fm_detail_vente.Show();
            Close();
        }

        /// <summary>
        /// Ouvre la fenêtre de recherche d'un client.
        /// </summary>
        private void btRechercheClient_Click(object sender, EventArgs e)
        {
            Fm_Client_Vente fmClient = new Fm_Client_Vente("fm_vente", idClient);
            fmClient.ShowDialog();
        }

        /// <summary>
        /// Retourne au menu principal.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Menu fm_menu = new Fm_Menu();
            fm_menu.Show();
            Close();
        }
    }
}
