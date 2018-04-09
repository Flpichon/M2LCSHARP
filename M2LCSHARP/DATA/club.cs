using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
     class club
    {
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
