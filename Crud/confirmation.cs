using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Crud
{
    public partial class confirmation : Form
    {
        public confirmation()
        {
            InitializeComponent();
        }
     
        private void delatebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar?", "Eliminar Cormimacio de orden", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Uapa\\17-2\\db\\empleado.db;Version=3;");
                try
                {
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");

                }
                string comando = "DELETE FROM roster WHERE id_roster = '" + idcon.Text + "'";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                insertion.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado!");
                Close();
            }
            else if (result == DialogResult.No)
            {
            }
            }

        private void confirmarbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea corfirmar esta nomina?, de ser asi no podra modificarla en el futuro.", "Confirmar nomina", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Uapa\\17-2\\db\\empleado.db;Version=3;");
                try
                {
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");

                }
                string status = "Cerrada";
                string comando = "UPDATE roster set status = '" +status+ "' WHERE id_roster = '" + idcon.Text + "'";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                insertion.ExecuteNonQuery();
                MessageBox.Show("Se ha confrimado!");
                Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

