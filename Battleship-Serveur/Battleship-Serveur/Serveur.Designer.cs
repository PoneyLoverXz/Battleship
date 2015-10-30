namespace Battleship_Serveur
{
    partial class Serveur
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
            this.TB_Affichage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Statut = new System.Windows.Forms.Label();
            this.BTN_Lancer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Affichage
            // 
            this.TB_Affichage.DetectUrls = false;
            this.TB_Affichage.Location = new System.Drawing.Point(12, 46);
            this.TB_Affichage.Name = "TB_Affichage";
            this.TB_Affichage.ReadOnly = true;
            this.TB_Affichage.Size = new System.Drawing.Size(378, 192);
            this.TB_Affichage.TabIndex = 2;
            this.TB_Affichage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statut:";
            // 
            // LB_Statut
            // 
            this.LB_Statut.AutoSize = true;
            this.LB_Statut.Location = new System.Drawing.Point(54, 13);
            this.LB_Statut.Name = "LB_Statut";
            this.LB_Statut.Size = new System.Drawing.Size(36, 13);
            this.LB_Statut.TabIndex = 4;
            this.LB_Statut.Text = "Fermé";
            // 
            // BTN_Lancer
            // 
            this.BTN_Lancer.Location = new System.Drawing.Point(263, 12);
            this.BTN_Lancer.Name = "BTN_Lancer";
            this.BTN_Lancer.Size = new System.Drawing.Size(127, 28);
            this.BTN_Lancer.TabIndex = 5;
            this.BTN_Lancer.Text = "Lancer";
            this.BTN_Lancer.UseVisualStyleBackColor = true;
            this.BTN_Lancer.Click += new System.EventHandler(this.BTN_Lancer_Click);
            // 
            // Serveur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 250);
            this.Controls.Add(this.BTN_Lancer);
            this.Controls.Add(this.LB_Statut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Affichage);
            this.Name = "Serveur";
            this.Text = "Serveur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TB_Affichage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Statut;
        private System.Windows.Forms.Button BTN_Lancer;
    }
}

