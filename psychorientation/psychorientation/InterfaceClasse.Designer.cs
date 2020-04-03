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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceClasse));
            this.pb_action_suivante = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblMoyenne = new System.Windows.Forms.Label();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.lblEffort = new System.Windows.Forms.Label();
            this.pnlListeEleve = new System.Windows.Forms.Panel();
            this.lblListeEleve = new System.Windows.Forms.Label();
            this.imgListPerso = new System.Windows.Forms.ImageList(this.components);
            this.pnlChoix = new System.Windows.Forms.Panel();
            this.lbl_barre_decisions = new System.Windows.Forms.Label();
            this.lblCours = new System.Windows.Forms.Label();
            this.lblNotation = new System.Windows.Forms.Label();
            this.pbProf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).BeginInit();
            this.pnlListeEleve.SuspendLayout();
            this.pnlChoix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProf)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_action_suivante
            // 
            this.pb_action_suivante.BackColor = System.Drawing.Color.Transparent;
            this.pb_action_suivante.BackgroundImage = global::psychorientation.Properties.Resources.passer;
            this.pb_action_suivante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_action_suivante.InitialImage = null;
            this.pb_action_suivante.Location = new System.Drawing.Point(1156, 623);
            this.pb_action_suivante.Name = "pb_action_suivante";
            this.pb_action_suivante.Size = new System.Drawing.Size(165, 148);
            this.pb_action_suivante.TabIndex = 0;
            this.pb_action_suivante.TabStop = false;
            this.pb_action_suivante.Click += new System.EventHandler(this.Pb_action_suivante_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(275, 171);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(140, 22);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Chargement...";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.BackColor = System.Drawing.Color.Transparent;
            this.lblClasse.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.ForeColor = System.Drawing.Color.White;
            this.lblClasse.Location = new System.Drawing.Point(949, 171);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(140, 22);
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
            this.pnlListeEleve.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlListeEleve.BackgroundImage = global::psychorientation.Properties.Resources.paternFeuille;
            this.pnlListeEleve.Controls.Add(this.lblListeEleve);
            this.pnlListeEleve.Location = new System.Drawing.Point(0, -1);
            this.pnlListeEleve.Name = "pnlListeEleve";
            this.pnlListeEleve.Size = new System.Drawing.Size(245, 783);
            this.pnlListeEleve.TabIndex = 5;
            // 
            // lblListeEleve
            // 
            this.lblListeEleve.AutoSize = true;
            this.lblListeEleve.BackColor = System.Drawing.Color.Transparent;
            this.lblListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeEleve.ForeColor = System.Drawing.Color.Black;
            this.lblListeEleve.Location = new System.Drawing.Point(10, 4);
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
            // pnlChoix
            // 
            this.pnlChoix.BackgroundImage = global::psychorientation.Properties.Resources.paternFeuille1;
            this.pnlChoix.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChoix.Controls.Add(this.lbl_barre_decisions);
            this.pnlChoix.Controls.Add(this.lblCours);
            this.pnlChoix.Controls.Add(this.lblNotation);
            this.pnlChoix.Location = new System.Drawing.Point(1107, 99);
            this.pnlChoix.Name = "pnlChoix";
            this.pnlChoix.Size = new System.Drawing.Size(189, 323);
            this.pnlChoix.TabIndex = 8;
            // 
            // lbl_barre_decisions
            // 
            this.lbl_barre_decisions.BackColor = System.Drawing.Color.DimGray;
            this.lbl_barre_decisions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_barre_decisions.Location = new System.Drawing.Point(-1, 185);
            this.lbl_barre_decisions.Name = "lbl_barre_decisions";
            this.lbl_barre_decisions.Size = new System.Drawing.Size(189, 10);
            this.lbl_barre_decisions.TabIndex = 2;
            this.lbl_barre_decisions.Text = " ";
            // 
            // lblCours
            // 
            this.lblCours.BackColor = System.Drawing.Color.Transparent;
            this.lblCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCours.ForeColor = System.Drawing.Color.Black;
            this.lblCours.Location = new System.Drawing.Point(13, 204);
            this.lblCours.Name = "lblCours";
            this.lblCours.Size = new System.Drawing.Size(164, 59);
            this.lblCours.TabIndex = 1;
            this.lblCours.Text = "Type de cours visant à aider les élèves de compétence :";
            // 
            // lblNotation
            // 
            this.lblNotation.BackColor = System.Drawing.Color.Transparent;
            this.lblNotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNotation.ForeColor = System.Drawing.Color.Black;
            this.lblNotation.Location = new System.Drawing.Point(13, 20);
            this.lblNotation.Name = "lblNotation";
            this.lblNotation.Size = new System.Drawing.Size(164, 74);
            this.lblNotation.TabIndex = 0;
            this.lblNotation.Text = "Coefficients de prise en compte de l\'effort et de la compétence pour noter :";
            // 
            // pbProf
            // 
            this.pbProf.BackColor = System.Drawing.Color.Transparent;
            this.pbProf.Image = global::psychorientation.Properties.Resources.prof2;
            this.pbProf.Location = new System.Drawing.Point(642, 234);
            this.pbProf.Name = "pbProf";
            this.pbProf.Size = new System.Drawing.Size(71, 93);
            this.pbProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProf.TabIndex = 9;
            this.pbProf.TabStop = false;
            // 
            // InterfaceClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 783);
            this.Controls.Add(this.pbProf);
            this.Controls.Add(this.pnlChoix);
            this.Controls.Add(this.lblEffort);
            this.Controls.Add(this.lblCompetence);
            this.Controls.Add(this.lblMoyenne);
            this.Controls.Add(this.pnlListeEleve);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pb_action_suivante);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "InterfaceClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psychorientation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfaceClasse_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.InterfaceClasse_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InterfaceClasse_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_action_suivante)).EndInit();
            this.pnlListeEleve.ResumeLayout(false);
            this.pnlListeEleve.PerformLayout();
            this.pnlChoix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_action_suivante;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblClasse;

        private System.Windows.Forms.Label lblMoyenne;
        private System.Windows.Forms.Label lblCompetence;
        private System.Windows.Forms.Label lblEffort;

        private System.Windows.Forms.Panel pnlListeEleve;
        private System.Windows.Forms.Label lblListeEleve;
        private System.Windows.Forms.ImageList imgListPerso;
        private System.Windows.Forms.Panel pnlChoix;
        private System.Windows.Forms.Label lblNotation;
        private System.Windows.Forms.Label lblCours;
        private System.Windows.Forms.Label lbl_barre_decisions;
        private System.Windows.Forms.PictureBox pbProf;
    }
}

