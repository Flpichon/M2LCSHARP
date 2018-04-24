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
using M2LCSHARP.BDD;
namespace M2LCSHARP.Vues
{
    public partial class Gestion_Adherents : Form
    {
        public gestion_Adherents gAdhe;
        public gestion_Clubs gClub;
        BDD_Adhérents bADH = new BDD_Adhérents();
       
        public Gestion_Adherents(gestion_Adherents gADhe, gestion_Clubs gClubs)
        {
            InitializeComponent();
            this.gAdhe = gADhe;
            gClub = gClubs;

        }

        private void Gestion_Adherents_Load(object sender, EventArgs e)
        {
            gAdhe.liste = bADH.Readadherent();
            foreach (var item in gAdhe.liste)
             {


            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoResizeColumns();
                try
                { dataGridView1.Rows.Add(item.Id,item.Nom,item.Prenom,item.CodePostal,item.Ville,item.Adresse,item.numero_licence,item.Cotisation,item.club.Titre_club); }
                catch
                { dataGridView1.Rows.Add(item.Id, item.Nom, item.Prenom, item.CodePostal, item.Ville, item.Adresse,"Aucun","Aucune","Pas de club"); }
            
           }

        }

        private void btn_Ajouter_Adh_Click(object sender, EventArgs e)
        {
            ajout_adh ajt = new ajout_adh(gAdhe,gClub);
            ajt.ShowDialog();

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Modifer_Adh Mod = new Modifer_Adh(gAdhe.select_Adherent_Liste(dataGridView1.CurrentRow.Index),gClub);
            Mod.ShowDialog();
        }

        private void Gestion_Adherents_MouseEnter(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Invalidate();
            gAdhe.liste = bADH.Readadherent();
            dataGridView1.DataSource = gAdhe.liste;
        }

        private void refresh_Click_1(object sender, EventArgs e)
        {
            
            dataGridView1.Update();
            gAdhe.liste = bADH.Readadherent();

            dataGridView1.Refresh();
            
            
            

            

        }
    }
}
