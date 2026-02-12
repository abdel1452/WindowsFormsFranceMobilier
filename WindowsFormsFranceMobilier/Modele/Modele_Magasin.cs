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
    /// Classe modèle pour gérer les magasins et interagir avec la table "Magasin" de la base de données.
    /// </summary>
    public class Modele_Magasin
    {
        /// <summary>
        /// Liste des magasins chargés depuis la base de données.
        /// </summary>
        private List<Magasin> lesMagasins;

        /// <summary>
        /// Constructeur qui initialise la liste des magasins.
        /// </summary>
        public Modele_Magasin()
        {
            lesMagasins = new List<Magasin>();
        }

        /// <summary>
        /// Retourne la liste complète des magasins présents dans la base de données.
        /// </summary>
        /// <returns>Liste de tous les magasins.</returns>
        public List<Magasin> GetListe()
        {
            SqlDataReader reader = null;

            try
            {
                string sql = "SELECT mag_code, mag_nom, mag_adresseRue, mag_cpVille FROM Magasin ORDER BY mag_code;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceCode = reader.GetOrdinal("mag_code");
                        int indiceNom = reader.GetOrdinal("mag_nom");
                        int indiceAdresseRue = reader.GetOrdinal("mag_adresseRue");
                        int indiceCpVille = reader.GetOrdinal("mag_cpVille");

                        Magasin unMagasin = new Magasin(reader.GetString(indiceCode), reader.GetString(indiceNom), reader.GetString(indiceAdresseRue), reader.GetString(indiceCpVille));
                        lesMagasins.Add(unMagasin);
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
            return lesMagasins;
        }

        /// <summary>
        /// Retourne un magasin spécifique selon son code.
        /// </summary>
        /// <param name="codeMagasin">Code du magasin recherché.</param>
        /// <returns>Le magasin correspondant ou null si non trouvé.</returns>
        public Magasin GetMagasin(string codeMagasin)
        {
            Magasin leMagasin = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT mag_code, mag_nom, mag_adresseRue, mag_cpVille  FROM  Magasin WHERE mag_code = @codeMagasin;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@codeMagasin", SqlDbType.Char, 3);
                parm0.Value = codeMagasin;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceCode = reader.GetOrdinal("mag_code");
                        int indiceNom = reader.GetOrdinal("mag_nom");
                        int indiceAdresseRue = reader.GetOrdinal("mag_adresseRue");
                        int indiceCpVille = reader.GetOrdinal("mag_cpVille");

                        leMagasin = new Magasin(reader.GetString(indiceCode), reader.GetString(indiceNom), reader.GetString(indiceAdresseRue), reader.GetString(indiceCpVille));
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
            return leMagasin;
        }
    }
}
