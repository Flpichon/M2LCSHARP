using M2LCSHARP.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
   public class gestion_Clubs
    {
        public List<club> liste { get; set; }
        

        public gestion_Clubs()
        {
            liste = gestion_Listes.Créer_Liste_Club();
        }
        public void ajouter_Club(club unClub)
        {
            liste.Add(unClub);
        }

        public club RechercherClub (string libelle)
        {
            int i = 0;
            while (liste[i].Titre_club!=libelle)
            {
                i++;
            }

            return liste[i];
            
        }


    }
}
