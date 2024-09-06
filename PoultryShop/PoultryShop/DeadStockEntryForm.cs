using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoultryShop.Classes;
using System.Text.RegularExpressions;
using System.IO;

namespace PoultryShop
{
    public partial class DeadStockEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        public DeadStockEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from DeadProduct")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            string name = txtname.Text;            
            string cat = cmbcategory.Text;
            string brand = txtbrand.Text;
            string qty = txtqty.Text;
            string price = txtprice.Text;
            string others = txtothers.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("ProductFor cannot be left empty..", "Input Error");
                cmbcategory.Focus();
                return;
            }
            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Brand cannot be left empty..", "Input Error");
                txtbrand.Focus();
                return;
            }
            if (string.IsNullOrEmpty(qty))
            {
                MessageBox.Show("Qty cannot be left empty..", "Input Error");
                txtqty.Focus();
                return;
            }
            if (!Regex.IsMatch(qty,"^\\d+$"))
            {
                MessageBox.Show("Qty must be numeric..", "Input Error");
                txtqty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Price cannot be left empty..", "Input Error");
                txtprice.Focus();
                return;
            }
            if (!Regex.IsMatch(price, "^\\d+(\\.\\d{1,2})?$"))
            {
                MessageBox.Show("Price must be numeric..", "Input Error");
                txtprice.Focus();
                return;
            }
            
            
           
           string sql = string.Format("Insert into DeadProduct values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", no, name, cat, brand,qty, price,others);
           db.ExecuteCommand(sql);
           db.ExecuteCommand("Update product set qty=qty-" + qty + " where ProductNo=" + no);
           MessageBox.Show("Product Dead Stock Record is Saved Successfully...");
            
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();
            txtbrand.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtothers.Clear();                        
            txtno.Focus();
        }

        

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeadStockEntryForm_Load(object sender, EventArgs e)
        {
            FillTable();            

        }

        

        private void btnlist_Click(object sender, EventArgs e)
        {
            

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtsearch.Text))
                {
                    FillTable();
                }
                else
                {
                    FillTable("select * from DeadProduct where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnget1_Click(object sender, EventArgs e)
        {
            
            String id = txtno.Text;
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter product no");
                txtno.Focus();
                return;
            }

            DataTable dt = db.GetDataTable("select * from Product where ProductNo=" + id);
            if (dt.Rows.Count > 0)
            {
                txtno.Text = id;
                txtname.Text = dt.Rows[0][1].ToString();
                cmbcategory.Text = dt.Rows[0][2].ToString();
                txtbrand.Text = dt.Rows[0][3].ToString();
                txtqty.Text = dt.Rows[0][4].ToString();
                txtprice.Text = dt.Rows[0][5].ToString();
                txtothers.Text = dt.Rows[0][6].ToString();
                btnsave.Text = "Update";
                txtname.Focus();

            }
        }
    }
}