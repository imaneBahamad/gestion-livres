namespace GestionLivre_BahamadImane
{
    partial class ListerLivres
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lister_btn = new MetroFramework.Controls.MetroButton();
            this.numero_txt = new MetroFramework.Controls.MetroTextBox();
            this.numero_lbl = new MetroFramework.Controls.MetroLabel();
            this.exception_lbl = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.titre,
            this.prix});
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(47, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 380);
            this.dataGridView1.TabIndex = 7;
            // 
            // code
            // 
            this.code.HeaderText = "Code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            // 
            // titre
            // 
            this.titre.HeaderText = "Titre";
            this.titre.MinimumWidth = 6;
            this.titre.Name = "titre";
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            // 
            // lister_btn
            // 
            this.lister_btn.Location = new System.Drawing.Point(443, 104);
            this.lister_btn.Name = "lister_btn";
            this.lister_btn.Size = new System.Drawing.Size(99, 23);
            this.lister_btn.TabIndex = 2;
            this.lister_btn.Text = "Lister";
            this.lister_btn.Click += new System.EventHandler(this.lister_btn_Click);
            // 
            // numero_txt
            // 
            this.numero_txt.Location = new System.Drawing.Point(191, 104);
            this.numero_txt.Name = "numero_txt";
            this.numero_txt.Size = new System.Drawing.Size(218, 23);
            this.numero_txt.TabIndex = 1;
            // 
            // numero_lbl
            // 
            this.numero_lbl.AutoSize = true;
            this.numero_lbl.Location = new System.Drawing.Point(47, 107);
            this.numero_lbl.Name = "numero_lbl";
            this.numero_lbl.Size = new System.Drawing.Size(113, 20);
            this.numero_lbl.TabIndex = 14;
            this.numero_lbl.Text = "Numero étagère";
            // 
            // exception_lbl
            // 
            this.exception_lbl.ForeColor = System.Drawing.Color.Red;
            this.exception_lbl.Location = new System.Drawing.Point(47, 66);
            this.exception_lbl.Name = "exception_lbl";
            this.exception_lbl.Size = new System.Drawing.Size(730, 33);
            this.exception_lbl.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(47, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(741, 380);
            this.dataGridView2.TabIndex = 27;
            // 
            // ListerLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.exception_lbl);
            this.Controls.Add(this.lister_btn);
            this.Controls.Add(this.numero_txt);
            this.Controls.Add(this.numero_lbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListerLivres";
            this.Text = "Lister les livres d\'une étagère";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private MetroFramework.Controls.MetroButton lister_btn;
        private MetroFramework.Controls.MetroTextBox numero_txt;
        private MetroFramework.Controls.MetroLabel numero_lbl;
        private MetroFramework.Controls.MetroLabel exception_lbl;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}