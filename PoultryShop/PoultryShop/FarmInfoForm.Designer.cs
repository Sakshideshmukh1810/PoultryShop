namespace PoultryShop
{
    partial class FarmInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmInfoForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.dtestdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnbrowse);
            this.groupBox1.Controls.Add(this.dtestdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtreg);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcontact);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poultry Farm Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.Orange;
            this.btnbrowse.Location = new System.Drawing.Point(476, 184);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(67, 33);
            this.btnbrowse.TabIndex = 19;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // dtestdate
            // 
            this.dtestdate.Location = new System.Drawing.Point(110, 262);
            this.dtestdate.Name = "dtestdate";
            this.dtestdate.Size = new System.Drawing.Size(263, 24);
            this.dtestdate.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Est. Date";
            // 
            // txtreg
            // 
            this.txtreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreg.Location = new System.Drawing.Point(110, 225);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(263, 24);
            this.txtreg.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Reg. No.";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(110, 195);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(263, 24);
            this.txtemail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email ID";
            // 
            // txtcontact
            // 
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontact.Location = new System.Drawing.Point(110, 165);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(263, 24);
            this.txtcontact.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No";
            // 
            // txtaddress
            // 
            this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddress.Location = new System.Drawing.Point(110, 64);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(263, 95);
            this.txtaddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Orange;
            this.btnsave.Location = new System.Drawing.Point(110, 307);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(263, 37);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Update Profile";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(110, 34);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(263, 24);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 519);
            this.panel1.TabIndex = 6;
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
            this.panel2.Size = new System.Drawing.Size(687, 66);
            this.panel2.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Orange;
            this.btnclose.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(631, 15);
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
            this.label3.Size = new System.Drawing.Size(391, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "Poultry Farm Information";
            // 
            // FarmInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 519);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FarmInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Entry Form";
            this.Load += new System.EventHandler(this.ShopInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtestdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbrowse;
    }
}