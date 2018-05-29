using M2LCSHARP.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
    public class gestion_Evenements
    {
        public List<evenement> liste { get; set; }

        public gestion_Evenements()
        {
            liste = gestion_Listes.Créer_Liste_Even();
        }

        public evenement indexevenement(int i)
        {
            return liste[i];
        }
        public void ajouterevent(evenement eve)
        {
            liste.Add(eve);
        }

    }
}
