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
        BDD_Adhérents bADH = new BDD_Adhérents();
       
        public Gestion_Adherents(gestion_Adherents gADhe)
        {
            InitializeComponent();
            this.gAdhe = gADhe;

        }

        private void Gestion_Adherents_Load(object sender, EventArgs e)
        {
            
            foreach (var item in gAdhe.liste)
             {


            dataGridView1.AutoGenerateColumns = true;
             dataGridView1.AutoResizeColumns();
                gAdhe.liste = bADH.Readadherent();
                dataGridView1.DataSource = gAdhe.liste;
            
           }

        }

        private void btn_Ajouter_Adh_Click(object sender, EventArgs e)
        {
            ajout_adh ajt = new ajout_adh(gAdhe);
            ajt.ShowDialog();

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Invalidate();
            gAdhe.liste = bADH.Readadherent();
            dataGridView1.DataSource = gAdhe.liste;
        }
    }
}
