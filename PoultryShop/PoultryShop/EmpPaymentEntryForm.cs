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
    public partial class EmpPaymentEntryForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        public EmpPaymentEntryForm()
        {
            InitializeComponent();
        }


        void FillTable(string sql = "select * from EmployeePayment")
        {
            DataTable dt = db.GetDataTable(sql);
            dg.DataSource = dt;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            String paydate = DateTime.Now.ToString("yyyy-MM-dd");
            String fromdate = txtfdate.Value.ToString("yyyy-MM-dd");
            String todate = txtfdate.Value.ToString("yyyy-MM-dd");

            int d=(int)(txttdate.Value - txtfdate.Value).TotalDays;
            int d1=Enumerable.Range(1, d).Select(x => txtfdate.Value.AddDays(x))
            .Count(x => x.DayOfWeek == DayOfWeek.Sunday);
            d = d - d1;

            string no = txtno.Text;            
            string name = txtname.Text;            
            string days = txtdays.Text;
            string salary = txtsalary.Text;
            string advance = txtadvance.Text;
            string deduction = txtdeduction.Text;
            string paymode = cmbpaymode.Text;            
            string details = txtdetails.Text;
            if (String.IsNullOrEmpty(deduction))
            {
                deduction = "0";
            }
            double salday = double.Parse(salary) / d;
            double tsalary = salday * int.Parse(days);
            tsalary = tsalary - (double.Parse(advance) + double.Parse(deduction));
            lblnetpay.Text = tsalary + "";
            string netpay = lblnetpay.Text;

            if (string.IsNullOrEmpty(no))
            {
                MessageBox.Show("Employee ID cannot be left empty..", "Input Error");
                txtno.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Employee name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Employee Salary cannot be left empty..", "Input Error");
                txtsalary.Focus();
                return;
            }
            

            string sql = string.Format("Insert into EmployeePayment (PayDate,FromDate,ToDate,EmpNo,EmpName,PresentDays,Salary,Advance,Deduction,PayMode,Details,NetPay) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", paydate,fromdate,todate, no, name,days,salary,advance,deduction,paymode,details,netpay);            
            db.ExecuteCommand(sql);            
            MessageBox.Show("Employee Payment entry made Successfully......");
            FillTable();
            txtno.Focus();
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();            
            txtsalary.Clear();
            txtdays.Clear();
            txtadvance.Clear();
            txtdeduction.Clear();
            txtdetails.Clear();            
            txtno.Focus();
        }
        

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        private void btnget_Click(object sender, EventArgs e)
        {
            String no = txtno.Text;
            if (String.IsNullOrEmpty(no))
            {
                MessageBox.Show("Please enter Employee ID...");
                return;
            }
            DataTable dt = db.GetDataTable("select * from Employee where EmployeeNo=" + no);
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0][1].ToString();                
                txtsalary.Text = dt.Rows[0][6].ToString();
                FillTable("Select * from EmployeePayment where EmpNo=" + no);

                txtname.Focus();

            }
            else
            {
                txtname.Clear();                
                txtsalary.Clear();
                MessageBox.Show("Record not found...");
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            FillTable();
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
                    db.ExecuteCommand("delete from EmployeePayment where PayId='" + id + "'");
                    FillTable();
                }
            }
            else
            {
                MessageBox.Show("Select row to delete...");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePaymentEntryForm_Load(object sender, EventArgs e)
        {
            FillTable();
            cmbpaymode.SelectedIndex = 0;
            lblnetpay.Text = "0.00";
            lblpaydate.Text = DateTime.Now.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        
    }
}