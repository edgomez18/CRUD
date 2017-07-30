﻿using System;
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
            if (string.IsNullOrEmpty(salarytxt.Text))
            {

            }
            else
            {
                double salary = Convert.ToDouble(salarytxt.Text);
                double ars = Convert.ToDouble(salarytxt.Text) * 0.033;
                arstxt.Text = Convert.ToString(ars);
                double afp = Convert.ToDouble(salarytxt.Text) * 0.027;
                afptxt.Text = Convert.ToString(afp);
                if (salary > 33000)
                {
                    double irs = Convert.ToDouble(salarytxt.Text) * 0.04;
                    irstxt.Text = Convert.ToString(irs);
                    double ahorro = Convert.ToDouble(salarytxt.Text) * 0.02;
                    desctxt.Text = Convert.ToString(ahorro);
                    double totaldesc = ars + afp + irs + ahorro;
                    totaldesctxt.Text = Convert.ToString(totaldesc);
                    double salaryreal = Convert.ToDouble(salarytxt.Text) - totaldesc;
                    salaryrealtxt.Text = Convert.ToString(salaryreal);
                }
                else
                {
                    double irs = 0;
                    irstxt.Text = Convert.ToString(irs); 
                    double ahorro = Convert.ToDouble(salarytxt.Text) * 0.02;
                    desctxt.Text = Convert.ToString(ahorro);
                    double totaldesc = ars + afp + irs + ahorro;
                    totaldesctxt.Text = Convert.ToString(totaldesc);
                    double salaryreal = Convert.ToDouble(salarytxt.Text) - totaldesc;
                    salaryrealtxt.Text = Convert.ToString(salaryreal);
                }
                

            }
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {

           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(statuscb.Text)) { MessageBox.Show("Seleccione Un estatus por favor!"); }
            else {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\Uapa\\17-2\\db\\empleado.db;Version=3;");
                try
                {
                    cnx.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");

                }
                string nameandlast = String.Format("{0} {1}", nametxt.Text, lnametxt.Text);
                string comando = "INSERT INTO roster(name_emp, dept_emp, position_emp, date, date_start, date_end, neto_salary_emp, ars, afp, others_desc, final_salary_emp, status, irs) VALUES('" + nameandlast + "', '" + deptxt.Text + "','" + positiontxt.Text + "','" + todaydate.Text + "', '" + datestart.Text + "', '" + datend.Text + "', '" + salarytxt.Text + "', '" + arstxt.Text + "', '" + afptxt.Text + "', '" + desctxt.Text + "', '" + salaryrealtxt.Text + "', '" + statuscb.Text + "', '"+ irstxt.Text+"');";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                    idroster.Text = "";
                    nametxt.Text = "";
                    lnametxt.Text = "";
                    deptxt.Text = "";
                    positiontxt.Text = "";
                    salarytxt.Text = "";
                    arstxt.Text = "";
                    afptxt.Text = "";
                    desctxt.Text = "";
                    salaryrealtxt.Text = "";
                    irstxt.Text = "";

                    searchbtn.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Algo ha fallado");
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            nomina frm = new nomina();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
