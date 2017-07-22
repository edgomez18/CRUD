namespace Crud
{
    partial class manager
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.stxt = new System.Windows.Forms.TextBox();
            this.sbnt = new System.Windows.Forms.Button();
            this.newbnt = new System.Windows.Forms.Button();
            this.connection = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.RadioButton();
            this.sname = new System.Windows.Forms.RadioButton();
            this.slname = new System.Windows.Forms.RadioButton();
            this.sidperson = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stxt
            // 
            this.stxt.Location = new System.Drawing.Point(258, 24);
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(298, 20);
            this.stxt.TabIndex = 1;
            // 
            // sbnt
            // 
            this.sbnt.Location = new System.Drawing.Point(563, 22);
            this.sbnt.Name = "sbnt";
            this.sbnt.Size = new System.Drawing.Size(75, 23);
            this.sbnt.TabIndex = 5;
            this.sbnt.Text = "Buscar";
            this.sbnt.UseVisualStyleBackColor = true;
            this.sbnt.Click += new System.EventHandler(this.sbnt_Click);
            // 
            // newbnt
            // 
            this.newbnt.Location = new System.Drawing.Point(644, 22);
            this.newbnt.Name = "newbnt";
            this.newbnt.Size = new System.Drawing.Size(75, 23);
            this.newbnt.TabIndex = 6;
            this.newbnt.Text = "Crear";
            this.newbnt.UseVisualStyleBackColor = true;
            this.newbnt.Click += new System.EventHandler(this.newbnt_Click);
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(323, 245);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(75, 23);
            this.connection.TabIndex = 8;
            this.connection.Text = "Refrescar";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(779, 181);
            this.dataGridView1.TabIndex = 9;
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Location = new System.Drawing.Point(12, 25);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(36, 17);
            this.sid.TabIndex = 10;
            this.sid.TabStop = true;
            this.sid.Text = "ID";
            this.sid.UseVisualStyleBackColor = true;
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(54, 25);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(62, 17);
            this.sname.TabIndex = 11;
            this.sname.TabStop = true;
            this.sname.Text = "Nombre";
            this.sname.UseVisualStyleBackColor = true;
            // 
            // slname
            // 
            this.slname.AutoSize = true;
            this.slname.Location = new System.Drawing.Point(122, 25);
            this.slname.Name = "slname";
            this.slname.Size = new System.Drawing.Size(62, 17);
            this.slname.TabIndex = 12;
            this.slname.TabStop = true;
            this.slname.Text = "Apellido";
            this.slname.UseVisualStyleBackColor = true;
            // 
            // sidperson
            // 
            this.sidperson.AutoSize = true;
            this.sidperson.Location = new System.Drawing.Point(190, 25);
            this.sidperson.Name = "sidperson";
            this.sidperson.Size = new System.Drawing.Size(58, 17);
            this.sidperson.TabIndex = 13;
            this.sidperson.TabStop = true;
            this.sidperson.Text = "Cedula";
            this.sidperson.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 286);
            this.Controls.Add(this.sidperson);
            this.Controls.Add(this.slname);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.newbnt);
            this.Controls.Add(this.sbnt);
            this.Controls.Add(this.stxt);
            this.Name = "manager";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.Button sbnt;
        private System.Windows.Forms.Button newbnt;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sid;
        private System.Windows.Forms.RadioButton sname;
        private System.Windows.Forms.RadioButton slname;
        private System.Windows.Forms.RadioButton sidperson;
    }
}

