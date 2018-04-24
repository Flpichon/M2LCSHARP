namespace M2LCSHARP
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Club = new System.Windows.Forms.Button();
            this.Adherents = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logofranck.png");
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 260);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Club);
            this.panel2.Controls.Add(this.Adherents);
            this.panel2.Location = new System.Drawing.Point(2, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 48);
            this.panel2.TabIndex = 5;
            // 
            // btn_Club
            // 
            this.btn_Club.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Club.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Club.Location = new System.Drawing.Point(395, 6);
            this.btn_Club.Name = "btn_Club";
            this.btn_Club.Size = new System.Drawing.Size(101, 37);
            this.btn_Club.TabIndex = 1;
            this.btn_Club.Text = "Clubs";
            this.btn_Club.UseVisualStyleBackColor = false;
            this.btn_Club.Click += new System.EventHandler(this.btn_Club_Click);
            // 
            // Adherents
            // 
            this.Adherents.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Adherents.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adherents.Location = new System.Drawing.Point(49, 6);
            this.Adherents.Name = "Adherents";
            this.Adherents.Size = new System.Drawing.Size(101, 37);
            this.Adherents.TabIndex = 0;
            this.Adherents.Text = "Adhérents";
            this.Adherents.UseVisualStyleBackColor = false;
            this.Adherents.Click += new System.EventHandler(this.Adherents_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Accueil";
            this.Text = "Accueil M2L";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Adherents;
        private System.Windows.Forms.Button btn_Club;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

