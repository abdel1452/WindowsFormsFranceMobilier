using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente l'état du stock d'un produit dans un magasin.
    /// Contient la quantité disponible ainsi que la quantité à livrer aux clients.
    /// </summary>
    public class Stock
    {
        private int idProduit;
        private string codeMagasin;
        private string nomMagasin;
        private int quantiteEnStock;
        private int quantite_aLivrer;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Stock
        /// avec toutes les informations sur le produit et le magasin.
        /// </summary>
        /// <param name="unIdProduit">Identifiant du produit</param>
        /// <param name="unCodeMagasin">Code du magasin</param>
        /// <param name="unNomMagasin">Nom du magasin</param>
        /// <param name="uneQuantiteEnStock">Quantité en stock</param>
        /// <param name="uneQuantite_aLivrer">Quantité à livrer aux clients</param>
        public Stock(int unIdProduit, string unCodeMagasin, string unNomMagasin, int uneQuantiteEnStock, int uneQuantite_aLivrer)
        {
            idProduit = unIdProduit;
            codeMagasin = unCodeMagasin;
            nomMagasin = unNomMagasin;
            quantiteEnStock = uneQuantiteEnStock;
            quantite_aLivrer = uneQuantite_aLivrer;
        }

        /// <summary>
        /// Initialise une nouvelle instance de la classe Stock
        /// avec des valeurs par défaut.
        /// </summary>
        public Stock()
        {
            idProduit = 0;
            codeMagasin = null;
            nomMagasin = null;
            quantiteEnStock = 0;
            quantite_aLivrer = 0;
        }

        /// <summary>
        /// Retourne l'identifiant du produit.
        /// </summary>
        /// <returns>Identifiant du produit</returns>
        public int GetIdProduit()
        {
            return idProduit;
        }

        /// <summary>
        /// Retourne le code du magasin où le produit est stocké.
        /// </summary>
        /// <returns>Code du magasin</returns>
        public string GetCodeMagasin()
        {
            return codeMagasin;
        }

        /// <summary>
        /// Retourne le nom du magasin où le produit est stocké.
        /// </summary>
        /// <returns>Nom du magasin</returns>
        public string GetNomMagasin()
        {
            return nomMagasin;
        }

        /// <summary>
        /// Retourne la quantité disponible du produit en stock.
        /// </summary>
        /// <returns>Quantité en stock</returns>
        public int GetQuantiteEnStock()
        {
            return quantiteEnStock;
        }

        /// <summary>
        /// Retourne la quantité du produit à livrer.
        /// </summary>
        /// <returns>Quantité à livrer</returns>
        public int GetQuantite_aLivrer()
        {
            return quantite_aLivrer;
        }

    }
}
