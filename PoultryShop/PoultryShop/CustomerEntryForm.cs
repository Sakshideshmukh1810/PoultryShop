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
    public partial class CustomerEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        public CustomerEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Customer")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            string name = txtname.Text;
            string address = txtaddress.Text;            
            string contact = txtmobile.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Customer name cannot be left empty..", "Input Error");
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
                MessageBox.Show("Mobile No cannot be left empty..", "Input Error");
                txtmobile.Focus();
                return;
            }
            if (!Regex.IsMatch(contact, "^\\d{10}$"))
            {
                MessageBox.Show("Mobile No should be 10 digits..", "Input Error");
                txtmobile.Focus();
                return;
            }            
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into Customer values('{0}','{1}','{2}','{3}')", no, name, address,contact);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {                   
                    db.UpdateID("CustNo");
                    MessageBox.Show("Customer Record is Saved Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Save Customer Record... Something went wrong");
                }
            }
            else
            {
                string sql = string.Format("Update Customer set CustName='{0}',CustAddress='{1}',PhoneNo='{2}' where CustNo='{3}'", name, address,contact, no);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    MessageBox.Show("Customer Record is Updated Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Update Customer Record... Something went wrong");
                }
            }
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();
           
            txtmobile.Clear();
            txtaddress.Clear();
            btnsave.Text = "Save";
            txtno.Text = db.GetID("CustNo");
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i=db.ExecuteCommand("delete from Customer where CustNo='" + id + "'");
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
            txtno.Text = db.GetID("CustNo");

        }
       
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row=dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

                DataTable dt = db.GetDataTable("select * from Customer where CustNo=" + id);
                if (dt.Rows.Count > 0)
                {
                    txtno.Text = id;
                    txtname.Text = dt.Rows[0][1].ToString();
                    txtaddress.Text = dt.Rows[0][2].ToString();
                    txtmobile.Text = dt.Rows[0][3].ToString();
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
                    FillTable("select * from Customer where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}