using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente une catégorie de produits.
    /// Une catégorie permet de regrouper des produits similaires ou liés.
    /// </summary>
    public class Categorie
    {
        private int id;
        private string libelle;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Categorie
        /// avec un identifiant et un libellé spécifiés.
        /// </summary>
        /// <param name="unId">Identifiant de la catégorie</param>
        /// <param name="unLibelle">Libellé ou nom de la catégorie</param>
        public Categorie(int unId, string unLibelle)
        {
            id = unId;
            libelle = unLibelle;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Categorie
        /// avec des valeurs par défaut.
        /// </summary>
        public Categorie()
        {
            id = 0;
            libelle = null;
        }

        /// <summary>
        /// Retourne l'identifiant de la catégorie.
        /// </summary>
        /// <returns>Identifiant de la catégorie</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Retourne le libellé de la catégorie.
        /// </summary>
        /// <returns>Libellé ou nom de la catégorie</returns>
        public string GetLibelle()
        {
            return libelle;
        }

    }
}
