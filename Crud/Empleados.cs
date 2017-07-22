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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newbnt_Click(object sender, EventArgs e)
        {
            CEmpleado frm = new CEmpleado();
            frm.Show();
        }

        private void connection_Click(object sender, EventArgs e)
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
            SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado", cnx);
            DataTable tabla = new DataTable("Empleados");
            adac.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }

        public void manager_Load(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Uapa\\17-2\\db\\empleado.db;Version=3;");
            try
            {
                cnx.Open();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
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
            SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado", cnx);
            DataTable tabla = new DataTable("Empleados");
            adac.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void sbnt_Click(object sender, EventArgs e)
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
            if (sid.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado where id like '"+stxt.Text+"'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (sname.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado where name like '" + stxt.Text + "'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (slname.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado where lastname like '" + stxt.Text + "'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            else if (sidperson.Checked)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado where idperson like '" + stxt.Text + "'", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }
    }
}
