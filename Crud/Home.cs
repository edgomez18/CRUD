using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEmpleado frm = new CEmpleado();
            frm.Show(); 
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager frm = new manager();
            frm.Show();
        }

        private void asignarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addrouster frm = new addrouster();
            frm.Show();
        }

        private void verNominasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seeroster frm = new seeroster();
            frm.Show();
        }
    }
}
