using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

namespace WindowsFormsFranceMobilier
{
    static class Program
    {
        /// <summary>
        /// Connexion SQL globale utilisée par l'application.
        /// Permet de partager la même connexion entre toutes les fenêtres.
        /// </summary>
        public static SqlConnection maConnexion;

        /// <summary>
        /// Employé actuellement connecté.
        /// Les informations de cet employé sont disponibles dans toutes les fenêtres.
        /// </summary>
        public static Employe employe;

        /// <summary>
        /// Magasin associé à l'employé connecté.
        /// Les informations du magasin sont disponibles dans toutes les fenêtres.
        /// </summary>
        public static Magasin magasin;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// Configure la culture pour que le séparateur décimal soit le point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Env.Load();

            string host = Environment.GetEnvironmentVariable("DB_HOST");
            string db = Environment.GetEnvironmentVariable("DB_NAME");
            string user = Environment.GetEnvironmentVariable("DB_USER");
            string pass = Environment.GetEnvironmentVariable("DB_PASS");

            string connStr =
                $"Server={host};Database={db};User Id={user};Password={pass};";

            maConnexion = new SqlConnection(connStr);


            CultureInfo culture;
            culture = (CultureInfo)Application.CurrentCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ".";
            Application.CurrentCulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //nécessaire pour gérer le menu 
            Fm_Login fm_login = new Fm_Login();
            fm_login.Show();

            Application.Run();

        }
    }
}
