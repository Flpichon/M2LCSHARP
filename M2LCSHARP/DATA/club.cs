using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
     public class club
    {
        public club(int id_club, string titre_club, string url_club, string adresse_club, string code_Postal, string ville, string mail_club, int telephone_club)
        {
            this.id_club = id_club;
            Titre_club = titre_club;
            this.url_club = url_club;
            Adresse_club = adresse_club;
            Code_Postal = code_Postal;
            Ville = ville;
            this.mail_club = mail_club;
            this.telephone_club = telephone_club;
        }

        public int id_club { get; set; }
        public string Titre_club { get; set; }
        public string url_club { get; set; }
        public string Adresse_club { get; set; }
        public string Code_Postal { get; set; }
        public string Ville { get; set; }
        public string mail_club { get; set; }
        public int telephone_club { get; set; }
        public List<type_club> type { get; set; }
        public List<adherent> adherents { get; set; }

    }
}
