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
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_liste_eleves)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_action_suivante
            // 
            this.pb_action_suivante.BackColor = System.Drawing.SystemColors.Control;
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
            this.pb_liste_eleves.Location = new System.Drawing.Point(12, 12);
            this.pb_liste_eleves.Name = "pb_liste_eleves";
            this.pb_liste_eleves.Size = new System.Drawing.Size(100, 100);
            this.pb_liste_eleves.TabIndex = 1;
            this.pb_liste_eleves.TabStop = false;
            this.pb_liste_eleves.Click += new System.EventHandler(this.Pb_liste_eleves_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(118, 12);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(163, 29);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Chargement...";
            // 
            // InterfaceClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::psychorientation.Properties.Resources.salleV1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 783);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.pb_liste_eleves);
            this.Controls.Add(this.pb_action_suivante);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InterfaceClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psychorientation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.InterfaceClasse_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_liste_eleves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_action_suivante;
        private System.Windows.Forms.PictureBox pb_liste_eleves;
        private System.Windows.Forms.Label lbl_date;
    }
}

