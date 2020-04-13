using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLivre_BahamadImane
{
    public partial class GestionLivres : MetroForm
    {
        public bool database;
        public GestionLivres(bool database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void ajouter_livre_Click(object sender, EventArgs e)
        {
            new AjouterLivre(database).Show();
        }

        private void ajouter_etagere_Click(object sender, EventArgs e)
        {
            new AjouterEtagere(database).Show();
        }

        private void remettre_livre_Click(object sender, EventArgs e)
        {
            new RemettreLivre(database).Show();
        }

        private void retirer_livre_Click(object sender, EventArgs e)
        {
            new RetirerLivre(database).Show();
        }

        private void remplacer_livre_Click(object sender, EventArgs e)
        {
            new RemplacerLivre(database).Show();
        }

        private void lister_livres_Click(object sender, EventArgs e)
        {
            new ListerLivres(database).Show();
        }
    }
}
