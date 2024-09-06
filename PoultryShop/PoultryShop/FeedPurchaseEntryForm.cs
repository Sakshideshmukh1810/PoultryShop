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
    public partial class FeedPurchaseEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        CompanyEntryForm f;
        public FeedPurchaseEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from FeedPurchase")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            String fdate = txtfdate.Value.ToString("yyyy-MM-dd");
            string cno = txtcno.Text;
            string cname = txtcname.Text;
            string price = txtprice.Text;            
            string qty = txtqty.Text;            
            string total = txttotal.Text;
            
            if (string.IsNullOrEmpty(cno))
            {
                MessageBox.Show("Comp No cannot be left empty..", "Input Error");
                txtcno.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cname))
            {
                MessageBox.Show("Comp Name cannot be left empty..", "Input Error");
                txtcname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(qty))
            {
                MessageBox.Show("Qty cannot be left empty..", "Input Error");
                txtqty.Focus();
                return;
            }
            if (!Regex.IsMatch(qty, "^\\d+$"))
            {
                MessageBox.Show("Quantity should be number..", "Input Error");
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
                MessageBox.Show("Price should be number..", "Input Error");
                txtprice.Focus();
                return;
            }                   
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into FeedPurchase values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", no, fdate,cno,cname,price,qty,total);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {                   
                    db.UpdateID("FeedNo");
                    MessageBox.Show("Feed Purchase is Saved Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Save Feed Purchase Record... Something went wrong");
                }
            }
            else
            {
                string sql = string.Format("Update FeedPurchase set FDate='{0}',CompNo='{1}',CompName='{2}',Price=='{3}',Qty='{4}',TotalAmt='{5}' where Id='{6}'", fdate, cno, cname, price, qty, total, no);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    MessageBox.Show("FeedPurchase is Updated Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Update FeedPurchase Record... Something went wrong");
                }
            }
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtcno.Clear();
            txtcname.Clear();
            txtprice.Clear();           
            txttotal.Clear();
            txtqty.Clear();
            btnsave.Text = "Save";
            txtno.Text = db.GetID("FeedNo");
            txtcno.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i=db.ExecuteCommand("delete from FeedPurchase where ID='" + id + "'");
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
            txtno.Text = db.GetID("FeedNo");

        }
       
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row=dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

                DataTable dt = db.GetDataTable("select * from FeedPurchase where ID=" + id);
                if (dt.Rows.Count > 0)
                {
                    txtno.Text = id;
                    txtcno.Text = dt.Rows[0][1].ToString();
                    txtcname.Text = dt.Rows[0][2].ToString();
                    txtprice.Text = dt.Rows[0][3].ToString();
                    txtqty.Text = dt.Rows[0][4].ToString();
                    txttotal.Text = dt.Rows[0][5].ToString();
                    btnsave.Text = "Update";
                    txtcno.Focus();

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
                    FillTable("select * from FeedPurchase where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            //Open FeedPurchase Form
            f = new CompanyEntryForm();
            f.dg.Click += new EventHandler(dg1_Click);
            f.Show();
        }
        void dg1_Click(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.CurrentRow != null)
            {
                txtcno.Text = dg.CurrentRow.Cells[0].Value.ToString();
                txtcname.Text = dg.CurrentRow.Cells[1].Value.ToString();
                if (f != null)
                {
                    f.Close();
                }
            }
        }
    }
}