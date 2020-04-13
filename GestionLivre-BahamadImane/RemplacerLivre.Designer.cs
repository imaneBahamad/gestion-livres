namespace GestionLivre_BahamadImane
{
    partial class RemplacerLivre
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
            this.code_ancien_txt = new MetroFramework.Controls.MetroTextBox();
            this.code_lbl = new MetroFramework.Controls.MetroLabel();
            this.reinitialiser_btn = new MetroFramework.Controls.MetroButton();
            this.valider_btn = new MetroFramework.Controls.MetroButton();
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.numero_lbl = new MetroFramework.Controls.MetroLabel();
            this.prix_nouveau_txt = new MetroFramework.Controls.MetroTextBox();
            this.titre_nouveau_txt = new MetroFramework.Controls.MetroTextBox();
            this.code_nouveau_txt = new MetroFramework.Controls.MetroTextBox();
            this.prix_nouveau_lbl = new MetroFramework.Controls.MetroLabel();
            this.titre_nouveau_lbl = new MetroFramework.Controls.MetroLabel();
            this.code_nouveau_lbl = new MetroFramework.Controls.MetroLabel();
            this.exception_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // code_ancien_txt
            // 
            this.code_ancien_txt.Location = new System.Drawing.Point(231, 135);
            this.code_ancien_txt.Name = "code_ancien_txt";
            this.code_ancien_txt.Size = new System.Drawing.Size(218, 23);
            this.code_ancien_txt.TabIndex = 1;
            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Location = new System.Drawing.Point(87, 138);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(72, 20);
            this.code_lbl.TabIndex = 20;
            this.code_lbl.Text = "Code livre";
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.Location = new System.Drawing.Point(531, 357);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(99, 23);
            this.reinitialiser_btn.TabIndex = 7;
            this.reinitialiser_btn.Text = "Reinitialiser";
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // valider_btn
            // 
            this.valider_btn.Location = new System.Drawing.Point(371, 357);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(99, 23);
            this.valider_btn.TabIndex = 6;
            this.valider_btn.Text = "Valider";
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(231, 204);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(218, 23);
            this.numero_txt.TabIndex = 2;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Location = new System.Drawing.Point(87, 207);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Size = new System.Drawing.Size(113, 20);
            this.numero_lbl.TabIndex = 16;
            this.numero_lbl.Text = "Numero étagère";
            // 
            // prix_nouveau_txt
            // 
            this.prix_nouveau_txt.Location = new System.Drawing.Point(701, 237);
            this.prix_nouveau_txt.Name = "prix_nouveau_txt";
            this.prix_nouveau_txt.Size = new System.Drawing.Size(218, 23);
            this.prix_nouveau_txt.TabIndex = 5;
            // 
            // titre_nouveau_txt
            // 
            this.titre_nouveau_txt.Location = new System.Drawing.Point(701, 166);
            this.titre_nouveau_txt.Name = "titre_nouveau_txt";
            this.titre_nouveau_txt.Size = new System.Drawing.Size(218, 23);
            this.titre_nouveau_txt.TabIndex = 4;
            // 
            // code_nouveau_txt
            // 
            this.code_nouveau_txt.Location = new System.Drawing.Point(701, 99);
            this.code_nouveau_txt.Name = "code_nouveau_txt";
            this.code_nouveau_txt.Size = new System.Drawing.Size(218, 23);
            this.code_nouveau_txt.TabIndex = 3;
            // 
            // prix_nouveau_lbl
            // 
            this.prix_nouveau_lbl.AutoSize = true;
            this.prix_nouveau_lbl.Location = new System.Drawing.Point(557, 240);
            this.prix_nouveau_lbl.Name = "prix_nouveau_lbl";
            this.prix_nouveau_lbl.Size = new System.Drawing.Size(31, 20);
            this.prix_nouveau_lbl.TabIndex = 24;
            this.prix_nouveau_lbl.Text = "Prix";
            // 
            // titre_nouveau_lbl
            // 
            this.titre_nouveau_lbl.AutoSize = true;
            this.titre_nouveau_lbl.Location = new System.Drawing.Point(557, 169);
            this.titre_nouveau_lbl.Name = "titre_nouveau_lbl";
            this.titre_nouveau_lbl.Size = new System.Drawing.Size(37, 20);
            this.titre_nouveau_lbl.TabIndex = 23;
            this.titre_nouveau_lbl.Text = "Titre";
            // 
            // code_nouveau_lbl
            // 
            this.code_nouveau_lbl.AutoSize = true;
            this.code_nouveau_lbl.Location = new System.Drawing.Point(557, 102);
            this.code_nouveau_lbl.Name = "code_nouveau_lbl";
            this.code_nouveau_lbl.Size = new System.Drawing.Size(42, 20);
            this.code_nouveau_lbl.TabIndex = 22;
            this.code_nouveau_lbl.Text = "Code";
            // 
            // exception_lbl
            // 
            this.exception_lbl.ForeColor = System.Drawing.Color.Red;
            this.exception_lbl.Location = new System.Drawing.Point(49, 397);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(916, 33);
            this.exception_lbl.TabIndex = 25;
            // 
            // RemplacerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.prix_nouveau_txt);
            this.Controls.Add(this.titre_nouveau_txt);
            this.Controls.Add(this.code_nouveau_txt);
            this.Controls.Add(this.prix_nouveau_lbl);
            this.Controls.Add(this.titre_nouveau_lbl);
            this.Controls.Add(this.code_nouveau_lbl);
            this.Controls.Add(this.code_ancien_txt);
            this.Controls.Add(this.code_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.numero_lbl);
            this.Name = "RemplacerLivre";
            this.Text = "Remplacer un livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox code_ancien_txt;
        private MetroFramework.Controls.MetroLabel code_lbl;
        private MetroFramework.Controls.MetroButton reinitialiser_btn;
        private MetroFramework.Controls.MetroButton valider_btn;
        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel numero_lbl;
        private MetroFramework.Controls.MetroTextBox prix_nouveau_txt;
        private MetroFramework.Controls.MetroTextBox titre_nouveau_txt;
        private MetroFramework.Controls.MetroTextBox code_nouveau_txt;
        private MetroFramework.Controls.MetroLabel prix_nouveau_lbl;
        private MetroFramework.Controls.MetroLabel titre_nouveau_lbl;
        private MetroFramework.Controls.MetroLabel code_nouveau_lbl;
        private MetroFramework.Controls.MetroLabel exception_lbl;
    }
}