using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoultryShop.Classes;
using PoultryShop.Reports;
using System.Diagnostics;

namespace PoultryShop
{
    public partial class MainForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();

        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Close current form
            LoginForm.me.Show();
            LoginForm.me.txtuser.Clear();
            LoginForm.me.txtpass.Clear();
            LoginForm.me.txtuser.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = "Main Form - Poultry Management System [" + AppVariables.username + "]";
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarmInfoForm f = new FarmInfoForm();
            f.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEntryForm f = new CustomerEntryForm();
            f.Show();
        }

        

        
       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm();
            f.Show();
        }

       

       

        private void productBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedPurchaseEntryForm f = new FeedPurchaseEntryForm();
            f.Show();
        }

        

        private void empEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntryForm f = new EmployeeEntryForm();
            f.Show();
        }

       

        private void voucherEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherEntryForm f = new VoucherEntryForm();
            f.Show();
        }

        

        

        private void standardwiseFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.showReport(new CustomerReport(), "select * from Customer", "Customer");
        }

        

        private void admissionFormPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.showReport(new ProductListReport(), "select * from Product", "Product");
        }

        private void staffListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            db.showReport(new EmployeeListReport(), "select * from Employee", "Employee");
        }

        private void staffPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpReportCondForm f = new EmpReportCondForm();
            f.Show();
        }

        

        private void voucherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VoucherReportCondForm f = new VoucherReportCondForm();
            f.Show();
        }

       

        private void empPayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpPaymentEntryForm f = new EmpPaymentEntryForm();
            f.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyEntryForm f = new CompanyEntryForm();
            f.Show();
        }

        

        private void productBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductBillReportCondForm f = new ProductBillReportCondForm();
            f.Show();
        }

        private void compantReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.showReport(new CompanyReport(), "select * from Company", "Company");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductBillingForm f = new ProductBillingForm();
            f.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ProductEntryForm f = new ProductEntryForm();
            f.Show();
        }

        private void medicineEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicineEntryForm f = new MedicineEntryForm();
            f.Show();
        }

        private void deadStockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeadStockEntryForm f = new DeadStockEntryForm();
            f.Show();
        }

        

        
    }
}
