﻿namespace M2LCSHARP.Vues
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(524, 192);
            this.dataGridView1.TabIndex = 0;
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
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
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
    }
}