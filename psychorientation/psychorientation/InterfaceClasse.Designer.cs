﻿namespace psychorientation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceClasse));
            this.pb_action_suivante = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pb_sortir = new System.Windows.Forms.PictureBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.lblEffort = new System.Windows.Forms.Label();
            this.pnlListeEleve = new System.Windows.Forms.Panel();
            this.lblListeEleve = new System.Windows.Forms.Label();
            this.imgListPerso = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sortir)).BeginInit();
            this.pnlListeEleve.SuspendLayout();
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
            // lblMoyenne
            // 
            this.lblMoyenne.AutoSize = true;
            this.lblMoyenne.BackColor = System.Drawing.Color.Transparent;
            this.lblMoyenne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenne.ForeColor = System.Drawing.Color.White;
            this.lblMoyenne.Location = new System.Drawing.Point(544, 154);
            this.lblMoyenne.Name = "lblMoyenne";
            this.lblMoyenne.Size = new System.Drawing.Size(101, 18);
            this.lblMoyenne.TabIndex = 5;
            this.lblMoyenne.Text = "Chargement...";
            // 
            // lblCompetence
            // 
            this.lblCompetence.AutoSize = true;
            this.lblCompetence.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetence.ForeColor = System.Drawing.Color.White;
            this.lblCompetence.Location = new System.Drawing.Point(544, 175);
            this.lblCompetence.Name = "lblCompetence";
            this.lblCompetence.Size = new System.Drawing.Size(101, 18);
            this.lblCompetence.TabIndex = 6;
            this.lblCompetence.Text = "Chargement...";
            // 
            // lblEffort
            // 
            this.lblEffort.AutoSize = true;
            this.lblEffort.BackColor = System.Drawing.Color.Transparent;
            this.lblEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffort.ForeColor = System.Drawing.Color.White;
            this.lblEffort.Location = new System.Drawing.Point(544, 196);
            this.lblEffort.Name = "lblEffort";
            this.lblEffort.Size = new System.Drawing.Size(101, 18);
            this.lblEffort.TabIndex = 7;
            this.lblEffort.Text = "Chargement...";
            // 
            // pnlListeEleve
            // 
            this.pnlListeEleve.AutoScroll = true;
            this.pnlListeEleve.BackColor = System.Drawing.Color.Transparent;
            this.pnlListeEleve.Controls.Add(this.lblListeEleve);
            this.pnlListeEleve.Location = new System.Drawing.Point(0, -1);
            this.pnlListeEleve.Name = "pnlListeEleve";
            this.pnlListeEleve.Size = new System.Drawing.Size(241, 783);
            this.pnlListeEleve.TabIndex = 5;
            // 
            // lblListeEleve
            // 
            this.lblListeEleve.AutoSize = true;
            this.lblListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEleve.Location = new System.Drawing.Point(3, 0);
            this.lblListeEleve.Name = "lblListeEleve";
            this.lblListeEleve.Size = new System.Drawing.Size(217, 29);
            this.lblListeEleve.TabIndex = 0;
            this.lblListeEleve.Text = "Liste des élèves :";
            // 
            // imgListPerso
            // 
            this.imgListPerso.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListPerso.ImageStream")));
            this.imgListPerso.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListPerso.Images.SetKeyName(0, "personnage1.png");
            this.imgListPerso.Images.SetKeyName(1, "personnage2.png");
            this.imgListPerso.Images.SetKeyName(2, "personnage3.png");
            this.imgListPerso.Images.SetKeyName(3, "personnage4.png");
            this.imgListPerso.Images.SetKeyName(4, "prof1.png");
            this.imgListPerso.Images.SetKeyName(5, "prof2.png");
            // 
            // InterfaceClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 783);
            this.Controls.Add(this.lblEffort);
            this.Controls.Add(this.lblCompetence);
            this.Controls.Add(this.lblMoyenne);
            this.Controls.Add(this.pnlListeEleve);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.pb_sortir);
            this.Controls.Add(this.lblDate);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_sortir)).EndInit();
            this.pnlListeEleve.ResumeLayout(false);
            this.pnlListeEleve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_action_suivante;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pb_sortir;
        private System.Windows.Forms.Label lblClasse;

        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.Label lblCompetence;
        private System.Windows.Forms.Label lblEffort;

        private System.Windows.Forms.Panel pnlListeEleve;
        private System.Windows.Forms.Label lblListeEleve;
        private System.Windows.Forms.ImageList imgListPerso;
    }
}

