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
    /// Formulaire de gestion du détail d'une gamme de produits.
    /// Permet de créer une nouvelle gamme, modifier ou supprimer une gamme existante.
    /// </summary>
    public partial class Fm_Detail_Gamme : Form
    {
        /// <summary>
        /// Indique si l'utilisateur souhaite créer une nouvelle gamme.
        /// </summary>
        bool nouvelleGamme = false;

        /// <summary>
        /// Modèle de gestion des gammes pour l'accès à la base de données.
        /// </summary>
        Modele_Gamme modeleGamme = new Modele_Gamme();

        /// <summary>
        /// Constructeur du formulaire.
        /// Si idGamme = 0, prépare la création d'une nouvelle gamme, sinon affiche les détails de la gamme existante.
        /// </summary>
        /// <param name="idGamme">Identifiant de la gamme à afficher ou 0 pour créer une nouvelle gamme.</param>
        public Fm_Detail_Gamme(int idGamme)
        {
            InitializeComponent();

            if (idGamme == 0) //Création d'une nouvelle gamme
            {
                nouvelleGamme = true;
                CreeNouvelleGamme();
            }
            else //Modification d'une gamme existante
            {
                AffficheDetailGamme(idGamme);
            }
        }

        /// <summary>
        /// Affiche les détails d'une gamme existante dans le formulaire.
        /// Active ou désactive le bouton supprimer selon le profil de l'utilisateur.
        /// </summary>
        /// <param name="idGamme">Identifiant de la gamme à afficher.</param>
        private void AffficheDetailGamme(int idGamme)
        {
            Gamme uneGamme = modeleGamme.GetGamme(idGamme);

            tbIdGamme.Enabled = false;
            tbIdGamme.Text = uneGamme.GetId().ToString();
            tbLibelleGamme.Text = uneGamme.GetLibelle();

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
        /// Prépare le formulaire pour la création d'une nouvelle gamme.
        /// Masque le champ Id et désactive le bouton supprimer.
        /// </summary>
        private void CreeNouvelleGamme()
        {
            tbIdGamme.Visible = false;
            btSupprimer.Enabled = false; //Suppression impossible
        }

        /// <summary>
        /// Enregistre la gamme : création si nouvelle gamme, sinon mise à jour des informations existantes.
        /// Valide le libellé avant l'enregistrement.
        /// </summary>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            bool validated = true;
            string errorMsg;

            if (string.IsNullOrEmpty(tbLibelleGamme.Text.Trim()))
            {
                tbLibelleGamme.Select(0, tbLibelleGamme.Text.Length);

                // Définit le message d’erreur à afficher à l’aide de l’ErrorProvider. 
                errorMsg = "Libellé gamme incorrect";
                this.errorProviderDetailGamme.SetError(tbLibelleGamme, errorMsg);

                validated = false;
            }
            else
            {
                this.errorProviderDetailGamme.SetError(tbLibelleGamme, string.Empty);
            }

            if (validated)
            {

                if (nouvelleGamme == true) //Création d'une nouvelle gamme
                {

                    modeleGamme.InsertGamme(tbLibelleGamme.Text);

                }
                else //Modification d'une gamme existante
                {

                    modeleGamme.UpdateGamme(int.Parse(tbIdGamme.Text), tbLibelleGamme.Text);
                }

                btRetour.PerformClick(); //Retour au menu
            }
        }


        /// <summary>
        /// Supprime la gamme après confirmation de l'utilisateur.
        /// </summary>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            Button buttonYes = new Button();
            buttonYes.Text = "Oui";
            buttonYes.DialogResult = DialogResult.OK;

            Button buttonNo = new Button();
            buttonNo.Text = "non";
            buttonNo.DialogResult = DialogResult.Cancel;

            DialogResult dialogResult = MessageBox.Show("Attention, toutes les données seront définitivement effacées ! \nVoulez-vous vraiment supprimer cette gamme ?", "Quitter", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                modeleGamme.DeleteGamme(int.Parse(tbIdGamme.Text));
                btRetour.PerformClick(); //Retour au menu
            }
        }

        /// <summary>
        /// Retourne au formulaire des gammes.
        /// </summary>
        private void btRetour_Click(object sender, EventArgs e)
        {
            Fm_Gamme fm_gamme = new Fm_Gamme();
            fm_gamme.Show();
            Close();
        }
    }
}
