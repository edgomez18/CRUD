namespace Crud
{
    partial class CEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idemp = new System.Windows.Forms.TextBox();
            this.namemptxt = new System.Windows.Forms.TextBox();
            this.lnamemptxt = new System.Windows.Forms.TextBox();
            this.idpersemptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sexempcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveemp = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bdayemptxt = new System.Windows.Forms.DateTimePicker();
            this.dateingemp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.salarytxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idemp
            // 
            this.idemp.Enabled = false;
            this.idemp.Location = new System.Drawing.Point(29, 19);
            this.idemp.Name = "idemp";
            this.idemp.Size = new System.Drawing.Size(100, 20);
            this.idemp.TabIndex = 2;
            // 
            // namemptxt
            // 
            this.namemptxt.Location = new System.Drawing.Point(54, 43);
            this.namemptxt.Name = "namemptxt";
            this.namemptxt.Size = new System.Drawing.Size(210, 20);
            this.namemptxt.TabIndex = 3;
            // 
            // lnamemptxt
            // 
            this.lnamemptxt.Location = new System.Drawing.Point(54, 69);
            this.lnamemptxt.Name = "lnamemptxt";
            this.lnamemptxt.Size = new System.Drawing.Size(210, 20);
            this.lnamemptxt.TabIndex = 4;
            // 
            // idpersemptxt
            // 
            this.idpersemptxt.Location = new System.Drawing.Point(54, 95);
            this.idpersemptxt.Name = "idpersemptxt";
            this.idpersemptxt.Size = new System.Drawing.Size(117, 20);
            this.idpersemptxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Nac.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sexo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sexempcb
            // 
            this.sexempcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexempcb.FormattingEnabled = true;
            this.sexempcb.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexempcb.Location = new System.Drawing.Point(212, 95);
            this.sexempcb.Name = "sexempcb";
            this.sexempcb.Size = new System.Drawing.Size(52, 21);
            this.sexempcb.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Datos del Empleado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // saveemp
            // 
            this.saveemp.Location = new System.Drawing.Point(248, 265);
            this.saveemp.Name = "saveemp";
            this.saveemp.Size = new System.Drawing.Size(75, 23);
            this.saveemp.TabIndex = 12;
            this.saveemp.Text = "Guardar";
            this.saveemp.UseVisualStyleBackColor = true;
            this.saveemp.Click += new System.EventHandler(this.saveemp_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(413, 265);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(329, 265);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "Limpiar";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fecha Ingreso:";
            // 
            // bdayemptxt
            // 
            this.bdayemptxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdayemptxt.Location = new System.Drawing.Point(76, 121);
            this.bdayemptxt.Name = "bdayemptxt";
            this.bdayemptxt.Size = new System.Drawing.Size(95, 20);
            this.bdayemptxt.TabIndex = 17;
            this.bdayemptxt.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateingemp
            // 
            this.dateingemp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateingemp.Location = new System.Drawing.Point(88, 147);
            this.dateingemp.Name = "dateingemp";
            this.dateingemp.Size = new System.Drawing.Size(95, 20);
            this.dateingemp.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.idemp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateingemp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bdayemptxt);
            this.groupBox1.Controls.Add(this.namemptxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lnamemptxt);
            this.groupBox1.Controls.Add(this.idpersemptxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sexempcb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 199);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.salarytxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(296, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 62);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Salario:";
            // 
            // salarytxt
            // 
            this.salarytxt.Location = new System.Drawing.Point(55, 25);
            this.salarytxt.Name = "salarytxt";
            this.salarytxt.Size = new System.Drawing.Size(117, 20);
            this.salarytxt.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(296, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 130);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular Edad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Antiguedad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(167, 265);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 22;
            this.updatebtn.Text = "Actualizar";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(86, 265);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 23;
            this.deletebtn.Text = "Borrar";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // CEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.saveemp);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.Name = "CEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.CEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox idemp;
        public System.Windows.Forms.TextBox namemptxt;
        public System.Windows.Forms.TextBox lnamemptxt;
        public System.Windows.Forms.TextBox idpersemptxt;
        public System.Windows.Forms.ComboBox sexempcb;
        public System.Windows.Forms.DateTimePicker bdayemptxt;
        public System.Windows.Forms.DateTimePicker dateingemp;
        public System.Windows.Forms.TextBox salarytxt;
        public System.Windows.Forms.Button saveemp;
        public System.Windows.Forms.Button updatebtn;
        public System.Windows.Forms.Button deletebtn;
    }
}