using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2LCSHARP.DATA
{
    public class adherent
    {
        private int Id { get; set; }
        private int numero_licence { get; set; }
        private string Nom { get; set; }
        private string Prenom { get; set; }
        private string CodePostal { get; set; }
        private string Adresse { get; set; }
        private string Ville { get; set; }
        private DateTime DateNaissance { get; set; }
        private int Cotisation { get; set; }
    }
}
