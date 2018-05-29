using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace M2LCSHARP.BDD
{
    public class connexion_BDD
    {
        private string connectionString;
        public MySqlConnection connection { get; set; }

        public connexion_BDD()
        {
            this.ConnexionBDD();
        }
        public void ConnexionBDD()
        {
            string server = "localhost";
            string port = "3306";
            string database = "m2lcsharp";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            try { this.connection = new MySqlConnection(connectionString); }
            catch { };
            
        }

      

    }
}
