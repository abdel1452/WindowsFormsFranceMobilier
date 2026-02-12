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
    /// Classe modèle pour gérer les gammes de produits et interagir avec la table "Gamme" de la base de données.
    /// </summary>
    public class Modele_Gamme
    {
        /// <summary>
        /// Liste des gammes chargées depuis la base de données.
        /// </summary>
        private List<Gamme> lesGammes;

        /// <summary>
        /// Constructeur qui initialise la liste des gammes.
        /// </summary>
        public Modele_Gamme()
        {
            lesGammes = new List<Gamme>();
        }

        /// Retourne la liste complète des gammes présentes dans la base de données.
        /// </summary>
        /// <returns>Liste de toutes les gammes.</returns>
        public List<Gamme> GetListe()
        {
            SqlDataReader reader = null;

            try
            {
                string sql = "SELECT gam_id, gam_libelle FROM gamme ORDER BY gam_libelle;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Gamme uneGamme = new Gamme(reader.GetInt32(0), reader.GetString(1));
                        lesGammes.Add(uneGamme);
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
            return lesGammes;
        }

        /// <summary>
        /// Retourne une gamme spécifique selon son identifiant.
        /// </summary>
        /// <param name="idGamme">Identifiant de la gamme.</param>
        /// <returns>La gamme correspondante ou null si non trouvée.</returns>
        public Gamme GetGamme(int idGamme)
        {
            Gamme laGamme = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT gam_id, gam_libelle FROM  Gamme WHERE gam_id = @idGamme;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idGamme", SqlDbType.Int);
                parm0.Value = idGamme;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       laGamme = new Gamme(reader.GetInt32(0), reader.GetString(1));            
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
            return laGamme;
        }

        /// <summary>
        /// Insère une nouvelle gamme dans la base de données.
        /// </summary>
        /// <param name="libelleGamme">Libellé de la nouvelle gamme.</param>
        public void InsertGamme(string libelleGamme)
        {
            try
            {
                string sql = $"INSERT INTO Gamme(gam_libelle) VALUES (@libelleGamme);";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@libelleGamme", SqlDbType.NVarChar, 50);
                parm1.Value = libelleGamme;
                command.Parameters.Add(parm1);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                if (result == 1)
                {
                    MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Met à jour le libellé d'une gamme existante.
        /// </summary>
        /// <param name="idGamme">Identifiant de la gamme à modifier.</param>
        /// <param name="libelleGamme">Nouveau libellé de la gamme.</param>
        public void UpdateGamme(int idGamme, string libelleGamme)
        {
            try
            {
                string sql = $"UPDATE Gamme SET gam_libelle = @libelleGamme WHERE gam_id = @idGamme;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idGamme", SqlDbType.Int);
                parm0.Value = idGamme;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@libelleGamme", SqlDbType.NVarChar, 50);
                parm1.Value = libelleGamme;
                command.Parameters.Add(parm1);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                if (result == 1)
                {
                    MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Supprime une gamme de la base de données.
        /// </summary>
        /// <param name="idGamme">Identifiant de la gamme à supprimer.</param>
        public void DeleteGamme(int idGamme)
        {
            try
            {
                string sql = $"DELETE FROM gamme WHERE cat_id = @idGamme;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idGamme", SqlDbType.Int);
                parm0.Value = idGamme;
                command.Parameters.Add(parm0);

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
