using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;

namespace Exec_cmd
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            string conStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            Debug.WriteLine(conStr);
            con = new SqlConnection(conStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr = "insert into Boxes (Code, Contents, Value, Warehouse) " +
                                "values ('P2Y3', 'Rocker', 80, 1)";
                this.cmd = new SqlCommand(cmdStr, con);
                using (con)
                {
                    con.Open();
                    MessageBox.Show("Connection Open");
                    int res = cmd.ExecuteNonQuery();
                    Debug.WriteLine(res);
                    if (res > 0)
                    {
                        MessageBox.Show("Insert Success.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}