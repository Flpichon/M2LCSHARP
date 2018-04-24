using M2LCSHARP.BDD;
using M2LCSHARP.DATA_METHODES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2LCSHARP.Vues
{
    public partial class Gestion_Clubs : Form
    {
        public gestion_Clubs GesClub;
        public gestion_Adherents gesadh;
        public BDD_Clubs bADHC;
        
        

        public Gestion_Clubs(gestion_Clubs Ges)
        {
            InitializeComponent();
            GesClub = Ges;
            gesadh = new gestion_Adherents();
            bADHC = new BDD_Clubs();
        }

        private void Gestion_Clubs_Load(object sender, EventArgs e)
        {
            //Dt_Club.gener
            
            Dt_Club.AutoGenerateColumns = true;
            Dt_Club.AutoResizeColumns();
            GesClub.liste = bADHC.ReadClub();
            Dt_Club.DataSource = GesClub.liste;
            Dt_Club.Columns["id_club"].HeaderText = "Id";
            Dt_Club.Columns["type"].Visible = false;
          //  Dt_Club.Columns["libelle"].Visible = true;
            
        }

        private void btn_Ajouter_Clb_Click(object sender, EventArgs e)
        {

        }
    }
}
