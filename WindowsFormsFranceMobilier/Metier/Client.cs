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
    /// Représente un client de l'application.
    /// Hérite de la classe Personne.
    /// </summary>
    public class Client : Personne
    {

        private string adresse1;
        private string adresse2;
        private string cpVille;
        private string telFixe;
        private string telPortable;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Client avec toutes les informations.
        /// </summary>
        /// <param name="unId">Identifiant du client</param>
        /// <param name="unNom">Nom du client</param>
        /// <param name="unPrenom">Prénom du client</param>
        /// <param name="unMail">Adresse email du client</param>
        /// <param name="uneAdresse1">Adresse principale</param>
        /// <param name="uneAdresse2">Complément d'adresse</param>
        /// <param name="unCpVille">Code postal et ville</param>
        /// <param name="unTelFixe">Numéro de téléphone fixe</param>
        /// <param name="unTelPortable">Numéro de téléphone portable</param>
        public Client(int unId, string unNom, string unPrenom, string unMail, string uneAdresse1, string uneAdresse2, string unCpVille, string unTelFixe, string unTelPortable) : base(unId, unNom, unPrenom, unMail)
        {
            adresse1 = uneAdresse1;
            adresse2 = uneAdresse2;
            cpVille = unCpVille;
            telFixe = unTelFixe;
            telPortable = unTelPortable;
        }


        /// <summary>
        /// Initialise une nouvelle instance de la classe Client avec des valeurs par défaut.
        /// </summary>
        public Client()
        {
            id = 0;
            nom = null;
            prenom = null;
            mail = null;
            adresse1 = null;
            adresse2 = null;
            cpVille = null;
            telFixe = null;
            telPortable = null;    
        }


        /// <summary>
        /// Retourne l'adresse principale du client.
        /// </summary>
        /// <returns>Adresse principale</returns>
        public string GetAdresse1()
        {
            return adresse1;
        }

        /// <summary>
        /// Retourne le complément d'adresse du client.
        /// </summary>
        /// <returns>Complément d'adresse</returns>
        public string GetAdresse2()
        {
            return adresse2;
        }

        /// <summary>
        /// Retourne le code postal et la ville du client.
        /// </summary>
        /// <returns>Code postal et ville</returns>
        public string GetCpVille()
        {
            return cpVille;
        }

        /// <summary>
        /// Retourne le numéro de téléphone fixe du client.
        /// </summary>
        /// <returns>Téléphone fixe</returns>
        public string GetTelFixe()
        {
            return telFixe;
        }

        /// <summary>
        /// Retourne le numéro de téléphone portable du client.
        /// </summary>
        /// <returns>Téléphone portable</returns>
        public string GetTelPortable()
        {
            return telPortable;
        }

    }
}
