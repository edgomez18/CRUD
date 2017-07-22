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
            string comando = "INSERT INTO empleado(name, lastname, idperson, bday, years, sex) VALUES('" + namemptxt.Text + "', '" + lnamemptxt.Text + "','" + idpersemptxt.Text + "','" + bdayemptxt.Text + "', '"+yearsemptxt.Text+"', '"+sexempcb.Text+"');";
            SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            if (insertion.ExecuteNonQuery() > 0) { 
                MessageBox.Show("Se agrego correctamente");
            }
            namemptxt.Text = "";
            lnamemptxt.Text = "";
            idpersemptxt.Text = "";
            bdayemptxt.Text = "";
            yearsemptxt.Text = "";
            sexempcb.Text = "";
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
            yearsemptxt.Text = "";
            sexempcb.Text = "";
            this.namemptxt.Focus();
        }
    }
}
