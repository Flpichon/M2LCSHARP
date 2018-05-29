using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
     public class club
    {
        public club(string titre_club, string url_club, string adresse_club, string code_Postal, string ville, string mail_club, int telephone_club,type_club tp)
        {
            
            Titre_club = titre_club;
            this.url_club = url_club;
            Adresse_club = adresse_club;
            Code_Postal = code_Postal;
            Ville = ville;
            this.mail_club = mail_club;
            this.telephone_club = telephone_club;
            type = tp;
            adherents = new List<adherent>();
        }

        public int id_club { get; set; }
        public string Titre_club { get; set; }
        public string url_club { get; set; }
        public string Adresse_club { get; set; }
        public string Code_Postal { get; set; }
        public string Ville { get; set; }
        public string mail_club { get; set; }
        public int telephone_club { get; set; }
        public type_club type { get; set; }
        public List<adherent> adherents { get; set; }

        public void AjouterClubAdh (adherent Adh)
        {   int nbr = 0;
            int taille = adherents.Count;
            if (taille!=0)
            {
                foreach (var item in adherents)
                {
                    if (item.Id==Adh.Id) nbr++;



                }
                if (nbr == 0) adherents.Add(Adh);
            }
            else adherents.Add(Adh);
            
           
               
            


        }


    }

}
