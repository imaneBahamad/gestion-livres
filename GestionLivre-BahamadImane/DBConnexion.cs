using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionLivre_BahamadImane
{
    public class DBConnexion
    {
        public SqlConnection connexion;
        public DBConnexion()
        {
            connexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspaces\DotNet\GestionLivre-BahamadImane\GestionLivre-BahamadImane\GestionLivres.mdf;Integrated Security=True");
            connexion.Open();
        }

    }
}
