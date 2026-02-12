using iText.Commons.Actions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour gérer les produits de l'application.
    /// Fournit des méthodes pour lister, récupérer, insérer, mettre à jour et supprimer des produits.
    /// </summary>
    public class Modele_Produit
    {
        /// <summary>
        /// Liste interne des produits.
        /// </summary>
        private List<Produit> lesProduits;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Modele_Produit.
        /// </summary>
        public Modele_Produit()
        {
            lesProduits = new List<Produit>();
        }

        /// <summary>
        /// Récupère la liste des produits filtrée par catégorie, gamme, désignation et référence.
        /// </summary>
        /// <param name="uneCategorie">ID de la catégorie (0 pour toutes les catégories).</param>
        /// <param name="uneGamme">ID de la gamme (0 pour toutes les gammes).</param>
        /// <param name="uneDesignation">Filtre sur la désignation (vide pour toutes).</param>
        /// <param name="uneReference">Filtre sur la référence (vide pour toutes).</param>
        /// <returns>Liste des produits correspondant aux critères.</returns>
        public List<Produit> GetListe(int uneCategorie, int uneGamme, string uneDesignation, string uneReference)
        {
            SqlDataReader reader = null;

            try
            {
                string sql; //requête SQL

                sql = "SELECT * FROM produit WHERE pro_id LIKE @idPro ";

                if (uneCategorie != 0)
                {
                    sql = sql + "AND pro_categorie = @idCategorie ";
                }
                if (uneGamme != 0)
                {
                    sql = sql + "AND pro_gamme = @idGamme ";
                }
                if (uneDesignation != "")
                {
                    sql = sql + "AND pro_designation LIKE @designation ";
                }
                if (uneReference != "")
                {
                    sql = sql + "AND pro_reference LIKE @reference ";
                }

                sql = sql + "ORDER BY pro_reference;";  

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;

                SqlParameter parm0 = new SqlParameter("@idPro", SqlDbType.Char,1);
                parm0.Value = "%";
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@idCategorie", SqlDbType.Int);
                parm1.Value = uneCategorie;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@idGamme", SqlDbType.Int);
                parm2.Value = uneGamme;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@designation", SqlDbType.NVarChar, 50);
                parm3.Value = "%" + uneDesignation + "%";
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@reference", SqlDbType.NVarChar, 50);
                parm4.Value = "%" + uneReference + "%";
                command.Parameters.Add(parm4);

                command.CommandText = sql;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceId = reader.GetOrdinal("pro_id");
                        int indiceReference = reader.GetOrdinal("pro_reference");
                        int indiceDesignation = reader.GetOrdinal("pro_designation");
                        int indicePrixHt = reader.GetOrdinal("pro_prixHT");
                        int indicePhoto = reader.GetOrdinal("pro_photo");
                        int indiceCategorie = reader.GetOrdinal("pro_categorie");
                        int indiceGamme = reader.GetOrdinal("pro_gamme");
                        int indiceObsolete = reader.GetOrdinal("pro_obsolete");

                        string photo = "";
                        if (!reader.IsDBNull(indicePhoto))
                        {
                            photo = reader.GetString(indicePhoto);
                        }

                        int categorie = 0;
                        if (!reader.IsDBNull(indiceCategorie))
                        {
                            categorie = reader.GetInt32(indiceCategorie);
                        }

                        int gamme = 0;
                        if (!reader.IsDBNull(indiceGamme))
                        {
                            gamme = reader.GetInt32(indiceGamme);
                        }

                        Produit unProduit = new Produit(reader.GetInt32(indiceId), reader.GetString(indiceReference), reader.GetString(indiceDesignation), reader.GetDecimal(indicePrixHt), photo, categorie, gamme, reader.GetBoolean(indiceObsolete));
                        lesProduits.Add(unProduit);
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
            return lesProduits;
        }

        /// <summary>
        /// Récupère un produit par son identifiant.
        /// </summary>
        /// <param name="idProduit">Identifiant du produit.</param>
        /// <returns>L'objet de type Produit correspondant ou null si non trouvé.</returns>
        public Produit GetProduit(int idProduit)
        {
            Produit leProduit = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"Select * from produit where pro_id = @idProduit;";

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
                        int indiceId = reader.GetOrdinal("pro_id");
                        int indiceReference = reader.GetOrdinal("pro_reference");
                        int indiceDesignation = reader.GetOrdinal("pro_designation");
                        int indicePrixHt = reader.GetOrdinal("pro_prixHT");
                        int indicePhoto = reader.GetOrdinal("pro_photo");
                        int indiceCategorie = reader.GetOrdinal("pro_categorie");
                        int indiceGamme = reader.GetOrdinal("pro_gamme");
                        int indiceObsolete = reader.GetOrdinal("pro_obsolete");

                        string photo = "";
                        if (!reader.IsDBNull(indicePhoto))
                        {
                            photo = reader.GetString(indicePhoto);
                        }

                        int categorie = 0;
                        if (!reader.IsDBNull(indiceCategorie))
                        {
                            categorie = reader.GetInt32(indiceCategorie);
                        }

                        int gamme = 0;
                        if (!reader.IsDBNull(indiceGamme))
                        {
                            gamme = reader.GetInt32(indiceGamme);
                        }

                        leProduit = new Produit(reader.GetInt32(indiceId), reader.GetString(indiceReference), reader.GetString(indiceDesignation), reader.GetDecimal(indicePrixHt), photo, categorie, gamme, reader.GetBoolean(indiceObsolete));// création d'une nouvelle instance de Produit
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
            return leProduit;
        }


        /// <summary>
        /// Insère un nouveau produit dans la base de données, avec gestion optionnelle de photo.
        /// </summary>
        /// <param name="refProduit">Référence du produit.</param>
        /// <param name="designationProduit">Désignation du produit.</param>
        /// <param name="prixHtProduit">Prix HT du produit.</param>
        /// <param name="categorieProduit">ID de la catégorie (0 si aucune).</param>
        /// <param name="gammeProduit">ID de la gamme (0 si aucune).</param>
        /// <param name="obsoleteProduit">Indique si le produit est obsolète.</param>
        /// <param name="pathPhotoProduit">Chemin vers la photo du produit (vide si aucune).</param>
        public void InsertProduit(string refProduit, string designationProduit, decimal prixHtProduit, string categorieProduit, string gammeProduit, bool obsoleteProduit, string pathPhotoProduit)
        {
            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();

            SqlDataReader reader = null;
            
            string photoProduit="";

            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.Transaction = transaction;

                if (pathPhotoProduit != "") //On doit enregistrer une photo
                {
                    string sqlMaxNumPhoto = "SELECT MAX(pro_photo) FROM produit;";
                    command.CommandText = sqlMaxNumPhoto;

                    long maxNumPhoto = 0;

                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            maxNumPhoto = long.Parse((reader.GetString(0)).Split('.')[0]);
                        }
                    }
                    reader.Close();
                    maxNumPhoto++;

                    photoProduit = maxNumPhoto.ToString() + ".jpg";
                }
                
                string sql = $"INSERT INTO produit(pro_reference, pro_designation, pro_prixHT, pro_categorie , pro_gamme, pro_obsolete, pro_photo ) VALUES (@refProduit, @designationProduit, @prixHtProduit, @categorieProduit, @gammeProduit, @obsoleteProduit, @photoProduit);";
                
                command.CommandText = sql;
                command.Parameters.Clear();

                SqlParameter parm1 = new SqlParameter("@refProduit", SqlDbType.NVarChar, 50);
                parm1.Value = refProduit;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@designationProduit", SqlDbType.NVarChar, 100);
                parm2.Value = designationProduit;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@prixHtProduit", SqlDbType.Money);
                parm3.Value = prixHtProduit;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@photoProduit", SqlDbType.NVarChar, 50);
                parm4.Value = photoProduit;
                if (parm4.Value.ToString() == "")
                {
                    parm4.Value = DBNull.Value;
                }
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@categorieProduit", SqlDbType.Int);
                parm5.Value = categorieProduit;
                if (parm5.Value.ToString() == "0")
                {
                    parm5.Value = DBNull.Value;
                }
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@gammeProduit", SqlDbType.Int);
                parm6.Value = gammeProduit;
                if (parm6.Value.ToString() == "0")
                {
                    parm6.Value = DBNull.Value;
                }
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@obsoleteProduit", SqlDbType.Bit);
                parm7.Value = obsoleteProduit;
                command.Parameters.Add(parm7);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                if (pathPhotoProduit != "")
                {
                    File.Copy(pathPhotoProduit, Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\Resources\" + photoProduit), false);
                }

                transaction.Commit();

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);       

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    //On annule la transaction
                    transaction.Rollback();
                    
                    if (photoProduit != "")
                    {
                        File.Delete(Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\Resources\" + photoProduit));
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }

        /// <summary>
        /// Met à jour un produit existant dans la base, avec gestion optionnelle de photo.
        /// </summary>
        /// <param name="idProduit">ID du produit.</param>
        /// <param name="refProduit">Référence du produit.</param>
        /// <param name="designationProduit">Désignation du produit.</param>
        /// <param name="prixHtProduit">Prix HT du produit.</param>
        /// <param name="categorieProduit">ID de la catégorie (0 si aucune).</param>
        /// <param name="gammeProduit">ID de la gamme (0 si aucune).</param>
        /// <param name="obsoleteProduit">Indique si le produit est obsolète.</param>
        /// <param name="pathPhotoProduit">Chemin vers la photo du produit (vide si aucune).</param>
        public void UpdateProduit(string idProduit, string refProduit, string designationProduit, decimal prixHtProduit, string categorieProduit, string gammeProduit, bool obsoleteProduit, string pathPhotoProduit)
        {
            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();

            SqlDataReader reader = null;

            string photoProduit = "";

            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.Transaction = transaction;

                string sql = "";

                if (pathPhotoProduit != "") //On doit enregistrer une nouvelle photo
                {

                    string sqlMaxNumPhoto = "SELECT MAX(pro_photo) FROM produit;";
                    command.CommandText = sqlMaxNumPhoto;

                    long maxNumPhoto = 0;

                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            maxNumPhoto = long.Parse((reader.GetString(0)).Split('.')[0]);
                        }
                    }
                    reader.Close();
                    maxNumPhoto++;

                    photoProduit = maxNumPhoto.ToString() + ".jpg";

                    File.Copy(pathPhotoProduit, Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\Resources\" + photoProduit));

                    sql = $"UPDATE produit SET pro_reference = @refProduit, pro_designation = @designationProduit, pro_prixHT = @prixHtProduit, pro_categorie = @categorieProduit, pro_gamme = @gammeProduit, pro_obsolete = @obsoleteProduit, pro_photo = @photoProduit WHERE pro_id = @idProduit;";

                }
                else
                {
                    sql = $"UPDATE produit SET pro_reference = @refProduit, pro_designation = @designationProduit, pro_prixHT = @prixHtProduit, pro_categorie = @categorieProduit, pro_gamme = @gammeProduit, pro_obsolete = @obsoleteProduit WHERE pro_id = @idProduit;";          
                }

                command.CommandText = sql;
                command.Parameters.Clear();

                SqlParameter parm1 = new SqlParameter("@idProduit", SqlDbType.NVarChar, 50);
                parm1.Value = idProduit;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@refProduit", SqlDbType.NVarChar, 50);
                parm2.Value = refProduit;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@designationProduit", SqlDbType.NVarChar, 100);
                parm3.Value = designationProduit;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@prixHtProduit", SqlDbType.Money);
                parm4.Value = prixHtProduit;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@categorieProduit", SqlDbType.Int);
                parm5.Value = categorieProduit;
                if (parm5.Value.ToString() == "0")
                {
                    parm5.Value = DBNull.Value;
                }
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@gammeProduit", SqlDbType.Int);
                parm6.Value = gammeProduit;
                if (parm6.Value.ToString() == "0")
                {
                    parm6.Value = DBNull.Value;
                }
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@obsoleteProduit", SqlDbType.Bit);
                parm7.Value = obsoleteProduit;
                command.Parameters.Add(parm7);

                SqlParameter parm8 = new SqlParameter("@photoProduit", SqlDbType.NVarChar, 50);
                parm8.Value = photoProduit;
                if (parm8.Value.ToString() == "")
                {
                    parm8.Value = DBNull.Value;
                }
                command.Parameters.Add(parm8);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête      
               
                transaction.Commit();

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    //On annule la transaction
                    transaction.Rollback();

                    if (photoProduit != "")
                    {
                        File.Delete(Path.Combine(Directory.GetCurrentDirectory().ToString(), @"..\..\Resources\" + photoProduit));
                    }
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// Supprime un produit de la base de données et supprime son image associée.
        /// </summary>
        /// <param name="idProduit">ID du produit à supprimer.</param>
        /// <param name="imagePath">Chemin de l'image à supprimer.</param>
        public void DeleteProduit(int idProduit, string imagePath)
        {
            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {                
                string sql = "supprimerProduit";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.Transaction = transaction;

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@id_produit", SqlDbType.Int);
                parm1.Value = idProduit;
                parm1.Direction = ParameterDirection.Input;
                command.Parameters.Add(parm1);

                command.ExecuteNonQuery();

                MessageBox.Show("Données supprimées.", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                File.Delete(imagePath); //On supprime l'image

                transaction.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    //On annule la transaction
                    transaction.Rollback();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
