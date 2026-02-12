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

            // Charger le fichier .env (il doit être à la racine du projet)
            Env.Load();
        }

        private void btConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                bool connecte = false;
                

                // 🔑 Récupérer les identifiants depuis le .env
                string host = Environment.GetEnvironmentVariable("DB_HOST");
                string db = Environment.GetEnvironmentVariable("DB_NAME");   
                string user = Environment.GetEnvironmentVariable("DB_USER");
                string pass = Environment.GetEnvironmentVariable("DB_PASS"); 

                // 🔌 Chaîne de connexion initiale
                string connectionString = $"Server={host};Database={db};User Id={user};Password={pass};";

                Program.maConnexion = ConnexionBdd.GetDBConnection(connectionString);
                Program.maConnexion.Open();

                string req = "SELECT emp_id, emp_login, emp_password FROM employe";
                SqlCommand command = new SqlCommand(req, Program.maConnexion);
                SqlDataReader reader = command.ExecuteReader();

                // 🔹 Vérifier le login
                while (reader.Read())
                {
                    string login = reader.GetString(reader.GetOrdinal("emp_login"));
                    string mdp = reader.GetString(reader.GetOrdinal("emp_password"));
                    int id = reader.GetInt32(reader.GetOrdinal("emp_id"));

                    // Vérification du mot de passe hashé si tu utilises PasswordHelper
                    if (tbLogin.Text == login && PasswordHelper.VerifyPassword(tbPassword.Text, mdp))
                    {
                        connecte = true;
                        empId = id;
                        break;
                    }
                }

                // 🔹 Toujours fermer le reader après la boucle
                reader.Close();

                if (!connecte)
                {
                    tbPassword.Clear();
                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 🔹 Connexion avec rôle de l'employé
                Program.employe = new Modele_Employe().GetEmploye(empId);
                Program.maConnexion.Close();

                string roleUser = Program.employe.GetFonction();
                string roleConnectionString = $"Server={host};Database={db};User Id={roleUser};Password={pass};";

                Program.maConnexion = ConnexionBdd.GetDBConnection(roleConnectionString);
                Program.maConnexion.Open();

                // 🔹 Ouvrir le menu principal
                Fm_Menu menu = new Fm_Menu();
                flagQuitter = false;
                menu.Show();
                Close();
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
            // Vide pour l'instant
        }
    }
}
