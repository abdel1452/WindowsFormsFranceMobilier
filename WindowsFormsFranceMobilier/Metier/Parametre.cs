using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Représente les paramètres généraux de l'application.
    /// Contient les informations telles que le dernier numéro de facture
    /// et le taux de TVA appliqué.
    /// </summary>
    public class Parametre
    {
        private int id;
        private int derniereFacture;
        private decimal tauxTva;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Parametre
        /// avec les valeurs fournies.
        /// </summary>
        /// <param name="unid">Identifiant des paramètres</param>
        /// <param name="uneDerniereFacture">Dernier numéro de facture utilisé</param>
        /// <param name="unTauxTva">Taux de TVA appliqué</param>
        public Parametre(int unid , int uneDerniereFacture, decimal unTauxTva)
        {
            id = unid;
            derniereFacture = uneDerniereFacture;
            tauxTva = unTauxTva;
        }

        /// <summary>
        /// Retourne l'identifiant des paramètres.
        /// </summary>
        /// <returns>Identifiant</returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Retourne le dernier numéro de facture utilisé.
        /// </summary>
        /// <returns>Dernier numéro de facture</returns>
        public int GetDerniereFacture()
        {
            return derniereFacture;
        }

        /// <summary>
        /// Retourne le taux de TVA appliqué.
        /// </summary>
        /// <returns>Taux de TVA</returns>
        public decimal GetTauxTva()
        {
            return tauxTva;
        }
    }
}
