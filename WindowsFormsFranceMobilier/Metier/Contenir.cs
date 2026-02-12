using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente une ligne d'une vente à un client.
    /// Contient les informations sur le produit vendu, 
    /// les quantités et le prix unitaire hors taxes.
    /// </summary>
    public class Contenir
    {
        private int idVente;
        private int idProduit;
        private int quantiteVendue;
        private int quantiteRetiree;
        private decimal prixUnitaireHT;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Contenir
        /// avec toutes les informations sur la ligne de vente.
        /// </summary>
        /// <param name="unIdVente">Identifiant de la vente</param>
        /// <param name="unIdProduit">Identifiant du produit</param>
        /// <param name="uneQuantiteVendue">Quantité vendue</param>
        /// <param name="uneQuantiteRetiree">Quantité retirée</param>
        /// <param name="unPrixUnitaireHt">Prix unitaire HT</param>
        public Contenir(int unIdVente, int unIdProduit, int uneQuantiteVendue, int uneQuantiteRetiree, decimal unPrixUnitaireHt)
        {
            idVente = unIdVente;
            idProduit = unIdProduit;
            quantiteVendue = uneQuantiteVendue;
            quantiteRetiree = uneQuantiteRetiree;
            prixUnitaireHT = unPrixUnitaireHt;
        }

        /// <summary>
        /// Retourne l'identifiant de la vente associée à cette ligne.
        /// </summary>
        /// <returns>Identifiant de la vente</returns>
        public int GetIdVente()
        {
            return idVente;
        }

        /// <summary>
        /// Retourne l'identifiant du produit vendu.
        /// </summary>
        /// <returns>Identifiant du produit</returns>
        public int GetIdProduit()
        {
            return idProduit;
        }

        /// <summary>
        /// Retourne la quantité vendue du produit.
        /// </summary>
        /// <returns>Quantité vendue</returns>
        public int GetQuantiteVendue()
        {
            return quantiteVendue;
        }

        /// <summary>
        /// Retourne la quantité retirée du produit.
        /// </summary>
        /// <returns>Quantité retirée</returns>
        public int GetQuantiteRetiree()
        {
            return quantiteRetiree;
        }

        /// <summary>
        /// Retourne le prix unitaire hors taxes du produit.
        /// </summary>
        /// <returns>Prix unitaire HT</returns>
        public decimal GetPrixUnitaireHt()
        {
            return prixUnitaireHT;
        }
    }
}
