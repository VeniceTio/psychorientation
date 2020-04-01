namespace psychorientation
{
    partial class ListeEleve
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
            this.lblListeEleve = new System.Windows.Forms.Label();
            this.pnlListeEleve = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblListeEleve
            // 
            this.lblListeEleve.AutoSize = true;
            this.lblListeEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblListeEleve.Location = new System.Drawing.Point(23, 9);
            this.lblListeEleve.Name = "lblListeEleve";
            this.lblListeEleve.Size = new System.Drawing.Size(258, 24);
            this.lblListeEleve.TabIndex = 0;
            this.lblListeEleve.Text = "Liste des élèves de la classe :";
            // 
            // pnlListeEleve
            // 
            this.pnlListeEleve.AutoScroll = true;
            this.pnlListeEleve.Location = new System.Drawing.Point(13, 47);
            this.pnlListeEleve.Name = "pnlListeEleve";
            this.pnlListeEleve.Size = new System.Drawing.Size(277, 400);
            this.pnlListeEleve.TabIndex = 1;
            // 
            // ListeEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 458);
            this.Controls.Add(this.pnlListeEleve);
            this.Controls.Add(this.lblListeEleve);
            this.Name = "ListeEleve";
            this.Text = "ListeEleve";
            this.Load += new System.EventHandler(this.ListeEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListeEleve;
        private System.Windows.Forms.Panel pnlListeEleve;
    }
}