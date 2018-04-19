using M2LCSHARP.DATA;
using M2LCSHARP.DATA_METHODES;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.BDD
{
    
    class BDD_Adhérents : connexion_BDD
    {
        
        
         
        public List<adherent> Readadherent()
        {
            
            
            List<adherent> liste = new List<adherent>();
            
            adherent adhérents;
            
            
                using (connection)
                { 
                    connection.Open();
                string requete = "SELECT * FROM `adherent`";


                MySqlCommand cmd = new MySqlCommand(requete, connection);
                using (MySqlDataReader datareader = cmd.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        adhérents = new adherent((string)datareader["Nom_adherent"], (string)datareader["Prenom_adherent"], (string)datareader["Code_Postal_adherent"], (string)datareader["Adresse_adherent"], (string)datareader["Ville_adherent"]);

                        adhérents.DateNaissance = (DateTime)datareader["Date_naissance_adherent"];
                        adhérents.Id = (int)datareader["id_adherent"];
                        
                        ;
                        if (datareader["id_club"] != System.DBNull.Value && datareader["numero_licence"]!= System.DBNull.Value && datareader["cotisation_adherent"]!=System.DBNull.Value) 
                        { adhérents.club.id_club = Convert.ToInt32(datareader["id_club"]);
                            adhérents.numero_licence = Convert.ToInt32(datareader["numero_licence"]);
                            adhérents.Cotisation = Convert.ToInt32(datareader["cotisation_adherent"]);
                        }
                       
                        
                        
                        liste.Add(adhérents);

                    }

                }
            }
            return liste;
        }
        public void ajouterAdherent(adherent adhérents)
        {
            using (connection)
            {
                connection.Open();
                string requete = "INSERT INTO `adherent` (`id_adherent`, `numero_licence`, `Nom_adherent`, `Prenom_adherent`, `Date_naissance_adherent`, `Adresse_adherent`, `Code_Postal_adherent`, `Ville_adherent`, `cotisation_adherent`, `id_club`) VALUES (NULL,NULL, @nom, @prenom, @date, @Adresse, @codepostal, @ville, NULL, NULL);";
                MySqlCommand cmd = new MySqlCommand(requete, connection);
                cmd.Parameters.AddWithValue("@nom",adhérents.Nom);
                cmd.Parameters.AddWithValue("@prenom", adhérents.Prenom);
                cmd.Parameters.AddWithValue("@date", adhérents.DateNaissance);
                cmd.Parameters.AddWithValue("@adresse", adhérents.Adresse);
                cmd.Parameters.AddWithValue("@codepostal", adhérents.CodePostal);
                cmd.Parameters.AddWithValue("@ville", adhérents.Ville);
               // cmd.Parameters.AddWithValue("@numero", adhérents.numero);
                //cmd.Parameters.AddWithValue("@cotisation", adhérents.cotisation);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
