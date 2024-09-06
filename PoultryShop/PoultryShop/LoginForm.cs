using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoultryShop.Classes;

namespace PoultryShop
{
    public partial class LoginForm : Form
    {
        public static LoginForm me; //Current LoginForm class object
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            ClsDataAccess db = new ClsDataAccess();
            bool flag = db.CheckLogin(user, pass);
            if (flag)
            {
                AppVariables.username = user;
                AppVariables.password = pass;
                me = this; //Current Form object
                me.Hide(); //Hide Login Form
                MainForm f = new MainForm();
                f.Show();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
