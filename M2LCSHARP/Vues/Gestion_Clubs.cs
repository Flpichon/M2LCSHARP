using M2LCSHARP.BDD;
using M2LCSHARP.DATA;
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
        
        
        

        public Gestion_Clubs(gestion_Clubs Ges, gestion_Adherents gAdhe)
        {
            InitializeComponent();
            GesClub = Ges;
            gesadh = gAdhe;
            bADHC = new BDD_Clubs();
        }

        private void Gestion_Clubs_Load(object sender, EventArgs e)
        {
            //Dt_Club.gener
            GesClub.liste = bADHC.ReadClub();
            Dt_Club.AutoGenerateColumns = true;
            Dt_Club.AutoResizeColumns();
            foreach (club club in GesClub.liste)
            {
               int nbr= bADHC.Nombredadh(club);
                int nbrE = bADHC.Nombreevenement(club);

                Dt_Club.Rows.Add(club.id_club, club.Titre_club, club.url_club, club.Code_Postal, club.Ville, club.Adresse_club, club.mail_club, club.telephone_club, club.type.libelle, nbr,nbrE);

            }
            
            
         
            
        }

        private void btn_Ajouter_Clb_Click(object sender, EventArgs e)
        {
            ajout_club ajtclub = new ajout_club(GesClub);
            ajtclub.ShowDialog();
        }

        private void btncloseclub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Dt_Club.Rows.Clear();
            GesClub.liste = bADHC.ReadClub();
            Dt_Club.AutoGenerateColumns = true;
            Dt_Club.AutoResizeColumns();
            foreach (club club in GesClub.liste)
            {
                int nbr = bADHC.Nombredadh(club);
                int nbrE = bADHC.Nombreevenement(club);
                Dt_Club.Rows.Add(club.id_club, club.Titre_club, club.url_club, club.Code_Postal, club.Ville, club.Adresse_club, club.mail_club, club.telephone_club, club.type.libelle, nbr,nbrE);

            }
        }

        private void Dt_Club_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Modifier_Club Mod = new Modifier_Club(GesClub.indexclub(Dt_Club.CurrentRow.Index));
            Mod.ShowDialog();
        }
    }
}
