namespace M2LCSHARP.Vues
{
    partial class ajout_event
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
            this.ajout = new System.Windows.Forms.GroupBox();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.fermeraj = new System.Windows.Forms.Button();
            this.btn_Event_Valid = new System.Windows.Forms.Button();
            this.txt_Titre_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Titre_Event = new System.Windows.Forms.Label();
            this.txt_Début_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Début_Event = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.txt_Fin_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Fin_Event = new System.Windows.Forms.Label();
            this.cbb_club_Event = new System.Windows.Forms.ComboBox();
            this.ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajout
            // 
            this.ajout.Controls.Add(this.cbb_club_Event);
            this.ajout.Controls.Add(this.lbl_erreur);
            this.ajout.Controls.Add(this.fermeraj);
            this.ajout.Controls.Add(this.btn_Event_Valid);
            this.ajout.Controls.Add(this.txt_Titre_Event);
            this.ajout.Controls.Add(this.lbl_Titre_Event);
            this.ajout.Controls.Add(this.txt_Début_Event);
            this.ajout.Controls.Add(this.lbl_Début_Event);
            this.ajout.Controls.Add(this.lbl_);
            this.ajout.Controls.Add(this.txt_Fin_Event);
            this.ajout.Controls.Add(this.lbl_Fin_Event);
            this.ajout.Location = new System.Drawing.Point(2, 0);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(540, 314);
            this.ajout.TabIndex = 19;
            this.ajout.TabStop = false;
            this.ajout.Text = "ajouter";
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(364, 155);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(0, 13);
            this.lbl_erreur.TabIndex = 23;
            // 
            // fermeraj
            // 
            this.fermeraj.Location = new System.Drawing.Point(388, 274);
            this.fermeraj.Name = "fermeraj";
            this.fermeraj.Size = new System.Drawing.Size(75, 23);
            this.fermeraj.TabIndex = 17;
            this.fermeraj.Text = "Fermer";
            this.fermeraj.UseVisualStyleBackColor = true;
            // 
            // btn_Event_Valid
            // 
            this.btn_Event_Valid.Location = new System.Drawing.Point(230, 230);
            this.btn_Event_Valid.Name = "btn_Event_Valid";
            this.btn_Event_Valid.Size = new System.Drawing.Size(75, 23);
            this.btn_Event_Valid.TabIndex = 16;
            this.btn_Event_Valid.Text = "Ajouter";
            this.btn_Event_Valid.UseVisualStyleBackColor = true;
            this.btn_Event_Valid.Click += new System.EventHandler(this.btn_Event_Valid_Click);
            // 
            // txt_Titre_Event
            // 
            this.txt_Titre_Event.Location = new System.Drawing.Point(206, 28);
            this.txt_Titre_Event.Name = "txt_Titre_Event";
            this.txt_Titre_Event.PromptChar = ' ';
            this.txt_Titre_Event.Size = new System.Drawing.Size(119, 20);
            this.txt_Titre_Event.TabIndex = 0;
            // 
            // lbl_Titre_Event
            // 
            this.lbl_Titre_Event.AutoSize = true;
            this.lbl_Titre_Event.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre_Event.Location = new System.Drawing.Point(154, 28);
            this.lbl_Titre_Event.Name = "lbl_Titre_Event";
            this.lbl_Titre_Event.Size = new System.Drawing.Size(36, 17);
            this.lbl_Titre_Event.TabIndex = 1;
            this.lbl_Titre_Event.Text = "Titre";
            // 
            // txt_Début_Event
            // 
            this.txt_Début_Event.Location = new System.Drawing.Point(206, 81);
            this.txt_Début_Event.Mask = "00/00/0000";
            this.txt_Début_Event.Name = "txt_Début_Event";
            this.txt_Début_Event.PromptChar = ' ';
            this.txt_Début_Event.Size = new System.Drawing.Size(119, 20);
            this.txt_Début_Event.TabIndex = 2;
            this.txt_Début_Event.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Début_Event
            // 
            this.lbl_Début_Event.AutoSize = true;
            this.lbl_Début_Event.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Début_Event.Location = new System.Drawing.Point(143, 84);
            this.lbl_Début_Event.Name = "lbl_Début_Event";
            this.lbl_Début_Event.Size = new System.Drawing.Size(47, 17);
            this.lbl_Début_Event.TabIndex = 3;
            this.lbl_Début_Event.Text = "Début";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_.Location = new System.Drawing.Point(152, 191);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(38, 17);
            this.lbl_.TabIndex = 9;
            this.lbl_.Text = "Club";
            // 
            // txt_Fin_Event
            // 
            this.txt_Fin_Event.Location = new System.Drawing.Point(206, 135);
            this.txt_Fin_Event.Mask = "00/00/0000";
            this.txt_Fin_Event.Name = "txt_Fin_Event";
            this.txt_Fin_Event.PromptChar = ' ';
            this.txt_Fin_Event.Size = new System.Drawing.Size(119, 20);
            this.txt_Fin_Event.TabIndex = 6;
            this.txt_Fin_Event.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Fin_Event
            // 
            this.lbl_Fin_Event.AutoSize = true;
            this.lbl_Fin_Event.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fin_Event.Location = new System.Drawing.Point(162, 138);
            this.lbl_Fin_Event.Name = "lbl_Fin_Event";
            this.lbl_Fin_Event.Size = new System.Drawing.Size(28, 17);
            this.lbl_Fin_Event.TabIndex = 7;
            this.lbl_Fin_Event.Text = "Fin";
            // 
            // cbb_club_Event
            // 
            this.cbb_club_Event.FormattingEnabled = true;
            this.cbb_club_Event.Location = new System.Drawing.Point(206, 191);
            this.cbb_club_Event.Name = "cbb_club_Event";
            this.cbb_club_Event.Size = new System.Drawing.Size(121, 21);
            this.cbb_club_Event.TabIndex = 24;
            // 
            // ajout_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 275);
            this.Controls.Add(this.ajout);
            this.Name = "ajout_event";
            this.Text = "ajout_event";
            this.Load += new System.EventHandler(this.ajout_event_Load);
            this.ajout.ResumeLayout(false);
            this.ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ajout;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.Button fermeraj;
        private System.Windows.Forms.Button btn_Event_Valid;
        private System.Windows.Forms.MaskedTextBox txt_Titre_Event;
        private System.Windows.Forms.Label lbl_Titre_Event;
        private System.Windows.Forms.MaskedTextBox txt_Début_Event;
        private System.Windows.Forms.Label lbl_Début_Event;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.MaskedTextBox txt_Fin_Event;
        private System.Windows.Forms.Label lbl_Fin_Event;
        private System.Windows.Forms.ComboBox cbb_club_Event;
    }
}