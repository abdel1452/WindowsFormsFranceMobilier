using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour accéder et gérer les clients dans la base de données.
    /// Permet de récupérer, insérer, modifier et supprimer des enregistrements dans la table "Client".
    /// </summary>
    public class Modele_Client
    {
        /// <summary>
        /// Liste des clients récupérés depuis la base de données.
        /// </summary>
        private List<Client> lesClients;

        /// <summary>
        /// Initialise une nouvelle instance de la classe Modele_Client.
        /// </summary>
        public Modele_Client()
        {
            lesClients = new List<Client>();
        }

        /// <summary>
        /// Récupère la liste des clients correspondant à un nom et/ou numéro client partiel.
        /// </summary>
        /// <param name="unNom">Nom ou partie du nom du client à rechercher (vide = tous)</param>
        /// <param name="unNumClient">Numéro ou partie du numéro du client à rechercher (vide = tous)</param>
        /// <returns>Liste des objets Client correspondant aux critères</returns>
        public List<Client> GetListe(string unNom, string unNumClient)
        {
            SqlDataReader reader = null;

            try
            {
                string sql; //requête SQL

                sql = "SELECT * FROM client WHERE cli_nom LIKE @nom  ";

                if (unNumClient != "")
                {
                    sql = sql + "AND cli_id LIKE @idCli ";
                }


                sql = sql + "ORDER BY cli_nom, cli_prenom;";


                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;

                SqlParameter parm0 = new SqlParameter("@nom", SqlDbType.NVarChar, 50);
                if (unNom != "")
                {
                    parm0.Value = "%" + unNom + "%";
                }
                else
                {
                    parm0.Value = "%";
                }    
                command.Parameters.Add(parm0);

                if (unNumClient != "")
                {
                    SqlParameter parm1 = new SqlParameter("@idCli", SqlDbType.NVarChar, 50);
                    parm1.Value = "%" + unNumClient + "%";
                    command.Parameters.Add(parm1);
                }
  

                command.CommandText = sql;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceId = reader.GetOrdinal("cli_id");
                        int indiceNom = reader.GetOrdinal("cli_nom");
                        int indicePrenom = reader.GetOrdinal("cli_prenom");
                        int indiceAdresse1 = reader.GetOrdinal("cli_adr1");
                        int indiceAdresse2 = reader.GetOrdinal("cli_adr2");
                        int indiceCpVille = reader.GetOrdinal("cli_cpVille");
                        int indiceTelFixe = reader.GetOrdinal("cli_telFixe");
                        int indiceTelPortable = reader.GetOrdinal("cli_telPortable");
                        int indiceMail = reader.GetOrdinal("cli_email");
 
                        string adresse2 = "";
                        if (!reader.IsDBNull(indiceAdresse2))
                        {
                            adresse2 = reader.GetString(indiceAdresse2);
                        }

                        string telFixe = "";
                        if (!reader.IsDBNull(indiceTelFixe))
                        {
                            telFixe = reader.GetString(indiceTelFixe);
                        }

                        string telPortable = "";
                        if (!reader.IsDBNull(indiceTelPortable))
                        {
                            telFixe = reader.GetString(indiceTelPortable);
                        }

                        string email = "";
                        if (!reader.IsDBNull(indiceMail))
                        {
                            telFixe = reader.GetString(indiceMail);
                        }

                        Client unClient = new Client(reader.GetInt32(indiceId), reader.GetString(indiceNom), reader.GetString(indicePrenom), email, reader.GetString(indiceAdresse1), adresse2,  reader.GetString(indiceCpVille), telFixe, telPortable);
                        lesClients.Add(unClient);
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
            return lesClients;
        }

        /// <summary>
        /// Récupère un client spécifique à partir de son identifiant.
        /// </summary>
        /// <param name="idClient">Identifiant du client</param>
        /// <returns>Objet Client correspondant ou null si non trouvé</returns>
        public Client GetClient(int idClient)
        {
            Client leClient = null;
            SqlDataReader reader = null;

            try
            {            
                string sql = $"SELECT * FROM Client WHERE cli_id = @idClient;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;

                SqlParameter parm0 = new SqlParameter("@idClient", SqlDbType.Int);
                parm0.Value = idClient;
                command.Parameters.Add(parm0);
                
                command.CommandText = sql;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceId = reader.GetOrdinal("cli_id");
                        int indiceNom = reader.GetOrdinal("cli_nom");
                        int indicePrenom = reader.GetOrdinal("cli_prenom");
                        int indiceAdresse1 = reader.GetOrdinal("cli_adr1");
                        int indiceAdresse2 = reader.GetOrdinal("cli_adr2");
                        int indiceCpVille = reader.GetOrdinal("cli_cpVille");
                        int indiceTelFixe = reader.GetOrdinal("cli_telFixe");
                        int indiceTelPortable = reader.GetOrdinal("cli_email");
                        int indiceMail = reader.GetOrdinal("cli_email");

                        string adresse2 = "";
                        if (!reader.IsDBNull(indiceAdresse2))
                        {
                            adresse2 = reader.GetString(indiceAdresse2);
                        }

                        string telFixe = "";
                        if (!reader.IsDBNull(indiceTelFixe))
                        {
                            telFixe = reader.GetString(indiceTelFixe);
                        }

                        string telPortable = "";
                        if (!reader.IsDBNull(indiceTelPortable))
                        {
                            telPortable = reader.GetString(indiceTelPortable);
                        }

                        string email = "";
                        if (!reader.IsDBNull(indiceMail))
                        {
                            email = reader.GetString(indiceMail);
                        }

                        leClient = new Client(reader.GetInt32(indiceId), reader.GetString(indiceNom), reader.GetString(indicePrenom), email, reader.GetString(indiceAdresse1), adresse2, reader.GetString(indiceCpVille), telFixe, telPortable);
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
            return leClient;
        }


        /// <summary>
        /// Insère un nouveau client dans la base de données.
        /// </summary>
        /// <param name="nomClient">Nom du client.</param>
        /// <param name="prenomClient">Prénom du client.</param>
        /// <param name="adresse1Client">Adresse principale du client.</param>
        /// <param name="adresse2Client">Adresse secondaire du client (facultative).</param>
        /// <param name="codePostalVilleClient">Code postal et ville du client.</param>
        /// <param name="telFixeClient">Numéro de téléphone fixe (facultatif).</param>
        /// <param name="telPortableClient">Numéro de téléphone portable (facultatif).</param>
        /// <param name="mailClient">Adresse e-mail du client (facultative).</param>
        /// <remarks>
        /// Cette méthode prépare une requête SQL paramétrée pour insérer un nouveau client dans la table "Client".
        /// Les champs facultatifs (téléphones, e-mail) sont insérés comme NULL si les chaînes sont vides.
        /// En cas d'erreur lors de l'exécution, un message d'erreur est affiché via MessageBox.
        /// </remarks>
        public void InsertClient(string nomClient, string prenomClient, string adresse1Client, string adresse2Client, string codePostalVilleClient, string telFixeClient, string telPortableClient, string mailClient)
        {
            
            SqlDataReader reader = null;

            try
            {
                SqlConnection connection = Program.maConnexion;
                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
               
                string sql = $"INSERT INTO client(cli_nom, cli_prenom, cli_adr1, cli_adr2, cli_cpVille, cli_telFixe, cli_telPortable, cli_email) VALUES (@nomClient, @prenomClient, @adresse1Client, @adresse2Client, @codePostalVilleClient, @telFixeClient, @telPortableClient, @mailClient);";
                command.CommandText = sql;

                SqlParameter parm2 = new SqlParameter("@nomClient", SqlDbType.NVarChar, 50);
                parm2.Value = nomClient;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@prenomClient", SqlDbType.NVarChar, 50);
                parm3.Value = prenomClient;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@adresse1Client", SqlDbType.NVarChar, 100);
                parm4.Value = adresse1Client;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@adresse2Client", SqlDbType.NVarChar, 100);
                parm5.Value = adresse2Client;
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@codePostalVilleClient", SqlDbType.NVarChar, 100);
                parm6.Value = codePostalVilleClient;
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@telFixeClient", SqlDbType.NVarChar, 50);
                parm7.Value = telFixeClient;
                if (parm7.Value.ToString() == "")
                {
                    parm7.Value = DBNull.Value;
                }      
                command.Parameters.Add(parm7);

                SqlParameter parm8 = new SqlParameter("@telPortableClient", SqlDbType.NVarChar, 50);
                parm8.Value = telPortableClient;
                if (parm8.Value.ToString() == "")
                {
                    parm8.Value = DBNull.Value;
                }
                command.Parameters.Add(parm8);

                SqlParameter parm9 = new SqlParameter("@mailClient", SqlDbType.NVarChar, 100);
                parm9.Value = mailClient;
                if (parm9.Value.ToString() == "")
                {
                    parm9.Value = DBNull.Value;
                }
                command.Parameters.Add(parm9);

                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Met à jour les informations d’un client existant dans la base de données.
        /// </summary>
        /// <param name="idClient">Identifiant du client à mettre à jour.</param>
        /// <param name="nomClient">Nom du client.</param>
        /// <param name="prenomClient">Prénom du client.</param>
        /// <param name="adresse1Client">Adresse principale du client.</param>
        /// <param name="adresse2Client">Adresse secondaire du client (facultative).</param>
        /// <param name="codePostalVilleClient">Code postal et ville du client.</param>
        /// <param name="telFixeClient">Numéro de téléphone fixe (facultatif).</param>
        /// <param name="telPortableClient">Numéro de téléphone portable (facultatif).</param>
        /// <param name="mailClient">Adresse e-mail du client (facultative).</param>
        /// <remarks>
        /// Cette méthode met à jour les informations d'un client existant à partir de son identifiant.
        /// Les champs facultatifs (téléphones, e-mail) sont mis à jour en NULL si les chaînes sont vides.
        /// La méthode utilise une requête SQL paramétrée pour éviter les injections SQL.
        /// En cas de succès, un message de confirmation est affiché ; en cas d'erreur, un message d'erreur est affiché.
        /// </remarks>
        public void UpdateCLient(int idClient, string nomClient, string prenomClient, string adresse1Client, string adresse2Client, string codePostalVilleClient, string telFixeClient, string telPortableClient, string mailClient)
        {
            try
            {
                string sql = $"UPDATE Client SET cli_nom = @nomClient, cli_prenom = @prenomClient, cli_adr1 = @adresse1Client, cli_adr2 = @adresse2Client, cli_cpVille = @codePostalVilleClient, cli_telFixe = @telFixeClient, cli_telPortable = @telPortableClient, cli_email = @mailClient WHERE cli_id = @idClient;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@idClient", SqlDbType.Int);
                parm1.Value = idClient;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@nomClient", SqlDbType.NVarChar, 50);
                parm2.Value = nomClient;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@prenomClient", SqlDbType.NVarChar, 50);
                parm3.Value = prenomClient;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@adresse1Client", SqlDbType.NVarChar, 100);
                parm4.Value = adresse1Client;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@adresse2Client", SqlDbType.NVarChar, 100);
                parm5.Value = adresse2Client;
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@codePostalVilleClient", SqlDbType.NVarChar, 100);
                parm6.Value = codePostalVilleClient;
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@telFixeClient", SqlDbType.NVarChar, 50);
                parm7.Value = telFixeClient;
                if (parm7.Value.ToString() == "")
                {
                    parm7.Value = DBNull.Value;
                }
                command.Parameters.Add(parm7);

                SqlParameter parm8 = new SqlParameter("@telPortableClient", SqlDbType.NVarChar, 50);
                parm8.Value = telPortableClient;
                if (parm8.Value.ToString() == "")
                {
                    parm8.Value = DBNull.Value;
                }
                command.Parameters.Add(parm8);

                SqlParameter parm9 = new SqlParameter("@mailClient", SqlDbType.NVarChar, 100);
                parm9.Value = mailClient;
                if (parm9.Value.ToString() == "")
                {
                    parm9.Value = DBNull.Value;
                }
                command.Parameters.Add(parm9);

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
        /// Supprime un client existant de la base de données.
        /// </summary>
        /// <param name="idClient">Identifiant du client à supprimer</param>
        public void DeleteClient(int idClient)
        {
            try
            {
                string sql = $"DELETE FROM client WHERE cli_id = @idClient; ";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idClient", SqlDbType.Int);
                parm0.Value = idClient;
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
