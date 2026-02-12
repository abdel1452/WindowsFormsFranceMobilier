using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente une vente réalisée par l'entreprise.
    /// Une vente peut inclure plusieurs lignes de vente (produits) 
    /// et peut être associée à une facture.
    /// </summary>
    public class Vente
    {
        private int idVente;
        private Nullable<int> numFacture;
        private DateTime dateCommande;
        private Nullable<DateTime> dateFacture;
        private decimal tauxTva;
        private int idClient;
        private int idEmploye;
        private string magasin;
        private List<Contenir> listeLigneVente;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Vente
        /// avec toutes les informations nécessaires.
        /// </summary>
        /// <param name="unIdVente">Identifiant de la vente</param>
        /// <param name="unNumFacture">Numéro de facture (nullable)</param>
        /// <param name="uneDateCommande">Date de commande</param>
        /// <param name="uneDateFacture">Date de facturation (nullable)</param>
        /// <param name="unTauxTva">Taux de TVA appliqué</param>
        /// <param name="unIdClient">Identifiant du client</param>
        /// <param name="unIdEmploye">Identifiant de l'employé</param>
        /// <param name="unMagasin">Magasin de la vente</param>
        /// <param name="uneListeLigneVente">Liste des lignes de vente</param>
        public Vente(int unIdVente, Nullable<int> unNumFacture, DateTime uneDateCommande, Nullable<DateTime> uneDateFacture, decimal unTauxTva, int unIdClient, int unIdEmploye, string unMagasin, List<Contenir> uneListeLigneVente)
        {
            idVente = unIdVente;
            numFacture = unNumFacture;
            dateCommande = uneDateCommande;
            dateFacture = uneDateFacture;
            tauxTva = unTauxTva;
            idClient = unIdClient;
            idEmploye = unIdEmploye;
            magasin = unMagasin;
            listeLigneVente = uneListeLigneVente;
        }

        /// <summary>
        /// Retourne l'identifiant de la vente.
        /// </summary>
        /// <returns>Identifiant de la vente</returns>
        public int GetIdVente()
        {
            return idVente;
        }

        /// <summary>
        /// Retourne le numéro de facture associé à la vente.
        /// </summary>
        /// <returns>Numéro de facture (nullable)</returns>
        public Nullable<int> GetNumFacture()
        {
            return numFacture;
        }

        /// <summary>
        /// Retourne la date de commande de la vente.
        /// </summary>
        /// <returns>Date de commande</returns>
        public DateTime GetDateCommande()
        {
            return dateCommande;
        }

        /// <summary>
        /// Retourne la date de facturation de la vente.
        /// </summary>
        /// <returns>Date de facturation (nullable)</returns>
        public Nullable<DateTime> GetDateFacture()
        {
            return dateFacture;
        }

        /// <summary>
        /// Retourne le taux de TVA appliqué à la vente.
        /// </summary>
        /// <returns>Taux de TVA</returns>
        public decimal GetTauxTva()
        {
            return tauxTva;
        }

        /// <summary>
        /// Retourne l'identifiant du client associé à la vente.
        /// </summary>
        /// <returns>Identifiant du client</returns>
        public int GetIdClient()
        {
            return idClient;
        }

        /// <summary>
        /// Retourne l'identifiant de l'employé qui a enregistré la vente.
        /// </summary>
        /// <returns>Identifiant de l'employé</returns>
        public int GetIdEmploye()
        {
            return idEmploye;
        }

        /// <summary>
        /// Retourne le magasin dans lequel la vente a été effectuée.
        /// </summary>
        /// <returns>Nom ou code du magasin</returns>
        public string GetMagasin()
        {
            return magasin;
        }

        /// <summary>
        /// Retourne la liste des lignes de vente de la vente.
        /// </summary>
        /// <returns>Liste des lignes de vente</returns>
        public List<Contenir> GetListeLigneVente()
        {
            return listeLigneVente;
        }

        /// <summary>
        /// Modifie la liste des lignes de vente.
        /// </summary>
        /// <param name="uneListeLigneVente">Nouvelle liste des lignes de vente</param>
        public void SetListeLigneVente(List<Contenir> uneListeLigneVente)
        {
            listeLigneVente = uneListeLigneVente;
        }

    }

}
