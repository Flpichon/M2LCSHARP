using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
   public class type_club
    {
        public type_club(int id_type, string libelle)
        {
            this.id_type = id_type;
            this.libelle = libelle;
        }

        public int id_type { get; set; }
       public string libelle { get; set; }
        
        
    }
}
