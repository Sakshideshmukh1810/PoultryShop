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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            AppVariables.splashForm = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Hide();
            AppVariables.loginForm = new LoginForm();
            AppVariables.loginForm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
