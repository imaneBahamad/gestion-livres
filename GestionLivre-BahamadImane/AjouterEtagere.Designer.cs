namespace GestionLivre_BahamadImane
{
    partial class AjouterEtagere
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
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.numero_lbl = new MetroFramework.Controls.MetroLabel();
            this.reinitialiser_btn = new MetroFramework.Controls.MetroButton();
            this.valider_btn = new MetroFramework.Controls.MetroButton();
            this.exception_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(225, 182);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(218, 23);
            this.numero_txt.TabIndex = 1;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Location = new System.Drawing.Point(81, 185);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Size = new System.Drawing.Size(61, 20);
            this.numero_lbl.TabIndex = 4;
            this.numero_lbl.Text = "Numero";
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.Location = new System.Drawing.Point(293, 300);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(99, 23);
            this.reinitialiser_btn.TabIndex = 3;
            this.reinitialiser_btn.Text = "Reinitialiser";
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // valider_btn
            // 
            this.valider_btn.Location = new System.Drawing.Point(133, 300);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(99, 23);
            this.valider_btn.TabIndex = 2;
            this.valider_btn.Text = "Valider";
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // exception_lbl
            // 
            this.exception_lbl.ForeColor = System.Drawing.Color.Red;
            this.exception_lbl.Location = new System.Drawing.Point(35, 363);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(479, 33);
            this.exception_lbl.TabIndex = 22;
            // 
            // AjouterEtagere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 414);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.numero_lbl);
            this.Name = "AjouterEtagere";
            this.Text = "Ajouter une étagère";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel numero_lbl;
        private MetroFramework.Controls.MetroButton reinitialiser_btn;
        private MetroFramework.Controls.MetroButton valider_btn;
        private MetroFramework.Controls.MetroLabel exception_lbl;
    }
}