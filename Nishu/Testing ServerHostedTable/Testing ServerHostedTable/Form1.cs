using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Testing_ServerHostedTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


                string connectionString = "Data Source=192.254.236.171; Port=3306; Integrated Security=False; Initial Catalog=secodek6_AccidentReportingSystem; User ID=secodek6_codezen; Password=NSBM@20.1PLY;"; //Set your MySQL connection string here.
                string query = "Select * from Test"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=192.254.236.171; Port=3306; Integrated Security=False; Initial Catalog=secodek6_AccidentReportingSystem; User ID=secodek6_codezen; Password=NSBM@20.1PLY;";
            MySqlConnection mcon = new MySqlConnection(connString);
            mcon.Open();

            string cmdText = "INSERT INTO Test VALUES (@name)";
            MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
