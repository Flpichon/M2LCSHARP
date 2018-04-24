using M2LCSHARP.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace M2LCSHARP.DATA_METHODES
{
    public class gestion_Adherents
    {
        public List<adherent> liste { get; set; }

        public gestion_Adherents()
        {
            liste = gestion_Listes.Créer_Liste();
        }

        public void ajouter_Adherent(DATA.adherent unAdherent)
        {
            liste.Add(unAdherent);
        }

        public adherent select_Adherent_Liste(int index)
        {
            return liste[index];
        }

        public void supprimer_Adherent(DATA.adherent unAdherent)
        {
            liste.Remove(unAdherent);
        }

        /*public List<DATA.adherent> Get_adherent()
        {
            return this.liste;
        }*/
    }
}
