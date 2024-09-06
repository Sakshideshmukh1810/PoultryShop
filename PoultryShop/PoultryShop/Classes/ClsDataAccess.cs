using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using System.Data;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using PoultryShop.DataSet;

namespace PoultryShop.Classes
{
    class ClsDataAccess
    {
        SqlConnection cn;
        public void OpenConnection()
        {
            String filepath = new FileInfo("../../DB/PoultryDB.mdf").FullName;
            cn = new SqlConnection(@"server=.\sqlexpress;database="+filepath+";Integrated Security=true;user instance=true");
           // cn.Open(); //Open connection
        }
        public void CloseConnection()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public DataTable GetDataTable(string sql) //execute select command and returns rows in form of DataTable
        {
            OpenConnection(); 
            SqlDataAdapter da = new SqlDataAdapter(sql, cn); //SqlDataAdapter(selectcommand,connectionobj);
            DataTable dt = new DataTable();
            da.Fill(dt); //It executes Select command via connection and fills their result in DataTable object
            //DataTable looks like Login Table in DB
            CloseConnection(); //Close Connection
            return dt; //Return DataTable class object

        }
        public bool CheckLogin(string username, string password)
        {
            //Run Select command
            string sql=string.Format("select * from Login where UserName='{0}' and Password='{1}'",username,password);
            //MessageBox.Show(sql);
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count == 1)
            {
                return true; //Record exists
            }
            else
            {
                return false; //Record does notexists
            }
            
        }
        //Execute Non Parameterized or Normal SQL Commands
        public int ExecuteCommand(string sqlcommand) //Execute Insert,Update and Delete command
        {   
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sqlcommand, cn);
            int nrows = cmd.ExecuteNonQuery();
            CloseConnection();
            return nrows; //returns no of rows affected
        }
        //Execute Parameterized Commands
        //Execute("Insert into stud values(@roll,@name,@address",obj);
        public int Execute(string sqlcommand,Dictionary<string,object> obj)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sqlcommand, cn);
            foreach(string key in obj.Keys)
            {
                cmd.Parameters.AddWithValue(key, obj[key]);
            }
            int nrows = cmd.ExecuteNonQuery();
            CloseConnection();
            return nrows; //returns no of rows affected
        }

        public void FillCombo(ComboBox cmb, String sql, String display, String value)
        {
            DataTable dt = GetDataTable(sql);
            cmb.DataSource = dt;
            cmb.DisplayMember = display;
            cmb.ValueMember = value;
        }
        public void FillChk(CheckedListBox clb, String sql, String display, String value)
        {
            DataTable dt = GetDataTable(sql);
            clb.DataSource = dt;
            clb.DisplayMember = display;
            clb.ValueMember = value;
        }
        public String GetID(String field)
        {
            String id = "";
            OpenConnection();
            DataTable dt = GetDataTable("select " + field + " from PK");
            id = dt.Rows[0][0].ToString();
            CloseConnection();
            return id;

        }
        public void UpdateID(String field)
        {
            OpenConnection();
            ExecuteCommand(string.Format("Update PK set {0}={0}+1", field));
            CloseConnection();


        }

        public DataSet1 fillDataSet(string sql, String tablename)
        {
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, tablename);
            CloseConnection();
            return ds;

        }

        public void showReport(ReportClass rptobj, String sql, String tablename)
        {
            ReportForm f = new ReportForm();
            DataSet1 ds = fillDataSet(sql, tablename);
            rptobj.SetDataSource(ds);
            f.crystalReportViewer1.ReportSource = rptobj;
            f.Show();
        }

        public void showReport(ReportClass rptobj, String sql, String tablename,Dictionary<string,string> dic)
        {
            ReportForm f = new ReportForm();
            DataSet1 ds = fillDataSet(sql, tablename);
            rptobj.SetDataSource(ds);
            f.crystalReportViewer1.ReportSource = rptobj;
            foreach(string key in dic.Keys)
            {
                rptobj.SetParameterValue(key, dic[key]);
            }
            
            f.Show();
        }

    }
}
