using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente une gamme de produits de l'entreprise.
    /// Une gamme permet de regrouper des produits similaires ou liés.
    /// </summary>
    public class Gamme
    {
        private int id;
        private string libelle;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Gamme
        /// avec un identifiant et un libellé spécifiés.
        /// </summary>
        /// <param name="unId">Identifiant de la gamme</param>
        /// <param name="unLibelle">Libellé ou nom de la gamme</param>
        public Gamme(int unId, string unLibelle)
        {
            id = unId;
            libelle = unLibelle;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Gamme
        /// avec des valeurs par défaut.
        /// </summary>
        public Gamme()
        {
            id = 0;
            libelle = null;
        }

        /// <summary>
        /// Retourne l'identifiant de la gamme.
        /// </summary>
        /// <returns>Identifiant de la gamme</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Retourne le libellé de la gamme.
        /// </summary>
        /// <returns>Libellé ou nom de la gamme</returns>
        public string GetLibelle()
        {
            return libelle;
        }

    }
}
