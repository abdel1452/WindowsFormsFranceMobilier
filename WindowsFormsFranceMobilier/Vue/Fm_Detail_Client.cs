using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsFranceMobilier.Vue
{
    /// <summary>
    /// Formulaire de gestion du détail d'un client.
    /// Permet de créer un nouveau client ou de modifier/supprimer un client existant.
    /// </summary>
    public partial class Fm_Detail_Client: Form
    {
        /// <summary>
        /// Indique si l'utilisateur est en train de créer un nouveau client.
        /// </summary>
        bool nouveauClient = false; //Indique si l'utilisateur veut créer un nouveau client

        /// <summary>
        /// Modèle de gestion des clients pour l'accès à la base de données.
        /// </summary>
        Modele_Client modeleClient = new Modele_Client();

        /// <summary>
        /// Constructeur du formulaire.
        /// Si idClient = 0, prépare la création d'un nouveau client, sinon affiche les détails du client existant.
        /// </summary>
        /// <param name="idClient">Identifiant du client à afficher ou 0 pour créer un nouveau client.</param>
        public Fm_Detail_Client(int idClient)
        {
            InitializeComponent();

            if (idClient == 0) //Création d'un nouveau client
            {
                nouveauClient = true;
                CreeNouveauClient();
            }
            else //Modification d'un client existant
            {
                AffficheDetailClient(idClient);
            }
        }

        /// <summary>
        /// Affiche les informations d'un client existant dans les champs du formulaire.
        /// </summary>
        /// <param name="idClient">Identifiant du client à afficher.</param>
        private void AffficheDetailClient(int idClient)
        {
            tbIdClient.Enabled = false;
            
            Client unClient = modeleClient.GetClient(idClient);

            tbIdClient.Text = unClient.GetId().ToString();
            tbNomClient.Text = unClient.GetNom();
            tbPrenomClient.Text = unClient.GetPrenom();
            tbAdresse1Client.Text = unClient.GetAdresse1();
            tbAdresse2Client.Text = unClient.GetAdresse2();
            tbCodePostalVilleClient.Text = unClient.GetCpVille();
            tbTelFixeClient.Text = unClient.GetTelFixe();
            tbTelPortableClient.Text = unClient.GetTelPortable();
            tbMailClient.Text = unClient.GetMail();

        }

        /// <summary>
        /// Prépare le formulaire pour la création d'un nouveau client.
        /// Masque le champ Id et désactive le bouton de suppression.
        /// </summary>
        private void CreeNouveauClient()
        {     
            try
            {            
                tbIdClient.Visible = false;            
                btSupprimer.Enabled = false; //Suppression impossible
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Enregistre les modifications apportées au client ou crée un nouveau client.
        /// Valide les champs obligatoires avant d'exécuter l'opération.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            string errorMsg;
            bool validated = true;

            if (string.IsNullOrEmpty(tbNomClient.Text.Trim()))
            {
                tbNomClient.Select(0, tbNomClient.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Nom client incorrect";
                this.errorProviderClient.SetError(tbNomClient, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderClient.SetError(tbNomClient, string.Empty);
            }

            if (string.IsNullOrEmpty(tbPrenomClient.Text.Trim()))
            {
                tbPrenomClient.Select(0, tbPrenomClient.Text.Length);

                /// Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Prénom client incorrect";
                this.errorProviderClient.SetError(tbPrenomClient, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderClient.SetError(tbPrenomClient, string.Empty);
            }

            if (string.IsNullOrEmpty(tbAdresse1Client.Text.Trim()))
            {
                tbAdresse1Client.Select(0, tbAdresse1Client.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Adresse client incorrecte";
                this.errorProviderClient.SetError(tbAdresse1Client, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderClient.SetError(tbAdresse1Client, string.Empty);
            }

            if (string.IsNullOrEmpty(tbCodePostalVilleClient.Text.Trim()))
            {
                tbCodePostalVilleClient.Select(0, tbCodePostalVilleClient.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider.
                errorMsg = "Ville client incorrecte";
                this.errorProviderClient.SetError(tbCodePostalVilleClient, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderClient.SetError(tbCodePostalVilleClient, string.Empty);
            }

            if (validated)
            {
               
                if (nouveauClient == true) //Création d'un nouveau client
                {
                    modeleClient.InsertClient(tbNomClient.Text, tbPrenomClient.Text, tbAdresse1Client.Text, tbAdresse2Client.Text, tbCodePostalVilleClient.Text, tbTelFixeClient.Text, tbTelPortableClient.Text, tbMailClient.Text);
                }
                else //Modification d'un client existant
                {
                    modeleClient.UpdateCLient(int.Parse(tbIdClient.Text), tbNomClient.Text, tbPrenomClient.Text, tbAdresse1Client.Text, tbAdresse2Client.Text, tbCodePostalVilleClient.Text, tbTelFixeClient.Text, tbTelPortableClient.Text, tbMailClient.Text);
                }

                btRetour.PerformClick(); //Retour à la liste des clients 
            }
        }

        /// <summary>
        /// Supprime un client existant après confirmation de l'utilisateur.
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
                modeleClient.DeleteClient(int.Parse(tbIdClient.Text));
                btRetour.PerformClick(); //Retour au menu
            }
        }

        /// <summary>
        /// Ferme le formulaire et revient à la liste des clients.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
