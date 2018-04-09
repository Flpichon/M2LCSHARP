using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
     class evenement
    {
        public int id_evenement { get; set; }
        public string Titre_evenement { get; set; }
        public DateTime Debut_evenement { get; set; }
        public DateTime Fin_evenement { get; set; }
        public club Club { get; set; }

    }
}
