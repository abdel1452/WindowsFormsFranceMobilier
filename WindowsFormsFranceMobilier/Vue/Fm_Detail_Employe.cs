using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Formulaire de gestion du détail d'un employé.
    /// Permet de créer un nouvel employé, modifier ou supprimer un employé existant.
    /// </summary>
    public partial class Fm_Detail_Employe : Form
    {
        /// <summary>
        /// Indique si l'utilisateur est en train de créer un nouvel employé.
        /// </summary>
        bool nouvelEmploye = false;

        /// <summary>
        /// Stocke le mot de passe de l'employé existant (non visible pour la modification).
        /// </summary>
        string passwordEmploye;

        /// <summary>
        /// Stocke le nom et prénom concaténés pour l'employé.
        /// </summary>
        string nomPrenom;

        /// <summary>
        /// Modèle de gestion des employés pour l'accès à la base de données.
        /// </summary>
        Modele_Employe modeleEmploye = new Modele_Employe();

        /// <summary>
        /// Constructeur du formulaire.
        /// Si idEmploye = 0, prépare la création d'un nouvel employé, sinon affiche les détails de l'employé existant.
        /// </summary>
        /// <param name="idEmploye">Identifiant de l'employé à afficher ou 0 pour créer un nouvel employé.</param>
        public Fm_Detail_Employe(int idEmploye)
        {
            InitializeComponent();

            if (idEmploye == 0) //Création d'un nouvel employé
            {
                nouvelEmploye = true;
                CreeNouvelEmploye();
            }
            else //Modification d'un employé existant
            {
                AffficheDetailEmploye(idEmploye);
            }

        }

        /// <summary>
        /// Affiche les informations d'un employé existant dans le formulaire.
        /// Masque les champs de mot de passe pour la modification.
        /// Remplit les combobox fonction et magasin.
        /// </summary>
        /// <param name="idEmploye">Identifiant de l'employé à afficher.</param>
        private void AffficheDetailEmploye(int idEmploye)
        {
            tbIdEmploye.Enabled = false;
            tbLoginEmploye.Enabled = false;

            tbMdpEmploye.Visible = false; //On cache le textbox de saisie du mot de passe 
            lblMdp.Visible = false; //On cache le label de saisie du mot de passe 
            tbConfirmationMdpEmploye.Visible = false; //On cache le textbox de saisie de la confirmation mot de passe 
            lblConfirmationMdp.Visible = false; //On cache le label de saisie de la confirmation mot de passe 

            Employe unEmploye = modeleEmploye.GetEmploye(idEmploye);

            passwordEmploye = unEmploye.GetMdp();

            tbIdEmploye.Text = unEmploye.GetId().ToString();
            tbLoginEmploye.Text = unEmploye.GetLogin();
            tbNomEmploye.Text = unEmploye.GetNom();
            tbPrenomEmploye.Text = unEmploye.GetPrenom();    
            nomPrenom = tbNomEmploye.Text + " " + tbPrenomEmploye.Text;

            Dictionary<string, string> fonctions;

            if (Program.employe.GetFonction() == "fm_dr")
            {
                fonctions = new Dictionary<string, string> { { "Vendeur", "fm_ve" }, { "Responsable", "fm_rp" }, { "Directeur", "fm_dr" } };
            }
            else
            {
                fonctions = new Dictionary<string, string> { { "Vendeur", "fm_ve" }, { "Responsable", "fm_rp" } };
            }

            cbFonction.Items.Clear();
            cbFonction.DisplayMember = "Text";
            cbFonction.ValueMember = "Value";
            cbFonction.Items.Add(new { Text = "Aucune", Value = "0" });

            int indexItem = 0;

            foreach (KeyValuePair<string, string> fonction in fonctions)
            {
                cbFonction.Items.Add(new { Text = fonction.Key, Value = fonction.Value });
                if (fonction.Value == unEmploye.GetFonction())
                {
                    indexItem = (cbFonction.Items.Count) - 1;
                }
            }
            cbFonction.SelectedIndex = indexItem;

            tbMailEmploye.Text = unEmploye.GetMail();
            tbTelEmploye.Text = unEmploye.GetTel();
                        
            cbMagasin.Items.Clear();
            cbMagasin.DisplayMember = "Text";
            cbMagasin.ValueMember = "Value";
            cbMagasin.Items.Add(new { Text = "Aucun", Value = "0" });

            Modele_Magasin modeleMagasin = new Modele_Magasin();
            indexItem = 0;

            foreach (Magasin unMagasin in modeleMagasin.GetListe())
            {
                cbMagasin.Items.Add(new { Text = unMagasin.GetNom(), Value = unMagasin.GetCode().ToString() });
                if (unMagasin.GetCode() == unEmploye.GetMagasin())
                {
                    indexItem = (cbMagasin.Items.Count) - 1;
                }
            }
            cbMagasin.SelectedIndex = indexItem;

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
        /// Prépare le formulaire pour la création d'un nouvel employé.
        /// Affiche les champs de mot de passe et remplit les combobox fonction et magasin.
        /// </summary>
        private void CreeNouvelEmploye()
        {
            try
            {             
                tbIdEmploye.Visible = false;
                tbLoginEmploye.Visible = false;

                tbMdpEmploye.Visible = true; //On affiche le textbox de saisie du mot de passe 
                tbMdpEmploye.PasswordChar = '*'; // Utilisation de l'astérisque comme caractère affiché lors de la saisie du mot de passe
                lblMdp.Visible = true; //On affiche le label de saisie du mot de passe
                                       //
                tbConfirmationMdpEmploye.Visible = true; //On affiche le textbox de saisie de la confirmation mot de passe 
                tbConfirmationMdpEmploye.PasswordChar = '*'; // Utilisation de l'astérisque comme caractère affiché lors de la saisie du mot de passe
                lblConfirmationMdp.Visible = true; //On affiche le label de saisie de la confirmation mot de passe 

                btSupprimer.Enabled = false; //Suppression impossible

                Dictionary<string, string> fonctions;

                if (Program.employe.GetFonction() == "fm_dr")
                {
                   fonctions = new Dictionary<string, string> { { "Vendeur", "fm_ve" }, { "Responsable", "fm_rp" }, { "Directeur", "fm_dr" } };
                }
                else
                {
                    fonctions = new Dictionary<string, string> { { "Vendeur", "fm_ve" }, { "Responsable", "fm_rp" } };
                }

                cbFonction.Items.Clear();
                cbFonction.DisplayMember = "Text";
                cbFonction.ValueMember = "Value";
                cbFonction.Items.Add(new { Text = "Aucune", Value = "0" });

                foreach (KeyValuePair<string, string> fonction in fonctions)
                {
                    cbFonction.Items.Add(new { Text = fonction.Key, Value = fonction.Value });
                }
                cbFonction.SelectedIndex = 0;

                Modele_Magasin modeleMagasin = new Modele_Magasin();
                cbMagasin.Items.Clear();
                cbMagasin.DisplayMember = "Text";
                cbMagasin.ValueMember = "Value";

                cbMagasin.Items.Add(new { Text = "Aucun", Value = "0" });

                foreach (Magasin unMagasin in modeleMagasin.GetListe())
                {
                    cbMagasin.Items.Add(new { Text = unMagasin.GetNom(), Value = unMagasin.GetCode().ToString() });    
                }
                cbMagasin.SelectedIndex = 0;               
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enregistre un nouvel employé ou met à jour un employé existant.
        /// Valide les champs obligatoires avant l'insertion/modification.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            string magasin;
            string fonction;

            bool validated = true;
            string errorMsg;

            if (string.IsNullOrEmpty(tbPrenomEmploye.Text.Trim()))
            {
                tbPrenomEmploye.Select(0, tbPrenomEmploye.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Prénom employé(e) incorrect";
                this.errorProviderDetailEmploye.SetError(tbPrenomEmploye, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailEmploye.SetError(tbPrenomEmploye, string.Empty);
            }

            if (string.IsNullOrEmpty(tbNomEmploye.Text.Trim()))
            {
                tbNomEmploye.Select(0, tbNomEmploye.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Nom employé(e) incorrect";
                this.errorProviderDetailEmploye.SetError(tbNomEmploye, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailEmploye.SetError(tbNomEmploye, string.Empty);
            }

            if ((cbFonction.SelectedItem as dynamic).Value == "0")
            {
                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Il faut choisir une fonction";
                this.errorProviderDetailEmploye.SetError(cbFonction, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailEmploye.SetError(cbFonction, string.Empty);
            }

            if ((cbMagasin.SelectedItem as dynamic).Value == "0" && (cbFonction.SelectedItem as dynamic).Value != "fm_dr") //le profil "fm_dr" est autorisé à ne pas avoir de magasin
            {
                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Il faut choisir un magasin";
                this.errorProviderDetailEmploye.SetError(cbMagasin, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailEmploye.SetError(cbMagasin, string.Empty);
            }


            if (tbMdpEmploye.Visible == true) //On gère la saisie du mot de passe et de la confirmation
            {

                if (string.IsNullOrEmpty(tbMdpEmploye.Text.Trim()))
                {
                    tbMdpEmploye.Select(0, tbMdpEmploye.Text.Length);

                    // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                    errorMsg = "Saisie du mot de passe incorrecte";
                    this.errorProviderDetailEmploye.SetError(tbMdpEmploye, errorMsg);

                    validated = false;
                }
                else
                {
                    this.errorProviderDetailEmploye.SetError(tbMdpEmploye, string.Empty);
                }

                if (string.IsNullOrEmpty(tbConfirmationMdpEmploye.Text.Trim()))
                {
                    tbConfirmationMdpEmploye.Select(0, tbConfirmationMdpEmploye.Text.Length);

                    // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                    errorMsg = "La confirmation du mot de passe est obligatoire";
                    this.errorProviderDetailEmploye.SetError(tbConfirmationMdpEmploye, errorMsg);

                    validated = false;
                }
                else
                {
                    this.errorProviderDetailEmploye.SetError(tbConfirmationMdpEmploye, string.Empty);
                }

                if (!(string.IsNullOrEmpty(tbMdpEmploye.Text.Trim())) && (tbMdpEmploye.Text != tbConfirmationMdpEmploye.Text))
                {
                    MessageBox.Show("La confirmation ne correspond pas au mot de passe ! ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbMdpEmploye.Clear();
                    tbConfirmationMdpEmploye.Clear();

                    validated = false;
                }
            }

            if (validated)
            {
                if (nouvelEmploye == true) //Création d'un nouvel employé
                {
                    magasin = (cbMagasin.SelectedItem as dynamic).Value;

                    if (magasin == "Aucun")
                    {
                        magasin = "NULL";
                    }

                    fonction = (cbFonction.SelectedItem as dynamic).Value;

                    if (fonction == "Aucune")
                    {
                        fonction = "NULL";
                    }

                    nomPrenom = tbNomEmploye.Text + " " + tbPrenomEmploye.Text;

                    modeleEmploye.InsertEmploye(tbMdpEmploye.Text, tbNomEmploye.Text, tbPrenomEmploye.Text, nomPrenom, tbMailEmploye.Text, tbTelEmploye.Text, magasin, fonction);

                }
                else //Modification d'un employé existant
                {
                    magasin = (cbMagasin.SelectedItem as dynamic).Value;

                    if (magasin == "Aucun")
                    {
                        magasin = "NULL";
                    }

                    fonction = (cbFonction.SelectedItem as dynamic).Value;

                    if (fonction == "Aucune")
                    {
                        fonction = "NULL";
                    }

                    modeleEmploye.UpdateEmploye(int.Parse(tbIdEmploye.Text), tbLoginEmploye.Text, passwordEmploye, tbNomEmploye.Text, tbPrenomEmploye.Text, nomPrenom, tbMailEmploye.Text, tbTelEmploye.Text, magasin, fonction);
                }
            }
        }

        /// <summary>
        /// Supprime un employé existant après confirmation de l'utilisateur.
        /// </summary>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Button buttonYes = new Button();
            buttonYes.Text = "Oui";
            buttonYes.DialogResult = DialogResult.OK;

            Button buttonNo = new Button();
            buttonNo.Text = "non";
            buttonNo.DialogResult = DialogResult.Cancel;

            DialogResult dialogResult = MessageBox.Show("Attention, toutes les données seront définitivement effacées ! \nVoulez-vous vraiment supprimer l'employé(e) ?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modeleEmploye.DeleteEmploye(int.Parse(tbIdEmploye.Text));
                btRetour.PerformClick(); //Retour au menu
            }
        }

        /// <summary>
        /// Retour au formulaire de liste des employés.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Employe fm_employe = new Fm_Employe();

            //flagQuitter = false; //L'utilisateur n'a pas cliqué sur la croix - on ne quitte pas l'application
            fm_employe.Show();
            Close();
        }
       
    }
}
