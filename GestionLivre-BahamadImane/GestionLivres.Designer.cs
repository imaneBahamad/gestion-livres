namespace GestionLivre_BahamadImane
{
    partial class GestionLivres
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
            this.lister_livres = new MetroFramework.Controls.MetroButton();
            this.ajouter_livre = new MetroFramework.Controls.MetroButton();
            this.ajouter_etagere = new MetroFramework.Controls.MetroButton();
            this.remettre_livre = new MetroFramework.Controls.MetroButton();
            this.retirer_livre = new MetroFramework.Controls.MetroButton();
            this.remplacer_livre = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lister_livres
            // 
            this.lister_livres.Location = new System.Drawing.Point(654, 290);
            this.lister_livres.Name = "lister_livres";
            this.lister_livres.Size = new System.Drawing.Size(221, 45);
            this.lister_livres.TabIndex = 6;
            this.lister_livres.Text = "Lister les livres d\'une étagère";
            this.lister_livres.Click += new System.EventHandler(this.lister_livres_Click);
            // 
            // ajouter_livre
            // 
            this.ajouter_livre.Location = new System.Drawing.Point(73, 191);
            this.ajouter_livre.Name = "ajouter_livre";
            this.ajouter_livre.Size = new System.Drawing.Size(221, 45);
            this.ajouter_livre.TabIndex = 1;
            this.ajouter_livre.Text = "Ajouter un livre";
            this.ajouter_livre.Click += new System.EventHandler(this.ajouter_livre_Click);
            // 
            // ajouter_etagere
            // 
            this.ajouter_etagere.Location = new System.Drawing.Point(363, 191);
            this.ajouter_etagere.Name = "ajouter_etagere";
            this.ajouter_etagere.Size = new System.Drawing.Size(221, 45);
            this.ajouter_etagere.TabIndex = 2;
            this.ajouter_etagere.Text = "Ajouter une étagère";
            this.ajouter_etagere.Click += new System.EventHandler(this.ajouter_etagere_Click);
            // 
            // remettre_livre
            // 
            this.remettre_livre.Location = new System.Drawing.Point(652, 191);
            this.remettre_livre.Name = "remettre_livre";
            this.remettre_livre.Size = new System.Drawing.Size(223, 45);
            this.remettre_livre.TabIndex = 3;
            this.remettre_livre.Text = "Remettre un livre dans une étagère";
            this.remettre_livre.Click += new System.EventHandler(this.remettre_livre_Click);
            // 
            // retirer_livre
            // 
            this.retirer_livre.Location = new System.Drawing.Point(71, 290);
            this.retirer_livre.Name = "retirer_livre";
            this.retirer_livre.Size = new System.Drawing.Size(223, 45);
            this.retirer_livre.TabIndex = 4;
            this.retirer_livre.Text = "Retirer un livre d\'une étagère";
            this.retirer_livre.Click += new System.EventHandler(this.retirer_livre_Click);
            // 
            // remplacer_livre
            // 
            this.remplacer_livre.Location = new System.Drawing.Point(363, 290);
            this.remplacer_livre.Name = "remplacer_livre";
            this.remplacer_livre.Size = new System.Drawing.Size(223, 45);
            this.remplacer_livre.TabIndex = 5;
            this.remplacer_livre.Text = "Remplacer un livre";
            this.remplacer_livre.Click += new System.EventHandler(this.remplacer_livre_Click);
            // 
            // GestionLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 492);
            this.Controls.Add(this.remplacer_livre);
            this.Controls.Add(this.retirer_livre);
            this.Controls.Add(this.remettre_livre);
            this.Controls.Add(this.ajouter_etagere);
            this.Controls.Add(this.ajouter_livre);
            this.Controls.Add(this.lister_livres);
            this.Name = "GestionLivres";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gestion de livres sans base de données";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton lister_livres;
        private MetroFramework.Controls.MetroButton ajouter_livre;
        private MetroFramework.Controls.MetroButton ajouter_etagere;
        private MetroFramework.Controls.MetroButton remettre_livre;
        private MetroFramework.Controls.MetroButton retirer_livre;
        private MetroFramework.Controls.MetroButton remplacer_livre;
    }
}

