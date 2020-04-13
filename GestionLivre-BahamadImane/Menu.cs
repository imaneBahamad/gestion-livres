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
    public partial class Menu : MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestion_sans_bd_Click(object sender, EventArgs e)
        {
            new GestionLivres(false).Show();
        }

        private void gestion_avec_bd_Click(object sender, EventArgs e)
        {
            new GestionLivres(true).Show();
        }
    }
}
