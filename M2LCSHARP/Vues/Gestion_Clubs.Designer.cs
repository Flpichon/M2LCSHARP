namespace M2LCSHARP.Vues
{
    partial class Gestion_Clubs
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
            this.Dt_Club = new System.Windows.Forms.DataGridView();
            this.id_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Postal_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Ajouter_Clb = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btncloseclub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Club)).BeginInit();
            this.SuspendLayout();
            // 
            // Dt_Club
            // 
            this.Dt_Club.AllowUserToAddRows = false;
            this.Dt_Club.AllowUserToDeleteRows = false;
            this.Dt_Club.AllowUserToOrderColumns = true;
            this.Dt_Club.AllowUserToResizeColumns = false;
            this.Dt_Club.AllowUserToResizeRows = false;
            this.Dt_Club.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Club.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_club,
            this.Titre_club,
            this.url_club,
            this.Code_Postal_club,
            this.Ville_Club,
            this.Adresse_Club,
            this.Mail_Club,
            this.Telephone_Club,
            this.libelle,
            this.Nbr});
            this.Dt_Club.Location = new System.Drawing.Point(12, 27);
            this.Dt_Club.Name = "Dt_Club";
            this.Dt_Club.ReadOnly = true;
            this.Dt_Club.Size = new System.Drawing.Size(524, 192);
            this.Dt_Club.TabIndex = 1;
            this.Dt_Club.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dt_Club_RowHeaderMouseDoubleClick);
            // 
            // id_club
            // 
            this.id_club.HeaderText = "Id";
            this.id_club.Name = "id_club";
            this.id_club.ReadOnly = true;
            // 
            // Titre_club
            // 
            this.Titre_club.HeaderText = "Titre";
            this.Titre_club.Name = "Titre_club";
            this.Titre_club.ReadOnly = true;
            // 
            // url_club
            // 
            this.url_club.HeaderText = "url du club";
            this.url_club.Name = "url_club";
            this.url_club.ReadOnly = true;
            // 
            // Code_Postal_club
            // 
            this.Code_Postal_club.HeaderText = "Code Postal";
            this.Code_Postal_club.Name = "Code_Postal_club";
            this.Code_Postal_club.ReadOnly = true;
            // 
            // Ville_Club
            // 
            this.Ville_Club.HeaderText = "Ville";
            this.Ville_Club.Name = "Ville_Club";
            this.Ville_Club.ReadOnly = true;
            // 
            // Adresse_Club
            // 
            this.Adresse_Club.HeaderText = "Adresse";
            this.Adresse_Club.Name = "Adresse_Club";
            this.Adresse_Club.ReadOnly = true;
            // 
            // Mail_Club
            // 
            this.Mail_Club.HeaderText = "Mail";
            this.Mail_Club.Name = "Mail_Club";
            this.Mail_Club.ReadOnly = true;
            // 
            // Telephone_Club
            // 
            this.Telephone_Club.HeaderText = "Téléphone";
            this.Telephone_Club.Name = "Telephone_Club";
            this.Telephone_Club.ReadOnly = true;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "type de club";
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            // 
            // Nbr
            // 
            this.Nbr.HeaderText = "Nombre d\'adhérents";
            this.Nbr.Name = "Nbr";
            this.Nbr.ReadOnly = true;
            // 
            // btn_Ajouter_Clb
            // 
            this.btn_Ajouter_Clb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ajouter_Clb.BackColor = System.Drawing.Color.Lime;
            this.btn_Ajouter_Clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter_Clb.Location = new System.Drawing.Point(12, 247);
            this.btn_Ajouter_Clb.Name = "btn_Ajouter_Clb";
            this.btn_Ajouter_Clb.Size = new System.Drawing.Size(75, 45);
            this.btn_Ajouter_Clb.TabIndex = 3;
            this.btn_Ajouter_Clb.Text = "Ajouter";
            this.btn_Ajouter_Clb.UseVisualStyleBackColor = false;
            this.btn_Ajouter_Clb.Click += new System.EventHandler(this.btn_Ajouter_Clb_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(370, 269);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "raffraichir";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btncloseclub
            // 
            this.btncloseclub.Location = new System.Drawing.Point(451, 269);
            this.btncloseclub.Name = "btncloseclub";
            this.btncloseclub.Size = new System.Drawing.Size(75, 23);
            this.btncloseclub.TabIndex = 5;
            this.btncloseclub.Text = "fermer";
            this.btncloseclub.UseVisualStyleBackColor = true;
            this.btncloseclub.Click += new System.EventHandler(this.btncloseclub_Click);
            // 
            // Gestion_Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.btncloseclub);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btn_Ajouter_Clb);
            this.Controls.Add(this.Dt_Club);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 355);
            this.MinimumSize = new System.Drawing.Size(564, 355);
            this.Name = "Gestion_Clubs";
            this.Text = "Gestion_Clubs";
            this.Load += new System.EventHandler(this.Gestion_Clubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Club)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dt_Club;
        private System.Windows.Forms.Button btn_Ajouter_Clb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn url_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Postal_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbr;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btncloseclub;
    }
}