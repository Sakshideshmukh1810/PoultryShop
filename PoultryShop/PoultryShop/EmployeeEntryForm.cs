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
    public partial class EmployeeEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        string id;
        String fname;
        public EmployeeEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from Employee")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            string name = txtname.Text;
            string address = txtaddress.Text;
            string bdate = txtbdate.Value.ToString("yyyy-MM-dd");
            string jdate = txtjdate.Value.ToString("yyyy-MM-dd");            
            string contact = txtmobile.Text;
            string salary = txtsalary.Text;
            
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Employee name cannot be left empty..", "Input Error");
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
            if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Salary cannot be left empty..", "Input Error");
                txtsalary.Focus();
                return;
            }            
            
            if (btnsave.Text == "Save")
            {
                string sql = string.Format("Insert into Employee values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", no, name, address, bdate,jdate, contact,salary,null);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("photo", File.ReadAllBytes(fname));
                    dic.Add("EmpNo", no);
                    db.Execute("Update Employee set Photo=@photo where EmployeeNo=@EmpNo", dic);
                    db.UpdateID("EmpNo");
                    MessageBox.Show("Employee Record is Saved Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Save Employee Record... Something went wrong");
                }
            }
            else
            {
                string sql = string.Format("Update Employee set EmployeeName='{0}',Address='{1}',DOB='{2}',DOJ='{3}',MobileNo='{4}',Salary='{5}' where EmployeeNo='{6}'", name, address, bdate, jdate, contact, salary, no);
                int nrows = db.ExecuteCommand(sql);
                if (nrows == 1)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic.Add("photo", File.ReadAllBytes(fname));
                    dic.Add("EmpNo", no);
                    db.Execute("Update Employee set Photo=@photo where EmployeeNo=@EmpNo", dic);
                    MessageBox.Show("Employee Record is Updated Successfully...");
                }
                else
                {
                    MessageBox.Show("Failed to Update Employee Record... Something went wrong");
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
            txtsalary.Clear();
            txtaddress.Clear();
            pic1.Image = null;
            btnsave.Text = "Save";
            txtno.Text = db.GetID("EmpNo");
            txtname.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i=db.ExecuteCommand("delete from Employee where EmployeeNo='" + id + "'");
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
            txtno.Text = db.GetID("EmpNo");

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Employee Image";
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

                DataTable dt = db.GetDataTable("select * from Employee where EmployeeNo=" + id);
                if (dt.Rows.Count > 0)
                {
                    txtno.Text = id;
                    txtname.Text = dt.Rows[0][1].ToString();
                    txtaddress.Text = dt.Rows[0][2].ToString();
                    txtbdate.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                    txtjdate.Value = DateTime.Parse(dt.Rows[0][4].ToString());                    
                    txtmobile.Text = dt.Rows[0][5].ToString();
                    txtsalary.Text = dt.Rows[0][6].ToString();
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
                    FillTable("select * from Employee where " + cmbfield.Text + " like '%" + txtsearch.Text + "%'");
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}