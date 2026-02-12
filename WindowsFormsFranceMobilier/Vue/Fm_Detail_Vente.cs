using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsFranceMobilier.Modele;
using WindowsFormsFranceMobilier.Vue;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire de gestion du détail d'une vente.
    /// Permet de créer, modifier, supprimer, facturer et imprimer une vente.
    /// Gère les produits associés, le client, le vendeur, le magasin et la TVA.
    /// </summary>
    public partial class Fm_Detail_Vente : Form
    {
        /// <summary>
        /// Taux de TVA applicable à la vente.
        /// </summary>
        private decimal tauxTva;

        /// <summary>
        /// Liste des produits (lignes de commande) associés à la vente.
        /// </summary>
        private List<Contenir> lesProduits;

        /// <summary>
        /// Identifiant du client associé à la vente.
        /// </summary>
        private static Nullable<int> idClient;

        /// Constructeur du formulaire.
        /// Charge les informations d'une vente existante ou initialise une nouvelle vente.
        /// </summary>
        /// <param name="numVente">Identifiant de la vente existante ou null pour une nouvelle vente.</param>
        /// <param name="numClient">Identifiant du client associé à la vente ou null.</param>
        public Fm_Detail_Vente(Nullable<int> numVente, Nullable<int> numClient)
        {
            InitializeComponent();
            lesProduits = new List<Contenir>();
            idClient = numClient;
            AfficherDonneesVente(numVente);
        }

        /// <summary>
        /// Définit l'identifiant du client de manière statique (disponible pour les autres vues).
        /// </summary>
        public static void SetIdClient(Nullable<int> numClient)
        {
            idClient = numClient;
        }

        /// <summary>
        /// Evènement déclenché à l'activation du formulaire.
        /// Met à jour les informations du client si disponibles.
        /// </summary>
        private void Fm_Detail_Vente_Activated(object sender, EventArgs e)
        {
            if (idClient != null)
            {
                AfficherClient(idClient);
            }
        }

        /// <summary>
        /// Affiche toutes les données nécessaires à la vente.
        /// </summary>
        /// <param name="idVente">Identifiant de la vente existante ou null pour une nouvelle vente.</param>
        private void AfficherDonneesVente(Nullable<int> idVente)
        {

            if (idVente != null) //Edition d'une vente existante
            {
                Modele_Vente modeleVente = new Modele_Vente();
                Vente uneVente = modeleVente.GetVente(idVente);

                cbEmploye.Items.Clear();
                cbEmploye.DisplayMember = "Text";
                cbEmploye.ValueMember = "Value";
               
                Modele_Employe modeleEmploye = new Modele_Employe();

                Employe unEmploye = modeleEmploye.GetEmploye(uneVente.GetIdEmploye());
                cbEmploye.Items.Add(new { Text = unEmploye.GetNom() + " " + unEmploye.GetPrenom(), Value = unEmploye.GetId() });
                cbEmploye.SelectedIndex = 0;
                cbEmploye.Enabled = false;

                Modele_Magasin modeleMagasin = new Modele_Magasin();

                Magasin unMagasin = modeleMagasin.GetMagasin(uneVente.GetMagasin());

                string nomMagasin = unMagasin.GetNom(); //On récupère les infos sur le magasin
                tbMagasin.Text = nomMagasin;
                tbMagasin.Enabled = false;

                tbNumVente.Text = uneVente.GetIdVente().ToString();
                tbDateVente.Text = uneVente.GetDateCommande().ToString("d");
                
                if (uneVente.GetNumFacture() != null)
                {
                    tbNumFacture.Text = uneVente.GetNumFacture().ToString();
                    tbDateFacture.Text = DateTime.Parse(uneVente.GetDateFacture().ToString()).ToShortDateString();
                    btFacturer.Enabled = false; //La facture existe déjà
                    btImprimer.Enabled = true; //on peut imprimer la facture

                    //On ne peut plus modifier la vente
                    btEnregistrer.Enabled = false;
                    btAjouterProduit.Enabled = false;
                    btSupprimerProduit.Enabled = false;
                    listViewProduit.Enabled = false;
                    btSupprimer.Enabled = false;
                }
                else
                {
                    btImprimer.Enabled = false; //La facture n'existe pas donc on ne peut pas imprimer
                }

                tauxTva = uneVente.GetTauxTva();
                tbTvaHaut.Text = Math.Round(tauxTva * 100, 2).ToString();
                tbTvaBas.Text = Math.Round(tauxTva * 100, 2).ToString();

                AfficherClient(uneVente.GetIdClient());

                lesProduits = uneVente.GetListeLigneVente();
                Maj_listeLignesVente();
            }
            else //Nouvelle vente
            {
                cbEmploye.Items.Clear();
                cbEmploye.DisplayMember = "Text";
                cbEmploye.ValueMember = "Value";

                Modele_Employe modeleEmploye = new Modele_Employe();
                int indexItemEmploye = 0;
                string magEmploye = "";

                foreach (Employe unEmploye in modeleEmploye.GetListe(magEmploye))
                {
                    cbEmploye.Items.Add(new { Text = unEmploye.GetNom() + " " + unEmploye.GetPrenom(), Value = unEmploye.GetId() });
                    if (unEmploye.GetId() == Program.employe.GetId())
                    {
                        indexItemEmploye = (cbEmploye.Items.Count) - 1;
                    }
                }
                cbEmploye.SelectedIndex = indexItemEmploye;

                Modele_Magasin modeleMagasin = new Modele_Magasin();

                Magasin leMagasin = modeleMagasin.GetMagasin(Program.employe.GetMagasin());

                string nomMagasin = leMagasin.GetNom(); //On récupère les infos sur le magasin
                tbMagasin.Text = nomMagasin;
                tbMagasin.Enabled = false;

                Modele_Parametre modeleParametre = new Modele_Parametre();
                Parametre lesParametres = modeleParametre.GetParametre();
                tauxTva = lesParametres.GetTauxTva();
                tbTvaHaut.Text = Math.Round(tauxTva * 100, 2).ToString();
                tbTvaBas.Text = Math.Round(tauxTva * 100, 2).ToString();

                DateTime dateDuJour = DateTime.Today;
                tbDateVente.Text = dateDuJour.ToString("d");

                btFacturer.Enabled = false; //Pas encore de facturation possible
                btImprimer.Enabled = false; //La facture n'existe pas donc on ne peut pas imprimer
            }
        }

        /// <summary>
        /// Affiche les informations du client dans le formulaire.
        /// </summary>
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
        /// Met à jour l'affichage des lignes de vente et des totaux (HT, TVA, TTC).
        /// </summary>
        public void Maj_listeLignesVente()
        {    
            decimal montantTotalHtCommande = 0;
            Modele_Produit modeleProduit = new Modele_Produit();

            listViewProduit.Items.Clear();

            foreach (Contenir uneLigneCommande in lesProduits)
            {             
                Produit leProduit = modeleProduit.GetProduit(uneLigneCommande.GetIdProduit());

                decimal montantTotalHtLigne = Math.Round(uneLigneCommande.GetPrixUnitaireHt(), 2) * uneLigneCommande.GetQuantiteVendue();
                decimal prixUnitaireHTLigne = Math.Round(uneLigneCommande.GetPrixUnitaireHt(), 2);
                string[] ligne = { leProduit.GetReference().ToString() + " " + leProduit.GetDesignation().ToString(), prixUnitaireHTLigne.ToString(), uneLigneCommande.GetQuantiteVendue().ToString(), uneLigneCommande.GetQuantiteRetiree().ToString(), montantTotalHtLigne.ToString() };
                ListViewItem lvi = new ListViewItem(ligne);
                listViewProduit.Items.Add(lvi);

                montantTotalHtCommande = montantTotalHtCommande + montantTotalHtLigne;
            }

            tbTotalCommandeHt.Text = montantTotalHtCommande.ToString();
            tbTotalTva.Text = Math.Round((montantTotalHtCommande * tauxTva),2).ToString();
            tbTotalCommandeTtc.Text = Math.Round((montantTotalHtCommande * (tauxTva + 1M) ),2).ToString();
        }

        /// <summary>
        /// Ouvre le formulaire de recherche client.
        /// </summary>
        private void btRechercheClient_Click(object sender, EventArgs e)
        {
            Fm_Client_Vente fmClient = new Fm_Client_Vente("fm_detail_vente", idClient);
            fmClient.ShowDialog();
        }

        /// <summary>
        /// Ajoute une ligne de produit à la vente.
        /// </summary>
        private void btAjouterProduit_Click(object sender, EventArgs e)
        {
            Fm_Detail_Ligne_Vente fmDetailVente = new Fm_Detail_Ligne_Vente(null, lesProduits);

            DialogResult result = fmDetailVente.ShowDialog();
            if (result == DialogResult.OK)
            {
                btEnregistrer.PerformClick(); //On enregistre les modifications
                Maj_listeLignesVente();
            }
        }

        /// <summary>
        /// Supprime un produit sélectionné de la vente.
        /// </summary>
        private void btSupprimerProduit_Click(object sender, EventArgs e)
        {
            
            Modele_Produit modeleProduit = new Modele_Produit();
            Produit leProduit = modeleProduit.GetProduit(lesProduits[listViewProduit.SelectedItems[0].Index].GetIdProduit());

            Modele_Contenir modeleContenir = new Modele_Contenir();
            modeleContenir.DeleteContenir(int.Parse(tbNumVente.Text), leProduit.GetId());

            lesProduits.RemoveAt(listViewProduit.SelectedItems[0].Index);
            Maj_listeLignesVente();
            btSupprimerProduit.Enabled = false;
        }

        /// <summary>
        /// Active le bouton btSupprimerProduit lorsqu’un produit est sélectionné dans la liste.
        /// </summary>
        private void listViewProduit_Click(object sender, EventArgs e)
        {
            btSupprimerProduit.Enabled = true;
        }

        /// <summary>
        /// Ouvre un formulaire de détail pour la ligne de produit sélectionnée, 
        /// permettant à l’utilisateur de modifier la quantité ou d’autres informations sur ce produit dans la vente.
        /// </summary>
        private void listViewProduit_DoubleClick(object sender, EventArgs e)
        {

            int indexListView = ((ListViewItem)listViewProduit.SelectedItems[0]).Index;
            Fm_Detail_Ligne_Vente fmDetailVente = new Fm_Detail_Ligne_Vente(indexListView, lesProduits);
            fmDetailVente.ShowDialog();
        }

        /// <summary>
        /// Enregistre ou met à jour la vente dans la base de données.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {

            bool validated = true;
            string errorMsg;

            if (string.IsNullOrEmpty(tbClient.Text.Trim()))
            {
                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Il faut choisir un client";
                this.errorProviderDetailVente.SetError(tbClient, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailVente.SetError(tbClient, string.Empty);
            }

            if (lesProduits.Count < 1)
            {
                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Il faut ajouter au moins un produit";
                this.errorProviderDetailVente.SetError(listViewProduit, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailVente.SetError(listViewProduit, string.Empty);
            }
       
            if (validated)
            {
                try
                {
                    Modele_Vente modeleVente = new Modele_Vente();
                    int numClient = numClient = Convert.ToInt32(idClient);
                    int idVendeur = (cbEmploye.SelectedItem as dynamic).Value;
                    string codeMagasin = Program.employe.GetMagasin();

                    string tauxTvaSeparateur = (tauxTva.ToString()).Replace(',', '.'); //le séparateur décimal utilisé par SQLServer est le point

                    if (tbNumVente.Text != "")//Update
                    {

                        string dateFacture = null;
                        if (tbDateFacture.Text != "")
                        {
                            dateFacture = tbDateFacture.Text;
                        }

                        Nullable<int> numFacture = null;
                        if (tbNumFacture.Text != "")
                        {
                            numFacture = int.Parse(tbNumFacture.Text);
                        }

                        modeleVente.UpdateVente(int.Parse(tbNumVente.Text), numFacture, dateFacture, lesProduits);
                    }
                    else //Insert
                    {
                        string dateCommande = (new SqlDateTime(DateTime.Today)).ToString();

                        string dateFacture = "NULL";
                        if (tbDateFacture.Text != "")
                        {
                            dateFacture = tbDateFacture.Text;
                        }

                        decimal numCommande = modeleVente.InsertVente(null, dateCommande, dateFacture, tauxTvaSeparateur, numClient, idVendeur, codeMagasin, lesProduits);
                        tbNumVente.Text = numCommande.ToString(); 

                    }

                    btFacturer.Enabled = true; //La vente est enregistrée donc on peut facturer
                    btSupprimer.Enabled = true; //La vente est enregistrée donc on peut la supprimer
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Permet de facturer une vente si tous les produits sont entièrement retirés.
        /// </summary>
        private void btFacturer_Click(object sender, EventArgs e)
        {
            
            //Vérification que tous les produits sont bien livrés
            bool produitsEmportes = true;
            foreach (Contenir uneLigneCommande in lesProduits)
            {
                if (uneLigneCommande.GetQuantiteRetiree() != uneLigneCommande.GetQuantiteVendue())
                {
                    produitsEmportes = false;
                }
            }

            Modele_Vente modeleVente = new Modele_Vente();
            string numFacture = modeleVente.GetNumfacture(int.Parse(tbNumVente.Text));
            
            if (numFacture != "0" && produitsEmportes == true)
            {

                Button buttonYes = new Button();
                buttonYes.Text = "Oui";
                buttonYes.DialogResult = DialogResult.OK;

                Button buttonNo = new Button();
                buttonNo.Text = "non";
                buttonNo.DialogResult = DialogResult.Cancel;

                DialogResult dialogResult = MessageBox.Show("Attention, il sera impossible de modifier la vente apès cette opération !\nVoulez-vous facturer ?", "Quitter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tbNumFacture.Text = numFacture;
                    DateTime dateDuJour = DateTime.Today;
                    tbDateFacture.Text = dateDuJour.ToString("d");

                    btEnregistrer.PerformClick(); //On met à jour la BDD

                    AfficherDonneesVente(int.Parse(tbNumVente.Text)); //On met à jour l'affichage (modification impossible, impression activée)
                }
            }
            else
            {
                MessageBox.Show("Impossible de facturer \ncar la vente n'est pas entièrement livrée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Imprime la facture PDF de la vente.
        /// </summary>
        private void btImprimer_Click(object sender, EventArgs e)
        {
            FacturePdf.GeneratePdf(int.Parse(tbNumVente.Text));
        }
        
        /// <summary>
        /// Retour au menu principal avec confirmation si la vente n'est pas enregistrée.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {

            if (btEnregistrer.Enabled == true)
            {
                Button buttonYes = new Button();
                buttonYes.Text = "Oui";
                buttonYes.DialogResult = DialogResult.OK;

                Button buttonNo = new Button();
                buttonNo.Text = "non";
                buttonNo.DialogResult = DialogResult.Cancel;

                DialogResult dialogResult = MessageBox.Show("Attention, toutes les données non enregistrées seront perdues  ! \nVoulez-vous vraiment quitter ce formulaire ?", "Quitter", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Fm_Menu fm_menu = new Fm_Menu();
                    fm_menu.Show();
                    Close();
                }
            }
            else //La commande est déjà facturée - aucun enregistrement n'est possible
            {
                Fm_Menu fm_menu = new Fm_Menu();
                fm_menu.Show();
                Close();
            }
        }
    }
}
