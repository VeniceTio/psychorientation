namespace psychorientation
{
    partial class Message
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblEffort = new System.Windows.Forms.Label();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.lblMoyenen = new System.Windows.Forms.Label();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(962, 181);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(116, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(124, 42);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 63);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(962, 116);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "label1";
            this.lblScore.Visible = false;
            // 
            // lblEffort
            // 
            this.lblEffort.AutoSize = true;
            this.lblEffort.BackColor = System.Drawing.Color.Transparent;
            this.lblEffort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffort.Location = new System.Drawing.Point(14, 179);
            this.lblEffort.Name = "lblEffort";
            this.lblEffort.Size = new System.Drawing.Size(66, 24);
            this.lblEffort.TabIndex = 6;
            this.lblEffort.Text = "label2";
            this.lblEffort.Visible = false;
            // 
            // lblCompetence
            // 
            this.lblCompetence.AutoSize = true;
            this.lblCompetence.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetence.Location = new System.Drawing.Point(14, 207);
            this.lblCompetence.Name = "lblCompetence";
            this.lblCompetence.Size = new System.Drawing.Size(66, 24);
            this.lblCompetence.TabIndex = 7;
            this.lblCompetence.Text = "label2";
            this.lblCompetence.Visible = false;
            // 
            // lblMoyenen
            // 
            this.lblMoyenen.AutoSize = true;
            this.lblMoyenen.BackColor = System.Drawing.Color.Transparent;
            this.lblMoyenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoyenen.Location = new System.Drawing.Point(14, 236);
            this.lblMoyenen.Name = "lblMoyenen";
            this.lblMoyenen.Size = new System.Drawing.Size(66, 24);
            this.lblMoyenen.TabIndex = 8;
            this.lblMoyenen.Text = "label2";
            this.lblMoyenen.Visible = false;
            this.lblMoyenen.Click += new System.EventHandler(this.lblMoyenen_Click);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejouer.Location = new System.Drawing.Point(548, 284);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(172, 51);
            this.btnRejouer.TabIndex = 9;
            this.btnRejouer.Text = "Rejouer";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.btnRejouer_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::psychorientation.Properties.Resources.paternFeuille;
            this.ClientSize = new System.Drawing.Size(986, 347);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.lblMoyenen);
            this.Controls.Add(this.lblCompetence);
            this.Controls.Add(this.lblEffort);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblEffort;
        private System.Windows.Forms.Label lblCompetence;
        private System.Windows.Forms.Label lblMoyenen;
        private System.Windows.Forms.Button btnRejouer;
    }
}