using M2LCSHARP.BDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
    public class gestion_Listes
    {
        public static List<DATA.adherent> Créer_Liste()
        {
            List<DATA.adherent> Liste = new List<DATA.adherent>();
            BDD_Adhérents BD = new BDD_Adhérents();
            Liste = BD.Readadherent();
            
            return Liste;
        }
    }
}
