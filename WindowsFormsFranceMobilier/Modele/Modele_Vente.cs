using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour gérer les ventes dans l'application.
    /// Fournit des méthodes pour récupérer, insérer, mettre à jour les ventes et gérer les lignes de vente.
    /// </summary>
    public class Modele_Vente
    {
        /// <summary>
        /// Liste interne des ventes.
        /// </summary>
        private List<Vente> lesVentes;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Modele_Vente.
        /// </summary>
        public Modele_Vente()
        {
            lesVentes = new List<Vente>();
        }

        /// <summary>
        /// Récupère la liste des ventes d'un client spécifique.
        /// Chaque vente contient également sa liste de lignes de vente.
        /// </summary>
        /// <param name="idClient">Identifiant du client.</param>
        /// <returns>Liste des ventes pour le client.</returns>
        public List<Vente> GetListe(int idClient)
        {
            List<Vente> lesVentes = new List<Vente>();
            SqlDataReader reader = null;

            SqlCommand command = new SqlCommand();
            command.Connection = Program.maConnexion;

            try
            {
                string sql; //requête SQL

                sql = $"SELECT * FROM Vente WHERE ven_client = @idClient ORDER BY ven_dateCommande DESC, ven_id DESC ;";

                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idClient", SqlDbType.Int);
                parm0.Value = idClient;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceIdVente = reader.GetOrdinal("ven_id");
                        int indiceNumFacture = reader.GetOrdinal("ven_numeroFacture");
                        int indiceDateCommande = reader.GetOrdinal("ven_dateCommande");
                        int indiceDateFacture = reader.GetOrdinal("ven_dateFacture");
                        int indiceTauxTva = reader.GetOrdinal("ven_tauxTva");
                        int indiceIdClient = reader.GetOrdinal("ven_client");
                        int indiceIdEmploye = reader.GetOrdinal("ven_employe");
                        int indiceMagasin = reader.GetOrdinal("ven_magasin");


                        Nullable<int> numFacture = null;
                        if (!reader.IsDBNull(indiceNumFacture))
                        {
                            numFacture = reader.GetInt32(indiceNumFacture);
                        }

                        Nullable<DateTime> dateFacture = null;
                        if (!reader.IsDBNull(indiceDateFacture))
                        {
                            dateFacture = reader.GetDateTime(indiceDateFacture);
                        }


                        Vente uneVente = new Vente(reader.GetInt32(indiceIdVente), numFacture, reader.GetDateTime(indiceDateCommande), dateFacture, reader.GetDecimal(indiceTauxTva), reader.GetInt32(indiceIdClient), reader.GetInt32(indiceIdEmploye), reader.GetString(indiceMagasin), null);
                        lesVentes.Add(uneVente);          
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

            try
            {
                foreach (Vente uneVente in lesVentes)
                {
                    List<Contenir> lesLignesVente = new List<Contenir>();

                    string sql = $"SELECT * FROM contenir WHERE con_vente = @idVente ORDER BY con_vente;";

                    command.CommandText = sql;
                    command.Parameters.Clear();

                    SqlParameter parm1 = new SqlParameter("@idVente", SqlDbType.Int);
                    parm1.Value = uneVente.GetIdVente();
                    command.Parameters.Add(parm1);

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int indiceIdVenteLigne = reader.GetOrdinal("con_vente");
                            int indiceIdProduit = reader.GetOrdinal("con_produit");
                            int indiceQuantiteVendue = reader.GetOrdinal("con_qteVendue");
                            int indiceQuantiteRetiree = reader.GetOrdinal("con_qteRetiree");
                            int indicePrixUnitaireHt = reader.GetOrdinal("con_prixHT");               

                            Contenir uneLigneVente = new Contenir(reader.GetInt32(indiceIdVenteLigne), reader.GetInt32(indiceIdProduit), reader.GetInt32(indiceQuantiteVendue), reader.GetInt32(indiceQuantiteRetiree), reader.GetDecimal(indicePrixUnitaireHt));
                            lesLignesVente.Add(uneLigneVente);
                            
                        }
                    }
                    reader.Close();
                    uneVente.SetListeLigneVente(lesLignesVente);
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
            return lesVentes;
        }


        /// <summary>
        /// Récupère une vente spécifique par son identifiant.
        /// Inclut également les lignes de vente associées.
        /// </summary>
        /// <param name="idVente">Identifiant de la vente.</param>
        /// <returns>L'objet de type Vente correspondant ou null si non trouvé.</returns>
        public Vente GetVente(Nullable<int> idVente)
        {
            Vente uneVente = null;
            SqlDataReader reader = null;

            SqlCommand command = new SqlCommand();
            command.Connection = Program.maConnexion;

            try
            {
                string sql; //requête SQL

                sql = $"SELECT * FROM Vente WHERE ven_id = @idVente;";

                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@idVente", SqlDbType.Int);
                parm1.Value = idVente;
                command.Parameters.Add(parm1);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceIdVente = reader.GetOrdinal("ven_id");
                        int indiceNumFacture = reader.GetOrdinal("ven_numeroFacture");
                        int indiceDateCommande = reader.GetOrdinal("ven_dateCommande");
                        int indiceDateFacture = reader.GetOrdinal("ven_dateFacture");
                        int indiceTauxTva = reader.GetOrdinal("ven_tauxTva");
                        int indiceIdClient = reader.GetOrdinal("ven_client");
                        int indiceIdEmploye = reader.GetOrdinal("ven_employe");
                        int indiceMagasin = reader.GetOrdinal("ven_magasin");


                        Nullable<int> numFacture = null;
                        if (!reader.IsDBNull(indiceNumFacture))
                        {
                            numFacture = reader.GetInt32(indiceNumFacture);
                        }

                        Nullable<DateTime> dateFacture = null;
                        if (!reader.IsDBNull(indiceDateFacture))
                        {
                            dateFacture = reader.GetDateTime(indiceDateFacture);
                        }

                        uneVente = new Vente(reader.GetInt32(indiceIdVente), numFacture, reader.GetDateTime(indiceDateCommande), dateFacture, reader.GetDecimal(indiceTauxTva), reader.GetInt32(indiceIdClient), reader.GetInt32(indiceIdEmploye), reader.GetString(indiceMagasin), null);
                        
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

            try
            {
                List<Contenir> lesLignesVente = new List<Contenir>();

                string sql = $"SELECT * FROM contenir WHERE con_vente = @idVente ORDER BY con_vente;";

                command.CommandText = sql;
                command.Parameters.Clear();

                SqlParameter parm1 = new SqlParameter("@idVente", SqlDbType.Int);
                parm1.Value = uneVente.GetIdVente();
                command.Parameters.Add(parm1);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceIdVenteLigne = reader.GetOrdinal("con_vente");
                        int indiceIdProduit = reader.GetOrdinal("con_produit");
                        int indiceQuantiteVendue = reader.GetOrdinal("con_qteVendue");
                        int indiceQuantiteRetiree = reader.GetOrdinal("con_qteRetiree");
                        int indicePrixUnitaireHt = reader.GetOrdinal("con_prixHT");

                        Contenir uneLigneVente = new Contenir(reader.GetInt32(indiceIdVenteLigne), reader.GetInt32(indiceIdProduit), reader.GetInt32(indiceQuantiteVendue), reader.GetInt32(indiceQuantiteRetiree), reader.GetDecimal(indicePrixUnitaireHt));
                        lesLignesVente.Add(uneLigneVente);

                    }
                }
                uneVente.SetListeLigneVente(lesLignesVente);

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
            return uneVente;
        }

        /// <summary>
        /// Insère une nouvelle vente dans la base de données avec ses lignes.
        /// La méthode utilise une transaction pour assurer la cohérence des données.
        /// </summary>
        /// <param name="numFacture">Numéro de facture (nullable).</param>
        /// <param name="dateCommande">Date de commande au format chaîne (yyyy-MM-dd).</param>
        /// <param name="dateFacture">Date de facturation au format chaîne ou "NULL".</param>
        /// <param name="tauxTva">Taux de TVA appliqué.</param>
        /// <param name="idClient">Identifiant du client.</param>
        /// <param name="idVendeur">Identifiant de l'employé ayant réalisé la vente.</param>
        /// <param name="codeMagasin">Code du magasin.</param>
        /// <param name="lesProduits">Liste des produits vendus</param>
        /// <returns>Identifiant de la vente insérée.</returns>
        public decimal InsertVente(Nullable<int> numFacture, string dateCommande, string dateFacture, string tauxTva, int idClient, int idVendeur, string codeMagasin, List<Contenir> lesProduits)
        {
            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = Program.maConnexion;
            command.Transaction = transaction;

            DbDataReader reader = null;

            decimal lastInsertId = 0;

            try
            {
                string sql;
               
                sql = $"INSERT INTO Vente(ven_numeroFacture, ven_dateCommande, ven_dateFacture, ven_tauxTva, ven_client, ven_employe, ven_magasin) VALUES (@numFacture, @dateCommande, @dateFacture, @tauxTva, @idClient,  @idVendeur, @codeMagasin );";
            
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@numFacture", SqlDbType.Int);
                if (numFacture == null)
                {
                    parm1.Value = DBNull.Value;
                }
                else
                {
                    parm1.Value = numFacture;
                }
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@dateCommande", SqlDbType.Date);
                DateTime dateCommandeSql = DateTime.Parse(dateCommande);
                parm2.Value = dateCommandeSql;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@dateFacture", SqlDbType.Date);

                if (dateFacture == "NULL")
                {
                    parm3.Value = DBNull.Value;
                }
                else
                {
                    DateTime dateFactureSql = DateTime.Parse(dateFacture);
                    parm3.Value = dateFactureSql;
                }
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@tauxTva", SqlDbType.Decimal);       
                parm4.Precision = 18;
                parm4.Scale = 2;
                parm4.Value = tauxTva;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@idClient", SqlDbType.Int);
                parm5.Value = idClient;
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@idVendeur", SqlDbType.Int);
                parm6.Value = idVendeur;
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@codeMagasin", SqlDbType.Char, 3);
                parm7.Value = codeMagasin;
                command.Parameters.Add(parm7);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                string sqlLastInsertid = "SELECT IDENT_CURRENT('vente');";
                command.CommandText = sqlLastInsertid;


                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lastInsertId = reader.GetDecimal(0);
                    }
                }
                reader.Close();

                foreach (Contenir uneLigneVente in lesProduits)
                {
                    string prixUnitaireHt = (uneLigneVente.GetPrixUnitaireHt().ToString()).Replace(',', '.'); //le séparateur décimal utilisé par SQLServer est le point

                    string sqlLigne = $"INSERT INTO contenir (con_vente, con_produit, con_qteVendue, con_qteRetiree, con_prixHT) VALUES (@lastInsertId, @idProduit, @quantiteVendue, @quantiteRetiree, @prixUnitaireHt );";
                    command.CommandText = sqlLigne;

                    command.Parameters.Clear();

                    SqlParameter parm8 = new SqlParameter("@lastInsertId", SqlDbType.Int);
                    parm8.Value = lastInsertId;
                    command.Parameters.Add(parm8);

                    SqlParameter parm9 = new SqlParameter("@idProduit", SqlDbType.Int);
                    parm9.Value = uneLigneVente.GetIdProduit();
                    command.Parameters.Add(parm9);

                    SqlParameter parm10 = new SqlParameter("@quantiteVendue", SqlDbType.Int);
                    parm10.Value = uneLigneVente.GetQuantiteVendue();
                    command.Parameters.Add(parm10);

                    SqlParameter parm11 = new SqlParameter("@quantiteRetiree", SqlDbType.Int);
                    parm11.Value = uneLigneVente.GetQuantiteRetiree();
                    command.Parameters.Add(parm11);

                    SqlParameter parm12 = new SqlParameter("@prixUnitaireHt", SqlDbType.Decimal);
                    parm12.Precision = 18;
                    parm12.Scale = 2;
                    parm12.Value = prixUnitaireHt;
                    command.Parameters.Add(parm12);
                    
                    command.ExecuteNonQuery();
                }

                transaction.Commit();           

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur lors du COMMIT. Type : " + exception.GetType() +  "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return lastInsertId;
        }

        /// <summary>
        /// Met à jour une vente existante et ses lignes.
        /// Supprime d'abord les lignes existantes avant d'insérer les nouvelles.
        /// </summary>
        /// <param name="numVente">Identifiant de la vente.</param>
        /// <param name="numFacture">Numéro de facture (nullable).</param>
        /// <param name="dateFacture">Date de facturation au format chaîne ou null.</param>
        /// <param name="lesProduits">Nouvelle liste de lignes de vente</param>
        public void UpdateVente(int numVente, Nullable<int> numFacture, string dateFacture, List<Contenir> lesProduits)
        {

            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = Program.maConnexion;
            command.Transaction = transaction;

            try
            {
                string sql;
               
                sql = $"UPDATE Vente SET ven_numeroFacture = @numFacture, ven_dateFacture = @dateFacture  WHERE ven_id = @numVente;";
       
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@numVente", SqlDbType.Int);
                parm0.Value = numVente;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@numFacture", SqlDbType.Int);
                if (numFacture == null) 
                {
                    parm1.Value = DBNull.Value;
                }
                else
                {
                    parm1.Value = numFacture;
                }
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@dateFacture", SqlDbType.Date);
                if (dateFacture == null)
                {
                    parm2.Value = DBNull.Value;
                }
                else
                {
                    DateTime dateFactureSql = DateTime.Parse(dateFacture);
                   
                    parm2.Value = dateFactureSql;
                }
                command.Parameters.Add(parm2);
           

                command.ExecuteNonQuery(); // permet d'exécuter la requête


                string sqlDelete = $"DELETE fROM contenir WHERE con_vente = @numVenteDel;";

                command.CommandText = sqlDelete;

                command.Parameters.Clear();

                SqlParameter parm3 = new SqlParameter("@numVenteDel", SqlDbType.Int);
                parm3.Value = numVente;
                command.Parameters.Add(parm3); //ajout du paramètre @numVenteDel

                command.ExecuteNonQuery(); // permet d'exécuter la requête


                foreach (Contenir uneLigneVente in lesProduits)
                {
                    string prixUnitaireHt = (uneLigneVente.GetPrixUnitaireHt().ToString()).Replace(',', '.'); //le séparateur décimal utilisé par SQLServer est le point

                    string sqlLigne = $"INSERT INTO contenir (con_vente, con_produit, con_qteVendue, con_qteRetiree, con_prixHT) VALUES (@numVente, @idProduit, @quantiteVendue, @quantiteRetiree, @prixUnitaireHt );";
                   
                    command.CommandText = sqlLigne;

                    command.Parameters.Clear();

                    SqlParameter parm4 = new SqlParameter("@numVente", SqlDbType.Int);
                    parm4.Value = numVente;
                    command.Parameters.Add(parm4); //ajout du paramètre @numVenteDel

                    SqlParameter parm5 = new SqlParameter("@idProduit", SqlDbType.Int);
                    parm5.Value = uneLigneVente.GetIdProduit();
                    command.Parameters.Add(parm5);

                    SqlParameter parm6 = new SqlParameter("@quantiteVendue", SqlDbType.Int);
                    parm6.Value = uneLigneVente.GetQuantiteVendue();
                    command.Parameters.Add(parm6);

                    SqlParameter parm7 = new SqlParameter("@quantiteRetiree", SqlDbType.Int);
                    parm7.Value = uneLigneVente.GetQuantiteRetiree();
                    command.Parameters.Add(parm7);

                    SqlParameter parm8 = new SqlParameter("@prixUnitaireHt", SqlDbType.Decimal);
                    parm8.Precision = 18;
                    parm8.Scale = 2;
                    parm8.Value = prixUnitaireHt;
                    command.Parameters.Add(parm8);

                    command.ExecuteNonQuery();
                }

                transaction.Commit();

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur lors du COMMIT. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                     transaction.Rollback();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

         }

        /// <summary>
        /// Génère et récupère le numéro de facture pour une vente via une procédure stockée.
        /// </summary>
        public string GetNumfacture(int idVente)
        {
            string numFacture = "0";

            try
            {
                string sql = "facturerVente";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@id_ven", SqlDbType.Int);
                parm1.Value = idVente;
                parm1.Direction = ParameterDirection.Input;
                command.Parameters.Add(parm1);


                SqlParameter parm2 = new SqlParameter("@numeroFacture", SqlDbType.Int);
                parm2.Direction = ParameterDirection.Output;
                command.Parameters.Add(parm2);

                command.ExecuteNonQuery();

                numFacture = parm2.Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur d'accès à la base de données.\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
            return numFacture;
        }
    }
}
