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
    public partial class addrouster : Form
    {
        public addrouster()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void addrouster_Load(object sender, EventArgs e)
        {
/*double ars = Convert.ToDouble(salarytxt.Text) * 0.033;
            arstxt.Text = Convert.ToString(ars);
            double afp = Convert.ToDouble(salarytxt.Text) * 0.027;
            afptxt.Text = Convert.ToString(afp);
            double netsal = Convert.ToDouble(salarytxt.Text);
          //  if (desctxt.Text =! )
            double desc = Convert.ToDouble(desctxt.Text);
            double totalsalary = netsal - (ars + afp + desc);

            salaryrealtxt.Text = Convert.ToString(totalsalary);*/
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            double ars = Convert.ToDouble(salarytxt.Text) * 0.033;
            arstxt.Text = Convert.ToString(ars);
            double afp = Convert.ToDouble(salarytxt.Text) * 0.027;
            afptxt.Text = Convert.ToString(afp);
            double netsal = Convert.ToDouble(salarytxt.Text);
            if (string.IsNullOrEmpty(desctxt.Text))
            {
                desctxt.Text = "0";
                double totalsalary = netsal - (ars + afp);
                salaryrealtxt.Text = Convert.ToString(totalsalary);
            }
            else
            {
                double desc = Convert.ToDouble(desctxt.Text);
                double totalsalary = netsal - (ars + afp + desc);
                salaryrealtxt.Text = Convert.ToString(totalsalary);
            }
           
        }
    }
}
