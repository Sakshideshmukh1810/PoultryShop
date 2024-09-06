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
    public partial class MedicineEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        public MedicineEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Medicine")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            string pdate = txtpdate.Value.ToString("yyyy-MM-dd");
            string name = txtname.Text;
            string rate = txtrate.Text;            
            string qty = txtqty.Text;
            string amt = txtamt.Text;
            string shop = txtshop.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Medicine name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Medicine Name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(rate))
            {
                MessageBox.Show("Rate cannot be left empty..", "Input Error");
                txtrate.Focus();
                return;
            }
            if (!Regex.IsMatch(rate, "^\\d+(\\.\\d{0,2})?$"))
            {
                MessageBox.Show("Rate must be in numeric format..", "Input Error");
                txtrate.Focus();
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
                MessageBox.Show("Qty must be in integer format..", "Input Error");
                txtqty.Focus();
                return;
            }
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into Medicine (PDate,MedName,Rate,Qty,Amt,ShopName) values('{0}','{1}','{2}','{3}','{4}','{5}')", pdate,name,rate,qty,amt,shop);
                db.ExecuteCommand(sql);
                MessageBox.Show("Medicine Record is Saved Successfully...");
            }
            else
            {
                string sql = string.Format("Update Medicine set PDate='{1}',MedName='{2}',Rate='{3}',Qty='{4}',Amt='{5}',ShopName='{6}' where ID='{0}'", no, pdate, name, rate, qty, amt, shop);
                db.ExecuteCommand(sql);
                MessageBox.Show("Medicine Record is Updated Successfully...");
                
            }
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();           
            txtqty.Clear();
            txtrate.Clear();
            txtamt.Clear();
            txtshop.Clear();
            btnsave.Text = "Save";
            txtno.Text = "[AUTO]";
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i=db.ExecuteCommand("delete from Medicine where ID='" + id + "'");
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

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            FillTable();            

        }
       
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row=dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

                DataTable dt = db.GetDataTable("select * from Medicine where ID=" + id);
                if (dt.Rows.Count > 0)
                {
                    txtno.Text = id;
                    txtpdate.Value = DateTime.Parse(dt.Rows[0][1].ToString());
                    txtname.Text = dt.Rows[0][2].ToString();
                    txtrate.Text = dt.Rows[0][3].ToString();
                    txtqty.Text = dt.Rows[0][4].ToString();
                    txtamt.Text = dt.Rows[0][5].ToString();
                    txtshop.Text = dt.Rows[0][6].ToString();
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
                    FillTable("select * from Medicine where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            string qty = txtqty.Text;
            if (!string.IsNullOrEmpty(qty))
            {
                txtamt.Text = (double.Parse(txtrate.Text) * int.Parse(qty)).ToString();
            }
        }
    }
}