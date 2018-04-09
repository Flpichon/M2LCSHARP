using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
    class gestion_Adherents
    {
        private List<DATA.adherent> liste { get; set; }

        public void Liste_Adherent()
        {
            liste = gestion_Listes.Créer_Liste();
        }

        public void ajouter_Adherent(DATA.adherent unAdherent)
        {
            liste.Add(unAdherent);
        }
    }
}
