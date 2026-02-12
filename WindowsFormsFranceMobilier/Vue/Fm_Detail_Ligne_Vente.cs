using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsFormsFranceMobilier;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire permettant de gérer le détail d'une ligne de vente.
    /// Permet de sélectionner un produit, saisir la quantité vendue et la quantité retirée,
    /// et visualiser le stock disponible.
    /// </summary>
    public partial class Fm_Detail_Ligne_Vente : Form
    {
        /// <summary>
        /// Ligne de vente en cours de modification ou création.
        /// </summary>
        private Contenir ligneVente;

        /// <summary>
        /// Index de la ligne dans la liste des produits, si modification.
        /// </summary>
        private Nullable<int> indexLigne = null;

        /// <summary>
        /// Quantité disponible en stock pour le produit sélectionné.
        /// </summary>
        private int quantiteDisponible = 0;

        /// <summary>
        /// Liste des produits de la vente.
        /// </summary>
        private List<Contenir> lesProduits;

        /// <summary>
        /// Constructeur du formulaire.
        /// Initialise la liste des produits et désactive certains champs.
        /// </summary>
        /// <param name="indexLigneVente">Index de la ligne à modifier, ou null pour une nouvelle ligne.</param>
        /// <param name="produits">Liste des produits de la vente.</param>
        public Fm_Detail_Ligne_Vente(Nullable<int> indexLigneVente, List<Contenir> produits)
        {
            InitializeComponent();
            indexLigne = indexLigneVente;
            lesProduits = produits;
            tbQuantite.Enabled = false;
            tbEnleve.Enabled = false;
            AfficherListeProduits();           
        }

        /// <summary>
        /// Empêche la saisie de caractères non numériques dans le champ Quantité.
        /// </summary>
        private void tbQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Met à jour le total hors taxes après modification de la quantité.
        /// Active la saisie de la quantité enlevée.
        /// </summary>
        private void tbQuantite_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuantite.Text.Trim(), out var valueQuantite) && (cbProduit.SelectedItem as dynamic).Value != 0 )
            {
                tbTotalHt.Text = (int.Parse(tbQuantite.Text) * decimal.Parse(tbPrixHt.Text)).ToString();
                tbEnleve.Enabled = true; //On autorise la saisie d'une quantité enlevée
            }
        }

        /// <summary>
        /// Empêche la saisie de caractères non numériques dans le champ Quantité enlevée.
        /// </summary>
        private void tbEnleve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Affiche le stock disponible pour le produit sélectionné dans le magasin du vendeur.
        /// </summary>
        /// <param name="refProduit">Identifiant du produit.</param>
        private void AfficherStockProduit(int refProduit)
        {
            listViewStock.Items.Clear();

            //Affichage du stock dans le magasin du vendeur
            Modele_Stock modeleStock = new Modele_Stock();
            string codeMagasin = Program.employe.GetMagasin();

            Stock leStock = modeleStock.GetStock(refProduit, codeMagasin);
            if (leStock != null)
            {
                int stockFutur = (leStock.GetQuantiteEnStock() - leStock.GetQuantite_aLivrer());
                string[] ligne = { leStock.GetNomMagasin(), leStock.GetQuantiteEnStock().ToString(), leStock.GetQuantite_aLivrer().ToString(), stockFutur.ToString() };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewStock.Items.Add(lvi);

                quantiteDisponible = leStock.GetQuantiteEnStock();
            }
            else
            {
                Modele_Magasin modeleMagasin = new Modele_Magasin();
                Magasin unMagasin = modeleMagasin.GetMagasin(codeMagasin);
               
                string[] ligne = { unMagasin.GetNom(), "0", "0", "0" };
                ListViewItem lvi = new ListViewItem(ligne);

                listViewStock.Items.Add(lvi);

                quantiteDisponible = 0;
            }
        }

        /// <summary>
        /// Initialise et affiche la liste déroulante des produits.
        /// Si modification d'une ligne existante, pré-remplit les informations.
        /// </summary>
        private void AfficherListeProduits()
        {

            cbProduit.Items.Clear();
            cbProduit.DisplayMember = "Text";
            cbProduit.ValueMember = "Value";

            Modele_Produit modeleProduit = new Modele_Produit();

            if (indexLigne != null)
            {
                Contenir ligneVente = lesProduits[int.Parse(indexLigne.ToString())];
                Produit leProduit = modeleProduit.GetProduit(ligneVente.GetIdProduit());

                cbProduit.Items.Add(new { Text = leProduit.GetReference() + " " + leProduit.GetDesignation(), Value = leProduit.GetId() });
                cbProduit.SelectedIndex = 0;
                cbProduit.Enabled = false;

                AfficherStockProduit(leProduit.GetId());

                tbQuantite.Text = ligneVente.GetQuantiteVendue().ToString();
                tbEnleve.Text = ligneVente.GetQuantiteRetiree().ToString();
                tbQuantite.Enabled = true;
                tbEnleve.Enabled = true;

                tbPrixHt.Text = Math.Round(leProduit.GetPrixHt(), 2).ToString();                 
            }
            else
            {
                string texte = "Choissisez un produit";
                int valeur = 0;
                cbProduit.Items.Add(new { Text = texte, Value = valeur });
                cbProduit.SelectedIndex = 0;

                foreach (Produit unProduit in modeleProduit.GetListe(0, 0, "",""))
                {
                    cbProduit.Items.Add(new { Text = unProduit.GetReference() + " " + unProduit.GetDesignation(), Value = unProduit.GetId() });
                }
            }            
        }

        /// <summary>
        /// Gestion du changement de sélection d'un produit.
        /// Met à jour le stock et le prix hors taxes.
        /// </summary>
        private void cbProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idProduit = (cbProduit.SelectedItem as dynamic).Value;

                if (idProduit != 0) //On a selectionné un produit
                {
                    Modele_Produit modeleProduit = new Modele_Produit();
                    Produit leProduit = modeleProduit.GetProduit(idProduit);

                    AfficherStockProduit(leProduit.GetId());

                    tbPrixHt.Text = Math.Round(leProduit.GetPrixHt(), 2).ToString();

                    tbQuantite.Enabled = true; //On autorise la saisie d'une quantité
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Aucun produit n'a été sélectionné !" + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enregistre ou met à jour la ligne de vente après validation.
        /// Vérifie la quantité commandée, la quantité enlevée et la sélection du produit.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            bool validated = true;
            string errorMsg;

            if (!int.TryParse(tbQuantite.Text.Trim(), out var valueQuantite) || string.IsNullOrEmpty(tbQuantite.Text.Trim()) || valueQuantite <= 0 )
            {
                tbQuantite.Select(0, tbQuantite.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Quantité commandée incorrecte";
                this.errorProviderLigneVente.SetError(tbQuantite, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderLigneVente.SetError(tbQuantite, string.Empty);
            }

            if (!int.TryParse(tbEnleve.Text.Trim(), out var valueEnleve) || string.IsNullOrEmpty(tbEnleve.Text.Trim()) || valueEnleve < 0 || valueEnleve > valueQuantite || valueEnleve > quantiteDisponible)
            {
                tbEnleve.Select(0, tbEnleve.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Quantité enlevée incorrecte";
                this.errorProviderLigneVente.SetError(tbEnleve, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderLigneVente.SetError(tbEnleve, string.Empty);
            }

            
            if ((cbProduit.SelectedItem as dynamic).Value == 0)
            {

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Il faut choisir un produit";
                this.errorProviderLigneVente.SetError(cbProduit, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderLigneVente.SetError(cbProduit, string.Empty);
            }


            if (validated)
            {
                if (indexLigne != null)
                {
                    lesProduits.RemoveAt(int.Parse(indexLigne.ToString()));
                }

                int quantiteVendue = 0;
                int quantiteRetiree = 0;
                int index = 0;
                int indexModif = 0;

                foreach (Contenir uneLigneVente in lesProduits) //On parcourt les produits déjà commandés
                {
                    if (uneLigneVente.GetIdProduit() == (cbProduit.SelectedItem as dynamic).Value)
                    {
                        //Le produit est déjà dans la liste de commande pour ce magasin
                        quantiteVendue = uneLigneVente.GetQuantiteVendue() + int.Parse(tbQuantite.Text);
                        quantiteRetiree = uneLigneVente.GetQuantiteRetiree() + int.Parse(tbEnleve.Text);
                        indexModif = index;
                    }
                    index++;
                }

                if (quantiteVendue > 0) //Le produit est déjà dans la liste, il faut mettre à jour la quantité
                {
                    lesProduits.RemoveAt(indexModif);
                    ligneVente = new Contenir(0, (cbProduit.SelectedItem as dynamic).Value, quantiteVendue, quantiteRetiree, decimal.Parse(tbPrixHt.Text));

                }
                else //Le produit n'existait pas, on peut le créer
                {
                    ligneVente = new Contenir(0, (cbProduit.SelectedItem as dynamic).Value, int.Parse(tbQuantite.Text), int.Parse(tbEnleve.Text), decimal.Parse(tbPrixHt.Text));
                }

                lesProduits.Add(ligneVente);

                this.DialogResult = DialogResult.OK;
                Close();
            }     
        }

        /// <summary>
        /// Annule l'opération et ferme le formulaire sans enregistrer.
        /// </summary>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
