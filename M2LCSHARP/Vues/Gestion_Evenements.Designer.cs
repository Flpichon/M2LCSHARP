namespace M2LCSHARP.Vues
{
    partial class Gestion_Evenements
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
            this.btncloseEvent = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btn_Ajouter_Event = new System.Windows.Forms.Button();
            this.Dt_Event = new System.Windows.Forms.DataGridView();
            this.Id_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debut_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Event)).BeginInit();
            this.SuspendLayout();
            // 
            // btncloseEvent
            // 
            this.btncloseEvent.Location = new System.Drawing.Point(426, 270);
            this.btncloseEvent.Name = "btncloseEvent";
            this.btncloseEvent.Size = new System.Drawing.Size(75, 23);
            this.btncloseEvent.TabIndex = 9;
            this.btncloseEvent.Text = "fermer";
            this.btncloseEvent.UseVisualStyleBackColor = true;
            this.btncloseEvent.Click += new System.EventHandler(this.btncloseEvent_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(345, 270);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 8;
            this.btnrefresh.Text = "raffraichir";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btn_Ajouter_Event
            // 
            this.btn_Ajouter_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Ajouter_Event.BackColor = System.Drawing.Color.Lime;
            this.btn_Ajouter_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter_Event.Location = new System.Drawing.Point(28, 258);
            this.btn_Ajouter_Event.Name = "btn_Ajouter_Event";
            this.btn_Ajouter_Event.Size = new System.Drawing.Size(75, 45);
            this.btn_Ajouter_Event.TabIndex = 7;
            this.btn_Ajouter_Event.Text = "Ajouter";
            this.btn_Ajouter_Event.UseVisualStyleBackColor = false;
            this.btn_Ajouter_Event.Click += new System.EventHandler(this.btn_Ajouter_Event_Click);
            // 
            // Dt_Event
            // 
            this.Dt_Event.AllowUserToAddRows = false;
            this.Dt_Event.AllowUserToDeleteRows = false;
            this.Dt_Event.AllowUserToOrderColumns = true;
            this.Dt_Event.AllowUserToResizeColumns = false;
            this.Dt_Event.AllowUserToResizeRows = false;
            this.Dt_Event.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dt_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Event.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_event,
            this.Titre_event,
            this.Debut_event,
            this.Fin_event,
            this.Club_event});
            this.Dt_Event.Location = new System.Drawing.Point(48, 12);
            this.Dt_Event.Name = "Dt_Event";
            this.Dt_Event.ReadOnly = true;
            this.Dt_Event.Size = new System.Drawing.Size(453, 226);
            this.Dt_Event.TabIndex = 6;
            this.Dt_Event.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dt_Event_RowHeaderMouseDoubleClick);
            // 
            // Id_event
            // 
            this.Id_event.HeaderText = "Id";
            this.Id_event.Name = "Id_event";
            this.Id_event.ReadOnly = true;
            this.Id_event.Width = 50;
            // 
            // Titre_event
            // 
            this.Titre_event.HeaderText = "Titre";
            this.Titre_event.Name = "Titre_event";
            this.Titre_event.ReadOnly = true;
            // 
            // Debut_event
            // 
            this.Debut_event.HeaderText = "Début";
            this.Debut_event.MaxInputLength = 10;
            this.Debut_event.Name = "Debut_event";
            this.Debut_event.ReadOnly = true;
            this.Debut_event.Width = 80;
            // 
            // Fin_event
            // 
            this.Fin_event.HeaderText = "Fin";
            this.Fin_event.Name = "Fin_event";
            this.Fin_event.ReadOnly = true;
            this.Fin_event.Width = 80;
            // 
            // Club_event
            // 
            this.Club_event.HeaderText = "Club";
            this.Club_event.Name = "Club_event";
            this.Club_event.ReadOnly = true;
            // 
            // Gestion_Evenements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 316);
            this.Controls.Add(this.btncloseEvent);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btn_Ajouter_Event);
            this.Controls.Add(this.Dt_Event);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 355);
            this.MinimumSize = new System.Drawing.Size(564, 355);
            this.Name = "Gestion_Evenements";
            this.Text = "Gestion_Evenements";
            this.Load += new System.EventHandler(this.Gestion_Evenements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Event)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncloseEvent;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btn_Ajouter_Event;
        private System.Windows.Forms.DataGridView Dt_Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debut_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club_event;
    }
}