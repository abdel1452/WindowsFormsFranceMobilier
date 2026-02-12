using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour accéder aux paramètres globaux de l'application,
    /// stockés dans la table "param" de la base de données.
    /// </summary>
    public class Modele_Parametre
    {

        /// <summary>
        /// Récupère les paramètres de l'application depuis la base de données.
        /// </summary>
        /// <returns>
        /// identifiant du paramètre, numéro de la dernière facture et taux de TVA appliqué
        /// Retourne null si aucune donnée n'est trouvée.
        /// </returns>
        public Parametre GetParametre()
        {
            Parametre lesParametres = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT *  FROM  param;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceid = reader.GetOrdinal("par_id");
                        int indiceDerniereFacture = reader.GetOrdinal("par_derniereFacture");
                        int indiceTauxTva = reader.GetOrdinal("par_tauxTva");


                        lesParametres = new Parametre(reader.GetInt32(indiceid), reader.GetInt32(indiceDerniereFacture), reader.GetDecimal(indiceTauxTva));
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
            return lesParametres;
        }
    }
}
