namespace PoultryShop
{
    partial class VoucherEntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtvdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Controls.Add(this.txtdetails);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtamt);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtvdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voucher Entry Form";
            // 
            // txtdetails
            // 
            this.txtdetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdetails.Location = new System.Drawing.Point(468, 69);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(265, 74);
            this.txtdetails.TabIndex = 9;
            this.txtdetails.TextChanged += new System.EventHandler(this.txtdetails_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtamt
            // 
            this.txtamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamt.Location = new System.Drawing.Point(468, 34);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(150, 24);
            this.txtamt.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Orange;
            this.btnclear.Location = new System.Drawing.Point(84, 195);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 33);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Orange;
            this.btnsave.Location = new System.Drawing.Point(11, 195);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(67, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(394, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Amount";
            // 
            // txtvdate
            // 
            this.txtvdate.Location = new System.Drawing.Point(110, 36);
            this.txtvdate.Name = "txtvdate";
            this.txtvdate.Size = new System.Drawing.Size(263, 24);
            this.txtvdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Voucher Date";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(110, 154);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(263, 24);
            this.txtname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Person";
            // 
            // txtpart
            // 
            this.txtpart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpart.Location = new System.Drawing.Point(110, 71);
            this.txtpart.Multiline = true;
            this.txtpart.Name = "txtpart";
            this.txtpart.Size = new System.Drawing.Size(263, 72);
            this.txtpart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Particulars";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnshow);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 638);
            this.panel1.TabIndex = 6;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Orange;
            this.btndelete.Location = new System.Drawing.Point(20, 592);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(67, 33);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Orange;
            this.btnshow.Location = new System.Drawing.Point(548, 318);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(72, 24);
            this.btnshow.TabIndex = 19;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.Orange;
            this.btnfilter.Location = new System.Drawing.Point(470, 318);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(72, 24);
            this.btnfilter.TabIndex = 17;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 24);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filter ";
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(20, 348);
            this.dg.Name = "dg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Size = new System.Drawing.Size(754, 238);
            this.dg.TabIndex = 8;
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
            this.panel2.Size = new System.Drawing.Size(792, 66);
            this.panel2.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Orange;
            this.btnclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(729, 15);
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
            this.label3.Size = new System.Drawing.Size(309, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Voucher Entry Form";
            // 
            // VoucherEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 638);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoucherEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Advance Entry";
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
        private System.Windows.Forms.TextBox txtpart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtvdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Button btndelete;
    }
}