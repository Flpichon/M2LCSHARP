namespace M2LCSHARP.Vues
{
    partial class ajout_adh
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
            this.txt_Nom_Adh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nom_Adh = new System.Windows.Forms.Label();
            this.txt_Prenom_Adh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Prenom_Adh = new System.Windows.Forms.Label();
            this.lbl_naissance_adh = new System.Windows.Forms.Label();
            this.txt_naissance_adh = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cp_Adh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cp_Adh = new System.Windows.Forms.Label();
            this.txt_Ville_Adh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Ville_Adh = new System.Windows.Forms.Label();
            this.txt_Adr_Adh = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Adr_Adh = new System.Windows.Forms.Label();
            this.lbl_Club_Adh = new System.Windows.Forms.Label();
            this.cbb_Adh_Club = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Adh_Valid = new System.Windows.Forms.Button();
            this.ajout = new System.Windows.Forms.GroupBox();
            this.fermeraj = new System.Windows.Forms.Button();
            this.ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nom_Adh
            // 
            this.txt_Nom_Adh.Location = new System.Drawing.Point(149, 17);
            this.txt_Nom_Adh.Mask = "LLLLLLLLLLLL";
            this.txt_Nom_Adh.Name = "txt_Nom_Adh";
            this.txt_Nom_Adh.PromptChar = ' ';
            this.txt_Nom_Adh.Size = new System.Drawing.Size(81, 20);
            this.txt_Nom_Adh.TabIndex = 0;
            // 
            // lbl_Nom_Adh
            // 
            this.lbl_Nom_Adh.AutoSize = true;
            this.lbl_Nom_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom_Adh.Location = new System.Drawing.Point(6, 20);
            this.lbl_Nom_Adh.Name = "lbl_Nom_Adh";
            this.lbl_Nom_Adh.Size = new System.Drawing.Size(39, 17);
            this.lbl_Nom_Adh.TabIndex = 1;
            this.lbl_Nom_Adh.Text = "Nom";
            // 
            // txt_Prenom_Adh
            // 
            this.txt_Prenom_Adh.Location = new System.Drawing.Point(149, 58);
            this.txt_Prenom_Adh.Mask = "LLLLLLLLLLLL";
            this.txt_Prenom_Adh.Name = "txt_Prenom_Adh";
            this.txt_Prenom_Adh.PromptChar = ' ';
            this.txt_Prenom_Adh.Size = new System.Drawing.Size(81, 20);
            this.txt_Prenom_Adh.TabIndex = 2;
            // 
            // lbl_Prenom_Adh
            // 
            this.lbl_Prenom_Adh.AutoSize = true;
            this.lbl_Prenom_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom_Adh.Location = new System.Drawing.Point(6, 61);
            this.lbl_Prenom_Adh.Name = "lbl_Prenom_Adh";
            this.lbl_Prenom_Adh.Size = new System.Drawing.Size(60, 17);
            this.lbl_Prenom_Adh.TabIndex = 3;
            this.lbl_Prenom_Adh.Text = "Prénom";
            // 
            // lbl_naissance_adh
            // 
            this.lbl_naissance_adh.AutoSize = true;
            this.lbl_naissance_adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naissance_adh.Location = new System.Drawing.Point(6, 99);
            this.lbl_naissance_adh.Name = "lbl_naissance_adh";
            this.lbl_naissance_adh.Size = new System.Drawing.Size(130, 17);
            this.lbl_naissance_adh.TabIndex = 4;
            this.lbl_naissance_adh.Text = "Date de naissance";
            // 
            // txt_naissance_adh
            // 
            this.txt_naissance_adh.Location = new System.Drawing.Point(149, 96);
            this.txt_naissance_adh.Mask = "00/00/0000";
            this.txt_naissance_adh.Name = "txt_naissance_adh";
            this.txt_naissance_adh.PromptChar = ' ';
            this.txt_naissance_adh.Size = new System.Drawing.Size(81, 20);
            this.txt_naissance_adh.TabIndex = 5;
            this.txt_naissance_adh.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Cp_Adh
            // 
            this.txt_Cp_Adh.Location = new System.Drawing.Point(149, 135);
            this.txt_Cp_Adh.Mask = "00000";
            this.txt_Cp_Adh.Name = "txt_Cp_Adh";
            this.txt_Cp_Adh.PromptChar = ' ';
            this.txt_Cp_Adh.Size = new System.Drawing.Size(81, 20);
            this.txt_Cp_Adh.TabIndex = 6;
            // 
            // lbl_Cp_Adh
            // 
            this.lbl_Cp_Adh.AutoSize = true;
            this.lbl_Cp_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cp_Adh.Location = new System.Drawing.Point(6, 135);
            this.lbl_Cp_Adh.Name = "lbl_Cp_Adh";
            this.lbl_Cp_Adh.Size = new System.Drawing.Size(88, 17);
            this.lbl_Cp_Adh.TabIndex = 7;
            this.lbl_Cp_Adh.Text = "Code Postal";
            // 
            // txt_Ville_Adh
            // 
            this.txt_Ville_Adh.Location = new System.Drawing.Point(149, 174);
            this.txt_Ville_Adh.Mask = "AAAAAAAAAAAAAAAAA";
            this.txt_Ville_Adh.Name = "txt_Ville_Adh";
            this.txt_Ville_Adh.PromptChar = ' ';
            this.txt_Ville_Adh.Size = new System.Drawing.Size(119, 20);
            this.txt_Ville_Adh.TabIndex = 8;
            // 
            // lbl_Ville_Adh
            // 
            this.lbl_Ville_Adh.AutoSize = true;
            this.lbl_Ville_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville_Adh.Location = new System.Drawing.Point(6, 174);
            this.lbl_Ville_Adh.Name = "lbl_Ville_Adh";
            this.lbl_Ville_Adh.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ville_Adh.TabIndex = 9;
            this.lbl_Ville_Adh.Text = "Ville";
            // 
            // txt_Adr_Adh
            // 
            this.txt_Adr_Adh.Location = new System.Drawing.Point(149, 210);
            this.txt_Adr_Adh.Mask = "AAAAAAAAAAAA";
            this.txt_Adr_Adh.Name = "txt_Adr_Adh";
            this.txt_Adr_Adh.PromptChar = ' ';
            this.txt_Adr_Adh.Size = new System.Drawing.Size(119, 20);
            this.txt_Adr_Adh.TabIndex = 10;
            // 
            // lbl_Adr_Adh
            // 
            this.lbl_Adr_Adh.AutoSize = true;
            this.lbl_Adr_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adr_Adh.Location = new System.Drawing.Point(6, 213);
            this.lbl_Adr_Adh.Name = "lbl_Adr_Adh";
            this.lbl_Adr_Adh.Size = new System.Drawing.Size(62, 17);
            this.lbl_Adr_Adh.TabIndex = 11;
            this.lbl_Adr_Adh.Text = "Adresse";
            // 
            // lbl_Club_Adh
            // 
            this.lbl_Club_Adh.AutoSize = true;
            this.lbl_Club_Adh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Club_Adh.Location = new System.Drawing.Point(6, 250);
            this.lbl_Club_Adh.Name = "lbl_Club_Adh";
            this.lbl_Club_Adh.Size = new System.Drawing.Size(38, 17);
            this.lbl_Club_Adh.TabIndex = 12;
            this.lbl_Club_Adh.Text = "Club";
            // 
            // cbb_Adh_Club
            // 
            this.cbb_Adh_Club.FormattingEnabled = true;
            this.cbb_Adh_Club.Items.AddRange(new object[] {
            "club 1",
            "club 2",
            "club 3"});
            this.cbb_Adh_Club.Location = new System.Drawing.Point(149, 250);
            this.cbb_Adh_Club.Name = "cbb_Adh_Club";
            this.cbb_Adh_Club.Size = new System.Drawing.Size(81, 21);
            this.cbb_Adh_Club.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendar1.Location = new System.Drawing.Point(301, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_Adh_Valid
            // 
            this.btn_Adh_Valid.Location = new System.Drawing.Point(388, 244);
            this.btn_Adh_Valid.Name = "btn_Adh_Valid";
            this.btn_Adh_Valid.Size = new System.Drawing.Size(75, 23);
            this.btn_Adh_Valid.TabIndex = 16;
            this.btn_Adh_Valid.Text = "Valider";
            this.btn_Adh_Valid.UseVisualStyleBackColor = true;
            this.btn_Adh_Valid.Click += new System.EventHandler(this.btn_Adh_Valid_Click);
            // 
            // ajout
            // 
            this.ajout.Controls.Add(this.fermeraj);
            this.ajout.Controls.Add(this.monthCalendar1);
            this.ajout.Controls.Add(this.btn_Adh_Valid);
            this.ajout.Controls.Add(this.lbl_naissance_adh);
            this.ajout.Controls.Add(this.cbb_Adh_Club);
            this.ajout.Controls.Add(this.txt_Nom_Adh);
            this.ajout.Controls.Add(this.lbl_Club_Adh);
            this.ajout.Controls.Add(this.lbl_Nom_Adh);
            this.ajout.Controls.Add(this.lbl_Adr_Adh);
            this.ajout.Controls.Add(this.txt_Prenom_Adh);
            this.ajout.Controls.Add(this.txt_Adr_Adh);
            this.ajout.Controls.Add(this.lbl_Prenom_Adh);
            this.ajout.Controls.Add(this.lbl_Ville_Adh);
            this.ajout.Controls.Add(this.txt_naissance_adh);
            this.ajout.Controls.Add(this.txt_Ville_Adh);
            this.ajout.Controls.Add(this.txt_Cp_Adh);
            this.ajout.Controls.Add(this.lbl_Cp_Adh);
            this.ajout.Location = new System.Drawing.Point(5, 2);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(540, 314);
            this.ajout.TabIndex = 17;
            this.ajout.TabStop = false;
            this.ajout.Text = "ajouter";
            // 
            // fermeraj
            // 
            this.fermeraj.Location = new System.Drawing.Point(388, 274);
            this.fermeraj.Name = "fermeraj";
            this.fermeraj.Size = new System.Drawing.Size(75, 23);
            this.fermeraj.TabIndex = 17;
            this.fermeraj.Text = "Fermer";
            this.fermeraj.UseVisualStyleBackColor = true;
            this.fermeraj.Click += new System.EventHandler(this.fermeraj_Click);
            // 
            // ajout_adh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.ajout);
            this.Name = "ajout_adh";
            this.Text = "ajout_adh";
            this.ajout.ResumeLayout(false);
            this.ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_Nom_Adh;
        private System.Windows.Forms.Label lbl_Nom_Adh;
        private System.Windows.Forms.MaskedTextBox txt_Prenom_Adh;
        private System.Windows.Forms.Label lbl_Prenom_Adh;
        private System.Windows.Forms.Label lbl_naissance_adh;
        private System.Windows.Forms.MaskedTextBox txt_naissance_adh;
        private System.Windows.Forms.MaskedTextBox txt_Cp_Adh;
        private System.Windows.Forms.Label lbl_Cp_Adh;
        private System.Windows.Forms.MaskedTextBox txt_Ville_Adh;
        private System.Windows.Forms.Label lbl_Ville_Adh;
        private System.Windows.Forms.MaskedTextBox txt_Adr_Adh;
        private System.Windows.Forms.Label lbl_Adr_Adh;
        private System.Windows.Forms.Label lbl_Club_Adh;
        private System.Windows.Forms.ComboBox cbb_Adh_Club;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_Adh_Valid;
        private System.Windows.Forms.GroupBox ajout;
        private System.Windows.Forms.Button fermeraj;
    }
}