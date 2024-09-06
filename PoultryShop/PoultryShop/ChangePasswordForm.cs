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
    public partial class ChangePasswordForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {            
            string pass = txtpass1.Text;
            string pass1 = txtpass2.Text;
            string pass2 = txtpass3.Text;

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Old Password cannot be left empty..", "Input Error");
                txtpass1.Focus();
                return;
            }
            if (pass!=AppVariables.password)
            {
                MessageBox.Show("Wrong Old Password..", "Input Error");
                txtpass1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass1))
            {
                MessageBox.Show("New Password cannot be left empty..", "Input Error");
                txtpass2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Confirm New Password cannot be left empty..", "Input Error");
                txtpass3.Focus();
                return;
            }
            if (pass1 != pass2)
            {
                MessageBox.Show("New and Confirm new Password Mismatch..", "Input Error");
                txtpass3.Focus();
                return;
            }

            db.ExecuteCommand("Update Login set Password='" + pass2 + "' where UserName='" + AppVariables.username + "'");
            MessageBox.Show("Password Changed Successfully...");
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
