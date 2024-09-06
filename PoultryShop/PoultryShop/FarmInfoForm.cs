using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoultryShop.Classes;
using System.IO;
using System.Text.RegularExpressions;

namespace PoultryShop
{
    public partial class FarmInfoForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        string fname;
        public FarmInfoForm()
        {
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;
            string address = txtaddress.Text;
            string contact = txtcontact.Text;
            string email = txtemail.Text;            
            string reg = txtreg.Text;
            string estdate = dtestdate.Value.ToString("yyyy-MM-dd");
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be left empty..", "Input Error");
                txtaddress.Focus();
                return;
            }
            if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Contact No cannot be left empty..", "Input Error");
                txtcontact.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be left empty..", "Input Error");
                txtemail.Focus();
                return;
            }
            if (!Regex.IsMatch(email,@"^\w+@\w+\.\w{2,3}(\.\w{2,3})?$"))
            {
                MessageBox.Show("Wrong format of Email ID..", "Input Error");
                txtemail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(reg))
            {
                MessageBox.Show("Registration No cannot be left empty..", "Input Error");
                txtreg.Focus();
                return;
            }
           
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("name", name);
            dic.Add("address", address);
            dic.Add("contact", contact);
            dic.Add("email", email);            
            dic.Add("reg", reg);
            dic.Add("estdate", estdate);
            dic.Add("shopimage", File.ReadAllBytes(fname));

            DataTable dt = db.GetDataTable("select * from ShopInfo");
            if (dt.Rows.Count == 0)
            {
                db.Execute("Insert into ShopInfo values(@name,@address,@contact,@email,@reg,@estdate,@shopimage)", dic);
            }
            else
            {
                db.Execute("Update ShopInfo set Name=@name,Address=@address,ContactNo=@contact,Email=@email,RegNo=@reg,EstDate=@estdate,shopimage=@shopimage", dic);
            }
            MessageBox.Show("Shop Information is Updated Successfully...");
                
        }

        

        
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Browse Shop Image";
            fd.Filter = "Image Files(*.jpg)|*.jpg";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fname = fd.FileName;
                pictureBox1.Image = Image.FromFile(fname);
            }

        }

        private void ShopInfoForm_Load(object sender, EventArgs e)
        {
            DataTable dt = db.GetDataTable("select * from ShopInfo");
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0][0].ToString();
                txtaddress.Text = dt.Rows[0][1].ToString();
                txtcontact.Text = dt.Rows[0][2].ToString();
                txtemail.Text = dt.Rows[0][3].ToString();                
                txtreg.Text = dt.Rows[0][4].ToString();
                dtestdate.Value = DateTime.Parse(dt.Rows[0][5].ToString());
                byte[] b=(byte[])dt.Rows[0][6];
                fname=Path.GetTempFileName();
                File.WriteAllBytes(fname,b);
                pictureBox1.Image = Image.FromFile(fname);
                txtname.Focus();
            }
        }
    }
}
