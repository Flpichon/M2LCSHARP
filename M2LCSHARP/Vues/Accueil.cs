using System.Windows.Forms;
using M2LCSHARP.DATA;
using M2LCSHARP.DATA_METHODES;
using M2LCSHARP.BDD;
using M2LCSHARP.Vues;

namespace M2LCSHARP
{
    public partial class Accueil : Form
    {

        gestion_Adherents GAdhe;
        public Accueil()
        {
            InitializeComponent();
           
            GAdhe = new gestion_Adherents();
           
            
        }

        private void Accueil_Load(object sender, System.EventArgs e)
        {

        }

        

        private void Adherents_Click(object sender, System.EventArgs e)
        {
            Gestion_Adherents GA = new Gestion_Adherents(GAdhe);
            GA.ShowDialog();    
        }
    }
}
