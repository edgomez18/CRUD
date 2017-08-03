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
            CEmpleado frm = new CEmpleado();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex]; 
            frm.idemp.Text = act.Cells["id"].Value.ToString();
            frm.namemptxt.Text = act.Cells["name"].Value.ToString();
            frm.lnamemptxt.Text = act.Cells["lastname"].Value.ToString();
            frm.idpersemptxt.Text = act.Cells["idperson"].Value.ToString();
           
            //frm.dateingemp.Text = act.Cells["years"].Value.ToString();
            frm.sexempcb.Text = act.Cells["sex"].Value.ToString();
            frm.salarytxt.Text = act.Cells["salary"].Value.ToString();
            frm.deptxt.Text = act.Cells["dept"].Value.ToString();
            frm.positiontxt.Text = act.Cells["position"].Value.ToString();
            frm.phototxt.Text = act.Cells["photo"].Value.ToString();
            if (string.IsNullOrEmpty(act.Cells["photo"].Value.ToString()))
            {
                
            }
            else
            {
                Bitmap picture = new Bitmap(frm.phototxt.Text);
                frm.photoemp.Image = (Image)picture;
            }
            frm.saveemp.Visible = false;

            frm.Show();
        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
           
        }

        private void newbnt_Click(object sender, EventArgs e)
        {
            CEmpleado frm = new CEmpleado();
            frm.updatebtn.Visible = false;
            frm.deletebtn.Visible = false;
            frm.Show();
        }

        private void connection_Click(object sender, EventArgs e)
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
    if (stxt.Text.Length == 0)
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
else if (sid.Checked)
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Uapa\\17-2\\db\\empleado.db;Version=3;");
            try
            {
                cnx.Open();
                DataSet ds = new DataSet();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select * from empleado", cnx);
                DataTable tabla = new DataTable("Empleados");
                adac.Fill(tabla);
                ds.Tables.Add(tabla);
                ds.WriteXml(@"C:\Uapa\17-2\db\listaempleados.xml");
                MessageBox.Show("Hecho");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
    }
}
