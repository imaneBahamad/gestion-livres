namespace GestionLivre_BahamadImane
{
    partial class Menu
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
            this.gestion_sans_bd = new MetroFramework.Controls.MetroTile();
            this.gestion_avec_bd = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // gestion_sans_bd
            // 
            this.gestion_sans_bd.Location = new System.Drawing.Point(99, 181);
            this.gestion_sans_bd.Name = "gestion_sans_bd";
            this.gestion_sans_bd.Size = new System.Drawing.Size(283, 112);
            this.gestion_sans_bd.Style = MetroFramework.MetroColorStyle.Green;
            this.gestion_sans_bd.TabIndex = 0;
            this.gestion_sans_bd.Text = "Gestion de livres sans base de données";
            this.gestion_sans_bd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gestion_sans_bd.Click += new System.EventHandler(this.gestion_sans_bd_Click);
            // 
            // gestion_avec_bd
            // 
            this.gestion_avec_bd.Location = new System.Drawing.Point(419, 181);
            this.gestion_avec_bd.Name = "gestion_avec_bd";
            this.gestion_avec_bd.Size = new System.Drawing.Size(283, 112);
            this.gestion_avec_bd.Style = MetroFramework.MetroColorStyle.Orange;
            this.gestion_avec_bd.TabIndex = 1;
            this.gestion_avec_bd.Text = "Gestion de livres avec base de données";
            this.gestion_avec_bd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gestion_avec_bd.Click += new System.EventHandler(this.gestion_avec_bd_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gestion_avec_bd);
            this.Controls.Add(this.gestion_sans_bd);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile gestion_sans_bd;
        private MetroFramework.Controls.MetroTile gestion_avec_bd;
    }
}