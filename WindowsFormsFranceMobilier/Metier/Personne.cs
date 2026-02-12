using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente une personne de base dans l'application.
    /// Cette classe est destinée à être héritée par d'autres classes métier
    /// telles que Client, Employé, etc.
    /// </summary>
    public class Personne
    {

        protected int id;
        protected string nom;
        protected string prenom;
        protected string adresse;
        protected string mail;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Personne
        /// avec les informations essentielles.
        /// </summary>
        /// <param name="unId">Identifiant de la personne</param>
        /// <param name="unNom">Nom de la personne</param>
        /// <param name="unPrenom">Prénom de la personne</param>
        /// <param name="unMail">Adresse email de la personne</param>
        public Personne(int unId, string unNom, string unPrenom, string unMail)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            mail = unMail;
        }


        /// <summary>
        /// Initialise une nouvelle instance de la classe Personne
        /// avec des valeurs par défaut.
        /// </summary>
        public Personne()
        {
            id = 0;
            nom = null;
            prenom = null;
            mail = null;
        }

        /// <summary>
        /// Retourne l'identifiant de la personne.
        /// </summary>
        /// <returns>Identifiant de la personne</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Retourne le nom de la personne.
        /// </summary>
        /// <returns>Nom de la personne</returns>
        public string GetNom()
        {
            return nom;
        }

        /// <summary>
        /// Retourne le prénom de la personne.
        /// </summary>
        /// <returns>Prénom de la personne</returns>
        public string GetPrenom()
        {
            return prenom;
        }

        /// <summary>
        /// Retourne l'adresse email de la personne.
        /// </summary>
        /// <returns>Adresse email</returns>
        public string GetMail()
        {
            return mail;
        }


        /// <summary>
        /// Modifie l'identifiant de la personne.
        /// </summary>
        /// <param name="unId">Nouvel identifiant</param>
        public void SetId(int unId)
        {
            id = unId;
        }

    }
}
