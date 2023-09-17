using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Establishing_Connection
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr = "insert into Boxes (Code, Contents, Value, Warehouse) " +
                                "values (P2Y3, Rocker, 80, 1)";
                this.cmd = new SqlCommand(cmdStr, con);
                con.Open();
                MessageBox.Show("Connection Open");
                int res = cmd.ExecuteNonQuery();
                Debug.WriteLine(res);
                con.Close();
                if (!(res <= 0))
                {
                    MessageBox.Show("Insert Success.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}