using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire permettant de gérer le détail d’un produit.
    /// Permet de créer, modifier ou supprimer un produit, de gérer son image, sa catégorie, sa gamme et son prix.
    /// </summary>
    public partial class Fm_Detail_Produit : Form
    {
        /// <summary>
        /// Indique si l'utilisateur souhaite créer un nouveau produit.
        /// </summary>
        bool nouveauProduit = false; //Indique si l'utilisateur veut créer un nouveau produit

        /// <summary>
        /// Chemin du fichier image associé au produit.
        /// </summary>
        string pathImageFile = "";   //chemin image

        /// <summary>
        /// Modèle d'accès aux données produit.
        /// </summary>
        Modele_Produit modeleProduit = new Modele_Produit();

        /// <summary>
        /// Constructeur du formulaire.
        /// Initialise les composants et charge les informations d’un produit existant ou prépare la création d’un nouveau produit.
        /// </summary>
        /// <param name="idProduit">Identifiant du produit à modifier, ou 0 pour créer un nouveau produit.</param>
        public Fm_Detail_Produit(int idProduit)
        {
            InitializeComponent();

            if (idProduit == 0) //Création d'un nouveau produit
            {
                nouveauProduit = true;
                CreeNouveauProduit();
            }
            else //Modification d'un produit existant
            {
                AffficheDetailProduit(idProduit);
            }
        }

        /// <summary>
        /// Charge une image dans un PictureBox sans verrouiller le fichier.
        /// </summary>
        /// <param name="picBox">PictureBox où l’image sera affichée.</param>
        /// <param name="chemin">Chemin complet du fichier image.</param>
        private void ChargerImageSansVerrou(PictureBox picBox, string chemin)
        {
            try
            {
                using (var img = Image.FromFile(chemin))
                {
                    picBox.Image = new Bitmap(img);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur lors du chargement de l'image. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Affiche les détails d’un produit existant, y compris catégorie, gamme, image et stock.
        /// </summary>
        /// <param name="refProduit">Identifiant du produit à afficher.</param>
        private void AffficheDetailProduit(int refProduit)
        {
            Produit leProduit = modeleProduit.GetProduit(refProduit);

            tbIdProduit.Text = leProduit.GetId().ToString();
            tbReferenceProduit.Text = leProduit.GetReference().ToString();
            tbDesignationProduit.Text = leProduit.GetDesignation();
            tbPrixHtProduit.Text = (Math.Round(leProduit.GetPrixHt(), 2)).ToString();
            ckbObsolete.Checked = leProduit.GetObsolete();

            cbCategorie.Items.Clear();
            cbCategorie.DisplayMember = "Text";
            cbCategorie.ValueMember = "Value";

            Modele_Categorie modeleCategorie = new Modele_Categorie();
            int indexItem = 0;
            string texte = "Choissisez une catégorie";
            string valeur = "0";
            cbCategorie.Items.Add(new { Text = texte, Value = valeur });

            foreach (Categorie uneCategorie in modeleCategorie.GetListe())
            {
                cbCategorie.Items.Add(new { Text = uneCategorie.GetLibelle(), Value = uneCategorie.GetId().ToString() });
                if (uneCategorie.GetId() == leProduit.GetCategorie())
                {
                    indexItem = (cbCategorie.Items.Count) - 1;
                }
            }
            cbCategorie.SelectedIndex = indexItem;

            cbGamme.Items.Clear();
            cbGamme.DisplayMember = "Text";
            cbGamme.ValueMember = "Value";

            Modele_Gamme modeleGamme = new Modele_Gamme();
            indexItem = 0;
            texte = "Choissisez une gamme";
            valeur = "0";
            cbGamme.Items.Add(new { Text = texte, Value = valeur });

            foreach (Gamme uneGamme in modeleGamme.GetListe())
            {
                cbGamme.Items.Add(new { Text = uneGamme.GetLibelle(), Value = uneGamme.GetId().ToString() });
                if (uneGamme.GetId() == leProduit.GetGamme())
                {
                    indexItem = (cbGamme.Items.Count) - 1;
                }
            }
            cbGamme.SelectedIndex = indexItem;

            //Les images se trouvent dans le répertoire \Ressources
            if (leProduit.GetPhoto() != "")
            {
                pathImageFile = @"..\..\Resources\" + leProduit.GetPhoto();
                ChargerImageSansVerrou(picBoxProduit, pathImageFile); 
            }
            else
            {
                //On affiche le logo s'il n'y a pas d'image
                pathImageFile = @"..\..\Resources\" + "Fm_Logo.png";
                ChargerImageSansVerrou(picBoxProduit, pathImageFile);
            }

            //Affichage du stock dans les différents magasins
            listViewStock.Items.Clear();

            Modele_Stock modeleStock = new Modele_Stock();
            List<Stock> lesStocks = modeleStock.GetListe(refProduit);

            if (lesStocks.Count > 0)
            {
                foreach (Stock unStock in lesStocks)
                {
                    int stockFutur = (unStock.GetQuantiteEnStock() - unStock.GetQuantite_aLivrer());
                    string[] ligne = { unStock.GetNomMagasin(), unStock.GetQuantiteEnStock().ToString(), unStock.GetQuantite_aLivrer().ToString(), stockFutur.ToString() };
                    ListViewItem lvi = new ListViewItem(ligne);

                    listViewStock.Items.Add(lvi);
                }
            }
            else
            {
                Modele_Magasin modeleMagasin = new Modele_Magasin();
                foreach (Magasin unMagasin in modeleMagasin.GetListe())
                {
                    string[] ligne = { unMagasin.GetNom(), "0", "0", "0" };
                    ListViewItem lvi = new ListViewItem(ligne);

                    listViewStock.Items.Add(lvi);
                }
            }

            //Affichage des boutons en fonction du profil utilisateur
            if (Program.employe.GetFonction() == "fm_dr" || Program.employe.GetFonction() == "fm_rp")
            {
                btSupprimer.Enabled = true;
            }
            else
            {
                btSupprimer.Enabled = false;
            }
        }

        /// <summary>
        /// Prépare le formulaire pour la création d’un nouveau produit.
        /// </summary>
        private void CreeNouveauProduit()
        {

            btSupprimer.Enabled = false; //Suppression impossible
            tbIdProduit.Visible = false;

            cbCategorie.Items.Clear();
            cbCategorie.DisplayMember = "Text";
            cbCategorie.ValueMember = "Value";

            Modele_Categorie modeleCategorie = new Modele_Categorie();
            string texte = "Choissisez une catégorie";
            string valeur = "0";
            cbCategorie.Items.Add(new { Text = texte, Value = valeur });

            foreach (Categorie uneCategorie in modeleCategorie.GetListe())
            {
                cbCategorie.Items.Add(new { Text = uneCategorie.GetLibelle(), Value = uneCategorie.GetId().ToString() });
            }
            cbCategorie.SelectedIndex = 0;

            cbGamme.Items.Clear();
            cbGamme.DisplayMember = "Text";
            cbGamme.ValueMember = "Value";

            Modele_Gamme modeleGamme = new Modele_Gamme();
            texte = "Choissisez une gamme";
            valeur = "0";
            cbGamme.Items.Add(new { Text = texte, Value = valeur });

            foreach (Gamme uneGamme in modeleGamme.GetListe())
            {
                cbGamme.Items.Add(new { Text = uneGamme.GetLibelle(), Value = uneGamme.GetId().ToString() });
            }
            cbGamme.SelectedIndex = 0;

            lblStock.Visible = false;
            listViewStock.Visible = false;

            //On affiche le logo comme image par défaut
            ChargerImageSansVerrou(picBoxProduit, @"..\..\Resources\" + "Fm_Logo.png");
        }

        /// <summary>
        /// Parcourt le système de fichiers pour sélectionner une image produit.
        /// </summary>
        private void BtParcourir_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\Resources\");
            openFileDialogImg.InitialDirectory = Path.GetFullPath(path);
            openFileDialogImg.Filter = "jpeg files (*.jpg)|*.jpg";
            openFileDialogImg.FilterIndex = 0;
            openFileDialogImg.RestoreDirectory = true;
			openFileDialogImg.FileName = "";

            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                pathImageFile = openFileDialogImg.FileName;
                picBoxProduit.Image = Image.FromFile(pathImageFile);
            }
        }

        /// <summary>
        /// Enregistre ou met à jour un produit après validation des champs.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            string categ;
            string gamme;
            bool obsolete = false;

            tbPrixHtProduit.Text = (tbPrixHtProduit.Text).Replace(',', '.'); //le séparateur décimal utilisé par SQLServer est le point

            bool validated = true;
            string errorMsg;

            if (!decimal.TryParse(tbPrixHtProduit.Text.Trim(), out var valuePrixHtProduit) || string.IsNullOrEmpty(tbPrixHtProduit.Text.Trim()) || valuePrixHtProduit < 0)
            {
                tbPrixHtProduit.Select(0, tbPrixHtProduit.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Prix incorrect";
                this.errorProviderProduit.SetError(tbPrixHtProduit, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderProduit.SetError(tbPrixHtProduit, string.Empty);
            }

            if (string.IsNullOrEmpty(tbDesignationProduit.Text.Trim()))
            {
                tbPrixHtProduit.Select(0, tbDesignationProduit.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Désignation produit incorrecte";
                this.errorProviderProduit.SetError(tbDesignationProduit, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderProduit.SetError(tbDesignationProduit, string.Empty);
            }

            if (string.IsNullOrEmpty(tbReferenceProduit.Text.Trim()))
            {
                tbPrixHtProduit.Select(0, tbReferenceProduit.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Référence produit incorrecte";
                this.errorProviderProduit.SetError(tbReferenceProduit, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderProduit.SetError(tbReferenceProduit, string.Empty);
            }

            if ((cbCategorie.SelectedItem as dynamic).Value == "0")
            {
                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Il faut choisir une categorie";
                this.errorProviderProduit.SetError(cbCategorie, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderProduit.SetError(cbCategorie, string.Empty);
            }

            if (validated)
            {
              
                categ = (cbCategorie.SelectedItem as dynamic).Value;            
                gamme = (cbGamme.SelectedItem as dynamic).Value;

                if (ckbObsolete.Checked == true)
                {
                    obsolete = true;
                }
                else
                {
                    obsolete = false;
                }

                if (nouveauProduit == true) //Création d'un nouveau produit
                {
                    modeleProduit.InsertProduit(tbReferenceProduit.Text, tbDesignationProduit.Text, valuePrixHtProduit, categ, gamme, obsolete, pathImageFile);
                }
                else //Modification d'un produit existant
                {
                    modeleProduit.UpdateProduit(tbIdProduit.Text, tbReferenceProduit.Text, tbDesignationProduit.Text, valuePrixHtProduit, categ, gamme, obsolete, pathImageFile);
                }

                btRetour.PerformClick(); //Retour au menu
            }
        }

        /// <summary>
        /// Supprime un produit après confirmation de l'utilisateur.
        /// </summary>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Button buttonYes = new Button();
            buttonYes.Text = "Oui";
            buttonYes.DialogResult = DialogResult.OK;

            Button buttonNo = new Button();
            buttonNo.Text = "non";
            buttonNo.DialogResult = DialogResult.Cancel;

            DialogResult dialogResult = MessageBox.Show("Attention, toutes les données seront définitivement effacées ! \nVoulez-vous vraiment supprimer ce produit ?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (picBoxProduit.Image != null)
                {
                    picBoxProduit.Image.Dispose();  //Libere l'image avant effacement
                }
                modeleProduit.DeleteProduit(int.Parse(tbIdProduit.Text), pathImageFile);
                btRetour.PerformClick(); //Retour au menu
            }
        }

        /// <summary>
        /// Retour au menu principal
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Produit fm_produit = new Fm_Produit();  
            fm_produit.Show();
            Close();
        }

    }
}
