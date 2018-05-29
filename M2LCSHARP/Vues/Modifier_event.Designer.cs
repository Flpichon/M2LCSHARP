namespace M2LCSHARP.Vues
{
    partial class Modifier_event
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
            this.txt_club_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.fermermod = new System.Windows.Forms.Button();
            this.btn_Event_Modifer = new System.Windows.Forms.Button();
            this.txt_Titre_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Titre_Event = new System.Windows.Forms.Label();
            this.txt_Début_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Début_Event = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.txt_Fin_Event = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Fin_Event = new System.Windows.Forms.Label();
            this.btn_sup_event = new System.Windows.Forms.Button();
            this.ajout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajout
            // 
            this.ajout.Controls.Add(this.btn_sup_event);
            this.ajout.Controls.Add(this.txt_club_Event);
            this.ajout.Controls.Add(this.lbl_erreur);
            this.ajout.Controls.Add(this.fermermod);
            this.ajout.Controls.Add(this.btn_Event_Modifer);
            this.ajout.Controls.Add(this.txt_Titre_Event);
            this.ajout.Controls.Add(this.lbl_Titre_Event);
            this.ajout.Controls.Add(this.txt_Début_Event);
            this.ajout.Controls.Add(this.lbl_Début_Event);
            this.ajout.Controls.Add(this.lbl_);
            this.ajout.Controls.Add(this.txt_Fin_Event);
            this.ajout.Controls.Add(this.lbl_Fin_Event);
            this.ajout.Location = new System.Drawing.Point(3, 2);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(540, 314);
            this.ajout.TabIndex = 20;
            this.ajout.TabStop = false;
            this.ajout.Text = "Modifier";
            // 
            // txt_club_Event
            // 
            this.txt_club_Event.Location = new System.Drawing.Point(206, 188);
            this.txt_club_Event.Name = "txt_club_Event";
            this.txt_club_Event.PromptChar = ' ';
            this.txt_club_Event.ReadOnly = true;
            this.txt_club_Event.Size = new System.Drawing.Size(119, 20);
            this.txt_club_Event.TabIndex = 24;
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
            // fermermod
            // 
            this.fermermod.Location = new System.Drawing.Point(306, 229);
            this.fermermod.Name = "fermermod";
            this.fermermod.Size = new System.Drawing.Size(75, 23);
            this.fermermod.TabIndex = 17;
            this.fermermod.Text = "Annuler";
            this.fermermod.UseVisualStyleBackColor = true;
            // 
            // btn_Event_Modifer
            // 
            this.btn_Event_Modifer.Location = new System.Drawing.Point(125, 229);
            this.btn_Event_Modifer.Name = "btn_Event_Modifer";
            this.btn_Event_Modifer.Size = new System.Drawing.Size(75, 23);
            this.btn_Event_Modifer.TabIndex = 16;
            this.btn_Event_Modifer.Text = "Modifier";
            this.btn_Event_Modifer.UseVisualStyleBackColor = true;
            this.btn_Event_Modifer.Click += new System.EventHandler(this.btn_Event_Modifer_Click);
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
            // btn_sup_event
            // 
            this.btn_sup_event.Location = new System.Drawing.Point(215, 229);
            this.btn_sup_event.Name = "btn_sup_event";
            this.btn_sup_event.Size = new System.Drawing.Size(75, 23);
            this.btn_sup_event.TabIndex = 25;
            this.btn_sup_event.Text = "Supprimer";
            this.btn_sup_event.UseVisualStyleBackColor = true;
            this.btn_sup_event.Click += new System.EventHandler(this.btn_sup_event_Click);
            // 
            // Modifier_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 275);
            this.Controls.Add(this.ajout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 314);
            this.MinimumSize = new System.Drawing.Size(540, 314);
            this.Name = "Modifier_event";
            this.Text = "Modifier_event";
            this.Load += new System.EventHandler(this.Modifier_event_Load);
            this.ajout.ResumeLayout(false);
            this.ajout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ajout;
        private System.Windows.Forms.MaskedTextBox txt_club_Event;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.Button fermermod;
        private System.Windows.Forms.Button btn_Event_Modifer;
        private System.Windows.Forms.MaskedTextBox txt_Titre_Event;
        private System.Windows.Forms.Label lbl_Titre_Event;
        private System.Windows.Forms.MaskedTextBox txt_Début_Event;
        private System.Windows.Forms.Label lbl_Début_Event;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.MaskedTextBox txt_Fin_Event;
        private System.Windows.Forms.Label lbl_Fin_Event;
        private System.Windows.Forms.Button btn_sup_event;
    }
}