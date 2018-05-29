using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M2LCSHARP.BDD;
using M2LCSHARP.DATA;
using M2LCSHARP.DATA_METHODES;

namespace M2LCSHARP.Vues
{
    public partial class ajout_event : Form
    {
        gestion_Evenements gestE;
        gestion_Clubs gestC;
        BDD_evenement BDDE;

        public ajout_event(gestion_Evenements gesE, gestion_Clubs gesC, BDD_evenement bDDE)
        {
            InitializeComponent();
            gestE = gesE;
            gestC = gesC;
            BDDE = bDDE;
        }

        private void ajout_event_Load(object sender, EventArgs e)
        {
            foreach (var item in gestC.liste)
            {
                cbb_club_Event.Items.Add(item.Titre_club);
            }
        }

        private void btn_Event_Valid_Click(object sender, EventArgs e)
        {
            string titre = txt_Titre_Event.Text;
            DateTime debut;
            DateTime fin;
            string clublib;
            try
            {
                 debut = DateTime.Parse(txt_Début_Event.Text);
                 fin = DateTime.Parse(txt_Fin_Event.Text);
                clublib = cbb_club_Event.SelectedItem.ToString();
                
                    club club = gestC.RechercherClub(clublib);
                    if (debut <= fin)
                    {
                        if (titre.Length != 0)
                        {
                            evenement evene = new evenement(titre, debut, fin, club);
                            BDDE.Ajouter_Evenement(evene);
                        MessageBox.Show("Ajout de l'événement réussi", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        }
                        else MessageBox.Show("Attention aucun titre n'a été renseigné", "Aucun titre !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Attention la date de fin de l'événement doit être supérieure à la date de début !", "date début > date fin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch
            {
                MessageBox.Show("Veuillez Remplir tous les champs !","Champ(s) non remplis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
