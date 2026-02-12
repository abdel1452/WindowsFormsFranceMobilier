using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsFranceMobilier
{
    /// <summary>
    /// Classe utilitaire permettant de créer et de retourner une connexion
    /// à la base de données SQL Server de l'application FranceMobilier.
    /// </summary>
    public class ConnexionBdd
    {
        public static SqlConnection GetDBConnection(string connectionString)
        {
            SqlConnection maConnexion = new SqlConnection(connectionString);
            return maConnexion;
        }
    }
}
