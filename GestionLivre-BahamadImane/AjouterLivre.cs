using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionLivre_BahamadImane
{
    public partial class AjouterLivre : MetroForm
    {
        public bool database;
        public DBConnexion dbconnexion;
        public AjouterLivre(bool database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!database)
                {

                    Livre livre = new Livre(code_txt.Text, titre_txt.Text, Convert.ToInt32(prix_txt.Text));
                    Program.ajout_livre(livre, numero_txt.Text);
                }
                else
                {
                    dbconnexion = new DBConnexion();
                    SqlCommand cmd = dbconnexion.connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into Livre values ('" + code_txt.Text + "','" + titre_txt.Text + "','"
                        + Convert.ToInt32(prix_txt.Text) + "','"+ numero_txt.Text + "')";
                    cmd.ExecuteNonQuery();
                    dbconnexion.connexion.Close();
                }
            }
            catch (SaisieException exp)
            {
                exception_lbl.Text = exp.Message;
            }
            catch (ExistenceException exp)
            {
                exception_lbl.Text = exp.Message;
            }
            catch (Exception exp)
            {
                exception_lbl.Text = "Données incorrectes (étagère introuvable, code déjà existant,...)!";
            }

            reinitialiser_btn_Click(sender, e);
        }

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            code_txt.Text = "";
            titre_txt.Text = "";
            prix_txt.Text = "";
            numero_txt.Text = "";
        }
    }
}
