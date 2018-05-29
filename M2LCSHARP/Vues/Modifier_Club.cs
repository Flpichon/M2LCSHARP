using M2LCSHARP.BDD;
using M2LCSHARP.DATA;
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
    public partial class Modifier_Club : Form
    {
        BDD_Clubs BDDC = new BDD_Clubs();
        club unclub;
        public Modifier_Club(club club)
        {
            InitializeComponent();
            unclub = club;

        }

        private void Modifier_Club_Load(object sender, EventArgs e)
        {
            txt_Titre_Club.Text = unclub.Titre_club;
            txt_Url_Club.Text = unclub.url_club;
            txt_Cp_Club.Text = unclub.Code_Postal;
            txt_Ville_CLub.Text = unclub.Ville;
            txt_Adr_Club.Text = unclub.Adresse_club;
            txt_Mail_Club.Text = unclub.mail_club;
            txt_Tel_Club.Text = unclub.telephone_club.ToString();
        }

        private void btn_Club_Modif_Click(object sender, EventArgs e)
        {
            unclub.Titre_club = txt_Titre_Club.Text;
            if (txt_Url_Club.Text.Length != 0 && txt_Cp_Club.Text.Length != 0 && txt_Ville_CLub.Text.Length != 0 && txt_Adr_Club.Text.Length != 0 && txt_Mail_Club.Text.Length != 0 && txt_Tel_Club.Text.Length != 0)
            {
                unclub.url_club = txt_Url_Club.Text;
                unclub.Code_Postal = txt_Cp_Club.Text;
                unclub.Ville = txt_Ville_CLub.Text;
                unclub.Adresse_club = txt_Adr_Club.Text;
                unclub.mail_club = txt_Mail_Club.Text;
                unclub.telephone_club = int.Parse(txt_Tel_Club.Text);
                BDDC.modifier_club(unclub);
                MessageBox.Show("Modifications réussites", "Modifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Veuillez remplir tous les champs !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
