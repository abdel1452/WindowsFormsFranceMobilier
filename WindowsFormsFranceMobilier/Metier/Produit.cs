using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente un produit commercialisé par l'entreprise.
    /// Contient les informations nécessaires à l'identification,
    /// à la classification et à la tarification du produit.
    /// </summary>
    public class Produit
    {
       
        private int id;
        private string reference;
        private string designation;
        private decimal prixHt;
        private string photo;
        private int categorie;
        private int gamme;
        private bool obsolete;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Produit
        /// avec l'ensemble de ses caractéristiques.
        /// </summary>
        /// <param name="unId">Identifiant du produit</param>
        /// <param name="uneReference">Référence commerciale</param>
        /// <param name="uneDesignation">Désignation du produit</param>
        /// <param name="unPrixHt">Prix hors taxes</param>
        /// <param name="unePhoto">Photo ou chemin vers la photo du produit</param>
        /// <param name="uneCategorie">Identifiant de la catégorie</param>
        /// <param name="uneGamme">Identifiant de la gamme</param>
        /// <param name="estObsolete">Indique si le produit est obsolète</param>
        public Produit(int unId, string uneReference, string uneDesignation, decimal unPrixHt, string unePhoto, int uneCategorie, int uneGamme, bool estObsolete)
        {
            id = unId;
            reference = uneReference;
            designation = uneDesignation;
            prixHt = unPrixHt;
            photo = unePhoto;
            categorie = uneCategorie;
            gamme = uneGamme;
            obsolete = estObsolete;
        }

        /// <summary>
        /// Retourne l'identifiant du produit.
        /// </summary>
        /// <returns>Identifiant du produit</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Retourne la référence commerciale du produit.
        /// </summary>
        /// <returns>Référence du produit</returns>
        public string GetReference()
        {
            return reference;
        }

        /// <summary>
        /// Retourne la désignation du produit.
        /// </summary>
        /// <returns>Désignation du produit</returns>
        public string GetDesignation()
        {
            return designation;
        }

        /// <summary>
        /// Retourne le prix hors taxes du produit.
        /// </summary>
        /// <returns>Prix HT</returns>
        public decimal GetPrixHt()
        {
            return prixHt;
        }

        /// <summary>
        /// Retourne la photo associée au produit.
        /// </summary>
        /// <returns>Nom ou chemin du fichier photo</returns>
        public string GetPhoto()
        {
            return photo;
        }

        /// <summary>
        /// Retourne l'identifiant de la catégorie du produit.
        /// </summary>
        /// <returns>Identifiant de la catégorie</returns>
        public int GetCategorie()
        {
            return categorie;
        }

        /// <summary>
        /// Retourne l'identifiant de la gamme du produit.
        /// </summary>
        /// <returns>Identifiant de la gamme</returns>
        public int GetGamme()
        {
            return gamme;
        }

        /// <summary>
        /// Indique si le produit est obsolète.
        /// </summary>
        /// <returns>true si le produit est obsolète, sinon false</returns>
        public bool GetObsolete()
        {
            return obsolete;
        }
    }
}
