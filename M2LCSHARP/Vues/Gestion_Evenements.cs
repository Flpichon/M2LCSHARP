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
    public partial class Gestion_Evenements : Form
    {
        public gestion_Evenements gesE;
        public gestion_Clubs gesC;
        public BDD_evenement BDDE;
        public BDD_Clubs BDDC;
        public Gestion_Evenements(DATA_METHODES.gestion_Evenements gEvent, DATA_METHODES.gestion_Clubs gClubs)
        {
            InitializeComponent();
            gesE = gEvent;
            gesC = gClubs;
            BDDE = new BDD_evenement();
            BDDC = new BDD_Clubs();
        }

        private void Gestion_Evenements_Load(object sender, EventArgs e)
        {
            gesE.liste = BDDE.ReadEvent();
            gesC.liste = BDDC.ReadClub();
            Dt_Event.AutoGenerateColumns = true;
            //Dt_Event.AutoResizeColumns();
            foreach(evenement even in gesE.liste)
            {
                Dt_Event.Rows.Add(even.id_evenement, even.Titre_evenement, even.Debut_evenement, even.Fin_evenement,even.Club.Titre_club);
            }

        }

        private void btncloseEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ajouter_Event_Click(object sender, EventArgs e)
        {
            ajout_event ajtev = new ajout_event(gesE, gesC,BDDE);
            ajtev.ShowDialog();
        }

        private void Dt_Event_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Modifier_event modev = new Modifier_event(gesE.indexevenement(Dt_Event.CurrentRow.Index), gesC,BDDE);
            modev.ShowDialog();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Dt_Event.Rows.Clear();
            gesE.liste = BDDE.ReadEvent();
            gesC.liste = BDDC.ReadClub();
            Dt_Event.AutoGenerateColumns = true;
            //Dt_Event.AutoResizeColumns();
            foreach (evenement even in gesE.liste)
            {
                Dt_Event.Rows.Add(even.id_evenement, even.Titre_evenement, even.Debut_evenement, even.Fin_evenement, even.Club.Titre_club);
            }
        }
    }
}
