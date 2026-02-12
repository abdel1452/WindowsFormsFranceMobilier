using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente un magasin de l'entreprise.
    /// Contient les informations nécessaires pour l'identifier et localiser le magasin.
    /// </summary>
    public class Magasin
    {
        private string code;
        private string nom;
        private string adresseRue;
        private string cpVille;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Magasin
        /// avec toutes les informations.
        /// </summary>
        /// <param name="unCode">Code du magasin</param>
        /// <param name="unNom">Nom du magasin</param>
        /// <param name="uneAdresseRue">Adresse postale (rue)</param>
        /// <param name="unCpVille">Code postal et ville</param>
        public Magasin(string unCode, string unNom, string uneAdresseRue, string unCpVille)
        {
            code = unCode;
            nom = unNom;
            adresseRue = uneAdresseRue;
            cpVille = unCpVille;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Magasin
        /// avec des valeurs par défaut.
        /// </summary>
        public Magasin()
        {
            code= null;
            nom = null;
            adresseRue = null;
            cpVille = null;
        }

        /// <summary>
        /// Retourne le code du magasin.
        /// </summary>
        /// <returns>Code du magasin</returns>
        public string GetCode()
        {
            return code;
        }

        /// <summary>
        /// Retourne le nom du magasin.
        /// </summary>
        /// <returns>Nom du magasin</returns>
        public string GetNom()
        {
            return nom;
        }

        /// <summary>
        /// Retourne l'adresse postale (rue) du magasin.
        /// </summary>
        /// <returns>Adresse rue</returns>
        public string GetAdresseRue()
        {
            return adresseRue;
        }

        /// <summary>
        /// Retourne le code postal et la ville du magasin.
        /// </summary>
        /// <returns>Code postal et ville</returns>
        public string GetCpVille()
        {
            return cpVille;
        }

    }
}
