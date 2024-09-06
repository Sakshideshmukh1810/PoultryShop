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
    public partial class ProductBillingForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        CustomerEntryForm f;
        ProductEntryForm f1;
        int qty1;
        public ProductBillingForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Billing")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string billno = txtno.Text;
            String bdate = txtfdate.Value.ToString("yyyy-MM-dd");
            string custno = txtcustno.Text;
            string name = txtname.Text;
            string amt = txtamt.Text;            
            string discp = txtdiscp.Text;
            string discamt = txtdiscamt.Text;
            string net = txtnet.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("PetBillView name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }            
            if (string.IsNullOrEmpty(custno))
            {
                MessageBox.Show("CustNo cannot be left empty..", "Input Error");
                txtcustno.Focus();
                return;
            }
            if (string.IsNullOrEmpty(amt))
            {
                MessageBox.Show("Price cannot be left empty..", "Input Error");
                txtamt.Focus();
                return;
            }
            if (!Regex.IsMatch(amt, "^\\d+(\\.\\d{1,2})?$"))
            {
                MessageBox.Show("Price should be number..", "Input Error");
                txtamt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(discp))
            {
                MessageBox.Show("Discount Percent cannot be left empty..", "Input Error");
                txtdiscp.Focus();
                return;
            }
            if (!Regex.IsMatch(discp, "^\\d+(\\.\\d{1,2})?$"))
            {
                MessageBox.Show("Discount Percent  should be number..", "Input Error");
                txtdiscp.Focus();
                return;
            }
            if (string.IsNullOrEmpty(discamt))
            {
                MessageBox.Show("Discount Amt cannot be left empty..", "Input Error");
                txtdiscamt.Focus();
                return;
            }
            if (!Regex.IsMatch(discamt, "^\\d+(\\.\\d{1,2})?$"))
            {
                MessageBox.Show("Discount Amt  should be number..", "Input Error");
                txtdiscamt.Focus();
                return;
            }
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into Billing values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", billno,bdate,custno,name,amt,discp,discamt,net);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    foreach (ListViewItem lt in lv1.Items)
                    {
                        String pno = lt.Text;
                        String pname = lt.SubItems[1].Text;
                        String price= lt.SubItems[2].Text;
                        String qty = lt.SubItems[3].Text;
                        String total = lt.SubItems[4].Text;
                        sql = string.Format("Insert into BillItems values('{0}','{1}','{2}','{3}','{4}')", billno,pno,price,qty,total);
                        db.ExecuteCommand(sql);
                        db.ExecuteCommand("Update Product set Qty=Qty-"+qty+" where ProductNo=" + pno);
                    }
                    
                    db.UpdateID("PBillNo");
                    MessageBox.Show("Product Bill is generated Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Save Pet Bill Record... Something went wrong");
                }
            }
            
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();
            txtcustno.Clear();
            txtptno.Clear();
            txtpname.Clear();
            txtprice.Clear();
            txtqty.Clear();                       
            txtamt.Clear();
            txtdiscp.Clear();
            txtdiscamt.Clear();
            txtnet.Clear();
            lv1.Items.Clear();
            btnsave.Text = "Save";
            txtno.Text = db.GetID("PBillNo");
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                db.ExecuteCommand("delete from BillItems where BillNo=" + id);
                int i=db.ExecuteCommand("delete from Billing where BillNo='" + id + "'");
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
            txtno.Text = db.GetID("PBillNo");

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
                    FillTable("select * from Billing where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            //Open Customer Form
            f = new CustomerEntryForm();
            f.dg.Click += new EventHandler(dg1_Click);
            f.Show();
        }
        void dg1_Click(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.CurrentRow != null)
            {
                txtcustno.Text = dg.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dg.CurrentRow.Cells[1].Value.ToString();
                if (f != null)
                {
                    f.Close();
                }
            }
        }

        private void btnpet_Click(object sender, EventArgs e)
        {
            //Open Pet Form
            f1 = new ProductEntryForm();
            f1.dg.Click += new EventHandler(dg2_Click);
            f1.Show();
        }
        void dg2_Click(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            if (dg.CurrentRow != null)
            {
                String q = dg.CurrentRow.Cells[4].Value.ToString();
                int qty = int.Parse(q);
                if (qty <= 0)
                {
                    MessageBox.Show("Sorry! Stock is not available...");
                    if (f1 != null)
                    {
                        f1.Close();
                    }
                    return;
                }
                txtptno.Text = dg.CurrentRow.Cells[0].Value.ToString();
                txtpname.Text = dg.CurrentRow.Cells[1].Value.ToString();
                txtprice.Text = dg.CurrentRow.Cells[5].Value.ToString();
                qty1 = int.Parse(dg.CurrentRow.Cells[4].Value.ToString());
                txtqty.Focus();
                
                if (f1 != null)
                {
                    f1.Close();
                }
            }
        }

        private void txtdiscp_TextChanged(object sender, EventArgs e)
        {
            String disp = txtdiscp.Text;
            if (String.IsNullOrEmpty(disp))
            {
                disp = "0";
            }
            double amt = double.Parse(txtamt.Text);
            double dp = double.Parse(disp);
            double disamt = amt * (dp / 100);
            txtdiscamt.Text = disamt+"";
            double net = amt - disamt;
            txtnet.Text = net+"";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtptno.Text))
            {
                MessageBox.Show("Product No Required...");
                txtptno.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtqty.Text))
            {
                MessageBox.Show("Qty Required...");
                txtqty.Focus();
                return;
            }
            if (!Regex.IsMatch(txtqty.Text, "^\\d+$"))
            {
                MessageBox.Show("Qty must be numeric..", "Input Error");
                txtqty.Focus();
                return;
            }

            if (int.Parse(txtqty.Text) > qty1)
            {
                MessageBox.Show("Exceeded an existing stock of product...");
                return;
            }
            ListViewItem lt = new ListViewItem(txtptno.Text);
            lt.SubItems.Add(txtpname.Text);
            lt.SubItems.Add(txtprice.Text);
            lt.SubItems.Add(txtqty.Text);
            lt.SubItems.Add((double.Parse(txtprice.Text) * int.Parse(txtqty.Text))+"");
            lv1.Items.Add(lt);
            CalcTotal();
            txtptno.Focus();

        }
        void CalcTotal()
        {
            double a = 0;
            foreach (ListViewItem lt in lv1.Items)
            {
                a += double.Parse(lt.SubItems[4].Text);
            }
            txtamt.Text = a + "";
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (lv1.FocusedItem != null)
            {
                int i = lv1.FocusedItem.Index;
                lv1.Items[i].Remove();
                lv1.Refresh();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}