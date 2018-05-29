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
                string requete = "SELECT `id_club`,`Titre_club`,`url_club`,`Adresse_club`,`Code_Postal_club`,`Ville_club`,`mail_club`,`telephone_club`,libelle,type_club.id_type_club from club inner join type_club on club.id_type_club=type_club.id_type_club order by `id_club`";


                MySqlCommand cmd = new MySqlCommand(requete, connection);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        typec = new type_club(Convert.ToInt32(datareader["id_type_club"]), (string)datareader["libelle"]);
                        club = new club((string)datareader["Titre_club"], (string)datareader["url_club"], (string)datareader["Adresse_club"], (string)datareader["Code_Postal_club"], (string)datareader["Ville_club"], (string)datareader["mail_club"], Convert.ToInt32(datareader["telephone_club"]), typec);
                        club.id_club = Convert.ToInt32(datareader["id_club"]);

                        //typec.libelle = (string)datareader["libelle"];
                        //club.type.id_type = (int)datareader["id_type_club"];
                        liste.Add(club);





                    }

                }
            }
            return liste;
        }

        public int Nombredadh(club club)
        {
            int Nbr = 0;
            using (connection)
            {
                connection.Open();
                string requete = "SELECT count(id_adherent) as Nbr from adherent where adherent.id_club=@id";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@id", club.id_club);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        Nbr = Convert.ToInt32(datareader["Nbr"]);
                    }
                }
            }

            return Nbr;
        }


        public List<type_club> Liste_Type()
        {
            List<type_club> Laliste = new List<type_club>();
            type_club type;
            using (connection)
            {
                connection.Open();
                string requete = "select * from type_club";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        type = new type_club(Convert.ToInt32(datareader["id_type_club"]), (string)datareader["libelle"]);
                        Laliste.Add(type);

                    }
                }


            }
            return Laliste;

        }
        public type_club RecupType(string lib)
        {
            type_club typeclu;
            List <type_club> Liste= new List<type_club>();
            using (connection)
            {
                connection.Open();
                string requete = "select * from type_club where libelle=@libelle";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@libelle", lib);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        typeclu = new type_club(Convert.ToInt32(datareader["id_type_club"]), (string)datareader["libelle"]);
                        Liste.Add(typeclu);
                    }
                    
                }

            }
            return Liste[0];

        }
        public void ajouterClub(club UnClub)
        {
            using (connection)
            {
                connection.Open();
                string requete = "INSERT INTO `club` (`id_club`, `Titre_club`, `url_club`, `Adresse_club`, `Code_Postal_club`, `Ville_club`, `mail_club`, `telephone_club`, `id_type_club`) VALUES(NULL, @titre,@url,@adresse,@cp,@ville,@mail,@tel,@type)";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@titre", UnClub.Titre_club);
                cmd.Parameters.AddWithValue("@url", UnClub.url_club);
                cmd.Parameters.AddWithValue("@adresse", UnClub.Adresse_club);
                cmd.Parameters.AddWithValue("@cp", UnClub.Code_Postal);
                cmd.Parameters.AddWithValue("@ville", UnClub.Ville);
                cmd.Parameters.AddWithValue("@mail", UnClub.mail_club);
              
                cmd.Parameters.AddWithValue("@tel", UnClub.telephone_club);
                cmd.Parameters.AddWithValue("@type", UnClub.type.id_type);
                cmd.ExecuteNonQuery();
            }
        }

        public void modifier_club(club UnClub)
        {
            using (connection)
            {
                connection.Open();
                string requete = "UPDATE `club` SET `Titre_club` = @titre, `url_club` = @url, `Adresse_club` = @adresse, `Code_Postal_club` = @cp, `Ville_club` = @ville, `mail_club` = @mail, `telephone_club` = @tel WHERE `club`.`id_club` = @idc";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@titre", UnClub.Titre_club);
                cmd.Parameters.AddWithValue("@url", UnClub.url_club);
                cmd.Parameters.AddWithValue("@adresse", UnClub.Adresse_club);
                cmd.Parameters.AddWithValue("@cp", UnClub.Code_Postal);
                cmd.Parameters.AddWithValue("@ville", UnClub.Ville);
                cmd.Parameters.AddWithValue("@mail", UnClub.mail_club);

                cmd.Parameters.AddWithValue("@tel", UnClub.telephone_club);
                cmd.Parameters.AddWithValue("@idc", UnClub.id_club);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
