namespace M2LCSHARP.Vues
{
    partial class Modifer_Adh
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
            this.fermeraj_Mod = new System.Windows.Forms.Button();
            this.monthCalendar1_Mod = new System.Windows.Forms.MonthCalendar();
            this.btn_Adh_Valid_Mod = new System.Windows.Forms.Button();
            this.lbl_naissance_adh_Mod = new System.Windows.Forms.Label();
            this.Modi = new System.Windows.Forms.GroupBox();
            this.btn_suppr_Adh = new System.Windows.Forms.Button();
            this.cbb_Adh_Club_Mod = new System.Windows.Forms.ComboBox();
            this.txt_Nom_Adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Club_Adh_Mod = new System.Windows.Forms.Label();
            this.lbl_Nom_Adh_Mod = new System.Windows.Forms.Label();
            this.lbl_Adr_Adh_Mod = new System.Windows.Forms.Label();
            this.txt_Prenom_Adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.txt_Adr_Adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Prenom_Adh_Mod = new System.Windows.Forms.Label();
            this.lbl_Ville_Adh_Mod = new System.Windows.Forms.Label();
            this.txt_naissance_adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.txt_Ville_Adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.txt_Cp_Adh_Mod = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Cp_Adh_Mod = new System.Windows.Forms.Label();
            this.Modi.SuspendLayout();
            this.SuspendLayout();
            // 
            // fermeraj_Mod
            // 
            this.fermeraj_Mod.Location = new System.Drawing.Point(453, 248);
            this.fermeraj_Mod.Name = "fermeraj_Mod";
            this.fermeraj_Mod.Size = new System.Drawing.Size(75, 23);
            this.fermeraj_Mod.TabIndex = 17;
            this.fermeraj_Mod.Text = "Annuler";
            this.fermeraj_Mod.UseVisualStyleBackColor = true;
            this.fermeraj_Mod.Click += new System.EventHandler(this.fermeraj_Mod_Click);
            // 
            // monthCalendar1_Mod
            // 
            this.monthCalendar1_Mod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.monthCalendar1_Mod.Location = new System.Drawing.Point(301, 32);
            this.monthCalendar1_Mod.Name = "monthCalendar1_Mod";
            this.monthCalendar1_Mod.TabIndex = 15;
            this.monthCalendar1_Mod.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_Mod_DateChanged);
            // 
            // btn_Adh_Valid_Mod
            // 
            this.btn_Adh_Valid_Mod.Location = new System.Drawing.Point(301, 248);
            this.btn_Adh_Valid_Mod.Name = "btn_Adh_Valid_Mod";
            this.btn_Adh_Valid_Mod.Size = new System.Drawing.Size(75, 23);
            this.btn_Adh_Valid_Mod.TabIndex = 16;
            this.btn_Adh_Valid_Mod.Text = "Modifier";
            this.btn_Adh_Valid_Mod.UseVisualStyleBackColor = true;
            this.btn_Adh_Valid_Mod.Click += new System.EventHandler(this.btn_Adh_Valid_Mod_Click);
            // 
            // lbl_naissance_adh_Mod
            // 
            this.lbl_naissance_adh_Mod.AutoSize = true;
            this.lbl_naissance_adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naissance_adh_Mod.Location = new System.Drawing.Point(6, 99);
            this.lbl_naissance_adh_Mod.Name = "lbl_naissance_adh_Mod";
            this.lbl_naissance_adh_Mod.Size = new System.Drawing.Size(130, 17);
            this.lbl_naissance_adh_Mod.TabIndex = 4;
            this.lbl_naissance_adh_Mod.Text = "Date de naissance";
            // 
            // Modi
            // 
            this.Modi.Controls.Add(this.btn_suppr_Adh);
            this.Modi.Controls.Add(this.fermeraj_Mod);
            this.Modi.Controls.Add(this.monthCalendar1_Mod);
            this.Modi.Controls.Add(this.btn_Adh_Valid_Mod);
            this.Modi.Controls.Add(this.lbl_naissance_adh_Mod);
            this.Modi.Controls.Add(this.cbb_Adh_Club_Mod);
            this.Modi.Controls.Add(this.txt_Nom_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Club_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Nom_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Adr_Adh_Mod);
            this.Modi.Controls.Add(this.txt_Prenom_Adh_Mod);
            this.Modi.Controls.Add(this.txt_Adr_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Prenom_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Ville_Adh_Mod);
            this.Modi.Controls.Add(this.txt_naissance_adh_Mod);
            this.Modi.Controls.Add(this.txt_Ville_Adh_Mod);
            this.Modi.Controls.Add(this.txt_Cp_Adh_Mod);
            this.Modi.Controls.Add(this.lbl_Cp_Adh_Mod);
            this.Modi.Location = new System.Drawing.Point(2, 2);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(540, 314);
            this.Modi.TabIndex = 18;
            this.Modi.TabStop = false;
            this.Modi.Text = "ajouter";
            // 
            // btn_suppr_Adh
            // 
            this.btn_suppr_Adh.Location = new System.Drawing.Point(382, 248);
            this.btn_suppr_Adh.Name = "btn_suppr_Adh";
            this.btn_suppr_Adh.Size = new System.Drawing.Size(65, 23);
            this.btn_suppr_Adh.TabIndex = 18;
            this.btn_suppr_Adh.Text = "Supprimer";
            this.btn_suppr_Adh.UseVisualStyleBackColor = true;
            this.btn_suppr_Adh.Click += new System.EventHandler(this.btn_suppr_Adh_Click);
            // 
            // cbb_Adh_Club_Mod
            // 
            this.cbb_Adh_Club_Mod.FormattingEnabled = true;
            this.cbb_Adh_Club_Mod.Location = new System.Drawing.Point(149, 250);
            this.cbb_Adh_Club_Mod.Name = "cbb_Adh_Club_Mod";
            this.cbb_Adh_Club_Mod.Size = new System.Drawing.Size(81, 21);
            this.cbb_Adh_Club_Mod.TabIndex = 14;
            // 
            // txt_Nom_Adh_Mod
            // 
            this.txt_Nom_Adh_Mod.Location = new System.Drawing.Point(149, 17);
            this.txt_Nom_Adh_Mod.Mask = "LLLLLLLLLLLL";
            this.txt_Nom_Adh_Mod.Name = "txt_Nom_Adh_Mod";
            this.txt_Nom_Adh_Mod.PromptChar = ' ';
            this.txt_Nom_Adh_Mod.Size = new System.Drawing.Size(81, 20);
            this.txt_Nom_Adh_Mod.TabIndex = 0;
            // 
            // lbl_Club_Adh_Mod
            // 
            this.lbl_Club_Adh_Mod.AutoSize = true;
            this.lbl_Club_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Club_Adh_Mod.Location = new System.Drawing.Point(6, 250);
            this.lbl_Club_Adh_Mod.Name = "lbl_Club_Adh_Mod";
            this.lbl_Club_Adh_Mod.Size = new System.Drawing.Size(38, 17);
            this.lbl_Club_Adh_Mod.TabIndex = 12;
            this.lbl_Club_Adh_Mod.Text = "Club";
            // 
            // lbl_Nom_Adh_Mod
            // 
            this.lbl_Nom_Adh_Mod.AutoSize = true;
            this.lbl_Nom_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom_Adh_Mod.Location = new System.Drawing.Point(6, 20);
            this.lbl_Nom_Adh_Mod.Name = "lbl_Nom_Adh_Mod";
            this.lbl_Nom_Adh_Mod.Size = new System.Drawing.Size(39, 17);
            this.lbl_Nom_Adh_Mod.TabIndex = 1;
            this.lbl_Nom_Adh_Mod.Text = "Nom";
            // 
            // lbl_Adr_Adh_Mod
            // 
            this.lbl_Adr_Adh_Mod.AutoSize = true;
            this.lbl_Adr_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adr_Adh_Mod.Location = new System.Drawing.Point(6, 213);
            this.lbl_Adr_Adh_Mod.Name = "lbl_Adr_Adh_Mod";
            this.lbl_Adr_Adh_Mod.Size = new System.Drawing.Size(62, 17);
            this.lbl_Adr_Adh_Mod.TabIndex = 11;
            this.lbl_Adr_Adh_Mod.Text = "Adresse";
            // 
            // txt_Prenom_Adh_Mod
            // 
            this.txt_Prenom_Adh_Mod.Location = new System.Drawing.Point(149, 58);
            this.txt_Prenom_Adh_Mod.Mask = "LLLLLLLLLLLL";
            this.txt_Prenom_Adh_Mod.Name = "txt_Prenom_Adh_Mod";
            this.txt_Prenom_Adh_Mod.PromptChar = ' ';
            this.txt_Prenom_Adh_Mod.Size = new System.Drawing.Size(81, 20);
            this.txt_Prenom_Adh_Mod.TabIndex = 2;
            // 
            // txt_Adr_Adh_Mod
            // 
            this.txt_Adr_Adh_Mod.Location = new System.Drawing.Point(149, 210);
            this.txt_Adr_Adh_Mod.Mask = "AAAAAAAAAAAA";
            this.txt_Adr_Adh_Mod.Name = "txt_Adr_Adh_Mod";
            this.txt_Adr_Adh_Mod.PromptChar = ' ';
            this.txt_Adr_Adh_Mod.Size = new System.Drawing.Size(119, 20);
            this.txt_Adr_Adh_Mod.TabIndex = 10;
            // 
            // lbl_Prenom_Adh_Mod
            // 
            this.lbl_Prenom_Adh_Mod.AutoSize = true;
            this.lbl_Prenom_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom_Adh_Mod.Location = new System.Drawing.Point(6, 61);
            this.lbl_Prenom_Adh_Mod.Name = "lbl_Prenom_Adh_Mod";
            this.lbl_Prenom_Adh_Mod.Size = new System.Drawing.Size(60, 17);
            this.lbl_Prenom_Adh_Mod.TabIndex = 3;
            this.lbl_Prenom_Adh_Mod.Text = "Prénom";
            // 
            // lbl_Ville_Adh_Mod
            // 
            this.lbl_Ville_Adh_Mod.AutoSize = true;
            this.lbl_Ville_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ville_Adh_Mod.Location = new System.Drawing.Point(6, 174);
            this.lbl_Ville_Adh_Mod.Name = "lbl_Ville_Adh_Mod";
            this.lbl_Ville_Adh_Mod.Size = new System.Drawing.Size(34, 17);
            this.lbl_Ville_Adh_Mod.TabIndex = 9;
            this.lbl_Ville_Adh_Mod.Text = "Ville";
            // 
            // txt_naissance_adh_Mod
            // 
            this.txt_naissance_adh_Mod.Location = new System.Drawing.Point(149, 96);
            this.txt_naissance_adh_Mod.Mask = "00/00/0000";
            this.txt_naissance_adh_Mod.Name = "txt_naissance_adh_Mod";
            this.txt_naissance_adh_Mod.PromptChar = ' ';
            this.txt_naissance_adh_Mod.Size = new System.Drawing.Size(81, 20);
            this.txt_naissance_adh_Mod.TabIndex = 5;
            this.txt_naissance_adh_Mod.ValidatingType = typeof(System.DateTime);
            // 
            // txt_Ville_Adh_Mod
            // 
            this.txt_Ville_Adh_Mod.Location = new System.Drawing.Point(149, 174);
            this.txt_Ville_Adh_Mod.Mask = "AAAAAAAAAAAAAAAAA";
            this.txt_Ville_Adh_Mod.Name = "txt_Ville_Adh_Mod";
            this.txt_Ville_Adh_Mod.PromptChar = ' ';
            this.txt_Ville_Adh_Mod.Size = new System.Drawing.Size(119, 20);
            this.txt_Ville_Adh_Mod.TabIndex = 8;
            // 
            // txt_Cp_Adh_Mod
            // 
            this.txt_Cp_Adh_Mod.Location = new System.Drawing.Point(149, 135);
            this.txt_Cp_Adh_Mod.Mask = "00000";
            this.txt_Cp_Adh_Mod.Name = "txt_Cp_Adh_Mod";
            this.txt_Cp_Adh_Mod.PromptChar = ' ';
            this.txt_Cp_Adh_Mod.Size = new System.Drawing.Size(81, 20);
            this.txt_Cp_Adh_Mod.TabIndex = 6;
            // 
            // lbl_Cp_Adh_Mod
            // 
            this.lbl_Cp_Adh_Mod.AutoSize = true;
            this.lbl_Cp_Adh_Mod.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cp_Adh_Mod.Location = new System.Drawing.Point(6, 135);
            this.lbl_Cp_Adh_Mod.Name = "lbl_Cp_Adh_Mod";
            this.lbl_Cp_Adh_Mod.Size = new System.Drawing.Size(88, 17);
            this.lbl_Cp_Adh_Mod.TabIndex = 7;
            this.lbl_Cp_Adh_Mod.Text = "Code Postal";
            // 
            // Modifer_Adh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.Modi);
            this.Name = "Modifer_Adh";
            this.Text = "Modifer_Adh";
            this.Load += new System.EventHandler(this.Modifer_Adh_Load);
            this.Modi.ResumeLayout(false);
            this.Modi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fermeraj_Mod;
        private System.Windows.Forms.MonthCalendar monthCalendar1_Mod;
        private System.Windows.Forms.Button btn_Adh_Valid_Mod;
        private System.Windows.Forms.Label lbl_naissance_adh_Mod;
        private System.Windows.Forms.GroupBox Modi;
        private System.Windows.Forms.ComboBox cbb_Adh_Club_Mod;
        private System.Windows.Forms.MaskedTextBox txt_Nom_Adh_Mod;
        private System.Windows.Forms.Label lbl_Club_Adh_Mod;
        private System.Windows.Forms.Label lbl_Nom_Adh_Mod;
        private System.Windows.Forms.Label lbl_Adr_Adh_Mod;
        private System.Windows.Forms.MaskedTextBox txt_Prenom_Adh_Mod;
        private System.Windows.Forms.MaskedTextBox txt_Adr_Adh_Mod;
        private System.Windows.Forms.Label lbl_Prenom_Adh_Mod;
        private System.Windows.Forms.Label lbl_Ville_Adh_Mod;
        private System.Windows.Forms.MaskedTextBox txt_naissance_adh_Mod;
        private System.Windows.Forms.MaskedTextBox txt_Ville_Adh_Mod;
        private System.Windows.Forms.MaskedTextBox txt_Cp_Adh_Mod;
        private System.Windows.Forms.Label lbl_Cp_Adh_Mod;
        private System.Windows.Forms.Button btn_suppr_Adh;
    }
}