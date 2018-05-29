using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
     public class evenement
    {
        public evenement(string titre_evenement, DateTime debut_evenement, DateTime fin_evenement, club club)
        {
            Titre_evenement = titre_evenement;
            Debut_evenement = debut_evenement;
            Fin_evenement = fin_evenement;
            Club = club;
        }

        public int id_evenement { get; set; }
        public string Titre_evenement { get; set; }
        public DateTime Debut_evenement { get; set; }
        public DateTime Fin_evenement { get; set; }
        public club Club { get; set; }

    }
}
