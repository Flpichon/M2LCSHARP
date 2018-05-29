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
    public partial class Modifier_event : Form
    {
        evenement E;
        gestion_Clubs gestC;
        BDD_evenement BDDE;
        public Modifier_event(evenement eve,gestion_Clubs gesC, BDD_evenement bDDE)
        {
            InitializeComponent();
            E = eve;
            gestC = gesC;
            BDDE = bDDE;
        }

        private void Modifier_event_Load(object sender, EventArgs e)
        {
            txt_Titre_Event.Text = E.Titre_evenement;
            txt_Début_Event.Text = E.Debut_evenement.ToShortDateString();
            txt_Fin_Event.Text = E.Fin_evenement.ToShortDateString();
            txt_club_Event.Text = E.Club.Titre_club;
            
        }

        private void btn_Event_Modifer_Click(object sender, EventArgs e)
        {
            string titre;
            DateTime debut;
            DateTime fin;
            try
            {
                debut = DateTime.Parse(txt_Début_Event.Text);
                fin = DateTime.Parse(txt_Fin_Event.Text);
                titre = txt_Titre_Event.Text;

                
                if (debut <= fin)
                {
                    if (titre.Length != 0)
                    {
                        E.Titre_evenement = titre;
                        E.Debut_evenement = debut;
                        E.Fin_evenement = fin;
                    }
                    else MessageBox.Show("Attention aucun titre n'a été renseigné", "Aucun titre !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Attention la date de fin de l'événement doit être supérieure à la date de début !", "date début > date fin", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("Veuillez Remplir tous les champs !", "Champ(s) non remplis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BDDE.Modifier_Evenement(E);
            MessageBox.Show("Modifications effectuées","Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
           
        }

        private void btn_sup_event_Click(object sender, EventArgs e)
        {
            try { BDDE.Supprimer_Evenement(E);
                MessageBox.Show("Suppression réussite", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch { MessageBox.Show("Suppression impossible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
