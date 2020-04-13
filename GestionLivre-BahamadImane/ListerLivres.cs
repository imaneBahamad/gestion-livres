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
    public partial class ListerLivres : MetroForm
    {
        public bool database;
        public DBConnexion dbconnexion;

        public ListerLivres(bool database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void remplirDataGrid(List<Livre> livres)
        {
            dataGridView1.Rows.Clear();
            foreach (Livre livre in livres)
            {
                dataGridView1.Rows.Add(livre.Code, livre.Titre, livre.Prix);
            }
        }

        private void lister_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!database)
                {
                    dataGridView2.Hide();
                    remplirDataGrid(Program.lister_livre_etagere(numero_txt.Text));
                }
                else
                {
                    dbconnexion = new DBConnexion();
                    SqlCommand cmd = dbconnexion.connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * from Livre where numero_etagere='" + numero_txt.Text + "'";
                    cmd.ExecuteNonQuery();

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd.CommandText, dbconnexion.connexion);
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;

                    dbconnexion.connexion.Close();
                }
            }
            catch (NullReferenceException exp)
            {
                exception_lbl.Text = "Cette étagère n'existe pas !";
            }
            catch (ExistenceException exp)
            {
                exception_lbl.Text = exp.Message;
            }
            catch (Exception exp)
            {
                exception_lbl.Text = "Données incorrectes (étagère introuvable,...)!";
            }
        }
    }
}
