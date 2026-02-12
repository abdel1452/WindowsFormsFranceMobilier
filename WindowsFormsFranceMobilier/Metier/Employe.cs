using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente un employé de l'entreprise.
    /// Hérite de la classe Personne et ajoute les informations
    /// nécessaires à l'authentification et au rôle de l'employé.
    /// </summary>
    public class Employe : Personne
    {

        private string login;
        private string mdp;
        private string magasin;
        private string fonction;
        private string tel;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Employe
        /// avec l'ensemble des informations personnelles et professionnelles.
        /// </summary>
        /// <param name="unId">Identifiant de l'employé</param>
        /// <param name="unNom">Nom de l'employé</param>
        /// <param name="unPrenom">Prénom de l'employé</param>
        /// <param name="unMail">Adresse email de l'employé</param>
        /// <param name="unTel">Numéro de téléphone de l'employé</param>
        /// <param name="unLogin">Identifiant de connexion</param>
        /// <param name="unMdp">Mot de passe</param>
        /// <param name="unMagasin">Magasin de rattachement</param>
        /// <param name="uneFonction">Fonction de l'employé</param>
        public Employe(int unId, string unNom, string unPrenom, string unMail, string unTel, string unLogin, string unMdp, string unMagasin, string uneFonction) : base(unId, unNom, unPrenom, unMail)
        {
            login = unLogin;
            mdp = unMdp;
            magasin = unMagasin;
            fonction = uneFonction;
            tel = unTel;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Employe
        /// avec des valeurs par défaut.
        /// </summary>
        public Employe()
        {
            id = 0;
            nom = null;
            prenom = null;
            mail = null;
            tel = null;
            login = null;
            mdp = null;
            magasin = null;
            fonction = null;
        }


        /// <summary>
        /// Retourne le numéro de téléphone de l'employé.
        /// </summary>
        /// <returns>Numéro de téléphone</returns>
        public string GetTel()
        {
            return tel;
        }

        /// <summary>
        /// Retourne l'identifiant de connexion de l'employé.
        /// </summary>
        /// <returns>Login</returns>
        public string GetLogin()
        {
            return login;
        }

        /// <summary>
        /// Retourne le mot de passe de l'employé.
        /// </summary>
        /// <returns>Mot de passe</returns>
        public string GetMdp()
        {
            return mdp;
        }

        /// <summary>
        /// Retourne le magasin de rattachement de l'employé.
        /// </summary>
        /// <returns>Magasin</returns>
        public string GetMagasin()
        {
            return magasin;
        }

        /// <summary>
        /// Retourne la fonction occupée par l'employé.
        /// </summary>
        /// <returns>Fonction</returns>
        public string GetFonction()
        {
            return fonction;
        }
    }
}
