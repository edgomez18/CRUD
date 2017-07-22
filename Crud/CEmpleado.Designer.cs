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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.namemptxt = new System.Windows.Forms.TextBox();
            this.lnamemptxt = new System.Windows.Forms.TextBox();
            this.idpersemptxt = new System.Windows.Forms.TextBox();
            this.yearsemptxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sexempcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveemp = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.bdayemptxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(37, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // namemptxt
            // 
            this.namemptxt.Location = new System.Drawing.Point(62, 61);
            this.namemptxt.Name = "namemptxt";
            this.namemptxt.Size = new System.Drawing.Size(210, 20);
            this.namemptxt.TabIndex = 3;
            // 
            // lnamemptxt
            // 
            this.lnamemptxt.Location = new System.Drawing.Point(62, 87);
            this.lnamemptxt.Name = "lnamemptxt";
            this.lnamemptxt.Size = new System.Drawing.Size(210, 20);
            this.lnamemptxt.TabIndex = 4;
            // 
            // idpersemptxt
            // 
            this.idpersemptxt.Location = new System.Drawing.Point(62, 113);
            this.idpersemptxt.Name = "idpersemptxt";
            this.idpersemptxt.Size = new System.Drawing.Size(210, 20);
            this.idpersemptxt.TabIndex = 5;
            // 
            // yearsemptxt
            // 
            this.yearsemptxt.Location = new System.Drawing.Point(62, 165);
            this.yearsemptxt.Name = "yearsemptxt";
            this.yearsemptxt.Size = new System.Drawing.Size(75, 20);
            this.yearsemptxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Nac.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edad";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sexo";
            // 
            // sexempcb
            // 
            this.sexempcb.FormattingEnabled = true;
            this.sexempcb.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sexempcb.Location = new System.Drawing.Point(181, 163);
            this.sexempcb.Name = "sexempcb";
            this.sexempcb.Size = new System.Drawing.Size(91, 21);
            this.sexempcb.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nuevo Empleado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveemp
            // 
            this.saveemp.Location = new System.Drawing.Point(23, 205);
            this.saveemp.Name = "saveemp";
            this.saveemp.Size = new System.Drawing.Size(75, 23);
            this.saveemp.TabIndex = 12;
            this.saveemp.Text = "Guardar";
            this.saveemp.UseVisualStyleBackColor = true;
            this.saveemp.Click += new System.EventHandler(this.saveemp_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(197, 205);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(116, 205);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 23);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "Limpiar";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // bdayemptxt
            // 
            this.bdayemptxt.Location = new System.Drawing.Point(81, 139);
            this.bdayemptxt.Name = "bdayemptxt";
            this.bdayemptxt.Size = new System.Drawing.Size(191, 20);
            this.bdayemptxt.TabIndex = 6;
            this.bdayemptxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // CEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.saveemp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sexempcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearsemptxt);
            this.Controls.Add(this.bdayemptxt);
            this.Controls.Add(this.idpersemptxt);
            this.Controls.Add(this.lnamemptxt);
            this.Controls.Add(this.namemptxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CEmpleado";
            this.Text = "Crear Empleado";
            this.Load += new System.EventHandler(this.CEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox namemptxt;
        private System.Windows.Forms.TextBox lnamemptxt;
        private System.Windows.Forms.TextBox idpersemptxt;
        private System.Windows.Forms.TextBox yearsemptxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sexempcb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveemp;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox bdayemptxt;
    }
}