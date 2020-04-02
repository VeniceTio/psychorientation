namespace psychorientation
{
    partial class InterfaceClasse
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
            this.pb_action_suivante = new System.Windows.Forms.PictureBox();
            this.pb_liste_eleves = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pb_sortir = new System.Windows.Forms.PictureBox();
            this.lblClasse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_liste_eleves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sortir)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_action_suivante
            // 
            this.pb_action_suivante.BackColor = System.Drawing.Color.Transparent;
            this.pb_action_suivante.BackgroundImage = global::psychorientation.Properties.Resources.passer;
            this.pb_action_suivante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_action_suivante.InitialImage = null;
            this.pb_action_suivante.Location = new System.Drawing.Point(1225, 651);
            this.pb_action_suivante.Name = "pb_action_suivante";
            this.pb_action_suivante.Size = new System.Drawing.Size(120, 120);
            this.pb_action_suivante.TabIndex = 0;
            this.pb_action_suivante.TabStop = false;
            this.pb_action_suivante.Click += new System.EventHandler(this.Pb_action_suivante_Click);
            // 
            // pb_liste_eleves
            // 
            this.pb_liste_eleves.BackColor = System.Drawing.Color.Transparent;
            this.pb_liste_eleves.BackgroundImage = global::psychorientation.Properties.Resources.grp;
            this.pb_liste_eleves.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_liste_eleves.Location = new System.Drawing.Point(12, 12);
            this.pb_liste_eleves.Name = "pb_liste_eleves";
            this.pb_liste_eleves.Size = new System.Drawing.Size(100, 100);
            this.pb_liste_eleves.TabIndex = 1;
            this.pb_liste_eleves.TabStop = false;
            this.pb_liste_eleves.Click += new System.EventHandler(this.Pb_liste_eleves_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(269, 171);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(129, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Chargement...";
            // 
            // pb_sortir
            // 
            this.pb_sortir.BackColor = System.Drawing.Color.Transparent;
            this.pb_sortir.BackgroundImage = global::psychorientation.Properties.Resources.sortir;
            this.pb_sortir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_sortir.Location = new System.Drawing.Point(1283, -1);
            this.pb_sortir.Name = "pb_sortir";
            this.pb_sortir.Size = new System.Drawing.Size(75, 75);
            this.pb_sortir.TabIndex = 3;
            this.pb_sortir.TabStop = false;
            this.pb_sortir.Click += new System.EventHandler(this.Pb_sortir_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.BackColor = System.Drawing.Color.Transparent;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.ForeColor = System.Drawing.Color.White;
            this.lblClasse.Location = new System.Drawing.Point(943, 171);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(129, 24);
            this.lblClasse.TabIndex = 4;
            this.lblClasse.Text = "Chargement...";
            // 
            // InterfaceClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::psychorientation.Properties.Resources.salleV11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 783);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.pb_sortir);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pb_liste_eleves);
            this.Controls.Add(this.pb_action_suivante);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InterfaceClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psychorientation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.InterfaceClasse_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_liste_eleves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sortir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_action_suivante;
        private System.Windows.Forms.PictureBox pb_liste_eleves;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pb_sortir;
        private System.Windows.Forms.Label lblClasse;
    }
}

