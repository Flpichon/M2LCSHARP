using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace M2LCSHARP.BDD
{
    class connexion_BDD
    {
        static private string connectionString;


        public connexion_BDD()
        {
            ConnexionBDD();
        }
        static public void ConnexionBDD()
        {
            string server = "localhost";
            string port = "3306";
            string database = "m2lcsharp";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }

    }
}
