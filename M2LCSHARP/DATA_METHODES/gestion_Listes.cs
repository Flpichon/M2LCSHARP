using M2LCSHARP.BDD;
using M2LCSHARP.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
    public class gestion_Listes
    {
        public static List<adherent> Créer_Liste()
        {
            List<adherent> Liste = new List<adherent>();
            BDD_Adhérents BD = new BDD_Adhérents();
            Liste = BD.Readadherent();
            
            return Liste;
        }
        public static List<club> Créer_Liste_Club()
        {
            List<club> Liste = new List<club>();
            BDD_Clubs BD = new BDD_Clubs();
            Liste = BD.ReadClub();
            return Liste;
        }
        public static List<evenement> Créer_Liste_Even()
        {
            List<evenement> Liste = new List<evenement>();
            BDD_evenement BD = new BDD_evenement();
            Liste = BD.ReadEvent();
            return Liste;
        }
    
            
    }
}
