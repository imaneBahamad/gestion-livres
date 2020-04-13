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
    public partial class RetirerLivre : MetroForm
    {
        public bool database;
        public DBConnexion dbconnexion;

        public RetirerLivre(bool database)
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
                    Program.Retirer_livre_etagere(code_txt.Text, numero_txt.Text);
                }
                else
                {
                    dbconnexion = new DBConnexion();
                    SqlCommand cmd = dbconnexion.connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert into LivreRetires select * from Livre where code='" + code_txt.Text +
                        "' and numero_etagere ='" + numero_txt.Text + "'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "Delete from Livre where code='" + code_txt.Text + "' and numero_etagere='" + numero_txt.Text +"'" ;
                    cmd.ExecuteNonQuery();
                    
                    dbconnexion.connexion.Close();
                }
            }
            catch (NullReferenceException exp)
            {
                exception_lbl.Text = "Le livre demandé est introuvable !";
            }
            catch (ExistenceException exp)
            {
                exception_lbl.Text = exp.Message;
            }
            catch (Exception exp)
            {
                exception_lbl.Text = "Données incorrectes (étagère/code introuvable,...)!";
            }
            reinitialiser_btn_Click(sender, e);
        }

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            code_txt.Text = "";
            numero_txt.Text = "";
        }
    }
}
