using M2LCSHARP.DATA;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.BDD
{
   public class BDD_evenement : connexion_BDD
    {
        /// <summary>
        /// Cette fonction permet de récuperer une liste d'évenement dans la BDD en l'associant à des instances de la classe : evenement
        /// </summary>
        /// <returns>Liste d'événements</returns>
        public List<evenement> ReadEvent()
        {
            List<evenement> Liste = new List<evenement>();
            club club;
            type_club typec;
            evenement evenement;
            using (connection)
            {
                connection.Open();
                string requete = "SELECT * from evenement join club on evenement.id_club=club.id_club join type_club on club.id_type_club=type_club.id_type_club";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        typec = new type_club(Convert.ToInt32(datareader["id_type_club"]), (string)datareader["libelle"]);
                        club = new club((string)datareader["Titre_club"], (string)datareader["url_club"], (string)datareader["Adresse_club"], (string)datareader["Code_Postal_club"], (string)datareader["Ville_club"], (string)datareader["mail_club"], Convert.ToInt32(datareader["telephone_club"]), typec);
                        club.id_club = Convert.ToInt32(datareader["id_club"]);
                        evenement = new evenement((string)datareader["Titre_evenement"], (DateTime)datareader["debut_evenement"], (DateTime)datareader["fin_evenement"], club);
                        evenement.id_evenement = Convert.ToInt32(datareader["id_evenement"]);
                        Liste.Add(evenement);
                    }
                }

            }
            return Liste;
        }
        
        /// <summary>
        /// Cette fonction permet d'ajouter un evenement passé en paramètre dans la base de données
        /// </summary>
        /// <param evenement="evenement"></param>
        public void Ajouter_Evenement(evenement evenement)
        {
            using (connection)
            {
                connection.Open();
                string requete = "INSERT INTO `evenement` (`id_evenement`, `Titre_evenement`, `debut_evenement`, `fin_evenement`, `id_club`) VALUES (NULL,@titre,@debut,@fin,@id_club)";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@titre", evenement.Titre_evenement);
                cmd.Parameters.AddWithValue("@debut", evenement.Debut_evenement);
                cmd.Parameters.AddWithValue("@fin", evenement.Fin_evenement);
                cmd.Parameters.AddWithValue("@id_club", evenement.Club.id_club);
                cmd.ExecuteNonQuery();

            }
        }
        public void Modifier_Evenement(evenement evenement)
        {
            using (connection)
            {
                connection.Open();
                string requete = "UPDATE `evenement` SET `Titre_evenement` = @titre, `debut_evenement` = @debut, `fin_evenement` = @fin WHERE `evenement`.`id_evenement` =@id";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@titre", evenement.Titre_evenement);
                cmd.Parameters.AddWithValue("@debut", evenement.Debut_evenement);
                cmd.Parameters.AddWithValue("@fin", evenement.Fin_evenement);
                cmd.Parameters.AddWithValue("@id", evenement.id_evenement);
                cmd.ExecuteNonQuery();

            }
        }
    }
}
