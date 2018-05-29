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
        gestion_Clubs GClubs;
        gestion_Evenements GEvent;

        public Accueil()
        {
            InitializeComponent();
           
            GAdhe = new gestion_Adherents();
            GClubs = new gestion_Clubs();
            GEvent = new gestion_Evenements();
            
        }

        private void Accueil_Load(object sender, System.EventArgs e)
        {

        }

        

        private void Adherents_Click(object sender, System.EventArgs e)
        {
            Gestion_Adherents GA = new Gestion_Adherents(GAdhe,GClubs);
       
            GA.ShowDialog();    
        }

        private void btn_Club_Click(object sender, System.EventArgs e)
        {
            Gestion_Clubs GC = new Gestion_Clubs(GClubs,GAdhe);
            GC.ShowDialog();
        }

        

        private void btn_event_Click(object sender, System.EventArgs e)
        {
            Gestion_Evenements GE = new Gestion_Evenements(GEvent, GClubs);
            GE.ShowDialog();
        }
    }
}
