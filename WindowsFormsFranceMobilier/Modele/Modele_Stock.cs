using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour gérer les stocks des produits dans les magasins.
    /// Fournit des méthodes pour récupérer la liste des stocks ou un stock spécifique.
    /// </summary>
    public class Modele_Stock
    {
        /// <summary>
        /// Liste interne des stocks.
        /// </summary>
        private List<Stock> lesStocks;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Modele_Stock.
        /// </summary>
        public Modele_Stock()
        {
            lesStocks = new List<Stock>();
        }

        /// <summary>
        /// Récupère la liste des stocks pour un produit donné.
        /// </summary>
        /// <param name="idProduit">Identifiant du produit pour lequel récupérer le stock.</param>
        /// <returns>Liste des stocks du produit dans tous les magasins.</returns>
        public List<Stock> GetListe(int idProduit)
        {
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT sto_produit, sto_magasin, mag_nom, sto_quantite, sto_aLivrer FROM Stocker JOIN Magasin ON sto_magasin = mag_code WHERE sto_produit = @idProduit ORDER BY sto_produit, sto_magasin;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idProduit", SqlDbType.Int);
                parm0.Value = idProduit;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceIdProduit = reader.GetOrdinal("sto_produit");
                        int indiceCodeMagasin = reader.GetOrdinal("sto_magasin");
                        int indiceNomMagasin = reader.GetOrdinal("mag_nom");
                        int indiceQuantiteStock = reader.GetOrdinal("sto_quantite");
                        int indiceQuantite_aLivrer = reader.GetOrdinal("sto_aLivrer");

                        Stock unStock = new Stock(reader.GetInt32(indiceIdProduit), reader.GetString(indiceCodeMagasin), reader.GetString(indiceNomMagasin), reader.GetInt32(indiceQuantiteStock), reader.GetInt32(indiceQuantite_aLivrer));
                        lesStocks.Add(unStock);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return lesStocks;
        }

        /// <summary>
        /// Récupère le stock d'un produit spécifique dans un magasin donné.
        /// </summary>
        /// <param name="idProduit">Identifiant du produit.</param>
        /// <param name="codeMagasin">Code du magasin.</param>
        /// <returns>L'objet <see cref="Stock"/> correspondant ou null si non trouvé.</returns>
        public Stock GetStock(int idProduit, string codeMagasin )
        {
            Stock leStock = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT sto_produit, sto_magasin, mag_nom, sto_quantite, sto_aLivrer FROM Stocker JOIN Magasin ON sto_magasin = mag_code WHERE sto_produit = @idProduit AND sto_magasin = @codeMagasin ;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idProduit", SqlDbType.Int);
                parm0.Value = idProduit;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@codeMagasin", SqlDbType.Char, 3);
                parm1.Value = codeMagasin;
                command.Parameters.Add(parm1);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceIdProduit = reader.GetOrdinal("sto_produit");
                        int indiceCodeMagasin = reader.GetOrdinal("sto_magasin");
                        int indiceNomMagasin = reader.GetOrdinal("mag_nom");
                        int indiceQuantiteStock = reader.GetOrdinal("sto_quantite");
                        int indiceQuantite_aLivrer = reader.GetOrdinal("sto_aLivrer"); 

                        leStock = new Stock(reader.GetInt32(indiceIdProduit), reader.GetString(indiceCodeMagasin), reader.GetString(indiceNomMagasin), reader.GetInt32(indiceQuantiteStock), reader.GetInt32(indiceQuantite_aLivrer));                    
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return leStock;
        }
    }
}
