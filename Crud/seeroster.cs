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

        public void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            string status = act.Cells["status"].Value.ToString();

            if (status == "Cerrada")
            {
                MessageBox.Show("Esta nomina esta cerrada, No puede ser modificada. Contacte al soporte tecnico");
            }
            else if (status == "Abierta")
            {
                confirmation frm = new confirmation();
                DataGridViewRow con = dataGridView1.Rows[e.RowIndex];
                 frm.idcon.Text = con.Cells["id_roster"].Value.ToString();
                 frm.namecon.Text = con.Cells["name_emp"].Value.ToString();
                 frm.deptcon.Text = con.Cells["dept_emp"].Value.ToString();
                 frm.positioncon.Text = con.Cells["position_emp"].Value.ToString();
                 frm.datecon.Text = con.Cells["date"].Value.ToString();
                 frm.startdatecon.Text = con.Cells["date_start"].Value.ToString();
                 frm.enddatecon.Text = con.Cells["date_end"].Value.ToString();
                 frm.salarycon.Text = con.Cells["neto_salary_emp"].Value.ToString();
                 frm.arscon.Text = con.Cells["ars"].Value.ToString();
                 frm.afpcon.Text = con.Cells["afp"].Value.ToString();
                 frm.descon.Text = con.Cells["others_desc"].Value.ToString();
                 frm.netosalarycon.Text = con.Cells["final_salary_emp"].Value.ToString();
                frm.Show();
            }
            else { MessageBox.Show("No hay acciones para el estado de esta nomina"); }
        }

        public void refresh_Click(object sender, EventArgs e)
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

        private void sid_roster_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
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
           if (sopen_roster.Checked)
            {
                string status = "Abierta";
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster where status like '" + status + "'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (sopen_roster.Checked)
            {
                string status = "Cerrada";
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster where status like '" + status + "'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (searchtxt.Text.Length == 0)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster", cnx);
                DataTable tabla = new DataTable("roster");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (sid_roster.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster where id_roster like '" + searchtxt.Text + "'", cnx);
                DataTable tabla = new DataTable("roster");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (sdate_roster.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster where date like '" + searchtxt.Text + "'", cnx);
                DataTable tabla = new DataTable("roster");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (ssalary_roster.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from roster where final_salary_emp like '" + searchtxt.Text + "'", cnx);
                DataTable tabla = new DataTable("roster");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printroster pr = new printroster();
            pr.Show();
        }
    }
}
