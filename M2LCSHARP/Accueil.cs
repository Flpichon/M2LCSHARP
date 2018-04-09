using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace M2LCSHARP
{
    public partial class Accueil : Form
    {
        DATA.club clubi = new DATA.club();
        DATA.adherent a = new DATA.adherent();
        
        public Accueil()
        {
            InitializeComponent();
            
           
        }
    }
}
