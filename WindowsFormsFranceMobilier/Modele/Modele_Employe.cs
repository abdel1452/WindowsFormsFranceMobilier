using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe modèle pour gérer les employés et interagir avec la table "Employe" de la base de données.
    /// </summary>
    public class Modele_Employe
    {
        /// <summary>
        /// Liste des employés chargés depuis la base de données.
        /// </summary>
        private List<Employe> lesEmployes;

        /// <summary>
        /// Constructeur qui initialise la liste des employés.
        /// </summary>
        public Modele_Employe()
        {
            lesEmployes = new List<Employe>();
        }

        public void HasherMotsDePasseExistants()
    {
        try
        {
            string sqlSelect = "SELECT emp_id, emp_password FROM Employe;";
            SqlCommand commandSelect = new SqlCommand(sqlSelect, Program.maConnexion);

            SqlDataReader reader = commandSelect.ExecuteReader();

            List<(int id, string mdp)> employes = new List<(int, string)>();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string mdp = reader.GetString(1);
                employes.Add((id, mdp));
            }
            reader.Close();

            foreach (var e in employes)
            {
                // Vérifier si le mot de passe n'est pas déjà hashé
                if (!PasswordHelper.IsHashed(e.mdp))
                {
                    string mdpHash = PasswordHelper.HashPassword(e.mdp);
                    string sqlUpdate = "UPDATE Employe SET emp_password = @mdpHash WHERE emp_id = @id;";
                    SqlCommand commandUpdate = new SqlCommand(sqlUpdate, Program.maConnexion);
                    commandUpdate.Parameters.AddWithValue("@mdpHash", mdpHash);
                    commandUpdate.Parameters.AddWithValue("@id", e.id);
                    commandUpdate.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Mots de passe existants hashés avec succès.", "Migration terminée", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erreur lors du hash des mots de passe : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        /// <summary>
        /// Retourne la liste des employés d’un magasin spécifique.
        /// </summary>
        /// <param name="codeMagasin">Code du magasin. Si vide, renvoie tous les employés.</param>
        /// <returns>Liste des employés correspondant au filtre.</returns>
        public List<Employe> GetListe(string codeMagasin)
        {
            SqlDataReader reader = null;

            try
            {
                string sql; //requête SQL

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;

                SqlParameter parm0 = new SqlParameter("@codeMagasin", SqlDbType.Char, 3);
                parm0.Value = codeMagasin;
                command.Parameters.Add(parm0);

                if (codeMagasin != "")
                {
                    sql = $"SELECT * FROM Employe WHERE emp_magasin = @codeMagasin ORDER BY emp_id;";
                }
                else
                {
                    sql = $"SELECT * FROM Employe ORDER BY emp_id;";
                }
                
                command.CommandText = sql;

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        int indiceId = reader.GetOrdinal("emp_id");
                        int indiceNom = reader.GetOrdinal("emp_nom");
                        int indicePrenom = reader.GetOrdinal("emp_prenom");
                        int indiceMail = reader.GetOrdinal("emp_email");
                        int indiceTel = reader.GetOrdinal("emp_tel");
                        int indiceLogin = reader.GetOrdinal("emp_login");
                        int indicePassword = reader.GetOrdinal("emp_password");
                        int indiceFonction = reader.GetOrdinal("emp_fonction");
                        int indiceMagasin = reader.GetOrdinal("emp_magasin");

                        string mail = "";
                        if (!reader.IsDBNull(indiceMail))
                        {
                            mail = reader.GetString(indiceMail);
                        }

                        string tel = "";
                        if (!reader.IsDBNull(indiceTel))
                        {
                            tel = reader.GetString(indiceTel);
                        }

                        string magasin = "";
                        if (!reader.IsDBNull(indiceMagasin))
                        {
                            magasin = reader.GetString(indiceMagasin);
                        }

                        Employe unEmploye = new Employe(reader.GetInt32(indiceId), reader.GetString(indiceNom), reader.GetString(indicePrenom), mail, tel, reader.GetString(indiceLogin), reader.GetString(indicePassword), magasin, reader.GetString(indiceFonction));
                        lesEmployes.Add(unEmploye);
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
            return lesEmployes;
        }



        /// <summary>
        /// Retourne un employé spécifique selon son identifiant.
        /// </summary>
        /// <param name="idEmploye">Identifiant de l’employé.</param>
        /// <returns>L’employé correspondant ou null si non trouvé.</returns>
        public Employe GetEmploye(int idEmploye)
        {
            Employe unEmploye = null;
            SqlDataReader reader = null;

            try
            {
                string sql = $"Select * from Employe where emp_id = @idEmploye;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idEmploye", SqlDbType.Int);
                parm0.Value = idEmploye;
                command.Parameters.Add(parm0);

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int indiceId = reader.GetOrdinal("emp_id");
                        int indiceNom = reader.GetOrdinal("emp_nom");
                        int indicePrenom = reader.GetOrdinal("emp_prenom");
                        int indiceMail = reader.GetOrdinal("emp_email");
                        int indiceTel = reader.GetOrdinal("emp_tel");
                        int indiceLogin = reader.GetOrdinal("emp_login");
                        int indicePassword = reader.GetOrdinal("emp_password");
                        int indiceFonction = reader.GetOrdinal("emp_fonction");
                        int indiceMagasin = reader.GetOrdinal("emp_magasin");


                        string mail = "";
                        if (!reader.IsDBNull(indiceMail))
                        {
                            mail = reader.GetString(indiceMail);
                        } 

                        string tel = "";
                        if (!reader.IsDBNull(indiceTel))
                        {
                           tel = reader.GetString(indiceTel);
                        }

                        string magasin = "";
                        if (!reader.IsDBNull(indiceMagasin))
                        {
                            magasin = reader.GetString(indiceMagasin);
                        }


                        unEmploye = new Employe(reader.GetInt32(indiceId), reader.GetString(indiceNom), reader.GetString(indicePrenom), mail, tel, reader.GetString(indiceLogin), reader.GetString(indicePassword), magasin, reader.GetString(indiceFonction));
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
            return unEmploye;
        }


        /// <summary>
        /// Insère un nouvel employé dans la base de données.
        /// </summary>
        /// <param name="passwordEmploye">Mot de passe de l’employé</param>
        /// <param name="nomEmploye">Nom de l’employé</param>
        /// <param name="prenomEmploye">Prénom de l’employé</param>
        /// <param name="nomPrenomEmploye">Nom complet (nom + prénom)</param>
        /// <param name="emailEmploye">Email</param>
        /// <param name="telEmploye">Téléphone</param>
        /// <param name="magasinEmploye">Code du magasin</param>
        /// <param name="fonctionEmploye">Fonction de l’employé</param>
        public void InsertEmploye(string passwordEmploye, string nomEmploye, string prenomEmploye, string nomPrenomEmploye, string emailEmploye, string telEmploye, string magasinEmploye, string fonctionEmploye)
        {

            SqlConnection connection = Program.maConnexion;
            SqlTransaction transaction = connection.BeginTransaction();
            DbDataReader reader = null;

            try
            {
               
                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.Transaction = transaction;

                string sqlMaxIdEmlploye = "SELECT MAX(emp_id) FROM employe;";
                command.CommandText = sqlMaxIdEmlploye;

                int maxIdEmploye = 0;

                //DbDataReader reader = command.ExecuteReader();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        maxIdEmploye = reader.GetInt32(0);
                    }
                }
                reader.Close();
                maxIdEmploye++;


                string sql = $"INSERT INTO Employe(emp_login, emp_password, emp_nom, emp_prenom, emp_nomPrenom, emp_email, emp_tel, emp_magasin, emp_fonction) VALUES (@loginEmploye, @passwordEmploye, @nomEmploye, @prenomEmploye, @nomPrenomEmploye, @emailEmploye, @telEmploye, @magasinEmploye, @fonctionEmploye);";
                command.CommandText = sql;

                SqlParameter parm1 = new SqlParameter("@loginEmploye", SqlDbType.NVarChar, 25);
                string login;
                if (magasinEmploye == "0") //Direction sans affectation d'un magasin
                {
                    login = fonctionEmploye + maxIdEmploye;
                }
                else
                {
                    login = login = "fm_" + magasinEmploye + fonctionEmploye.Substring(2,3) + maxIdEmploye;
                }
                parm1.Value = login;  
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@passwordEmploye", SqlDbType.NVarChar, 255);
                string passwordHash = PasswordHelper.HashPassword(passwordEmploye);
                parm2.Value = passwordHash;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@nomEmploye", SqlDbType.NVarChar, 50);
                parm3.Value = nomEmploye;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@prenomEmploye", SqlDbType.NVarChar, 50);
                parm4.Value = prenomEmploye;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@nomPrenomEmploye", SqlDbType.NVarChar, 100);
                parm5.Value = nomPrenomEmploye;
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@emailEmploye", SqlDbType.NVarChar, 50);
                if (string.IsNullOrEmpty(emailEmploye.Trim()))
                {
                    parm6.Value = DBNull.Value;
                }
                else
                {
                    parm6.Value = emailEmploye;
                } 
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@telEmploye", SqlDbType.NVarChar, 50);
                if (string.IsNullOrEmpty(telEmploye.Trim()))
                {
                    parm7.Value = DBNull.Value;
                }
                else
                {
                    parm7.Value = telEmploye;
                }      
                command.Parameters.Add(parm7);

                SqlParameter parm8 = new SqlParameter("@magasinEmploye", SqlDbType.Char, 3);
                if (magasinEmploye == "0")
                {
                    parm8.Value = DBNull.Value;
                }
                else
                {
                    parm8.Value = magasinEmploye;
                }
                command.Parameters.Add(parm8);

                SqlParameter parm9 = new SqlParameter("@fonctionEmploye", SqlDbType.Char, 5);
                parm9.Value = fonctionEmploye;
                command.Parameters.Add(parm9);


                int result = command.ExecuteNonQuery(); // permet d'exécuter la requête
                transaction.Commit();

                MessageBox.Show("Données enregistrées.", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erreur. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                try
                {
                    transaction.Rollback();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du ROLLBACK. Type : " + exception.GetType() + "\n" + exception.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                reader.Close();
            }        
        }

        /// <summary>
        /// Met à jour les informations d’un employé existant.
        /// </summary>
        /// <param name="idEmploye">Identifiant de l’employé</param>
        /// <param name="loginEmploye">Login de l’employé</param>
        /// <param name="passwordEmploye">Mot de passe</param>
        /// <param name="nomEmploye">Nom</param>
        /// <param name="prenomEmploye">Prénom</param>
        /// <param name="nomPrenomEmploye">Nom complet</param>
        /// <param name="emailEmploye">Email</param>
        /// <param name="telEmploye">Téléphone</param>
        /// <param name="magasinEmploye">Code magasin</param>
        /// <param name="fonctionEmploye">Fonction</param>
        public void UpdateEmploye(int idEmploye, string loginEmploye, string passwordEmploye, string nomEmploye, string prenomEmploye, string nomPrenomEmploye, string emailEmploye, string telEmploye, string magasinEmploye, string fonctionEmploye )
        {

            if (telEmploye == "")
            {
                telEmploye = "NULL";
            }

            try
            {
                string sql = $"UPDATE Employe SET emp_login = @loginEmploye, emp_password = @passwordEmploye, emp_nom  = @nomEmploye, emp_prenom = @prenomEmploye, emp_nomPrenom = @nomPrenomEmploye, emp_email = @emailEmploye, emp_tel = @telEmploye, emp_magasin = @magasinEmploye, emp_fonction = @fonctionEmploye WHERE emp_id = @idEmploye;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idEmploye", SqlDbType.Int);
                parm0.Value = idEmploye;
                command.Parameters.Add(parm0);

                SqlParameter parm1 = new SqlParameter("@loginEmploye", SqlDbType.NVarChar, 25);
                parm1.Value = loginEmploye;
                command.Parameters.Add(parm1);

                SqlParameter parm2 = new SqlParameter("@passwordEmploye", SqlDbType.NVarChar, 255);
                string passwordHash = PasswordHelper.HashPassword(passwordEmploye);
                parm2.Value = passwordHash;
                command.Parameters.Add(parm2);

                SqlParameter parm3 = new SqlParameter("@nomEmploye", SqlDbType.NVarChar, 50);
                parm3.Value = nomEmploye;
                command.Parameters.Add(parm3);

                SqlParameter parm4 = new SqlParameter("@prenomEmploye", SqlDbType.NVarChar, 50);
                parm4.Value = prenomEmploye;
                command.Parameters.Add(parm4);

                SqlParameter parm5 = new SqlParameter("@nomPrenomEmploye", SqlDbType.NVarChar, 100);
                parm5.Value = nomPrenomEmploye;
                command.Parameters.Add(parm5);

                SqlParameter parm6 = new SqlParameter("@emailEmploye", SqlDbType.NVarChar, 50);
                if (string.IsNullOrEmpty(emailEmploye.Trim()))
                {
                    parm6.Value = DBNull.Value;
                }
                else
                {
                    parm6.Value = emailEmploye;
                }
                command.Parameters.Add(parm6);

                SqlParameter parm7 = new SqlParameter("@telEmploye", SqlDbType.NVarChar, 50);
                if (string.IsNullOrEmpty(telEmploye.Trim()))
                {
                    parm7.Value = DBNull.Value;
                }
                else
                {
                    parm7.Value = telEmploye;
                }
                command.Parameters.Add(parm7);

                SqlParameter parm8 = new SqlParameter("@magasinEmploye", SqlDbType.Char, 3);
                if (magasinEmploye == "0")
                {
                    parm8.Value = DBNull.Value;
                }
                else
                {
                    parm8.Value = magasinEmploye;
                }
                command.Parameters.Add(parm8);

                SqlParameter parm9 = new SqlParameter("@fonctionEmploye", SqlDbType.Char, 5);
                parm9.Value = fonctionEmploye;
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
        /// Supprime un employé de la base de données.
        /// </summary>
        /// <param name="idEmploye">Identifiant de l’employé à supprimer</param>
        public void DeleteEmploye(int idEmploye)
        {
            try
            {
                string sql = $"DELETE FROM employe WHERE emp_id = @idEmploye;";

                SqlCommand command = new SqlCommand();
                command.Connection = Program.maConnexion;
                command.CommandText = sql;

                SqlParameter parm0 = new SqlParameter("@idEmploye", SqlDbType.Int);
                parm0.Value = idEmploye;
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
