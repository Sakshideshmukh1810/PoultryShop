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
    public partial class VoucherEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        public VoucherEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Voucher")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            String vdate = DateTime.Now.ToString("yyyy-MM-dd");
            string part = txtpart.Text;            
            string name = txtname.Text;
            string amt = txtamt.Text;
            string details = txtdetails.Text;            

            if (string.IsNullOrEmpty(part))
            {
                MessageBox.Show("Particulars cannot be left empty..", "Input Error");
                txtpart.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Person name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(amt))
            {
                MessageBox.Show("Amount cannot be left empty..", "Input Error");
                txtamt.Focus();
                return;
            }
            if (!Regex.IsMatch(amt,@"^\d+(\.\d{2})?$"))
            {
                MessageBox.Show("Amount must be numeric..", "Input Error");
                txtamt.Focus();
                return;
            }
            
            
            string sql = string.Format("Insert into Voucher (VoucherDate,Particulars,ToPerson,Amt,PayDetails) values('{0}','{1}','{2}','{3}','{4}')", vdate,part, name, amt, details);            
            db.ExecuteCommand(sql);            
            MessageBox.Show("Voucher Entry made Successfully......");
            FillTable();
            txtpart.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpart.Clear();
            txtname.Clear();
            txtamt.Clear();
            txtdetails.Clear();            
            txtpart.Focus();
        }
        

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            FillTable();            
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            FillTable("Select * from Voucher where VoucherDate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'");            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dg.CurrentRow;
            if (dr != null)
            {
                //delete row
                DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    String id = dr.Cells[0].Value.ToString();
                    db.ExecuteCommand("delete from Voucher where Id='" + id + "'");
                    FillTable();
                }
            }
            else
            {
                MessageBox.Show("Select row to delete...");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtdetails_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}