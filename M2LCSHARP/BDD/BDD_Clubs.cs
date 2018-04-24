using M2LCSHARP.DATA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.BDD
{
   public class BDD_Clubs : connexion_BDD

    {
        public List<club> ReadClub()
        {


            List<club> liste = new List<club>();

            club club;

            type_club typec;


            using (connection)
            {
                connection.Open();
                string requete = "select `id_club`,`Titre_club`,`url_club`,`Adresse_club`,`Code_Postal_club`,`Ville_club`,`mail_club`,`telephone_club`,type_club.libelle,type_club.id_type_club from club inner join type_club on club.id_type_club=type_club.id_type_club";


                MySqlCommand cmd = new MySqlCommand(requete, connection);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        typec = new type_club(Convert.ToInt32(datareader["id_type_club"]), (string)datareader["libelle"]);
                        club = new club((string)datareader["Titre_club"], (string)datareader["url_club"], (string)datareader["Adresse_club"], (string)datareader["Code_Postal_club"], (string)datareader["Ville_club"],(string)datareader["mail_club"], Convert.ToInt32(datareader["telephone_club"]),typec);
                        club.id_club = Convert.ToInt32(datareader["id_club"]);

                        //typec.libelle = (string)datareader["libelle"];
                        //club.type.id_type = (int)datareader["id_type_club"];
                        liste.Add(club);
                        


                        

                    }

                }
            }
            return liste;
        }
    }
}
