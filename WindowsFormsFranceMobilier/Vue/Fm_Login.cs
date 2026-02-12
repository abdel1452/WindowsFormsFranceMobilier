using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DotNetEnv;

namespace WindowsFormsFranceMobilier
{
    public partial class Fm_Login : Form
    {
        bool flagQuitter = true;

        public Fm_Login()
        {
            InitializeComponent();

            // Masquer les caractères du mot de passe
            tbPassword.PasswordChar = '*';

            // Charger le fichier .env
            Env.Load();
        }

        private void btConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                // 🔑 Récupérer les identifiants depuis le .env
                string host = Environment.GetEnvironmentVariable("DB_HOST"); // .
                string db = Environment.GetEnvironmentVariable("DB_NAME"); // FranceMobilier
                string user = Environment.GetEnvironmentVariable("DB_USER"); // sa
                string pass = Environment.GetEnvironmentVariable("DB_PASS"); // toto

                // 🔌 Construire la chaîne de connexion
                string connectionString = $"Server={host};Database={db};User Id={user};Password={pass};";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Tester la connexion

                    // Exemple de requête simple pour vérifier les utilisateurs
                    string req = "SELECT emp_id, emp_login, emp_password FROM employe";
                    SqlCommand command = new SqlCommand(req, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    bool connecte = false;
                    int empId = 0;

                    while (reader.Read())
                    {
                        string login = reader.GetString(reader.GetOrdinal("emp_login"));
                        string mdp = reader.GetString(reader.GetOrdinal("emp_password"));
                        int id = reader.GetInt32(reader.GetOrdinal("emp_id"));

                        // Ici tu peux remplacer par PasswordHelper.VerifyPassword si tu l’as
                        if (tbLogin.Text == login && tbPassword.Text == mdp)
                        {
                            connecte = true;
                            empId = id;
                            break;
                        }
                    }

                    reader.Close();

                    if (!connecte)
                    {
                        tbPassword.Clear();
                        MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Connexion réussie !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ici tu peux charger l'objet Employe et ouvrir le menu
                        // Exemple minimal :
                        // Program.employe = new Employe(empId, tbLogin.Text);
                        // Fm_Menu menu = new Fm_Menu();
                        // flagQuitter = false;
                        // menu.Show();
                        // Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'accès à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagQuitter)
                Application.Exit();
        }

        private void Fm_Login_Load(object sender, EventArgs e)
        {
            // vide pour l'instant
        }

    }
}
