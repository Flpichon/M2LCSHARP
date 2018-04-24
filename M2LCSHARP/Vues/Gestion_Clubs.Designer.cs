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
            this.btn_Ajouter_Clb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Club)).BeginInit();
            this.SuspendLayout();
            // 
            // Dt_Club
            // 
            this.Dt_Club.AllowUserToDeleteRows = false;
            this.Dt_Club.AllowUserToResizeColumns = false;
            this.Dt_Club.AllowUserToResizeRows = false;
            this.Dt_Club.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Club.Location = new System.Drawing.Point(12, 27);
            this.Dt_Club.Name = "Dt_Club";
            this.Dt_Club.ReadOnly = true;
            this.Dt_Club.Size = new System.Drawing.Size(524, 192);
            this.Dt_Club.TabIndex = 1;
            // 
            // btn_Ajouter_Clb
            // 
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
            // Gestion_Clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.btn_Ajouter_Clb);
            this.Controls.Add(this.Dt_Club);
            this.Name = "Gestion_Clubs";
            this.Text = "Gestion_Clubs";
            this.Load += new System.EventHandler(this.Gestion_Clubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Club)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dt_Club;
        private System.Windows.Forms.Button btn_Ajouter_Clb;
    }
}