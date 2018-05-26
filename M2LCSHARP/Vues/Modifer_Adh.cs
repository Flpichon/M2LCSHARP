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
    public partial class Modifer_Adh : Form
    {
        BDD_Adhérents Adh = new BDD_Adhérents();
        adherent modadh;
        
        gestion_Clubs GestionC;
        public Modifer_Adh(DATA.adherent adherent, gestion_Clubs gClub)
        {
            InitializeComponent();
            modadh = adherent;
            GestionC = gClub;

        }

        private void Modifer_Adh_Load(object sender, EventArgs e)
        {
            txt_Nom_Adh_Mod.Text = modadh.Nom;
            txt_Prenom_Adh_Mod.Text = modadh.Prenom;
            txt_naissance_adh_Mod.Text = modadh.DateNaissance.ToShortDateString();
            txt_Cp_Adh_Mod.Text = modadh.CodePostal;
            txt_Ville_Adh_Mod.Text = modadh.Ville;
            txt_Adr_Adh_Mod.Text = modadh.Adresse;
            Adh.ClubAdh();
            foreach (var item in Adh.ClubAdh())
            {
                try
                {
                    if (item.Titre_club != modadh.club.Titre_club)
                        cbb_Adh_Club_Mod.Items.Add(item.Titre_club);
                }
                catch
                { cbb_Adh_Club_Mod.Items.Add(item.Titre_club); }
                try { cbb_Adh_Club_Mod.Text = modadh.club.Titre_club; }
                catch
                { }
            }

        }

        private void btn_Adh_Valid_Mod_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            modadh.Nom = txt_Nom_Adh_Mod.Text;
            modadh.Prenom = txt_Prenom_Adh_Mod.Text;
            modadh.DateNaissance = DateTime.Parse(txt_naissance_adh_Mod.Text);
            modadh.CodePostal = txt_Cp_Adh_Mod.Text;
            modadh.Ville = txt_Ville_Adh_Mod.Text;
            modadh.Adresse = txt_Adr_Adh_Mod.Text;
            modadh.club = GestionC.RechercherClub(cbb_Adh_Club_Mod.Text);
            modadh.numero_licence = rand.Next(123456, 999999);
            modadh.Cotisation = (50 + (int)modadh.club.id_club);
            Adh.ModifierAdherent(modadh);
            Adh.AjouterUnClub(modadh.club, modadh);
            modadh.club.AjouterClubAdh(modadh);
            


            
            
            this.Close();
            //modadh.club 

        }

        private void monthCalendar1_Mod_DateChanged(object sender, DateRangeEventArgs e)
        {
            txt_naissance_adh_Mod.Text = monthCalendar1_Mod.SelectionStart.ToShortDateString();
        }

        private void fermeraj_Mod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_suppr_Adh_Click(object sender, EventArgs e)
        {
            Adh.SupprimerAdherent(modadh);
            this.Close();
        }
    }
}   