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
            
            try
            {
                string Titre = txt_Titre_Club.Text;
                string Url = txt_Url_Club.Text;
                string CP = txt_Cp_Club.Text;
                string Ville = txt_Ville_CLub.Text;
                string adresse = txt_Adr_Club.Text;
                string Mail = txt_Mail_Club.Text;
                string Tel = txt_Tel_Club.Text;
                string type = cbb_type_club.SelectedItem.ToString();
                if (Titre.Length != 0 && Url.Length != 0 && CP.Length != 0 && Ville.Length != 0 && adresse.Length != 0 && Mail.Length != 0 && Tel.Length != 0 & type.Length != 0)
                {
                    club Nclub = new club(Titre, Url, adresse, CP, Ville, Mail, int.Parse(Tel), BDDC.RecupType(type));
                    gest_club.ajouter_Club(Nclub);
                    BDDC.ajouterClub(Nclub);
                    MessageBox.Show("Ajout du club réussi", "ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Veuillez remplir tous les champs", "champ(s) non rempli(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Vérifiez que vous avez entré un nom de club unique et que tous les champs sont remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ajout_club_Load(object sender, EventArgs e)
        {
            foreach (var item in BDDC.Liste_Type())
            {
                cbb_type_club.Items.Add(item.libelle);
            }
        }

        private void fermeraj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
