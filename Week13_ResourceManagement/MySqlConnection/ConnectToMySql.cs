using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace MySqlConnection
{
    public partial class ConnectToMySql : Form
    {
        
        public ConnectToMySql()
        {
            InitializeComponent();
        }

        int idx = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            if(int.TryParse(textBoxConnCount.Text, out count))
            {
                string dbHost = "";
                string dbUser = "";
                string dbPwd  = "";
                string dbName = "";

                string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPwd + ";database=" + dbName;
                for(int i=idx;i<idx+count;i++)
                 {
                     Console.WriteLine("IDX=" + i.ToString());
                     MySql.Data.MySqlClient.MySqlConnection conn
                     = new MySql.Data.MySqlClient.MySqlConnection(connStr);

                     try
                     {
                         conn.OpenAsync();
                         string msg = string.Format("idx_{0}: Connection is OK at {1}", i, DateTime.Now);
                         AddItemToListBox(listBox1, msg);                        

                        //do something 
                    }
                     catch (MySql.Data.MySqlClient.MySqlException ex)
                     {
                         string msg = string.Format("idx_{0}: Connection is failed (Error code:{0}) at {1}", i, ex.Code, DateTime.Now);
                         AddItemToListBox(listBox1, msg);
                     }
                     finally
                     {
                         string msg = string.Format("idx_{0}: Connection is closed at {0}",i,DateTime.Now);
                        AddItemToListBox(listBox1, msg);
                        conn.CloseAsync();
                     }
                 }
            }
        }

        static void AddItemToListBox(ListBox lb, string msg)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new MethodInvoker(() => lb.Items.Add(msg)));
            }
            else
                lb.Items.Add(msg);
            Console.WriteLine(msg);
        }
    }
}
