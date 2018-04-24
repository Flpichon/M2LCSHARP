namespace M2LCSHARP.Vues
{
    partial class Gestion_Adherents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ajouter_Adh = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.clubtitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clubtitre,
            this.Nom,
            this.Prenom,
            this.Code_Postal,
            this.Ville,
            this.Adresse,
            this.numero,
            this.Cotisation,
            this.Club});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Adhérents";
            // 
            // btn_Ajouter_Adh
            // 
            this.btn_Ajouter_Adh.BackColor = System.Drawing.Color.Lime;
            this.btn_Ajouter_Adh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter_Adh.Location = new System.Drawing.Point(12, 251);
            this.btn_Ajouter_Adh.Name = "btn_Ajouter_Adh";
            this.btn_Ajouter_Adh.Size = new System.Drawing.Size(75, 45);
            this.btn_Ajouter_Adh.TabIndex = 2;
            this.btn_Ajouter_Adh.Text = "Ajouter";
            this.btn_Ajouter_Adh.UseVisualStyleBackColor = false;
            this.btn_Ajouter_Adh.Click += new System.EventHandler(this.btn_Ajouter_Adh_Click);
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(450, 273);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 3;
            this.fermer.Text = "fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(369, 273);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 4;
            this.refresh.Text = "button1";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // clubtitre
            // 
            this.clubtitre.HeaderText = "Id";
            this.clubtitre.Name = "clubtitre";
            this.clubtitre.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Code_Postal
            // 
            this.Code_Postal.HeaderText = "Code Postal";
            this.Code_Postal.Name = "Code_Postal";
            this.Code_Postal.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "N° Licence";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // Cotisation
            // 
            this.Cotisation.HeaderText = "Cotisation";
            this.Cotisation.Name = "Cotisation";
            this.Cotisation.ReadOnly = true;
            // 
            // Club
            // 
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            // 
            // Gestion_Adherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 326);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.btn_Ajouter_Adh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestion_Adherents";
            this.Text = "Gestion_Adherents";
            this.Load += new System.EventHandler(this.Gestion_Adherents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ajouter_Adh;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubtitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
    }
}