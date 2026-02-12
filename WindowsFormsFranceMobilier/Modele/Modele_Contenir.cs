using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier.Modele
{
    /// <summary>
    /// Classe modèle pour gérer les lignes de vente dans la table "Contenir".
    /// Permet de supprimer un enregistrement correspondant à une vente et un produit spécifiques.
    /// </summary>
    public class Modele_Contenir
    {
        /// <summary>
        /// Supprime une ligne de vente spécifique de la table "Contenir".
        /// </summary>
        /// <param name="numVente">Identifiant de la vente</param>
        /// <param name="numProduit">Identifiant du produit à supprimer de la vente</param>
        public void DeleteContenir(int numVente, int numProduit)
        {
            try
            {
                string sql = $"DELETE FROM Contenir WHERE con_vente = @idVente AND con_produit = @idProduit;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idVente", SqlDbType.Int);
                parm0.Value = numVente;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@idProduit", SqlDbType.Int);
                parm1.Value = numProduit;
                command.Parameters.Add(parm1);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                if (result == 1)
                {
                    MessageBox.Show("Données supprimées.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
