using System;
using System.Data;
using Newtonsoft.Json;

namespace Serializing
{
    public partial class SerializingDataSet : Form
    {
        DataTable dt;
        DataColumn dc;
        DataRow dr;
        DataSet ds;

        public SerializingDataSet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        DataTable GetEmployeeTable()
        {
            dt = new DataTable("Employee");
            #region Employee DataTable
            // Adding Columns
            dc = new DataColumn("EmpId", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("EmpName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("DeptId", typeof(int));
            dt.Columns.Add(dc);

            // Adding Rows
            dr = dt.NewRow();
            dr[0] = 101;
            dr[1] = "Anadi";
            dr[2] = 10;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 102;
            dr[1] = "Mohit";
            dr[2] = 10;

            dt.Rows.Add(dr);
            #endregion
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable emp = GetEmployeeTable();
            emp.WriteXml(@"C:\Users\dbdf0\source\repos\ado.net_SE\Serializing\data.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable emp = GetEmployeeTable();
            string json = JsonConvert.SerializeObject(emp);
            StreamWriter writer = File.CreateText(@"C:\Users\dbdf0\source\repos\ado.net_SE\Serializing\data.json");
            writer.WriteLine(json);
            writer.Close();
        }
    }
}