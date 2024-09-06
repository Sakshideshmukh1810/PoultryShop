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
    public partial class ProductEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        public ProductEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Product")
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
            
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into Product values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", no, name, cat, brand,qty, price,others, null);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("photo", File.ReadAllBytes(fname));
                    dic.Add("ProductNo", no);
                    db.Execute("Update Product set ProductImage=@photo where ProductNo=@ProductNo", dic);
                    db.UpdateID("ProductNo");
                    MessageBox.Show("Product Record is Saved Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Save Product Record... Something went wrong");
                }
            }
            else
            {
                string sql = string.Format("Update Product set ProductName='{0}',ProductCategory='{1}',Brand='{2}',Qty='{3}',Price='{4}',Others='{5}' where ProductNo='{6}'", name, cat, brand, qty, price, others, no);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("photo", File.ReadAllBytes(fname));
                    dic.Add("ProductNo", no);
                    db.Execute("Update Product set ProductImage=@photo where ProductNo=@ProductNo", dic);
                    MessageBox.Show("Product Record is Updated Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Update Product Record... Something went wrong");
                }
            }
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
            pic1.Image = null;
            btnsave.Text = "Save";
            txtno.Text = db.GetID("ProductNo");
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i=db.ExecuteCommand("delete from Product where ProductNo='" + id + "'");
                if (i == 0)
                    MessageBox.Show("Record is not found...");
                else
                    MessageBox.Show("Record is deleted successfully...");

            }
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            FillTable();
            txtno.Text = db.GetID("ProductNo");

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Product Image";
            fd.Filter = "Image Files(*.jpg)|*.jpg";
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fname = fd.FileName;
                pic1.Image = Image.FromFile(fname);
            }
        }
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row=dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

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
                    byte[] b = (byte[])dt.Rows[0][7];
                    fname = Path.GetTempFileName();
                    File.WriteAllBytes(fname, b);
                    pic1.Image = Image.FromFile(fname);
                    btnsave.Text = "Update";
                    txtname.Focus();

                }
            }
            
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
                    FillTable("select * from Product where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}