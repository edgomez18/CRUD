namespace Crud
{
    partial class seeroster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.sclosed_roster = new System.Windows.Forms.RadioButton();
            this.sopen_roster = new System.Windows.Forms.RadioButton();
            this.ssalary_roster = new System.Windows.Forms.RadioButton();
            this.sdate_roster = new System.Windows.Forms.RadioButton();
            this.sid_roster = new System.Windows.Forms.RadioButton();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1338, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(566, 13);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(461, 20);
            this.searchtxt.TabIndex = 1;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(1114, 12);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 21);
            this.refreshbtn.TabIndex = 2;
            this.refreshbtn.Text = "Recargar";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refresh_Click);
            // 
            // sclosed_roster
            // 
            this.sclosed_roster.AutoSize = true;
            this.sclosed_roster.Location = new System.Drawing.Point(493, 16);
            this.sclosed_roster.Name = "sclosed_roster";
            this.sclosed_roster.Size = new System.Drawing.Size(67, 17);
            this.sclosed_roster.TabIndex = 3;
            this.sclosed_roster.TabStop = true;
            this.sclosed_roster.Text = "Cerradas";
            this.sclosed_roster.UseVisualStyleBackColor = true;
            // 
            // sopen_roster
            // 
            this.sopen_roster.AutoSize = true;
            this.sopen_roster.Location = new System.Drawing.Point(424, 16);
            this.sopen_roster.Name = "sopen_roster";
            this.sopen_roster.Size = new System.Drawing.Size(63, 17);
            this.sopen_roster.TabIndex = 4;
            this.sopen_roster.TabStop = true;
            this.sopen_roster.Text = "Abiertas";
            this.sopen_roster.UseVisualStyleBackColor = true;
            // 
            // ssalary_roster
            // 
            this.ssalary_roster.AutoSize = true;
            this.ssalary_roster.Location = new System.Drawing.Point(361, 16);
            this.ssalary_roster.Name = "ssalary_roster";
            this.ssalary_roster.Size = new System.Drawing.Size(57, 17);
            this.ssalary_roster.TabIndex = 5;
            this.ssalary_roster.TabStop = true;
            this.ssalary_roster.Text = "Salario";
            this.ssalary_roster.UseVisualStyleBackColor = true;
            // 
            // sdate_roster
            // 
            this.sdate_roster.AutoSize = true;
            this.sdate_roster.Location = new System.Drawing.Point(262, 16);
            this.sdate_roster.Name = "sdate_roster";
            this.sdate_roster.Size = new System.Drawing.Size(93, 17);
            this.sdate_roster.TabIndex = 6;
            this.sdate_roster.TabStop = true;
            this.sdate_roster.Text = "Fecha emision";
            this.sdate_roster.UseVisualStyleBackColor = true;
            // 
            // sid_roster
            // 
            this.sid_roster.AutoSize = true;
            this.sid_roster.Location = new System.Drawing.Point(183, 16);
            this.sid_roster.Name = "sid_roster";
            this.sid_roster.Size = new System.Drawing.Size(73, 17);
            this.sid_roster.TabIndex = 7;
            this.sid_roster.TabStop = true;
            this.sid_roster.Text = "ID nomina";
            this.sid_roster.UseVisualStyleBackColor = true;
            this.sid_roster.CheckedChanged += new System.EventHandler(this.sid_roster_CheckedChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(1033, 12);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 21);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Buscar";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // seeroster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 261);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.sid_roster);
            this.Controls.Add(this.sdate_roster);
            this.Controls.Add(this.ssalary_roster);
            this.Controls.Add(this.sopen_roster);
            this.Controls.Add(this.sclosed_roster);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "seeroster";
            this.Text = "seeroster";
            this.Load += new System.EventHandler(this.seeroster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchtxt;
        public System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.RadioButton sclosed_roster;
        private System.Windows.Forms.RadioButton sopen_roster;
        private System.Windows.Forms.RadioButton ssalary_roster;
        private System.Windows.Forms.RadioButton sdate_roster;
        private System.Windows.Forms.RadioButton sid_roster;
        public System.Windows.Forms.Button searchbtn;
    }
}