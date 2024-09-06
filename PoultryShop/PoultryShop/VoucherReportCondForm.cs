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
using PoultryShop.Reports;

namespace PoultryShop
{
    public partial class VoucherReportCondForm : Form
    {
        ClsDataAccess db = new ClsDataAccess();
        public VoucherReportCondForm()
        {
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("p1", txtfdate.Value.ToString("yyyy-MM-dd"));
            dic.Add("p2", txttdate.Value.ToString("yyyy-MM-dd"));
            db.showReport(new VoucherReport(), "select * from Voucher where VoucherDate>='" + txtfdate.Value.ToString("yyyy-MM-dd") + "' and VoucherDate<='" + txttdate.Value.ToString("yyyy-MM-dd") + "'", "Voucher", dic);
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}