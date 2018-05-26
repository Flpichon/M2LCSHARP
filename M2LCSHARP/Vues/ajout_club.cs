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
    public partial class ajout_club : Form
    {
        public gestion_Clubs gest_club;
        BDD_Clubs BDDC = new BDD_Clubs();
        public ajout_club(gestion_Clubs gesClub)
        {
            InitializeComponent();
            gest_club = gesClub;
        }

        private void btn_Club_Valid_Click(object sender, EventArgs e)
        {
            string Titre = txt_Titre_Club.Text;
            string Url = txt_Url_Club.Text;
            string CP = txt_Cp_Club.Text;
            string Ville = txt_Ville_CLub.Text;
            string adresse = txt_Adr_Club.Text;
            string Mail = txt_Mail_Club.Text;
            string Tel = txt_Tel_Club.Text;
            string type = cbb_type_club.SelectedItem.ToString();

            club Nclub = new club(Titre, Url, adresse, CP, Ville, Mail,int.Parse(Tel), BDDC.RecupType(type));
            gest_club.ajouter_Club(Nclub);
            try
            { BDDC.ajouterClub(Nclub); }
            catch
            {
                MessageBox.Show("Nom de club déjà prit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajout_club_Load(object sender, EventArgs e)
        {
            foreach (var item in BDDC.Liste_Type())
            {
                cbb_type_club.Items.Add(item.libelle);
            }
        }
    }
}
