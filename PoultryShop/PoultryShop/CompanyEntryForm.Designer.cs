namespace PoultryShop
{
    partial class CompanyEntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnget = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbfield = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtmobile);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Entry";
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(110, 99);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(263, 88);
            this.txtaddress.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Address";
            // 
            // txtmobile
            // 
            this.txtmobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmobile.Location = new System.Drawing.Point(110, 195);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(263, 24);
            this.txtmobile.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Mobile No";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(110, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(263, 24);
            this.txtname.TabIndex = 4;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Orange;
            this.btnclear.Location = new System.Drawing.Point(196, 242);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 33);
            this.btnclear.TabIndex = 0;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Orange;
            this.btnsave.Location = new System.Drawing.Point(108, 242);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(67, 33);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comp. Name";
            // 
            // txtno
            // 
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtno.Location = new System.Drawing.Point(110, 34);
            this.txtno.Name = "txtno";
            this.txtno.ReadOnly = true;
            this.txtno.Size = new System.Drawing.Size(89, 24);
            this.txtno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CompNo";
            // 
            // btnget
            // 
            this.btnget.BackColor = System.Drawing.Color.Orange;
            this.btnget.Location = new System.Drawing.Point(441, 572);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(72, 33);
            this.btnget.TabIndex = 2;
            this.btnget.Text = "Edit";
            this.btnget.UseVisualStyleBackColor = false;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Orange;
            this.btndelete.Location = new System.Drawing.Point(519, 571);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(67, 34);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.btnget);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.cmbfield);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 625);
            this.panel1.TabIndex = 6;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(441, 116);
            this.dg.Name = "dg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg.Size = new System.Drawing.Size(618, 450);
            this.dg.TabIndex = 16;
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Location = new System.Drawing.Point(651, 84);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(331, 24);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cmbfield
            // 
            this.cmbfield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfield.FormattingEnabled = true;
            this.cmbfield.Items.AddRange(new object[] {
            "CompNo",
            "CompName",
            "CompAddress"});
            this.cmbfield.Location = new System.Drawing.Point(500, 83);
            this.cmbfield.Name = "cmbfield";
            this.cmbfield.Size = new System.Drawing.Size(145, 27);
            this.cmbfield.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(437, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "Filter By";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 66);
            this.panel2.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Orange;
            this.btnclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1014, 17);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 32);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Company Entry Form";
            // 
            // CompanyEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 625);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Entry Form";
            this.Load += new System.EventHandler(this.AdmissionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbfield;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dg;
    }
}