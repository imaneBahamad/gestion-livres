namespace GestionLivre_BahamadImane
{
    partial class RetirerLivre
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
            this.code_txt = new MetroFramework.Controls.MetroTextBox();
            this.code_lbl = new MetroFramework.Controls.MetroLabel();
            this.reinitialiser_btn = new MetroFramework.Controls.MetroButton();
            this.valider_btn = new MetroFramework.Controls.MetroButton();
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.numero_lbl = new MetroFramework.Controls.MetroLabel();
            this.exception_lbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // code_txt
            // 
            this.code_txt.Location = new System.Drawing.Point(227, 158);
            this.code_txt.Name = "code_txt";
            this.code_txt.Size = new System.Drawing.Size(218, 23);
            this.code_txt.TabIndex = 1;
            // 
            // code_lbl
            // 
            this.code_lbl.AutoSize = true;
            this.code_lbl.Location = new System.Drawing.Point(83, 161);
            this.code_lbl.Name = "code_lbl";
            this.code_lbl.Size = new System.Drawing.Size(72, 20);
            this.code_lbl.TabIndex = 20;
            this.code_lbl.Text = "Code livre";
            // 
            // reinitialiser_btn
            // 
            this.reinitialiser_btn.Location = new System.Drawing.Point(295, 343);
            this.reinitialiser_btn.Name = "reinitialiser_btn";
            this.reinitialiser_btn.Size = new System.Drawing.Size(99, 23);
            this.reinitialiser_btn.TabIndex = 4;
            this.reinitialiser_btn.Text = "Reinitialiser";
            this.reinitialiser_btn.Click += new System.EventHandler(this.reinitialiser_btn_Click);
            // 
            // valider_btn
            // 
            this.valider_btn.Location = new System.Drawing.Point(135, 343);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(99, 23);
            this.valider_btn.TabIndex = 3;
            this.valider_btn.Text = "Valider";
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(227, 227);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(218, 23);
            this.numero_txt.TabIndex = 2;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Location = new System.Drawing.Point(83, 230);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Size = new System.Drawing.Size(113, 20);
            this.numero_lbl.TabIndex = 16;
            this.numero_lbl.Text = "Numero étagère";
            // 
            // exception_lbl
            // 
            this.exception_lbl.ForeColor = System.Drawing.Color.Red;
            this.exception_lbl.Location = new System.Drawing.Point(39, 400);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(479, 33);
            this.exception_lbl.TabIndex = 21;
            // 
            // RetirerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.code_txt);
            this.Controls.Add(this.code_lbl);
            this.Controls.Add(this.reinitialiser_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.numero_lbl);
            this.Name = "RetirerLivre";
            this.Text = "Retirer un livre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox code_txt;
        private MetroFramework.Controls.MetroLabel code_lbl;
        private MetroFramework.Controls.MetroButton reinitialiser_btn;
        private MetroFramework.Controls.MetroButton valider_btn;
        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel numero_lbl;
        private MetroFramework.Controls.MetroLabel exception_lbl;
    }
}