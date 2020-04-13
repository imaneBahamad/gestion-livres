namespace GestionLivre_BahamadImane
{
    partial class AjouterLivre
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
            this.code_lbl = new MetroFramework.Controls.MetroLabel();
            this.titre_lbl = new MetroFramework.Controls.MetroLabel();
            this.prix_lbl = new MetroFramework.Controls.MetroLabel();
            this.code_txt = new MetroFramework.Controls.MetroTextBox();
            this.titre_txt = new MetroFramework.Controls.MetroTextBox();
            this.prix_txt = new MetroFramework.Controls.MetroTextBox();
            this.valider_btn = new MetroFramework.Controls.MetroButton();
            this.reinitialiser_btn = new MetroFramework.Controls.MetroButton();
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.numero_lbl = new MetroFramework.Controls.MetroLabel();
            this.exception_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Location = new System.Drawing.Point(87, 109);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(42, 20);
            this.code_lbl.TabIndex = 0;
            this.code_lbl.Text = "Code";
            // 
            // titre_lbl
            // 
            this.titre_lbl.AutoSize = true;
            this.titre_lbl.Location = new System.Drawing.Point(87, 169);
            this.titre_lbl.Name = "titre_lbl";
            this.titre_lbl.Size = new System.Drawing.Size(37, 20);
            this.titre_lbl.TabIndex = 1;
            this.titre_lbl.Text = "Titre";
            // 
            // prix_lbl
            // 
            this.prix_lbl.AutoSize = true;
            this.prix_lbl.Location = new System.Drawing.Point(87, 229);
            this.prix_lbl.Name = "prix_lbl";
            this.prix_lbl.Size = new System.Drawing.Size(31, 20);
            this.prix_lbl.TabIndex = 2;
            this.prix_lbl.Text = "Prix";
            // 
            // code_txt
            // 
            this.code_txt.Location = new System.Drawing.Point(231, 106);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(218, 23);
            this.code_txt.TabIndex = 1;
            // 
            // titre_txt
            // 
            this.titre_txt.Location = new System.Drawing.Point(231, 166);
            this.titre_txt.Name = "titre_txt";
            this.titre_txt.Size = new System.Drawing.Size(218, 23);
            this.titre_txt.TabIndex = 2;
            // 
            // prix_txt
            // 
            this.prix_txt.Location = new System.Drawing.Point(231, 226);
            this.prix_txt.Name = "prix_txt";
            this.prix_txt.Size = new System.Drawing.Size(218, 23);
            this.prix_txt.TabIndex = 3;
            // 
            // valider_btn
            // 
            this.valider_btn.Location = new System.Drawing.Point(134, 375);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(99, 23);
            this.valider_btn.TabIndex = 5;
            this.valider_btn.Text = "Valider";
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.Location = new System.Drawing.Point(294, 375);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(99, 23);
            this.reinitialiser_btn.TabIndex = 6;
            this.reinitialiser_btn.Text = "Reinitialiser";
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(229, 285);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(218, 23);
            this.numero_txt.TabIndex = 4;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Location = new System.Drawing.Point(85, 288);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Size = new System.Drawing.Size(113, 20);
            this.numero_lbl.TabIndex = 18;
            this.numero_lbl.Text = "Numero étagère";
            // 
            // exception_lbl
            // 
            this.exception_lbl.ForeColor = System.Drawing.Color.Red;
            this.exception_lbl.Location = new System.Drawing.Point(23, 421);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(497, 33);
            this.exception_lbl.Style = MetroFramework.MetroColorStyle.Red;
            this.exception_lbl.TabIndex = 19;
            // 
            // AjouterLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 461);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.numero_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.prix_txt);
            this.Controls.Add(this.titre_txt);
            this.Controls.Add(this.code_txt);
            this.Controls.Add(this.prix_lbl);
            this.Controls.Add(this.titre_lbl);
            this.Controls.Add(this.code_lbl);
            this.Name = "AjouterLivre";
            this.Text = "Ajouter un livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel code_lbl;
        private MetroFramework.Controls.MetroLabel titre_lbl;
        private MetroFramework.Controls.MetroLabel prix_lbl;
        private MetroFramework.Controls.MetroTextBox code_txt;
        private MetroFramework.Controls.MetroTextBox titre_txt;
        private MetroFramework.Controls.MetroTextBox prix_txt;
        private MetroFramework.Controls.MetroButton valider_btn;
        private MetroFramework.Controls.MetroButton reinitialiser_btn;
        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel numero_lbl;
        private MetroFramework.Controls.MetroLabel exception_lbl;
    }
}