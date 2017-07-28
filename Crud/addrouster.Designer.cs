namespace Crud
{
    partial class addrouster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.deptxt = new System.Windows.Forms.TextBox();
            this.positiontxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.idroster = new System.Windows.Forms.TextBox();
            this.arstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.datend = new System.Windows.Forms.DateTimePicker();
            this.todaydate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.afptxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.salaryrealtxt = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.statuscb = new System.Windows.Forms.ComboBox();
            this.calcularbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idroster);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.positiontxt);
            this.groupBox1.Controls.Add(this.deptxt);
            this.groupBox1.Controls.Add(this.lnametxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos el Empleado";
            // 
            // nametxt
            // 
            this.nametxt.Enabled = false;
            this.nametxt.Location = new System.Drawing.Point(6, 59);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 0;
            this.nametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lnametxt
            // 
            this.lnametxt.Enabled = false;
            this.lnametxt.Location = new System.Drawing.Point(112, 59);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(100, 20);
            this.lnametxt.TabIndex = 1;
            this.lnametxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // deptxt
            // 
            this.deptxt.Enabled = false;
            this.deptxt.Location = new System.Drawing.Point(218, 59);
            this.deptxt.Name = "deptxt";
            this.deptxt.Size = new System.Drawing.Size(100, 20);
            this.deptxt.TabIndex = 2;
            this.deptxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // positiontxt
            // 
            this.positiontxt.Enabled = false;
            this.positiontxt.Location = new System.Drawing.Point(324, 59);
            this.positiontxt.Name = "positiontxt";
            this.positiontxt.Size = new System.Drawing.Size(100, 20);
            this.positiontxt.TabIndex = 3;
            this.positiontxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Posicion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.salaryrealtxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.desctxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.afptxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.arstxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.salarytxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Nomina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salario:";
            // 
            // salarytxt
            // 
            this.salarytxt.Enabled = false;
            this.salarytxt.Location = new System.Drawing.Point(56, 17);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(100, 20);
            this.salarytxt.TabIndex = 6;
            // 
            // idroster
            // 
            this.idroster.Enabled = false;
            this.idroster.Location = new System.Drawing.Point(149, 10);
            this.idroster.Name = "idroster";
            this.idroster.Size = new System.Drawing.Size(100, 20);
            this.idroster.TabIndex = 9;
            this.idroster.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // arstxt
            // 
            this.arstxt.Location = new System.Drawing.Point(56, 44);
            this.arstxt.Name = "arstxt";
            this.arstxt.Size = new System.Drawing.Size(100, 20);
            this.arstxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ARS:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.todaydate);
            this.groupBox3.Controls.Add(this.datend);
            this.groupBox3.Controls.Add(this.datestart);
            this.groupBox3.Location = new System.Drawing.Point(13, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fechas";
            // 
            // datestart
            // 
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datestart.Location = new System.Drawing.Point(149, 31);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(136, 20);
            this.datestart.TabIndex = 1;
            // 
            // datend
            // 
            this.datend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datend.Location = new System.Drawing.Point(294, 31);
            this.datend.Name = "datend";
            this.datend.Size = new System.Drawing.Size(136, 20);
            this.datend.TabIndex = 2;
            // 
            // todaydate
            // 
            this.todaydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.todaydate.Location = new System.Drawing.Point(6, 31);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(136, 20);
            this.todaydate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha inicio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha final:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "AFP:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // afptxt
            // 
            this.afptxt.Location = new System.Drawing.Point(222, 17);
            this.afptxt.Name = "afptxt";
            this.afptxt.Size = new System.Drawing.Size(100, 20);
            this.afptxt.TabIndex = 10;
            this.afptxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Otros Descunetos:";
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(275, 44);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(100, 20);
            this.desctxt.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(224, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Total a Pagar:";
            // 
            // salaryrealtxt
            // 
            this.salaryrealtxt.Location = new System.Drawing.Point(304, 74);
            this.salaryrealtxt.Name = "salaryrealtxt";
            this.salaryrealtxt.Size = new System.Drawing.Size(121, 20);
            this.salaryrealtxt.TabIndex = 14;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(292, 297);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Guardar";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(373, 297);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // statuscb
            // 
            this.statuscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statuscb.FormattingEnabled = true;
            this.statuscb.Items.AddRange(new object[] {
            "Abierta",
            "Cerrada"});
            this.statuscb.Location = new System.Drawing.Point(162, 299);
            this.statuscb.Name = "statuscb";
            this.statuscb.Size = new System.Drawing.Size(121, 21);
            this.statuscb.TabIndex = 5;
            // 
            // calcularbtn
            // 
            this.calcularbtn.Location = new System.Drawing.Point(68, 296);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(75, 23);
            this.calcularbtn.TabIndex = 6;
            this.calcularbtn.Text = "Calcular";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // addrouster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 332);
            this.Controls.Add(this.calcularbtn);
            this.Controls.Add(this.statuscb);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "addrouster";
            this.Text = "Agregar Nomina";
            this.Load += new System.EventHandler(this.addrouster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox lnametxt;
        public System.Windows.Forms.TextBox nametxt;
        public System.Windows.Forms.TextBox positiontxt;
        public System.Windows.Forms.TextBox deptxt;
        public System.Windows.Forms.TextBox idroster;
        public System.Windows.Forms.TextBox salarytxt;
        public System.Windows.Forms.TextBox afptxt;
        public System.Windows.Forms.TextBox arstxt;
        public System.Windows.Forms.DateTimePicker todaydate;
        public System.Windows.Forms.DateTimePicker datend;
        public System.Windows.Forms.DateTimePicker datestart;
        public System.Windows.Forms.TextBox salaryrealtxt;
        public System.Windows.Forms.TextBox desctxt;
        public System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.Button cancelbtn;
        public System.Windows.Forms.ComboBox statuscb;
        private System.Windows.Forms.Button calcularbtn;
    }
}