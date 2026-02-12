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
    /// Classe modèle pour accéder et gérer les catégories de produits dans la base de données.
    /// Permet de récupérer, insérer, modifier et supprimer des enregistrements de la table "Categorie".
    /// </summary>
    public class Modele_Categorie
    {
        /// <summary>
        /// Liste des catégories récupérées depuis la base de données.
        /// </summary>
        private List<Categorie> lesCategories;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Modele_Categorie.
        /// </summary>
        public Modele_Categorie()
        {
            lesCategories = new List<Categorie>();
        }

        /// <summary>
        /// Retourne la liste complète des catégories présentes dans la base de données.
        /// </summary>
        /// <returns>Liste des objets Categorie</returns>
        public List<Categorie> GetListe()
        {
            SqlDataReader reader = null;
            try
            {
                string sql = "SELECT cat_id, cat_libelle FROM categorie ORDER BY cat_libelle;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Categorie uneCategorie = new Categorie(reader.GetInt32(0), reader.GetString(1));
                        lesCategories.Add(uneCategorie);
                    }
                }
                //reader.Close();
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
            return lesCategories;
        }

        /// <summary>
        /// Retourne une catégorie spécifique selon son identifiant.
        /// </summary>
        /// <param name="idCategorie">Identifiant de la catégorie</param>
        /// <returns>Objet Categorie correspondant ou null si non trouvé</returns>
        public Categorie GetCategorie(int idCategorie)
        {
            Categorie laCategorie = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"SELECT cat_id, cat_libelle FROM  categorie WHERE cat_id = @idCategorie;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idCategorie", SqlDbType.Int);
                parm0.Value = idCategorie;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       laCategorie = new Categorie(reader.GetInt32(0), reader.GetString(1));            
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
            return laCategorie;
        }

        /// <summary>
        /// Insère une nouvelle catégorie dans la base de données.
        /// </summary>
        /// <param name="libelleCategorie">Libellé de la nouvelle catégorie</param>
        public void InsertCategorie(string libelleCategorie)
        {
            try
            {
                string sql = $"INSERT INTO Categorie(cat_libelle) VALUES (@libelleCategorie);";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@libelleCategorie", SqlDbType.NVarChar, 50);
                parm1.Value = libelleCategorie;
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
        /// Met à jour une catégorie existante dans la base de données.
        /// </summary>
        /// <param name="idCategorie">Identifiant de la catégorie à modifier</param>
        /// <param name="libelleCategorie">Nouveau libellé de la catégorie</param>
        public void UpdateCategorie(int idCategorie, string libelleCategorie)
        {
            try
            {
                string sql = $"UPDATE Categorie SET cat_libelle = @libelleCategorie WHERE cat_id = @idCategorie;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idCategorie", SqlDbType.Int);
                parm0.Value = idCategorie;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@libelleCategorie", SqlDbType.NVarChar, 50);
                parm1.Value = libelleCategorie;
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
        /// Supprime une catégorie de la base de données.
        /// </summary>
        /// <param name="idCategorie">Identifiant de la catégorie à supprimer</param>
        public void DeleteCategorie(int idCategorie)
        {
            try
            {
                string sql = $"DELETE FROM categorie WHERE cat_id = @idCategorie;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idCategorie", SqlDbType.Int);
                parm0.Value = idCategorie;
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
