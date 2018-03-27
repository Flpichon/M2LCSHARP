using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
    public class evenement
    {
        private int id_evenement { get; set; }
        private string Titre_evenement { get; set; }
        private DateTime Debut_evenement { get; set; }
        private DateTime Fin_evenement { get; set; }
        private club Club { get; set; }

    }
}
