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
    public partial class CEmpleado : Form
    {
        public CEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CEmpleado_Load(object sender, EventArgs e)
        {
            this.namemptxt.Focus();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void saveemp_Click(object sender, EventArgs e)
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
            string comando = "INSERT INTO empleado(name, lastname, idperson, bday, years, sex, salary) VALUES('" + namemptxt.Text + "', '" + lnamemptxt.Text + "','" + idpersemptxt.Text + "','" + bdayemptxt.Text + "', '" + dateingemp.Text + "', '" + sexempcb.Text + "', '"+salarytxt.Text+"');";
            SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            if (insertion.ExecuteNonQuery() > 0) { 
                MessageBox.Show("Se agrego correctamente");
            }
            namemptxt.Text = "";
            lnamemptxt.Text = "";
            idpersemptxt.Text = "";
            bdayemptxt.Text = "";
            dateingemp.Text = "";
            sexempcb.Text = "";
            salarytxt.Text = "";
            this.namemptxt.Focus();

            /*Operacion oper = new Operacion();
            oper.ConsultaSinResultado("INSERT INTO empleado(name, lastname, idperson, bday, years, sex) VALUES(,'tulio', 'Gomez','40245454','05271996', '22', 'M')");*/
            }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            namemptxt.Text = "";
            lnamemptxt.Text = "";
            idpersemptxt.Text = "";
            bdayemptxt.Text = "";
            dateingemp.Text = "";
            sexempcb.Text = "";
            this.namemptxt.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese Eliminar?", "Eliminar empleado", MessageBoxButtons.YesNo);

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
            string comando = "DELETE FROM empleado WHERE id = '"+idemp.Text+"'";
            SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            insertion.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado!");
                Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Eliminar empleado", MessageBoxButtons.YesNo);

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
                string comando = "UPDATE empleado set name = '" + namemptxt.Text + "', lastname = '" + lnamemptxt.Text + "', idperson = '" + idpersemptxt.Text + "', bday = '" + bdayemptxt.Text + "', years = '" + dateingemp.Text + "', sex = '" + sexempcb.Text + "', salary = '" + salarytxt.Text + "' WHERE id = '" + idemp.Text + "'";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                insertion.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado!");
                Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechan = bdayemptxt.Value;
            int anyo = System.DateTime.Now.Year - fechan.Year;
            if (System.DateTime.Now.Subtract(fechan.AddYears(anyo)).TotalDays < 0)
                edadtxt.Text = Convert.ToString(anyo - 1);
            else
                edadtxt.Text = Convert.ToString(anyo);
        }
    }
}
