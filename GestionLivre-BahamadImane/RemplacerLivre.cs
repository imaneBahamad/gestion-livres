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
    public partial class RemplacerLivre : MetroForm
    {
        public bool database;
        public DBConnexion dbconnexion;

        public RemplacerLivre(bool database)
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
                    Livre nouveau = new Livre(code_nouveau_txt.Text, titre_nouveau_txt.Text, Convert.ToInt32(prix_nouveau_txt.Text));
                    Program.remplacer_livre_etagere(code_ancien_txt.Text, nouveau, numero_txt.Text);
                }
                else
                {
                    dbconnexion = new DBConnexion();
                    SqlCommand cmd = dbconnexion.connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from Livre where code='" + code_ancien_txt.Text + "' and numero_etagere='" + numero_txt.Text + "'";
                    cmd.ExecuteNonQuery();
                    Livre livre = new Livre(code_nouveau_txt.Text, titre_nouveau_txt.Text, Convert.ToInt32(prix_nouveau_txt.Text));
                    cmd.CommandText = "Insert into Livre values ('" + livre.Code + "','" + livre.Titre +
                        "','" + livre.Prix + "','" + numero_txt.Text + "')";
                    cmd.ExecuteNonQuery();

                    dbconnexion.connexion.Close();
                }
            }
            catch (SaisieException exp)
            {
                exception_lbl.Text = exp.Message;
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
                exception_lbl.Text = "Données incorrectes (étagère/code introuvable, livre déjà existant,...)!";
            }

            reinitialiser_btn_Click(sender, e);
        }

        private void reinitialiser_btn_Click(object sender, EventArgs e)
        {
            code_ancien_txt.Text = "";
            numero_txt.Text = "";
            code_nouveau_txt.Text = "";
            titre_nouveau_txt.Text = "";
            prix_nouveau_txt.Text = "";    
        }
    }
}
