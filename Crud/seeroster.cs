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
    public partial class seeroster : Form
    {
        public seeroster()
        {
            InitializeComponent();
        }
        public void CargarDatos()
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
            SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster", cnx);
            DataTable tabla = new DataTable("Roster");
            adac.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        private void seeroster_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            string status = act.Cells["status"].Value.ToString();

            if (status == "Cerrada")
            {
                MessageBox.Show("esta nomina esta cerrada, No puede ser modificada. Contacte al soporte tecnico");
            }
            else if (status == "Abierta")
            {
                confirmation frm = new confirmation();
                /* DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
                 frm.idemp.Text = act.Cells["id"].Value.ToString();
                 frm.namemptxt.Text = act.Cells["name"].Value.ToString();
                 frm.lnamemptxt.Text = act.Cells["lastname"].Value.ToString();
                 frm.idpersemptxt.Text = act.Cells["idperson"].Value.ToString();

                 //frm.dateingemp.Text = act.Cells["years"].Value.ToString();
                 frm.sexempcb.Text = act.Cells["sex"].Value.ToString();
                 frm.salarytxt.Text = act.Cells["salary"].Value.ToString();
                 frm.deptxt.Text = act.Cells["dept"].Value.ToString();
                 frm.positiontxt.Text = act.Cells["position"].Value.ToString();
                 frm.saveemp.Visible = false;*/
                frm.Show();
            }
            else { MessageBox.Show("No hay acciones para el estado de esta nomina"); }
        }
    }
}
